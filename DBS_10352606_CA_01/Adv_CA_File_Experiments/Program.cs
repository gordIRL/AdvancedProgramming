using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

//*************************CA - Brief ******************************************
//******************************************************************************
//
//CA 1 - Reading and Writing Files 10% Assignment
//Assignment 1 is based on transforming a large dataset in text format - over 5000 lines of text.
//You will need to read in a file, scrub (clean) the data, place it into the relevant holder/container objects and save the output in a csv format.
//Once in these objects you will see that there are 422 different sets of commit objects.
//The deadline is the 10th December 2017 on moodle @ 23:55.




// Files are read from & output to the directory 'C:\dbs\'
// Please ensure this directory is available on your system & that it 
// contains the file 'commit_changes.txt'


namespace DBS_10352606_CA_01
{
    class Program
    {
        // Paths for reading in & writing out file
        static readonly string PathFileOutput = @"C:\dbs\csvOutputFile.csv";
        static readonly string PathFileInput  = @"C:\dbs\commit_changes.txt";
                 

        static void Main(string[] args)
        {
            List<CA_File_Unit> myList = new List<CA_File_Unit>();
            int commitCount = 0;
            string inputString = string.Empty;
            string regex72Hypens = @"\-{72}";            
                               

            try             // Begin reading file
            {

                using (Stream fs = File.OpenRead(PathFileInput))
                {
                    using (TextReader txtReader = new StreamReader(fs, Encoding.UTF8))
                    {
                        inputString = txtReader.ReadLine();
                        while (txtReader.Peek() > -1)   // check not at end of file
                        {                            
                            // Create new object for file block
                            CA_File_Unit currentBlock = new CA_File_Unit();


                            // use regular expression to find the 72 hyphen start of file block
                            Match regExMatch = Regex.Match(inputString, regex72Hypens);

                            if (regExMatch.Success)
                            {
                                inputString = txtReader.ReadLine();                                

                                // Regular Expression to parse Main-Data-Line   ( includes no / name / date etc )                                
                                string regexMainLine = @"(\w*)\s*\|\s*([\w\W]*)\s*\|\s*";
                                regexMainLine += @"(\d{4}[\-|\s]*\d{2}[\-|\s]*\d{2})";   //   Short Date    
                                regexMainLine += @"\s*(\d{2}:\d{2}:\d{2})";              //   Time
                                regexMainLine += @"\s*(\+\s*\d{4})";                     //   Offset
                                regexMainLine += @"\s*\W(.{16})";                        //   LongDate
                                regexMainLine += @"\W*(\d*)";                            //   No Of Lines


                                // Display Main-Data-Line on Screen
                                MatchCollection matches = Regex.Matches(inputString, regexMainLine, RegexOptions.Multiline);                 
                                foreach (Match match in matches)
                                {
                                    // Write Main-Data-Line to object
                                    currentBlock.RNumber = match.Groups[1].Value;
                                    currentBlock.Name = match.Groups[2].Value;
                                    currentBlock.DateShort = match.Groups[3].Value;
                                    currentBlock.Time = match.Groups[4].Value;
                                    currentBlock.Offset = match.Groups[5].Value;
                                    currentBlock.DateLong = match.Groups[6].Value;
                                    int tempInt;
                                    int.TryParse(match.Groups[7].Value, out tempInt);
                                    currentBlock.NoOfLines = tempInt;
                                } // end foreach 
                            } // end if



                            // **** Changed Paths Section ****
                            // *******************************

                            inputString = txtReader.ReadLine();    // skip line with the text:   "Changed paths:
                            
                            // continue & read next line
                            inputString = txtReader.ReadLine();
                            inputString = inputString.Trim();  // remove blank space from start & end of string
                            string tempChangedPath = inputString + ",";

                            while (!string.IsNullOrWhiteSpace(inputString))
                            {                                
                                inputString = txtReader.ReadLine();
                                inputString = inputString.Trim();  // remove blank space from start & end string
                                tempChangedPath += inputString + ",";
                            } // end while  
                            
                            // Write final ChangedPaths string to object
                            currentBlock.ChangedPaths = tempChangedPath;




                            // **** Comments Section ****
                            // **************************
                           
                            // Blank line found and skipped over - read next line                            
                            inputString = txtReader.ReadLine();

                            // replace any "double quotes" with 'single quotes' for better csv file display in Excel
                            string regexQuotesPattern = "\"";
                            string replacement = "'";
                                                        
                            string tempComments = string.Empty;
                            string result = string.Empty;
                                                        
                            // Loop through comment lines until 72 x hyphen marker is encountered
                            bool con = true;
                            while (con)  // if NOT the EOF 72 hyphen line
                            {
                                Match regExMatch13 = Regex.Match(inputString, regex72Hypens);
                                if (regExMatch13.Success)
                                {
                                    con = false;   // if regex match 72 * hyphen - leave block
                                }
                                else    
                                {  
                                    // replace any "double quotes" with 'single quotes' for better csv file display in Excel
                                    Regex changeQuotes2 = new Regex(regexQuotesPattern);
                                    result = changeQuotes2.Replace(inputString, replacement);
                                    tempComments += result + "\n";
                                    inputString = txtReader.ReadLine();
                                } // end else                                                               
                            } // end while

                           
                            // Write final Comments string to object
                            currentBlock.Comments = tempComments;

                            // Add Main-Data-Line object to list
                            myList.Add(currentBlock);

                        } // end while                                           
                    } // end inner Using
                } // end outer Using

           

            Console.Clear();
            Console.WriteLine("\nData has been read into memory & stored in a list of objects.");
            Console.Write("\n[Enter] to continue to write to a new output file.\n");
            Console.ReadLine();
            


            //// Display all data added to object list - uncomment to view
            //foreach (CA_File_Unit cfu in myList)
            //{
            //    Console.WriteLine(cfu.RNumber);
            //    Console.WriteLine(cfu.Name);
            //    Console.WriteLine(cfu.DateShort);
            //    Console.WriteLine(cfu.Time);
            //    Console.WriteLine(cfu.Offset);
            //    Console.WriteLine(cfu.DateLong);
            //    Console.WriteLine(cfu.NoOfLines);
            //    Console.WriteLine(cfu.ChangedPaths);
            //    Console.WriteLine(cfu.Comments);
            //    Console.WriteLine();                
            //} // end foreach





            // **** Write to CSV file ****
            // ***************************

            // write file
            using (Stream fs = File.Create(PathFileOutput))
            {
                using (TextWriter txtWriter = new StreamWriter(fs, Encoding.UTF8))
                {
                    // Write header titles for csv columns 
                    string headerTitles = "Reference No:," + "Name:," + "DateShort:," + "Time:,"
                        + "Offset:," + "DateLong:," + "No of lines:," + "Comments:," + "ChangedPaths:,";
                    txtWriter.WriteLine(headerTitles);

                    foreach (CA_File_Unit cfu in myList)
                    {
                        txtWriter.Write(cfu.RNumber + ",");
                        txtWriter.Write(cfu.Name + ",");
                        txtWriter.Write(cfu.DateShort + ",");
                        txtWriter.Write(cfu.Time + ",");
                        txtWriter.Write(cfu.Offset + ",");
                        txtWriter.Write("\"" + cfu.DateLong + "\"" + ",");
                        txtWriter.Write(cfu.NoOfLines + ",");
                        txtWriter.Write("\"" + cfu.Comments + "\"" + ",");                       
                        txtWriter.WriteLine(cfu.ChangedPaths + ",");
                        //   
                        commitCount++;
                    }                    
                    Console.Write("Data written to file - Commit Count No: {0}\n\n", commitCount);
                    } // end inner Using
                } // end outer using          

            } // end try
            catch
            {
                Console.WriteLine("\nError - no file available to read");
                Console.WriteLine("The file:  commit_changes.txt   must be in the C:\\dbs\\   directory   \n\n");
            }
        } // end Main
    } // end Program
} // end Namespace


