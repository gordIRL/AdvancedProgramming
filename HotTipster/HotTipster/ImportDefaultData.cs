using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Text.RegularExpressions;


namespace HotTipster
{
    public static class ImportDefaultData
    {
        public static List<HorseBet> ImportData()
        {
            // Create a list to store HorseBets in
            List<HorseBet> HorseBetList = new List<HorseBet>();
            
            // Path for test data
            string testDataPath = @"C:\dbs\HotTipsterTestDataFULLVERSION.txt";   

            // Open file with write access via FileStream
            FileStream input = new FileStream(testDataPath, FileMode.OpenOrCreate, FileAccess.Read);
                        
            // Read in data from file
            string originalTextData;
            using (StreamReader streamReader = new StreamReader(testDataPath))
            {
                originalTextData = streamReader.ReadToEnd();
            }

            // Regex to parse originalTextData file
            originalTextData = originalTextData.Replace(" ", String.Empty);            
            string myRegexExpression = @"([\w]+)|";                   // Name   {2,}
            myRegexExpression += @"(\([\d]{4},[\d]{2},[\d]{2}\))|";   // Date    @"(\([\d]{4},[\d]{2},[\d]{2}\))|";
            myRegexExpression += @"([\d]*\.[\d]*[m])|";              // Money amount   @"([\d]*\.[\d]*[m])|"; 
            myRegexExpression += @"(true|false)";                    // true or false
            
            // Parse textDataFile
            Regex reEngine = new Regex(myRegexExpression);
            Match regExMatch = reEngine.Match(originalTextData);
            
            while (regExMatch.Success)
            {
                // Get Course Name
                string tempRaceCourse = regExMatch.ToString(); 

                // Get Date & remove surrounding parenthesis
                regExMatch = regExMatch.NextMatch();
                string tempRaceDateString = regExMatch.ToString();
                tempRaceDateString = Regex.Replace(tempRaceDateString, @"\(", "");  // remove '('
                tempRaceDateString = Regex.Replace(tempRaceDateString, @"\)", "");  // remove ')' 
                
                // Convert string to DateTime object
                DateTime tempRaceDate = Convert.ToDateTime(tempRaceDateString);
                
                // Get Money Amount               
                regExMatch = regExMatch.NextMatch();
                string tempBalanceChangeString = regExMatch.ToString();                // left of decimal point             
                regExMatch = regExMatch.NextMatch();
                tempBalanceChangeString += regExMatch.ToString();                      // right of decimal point
                tempBalanceChangeString =  Regex.Replace(tempBalanceChangeString, @"m", "");   // remove 'm'
                // Convert money string into a decimal
                decimal.TryParse(tempBalanceChangeString, out decimal tempBalanceChange);                
                
                // Get Won / Lost Bool                
                regExMatch = regExMatch.NextMatch();                
                bool.TryParse(regExMatch.ToString(), out bool tempRaceWasWon);                
               
                regExMatch = regExMatch.NextMatch();

                // Create a new temporary HorseBet object
                HorseBet tempHorseBet = new HorseBet(tempRaceCourse, tempRaceDate,
                    tempBalanceChange, tempRaceWasWon);

                // Add tempory HorseBet object to HorseBet List
                HorseBetList.Add(tempHorseBet);
            }           
            // Close the FileStream
            input.Close();     // close FileStream            

            // Return complete list of Horsebets
            return HorseBetList;
        }
    }
}
