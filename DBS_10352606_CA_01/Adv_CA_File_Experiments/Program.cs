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



namespace DBS_10352606_CA_01
{
    class Program
    {
        static readonly string PathFileOutput = @"C:\dbs\csvOutputFile.csv";
        //static readonly string PathFileInput = @"C:\dbs\commit_changes.txt";
        static readonly string PathFileInput = @"C:\dbs\commit_changes_edit2.txt";
        
         

        static void Main(string[] args)
        {
            List<CA_File_Unit> myList = new List<CA_File_Unit>();
            int commitCount = 0;
            string inputString = string.Empty;
            string myRegexExpression72Hyp = @"\-{72}";

            
                               

            try             // Begin reading file
            {

                using (Stream fs = File.OpenRead(PathFileInput))
                {
                    using (TextReader txtReader = new StreamReader(fs, Encoding.UTF8))
                    {
                        inputString = txtReader.ReadLine();
                        while (txtReader.Peek() > -1)   // check not at end of file
                        {
                            
                            // Clear screen & Wait
                            Console.WriteLine("\n\nReading contents from file: [enter] to continue  -  Maximise console window to view correctly.\n\n");
                            Console.ReadLine();
                            Console.Clear();


                            // Create new object for file block
                            CA_File_Unit currentBlock = new CA_File_Unit();



                            Match regExMatch = Regex.Match(inputString, myRegexExpression72Hyp);

                            if (regExMatch.Success)
                            {
                                inputString = txtReader.ReadLine();                                

                                // Regular Expression to parse Main-Data-Line   ( includes no / name / date etc )                                
                                string myRegexMainLine = @"(\w*)\s*\|\s*([\w\W]*)\s*\|\s*";
                                myRegexMainLine += @"(\d{4}[\-|\s]*\d{2}[\-|\s]*\d{2})";   //   Short Date    
                                myRegexMainLine += @"\s*(\d{2}:\d{2}:\d{2})";              //   Time
                                myRegexMainLine += @"\s*(\+\s*\d{4})";                     //   Offset
                                myRegexMainLine += @"\s*\W(.{16})";                        //   LongDate
                                myRegexMainLine += @"\W*(\d*)";                            //   No Of Lines


                                // Display Main-Data-Line on Screen
                                MatchCollection matches = Regex.Matches(inputString, myRegexMainLine, RegexOptions.Multiline);  //, RegexOptions.Multiline);               
                                foreach (Match match in matches)
                                {
                                    Console.WriteLine("\nR-Number      :   {0}", match.Groups[1].Value); //Console.ReadLine();
                                    Console.WriteLine("Name          :   {0}", match.Groups[2].Value); //Console.ReadLine();
                                    Console.WriteLine("Date          :   {0}", match.Groups[3].Value); //Console.ReadLine();
                                    Console.WriteLine("Time          :   {0}", match.Groups[4].Value); //Console.ReadLine();
                                    Console.WriteLine("Offset        :   {0}", match.Groups[5].Value); //Console.ReadLine();
                                    Console.WriteLine("Long-Date     :   {0}", match.Groups[6].Value); //Console.ReadLine();
                                    Console.WriteLine("No of Lines   :   {0}\n\n", match.Groups[7].Value); //Console.ReadLine(); 

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
                              //Console.ReadLine();



                            // ****   Changed Paths Section
                            // *************************************************************************
                            inputString = txtReader.ReadLine();    // skip line with text:   "Changed paths:
                            //string myRegexExpression = @"Changed paths:";
                            //Match regExMatch10 = Regex.Match(inputString, myRegexExpression);
                            //if (regExMatch10.Success)
                            //{
                            //    Console.WriteLine("\n\nFound Control Path: {0}\n\n", inputString);
                            //} // end if

                            // read next line
                            inputString = txtReader.ReadLine();
                            inputString = inputString.Trim();  // remove blank space from start & end of string
                            string tempChangedPath = inputString + ",";

                            while (!string.IsNullOrWhiteSpace(inputString))
                            {
                                Console.WriteLine("ChangedPaths(input from file):\n{0}", inputString);
                                inputString = txtReader.ReadLine();
                                inputString = inputString.Trim();  // remove blank space from start & end string
                                tempChangedPath += inputString + ",";
                            } // end while  
                            Console.WriteLine("\nChangedPaths(final combined string):\n{0}", tempChangedPath);

                            // Write final ChangedPaths string to object
                            currentBlock.ChangedPaths = tempChangedPath;




                            // **** Comments Section ****
                            // **********************************************************************
                           // Console.WriteLine("\n\nBlank line Found:\n\n");

                            // read next line
                            inputString = txtReader.ReadLine();

                            // replace any "double quotes" with 'single quotes' for better csv file display in Excel
                            string regexQuotesPattern = "\"";
                            string replacement = "'";
                            //Regex changeQuotes1 = new Regex(regexQuotesPattern);
                            //string result = changeQuotes1.Replace(inputString, replacement);

                            //string tempComments =  result  + "\n";
                            string tempComments = string.Empty;
                            string result = string.Empty;

                            Console.WriteLine("\n\nComments(input from file):");
                            // Loop through comment lines until 72 x hyphen marker is encountered
                            bool con = true;
                            while (con)  // if its NOT the EOF 72 hyphen line
                            {
                                Match regExMatch13 = Regex.Match(inputString, myRegexExpression72Hyp);
                                if (regExMatch13.Success)
                                {
                                    con = false;   // if regex match 72 * hyphen - leave block
                                }
                                else
                                {   //con = true;
                                    Console.WriteLine("{0}", inputString);

                                    // replace any "double quotes" with 'single quotes' for better csv file display in Excel

                                    Regex changeQuotes2 = new Regex(regexQuotesPattern);
                                    result = changeQuotes2.Replace(inputString, replacement);

                                    tempComments += result + "\n";
                                    inputString = txtReader.ReadLine();
                                } // end else                                                               
                            } // end while

                            Console.WriteLine("\nComments(final combined string):\n{0}\n\n", tempComments);


                            // Write final Comments string to object
                            currentBlock.Comments = tempComments;

                            // Add Main-Data-Line object to list
                            myList.Add(currentBlock);


                        } // end while                                           
                    } // end inner Using
                } // end outer Using

           


            Console.Write("Enter to continue to file display");
            Console.ReadLine();
            Console.Clear();

            foreach (CA_File_Unit cfu in myList)
            {
                Console.WriteLine(cfu.RNumber);
                Console.WriteLine(cfu.Name);
                Console.WriteLine(cfu.DateShort);
                Console.WriteLine(cfu.Time);
                Console.WriteLine(cfu.Offset);
                Console.WriteLine(cfu.DateLong);
                Console.WriteLine(cfu.NoOfLines);
                Console.WriteLine(cfu.ChangedPaths);
                Console.WriteLine(cfu.Comments);
                Console.WriteLine();                
            } // end foreach





            // **** Write to CSV file ****
            // *******************************

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
                        //txtWriter.Write(cfu.Comments + ",");
                        txtWriter.WriteLine(cfu.ChangedPaths + ",");

                        commitCount++;
                    }


                    ////****test - multiline cell in excel**************************************
                    ////                     
                    //string header = "Reference No," + "Name," + "Date," + "Rows," + "Extras,";
                    //txtWriter.WriteLine(header);

                    //txtWriter.Write("r11111111" + ",");
                    //txtWriter.Write("Gord" + ",");
                    //txtWriter.Write("06/03/1971" + ",");
                    //string fours = "\"Row One\n" + "Row Two\n" + "Row Three\n" + "Row Four\n\"";
                    //txtWriter.Write(fours + ",");
                    //txtWriter.Write("After fives 55");
                    //txtWriter.WriteLine(",");


                    //txtWriter.Write("r2222222" + ",");
                    //txtWriter.Write("Amanda" + ",");
                    //txtWriter.Write("30/7/1968" + ",");
                    //fours = "\"FTRPC - 500: Frontier Android || Inconsistencey in My Activity screen\n" 
                    //    + "Client used systemAttribute name = 'Creation - Date' instead of versionCreated as version created.\n"
                    //          + "Row Three\n" + "Row Four\n\"";
                    //txtWriter.Write(fours + ",");
                    //txtWriter.Write("After fives 55");
                    //txtWriter.WriteLine(",");


                    //txtWriter.Write("r3333333" + ",");
                    //txtWriter.Write("Smith" + ",");
                    //txtWriter.Write("19/12/1950" + ",");
                    //fours = "\"Row One\n" + "Row Two\n" + "Row Three\n" + "Row Four\n\"";
                    //txtWriter.Write(fours + ",");
                    //txtWriter.Write("After fives 55");
                    //txtWriter.WriteLine(",");




                    // *************************************************************************
                    Console.Write("Enter - to continue");
                    Console.ReadLine();
                    Console.Write("Data written to file - Commit Count No: {0}", commitCount);
                    Console.ReadLine();


                } // end inner Using
            } // end outer using

            Console.ReadLine();

            } // end try
            catch
            {
                Console.WriteLine("Error - no file available to read");
                Console.WriteLine("The file:  commit_changes.txt   must be in the C:\\ directory   \n\n");
            }

        } // end Main
    } // end Program
} // end Namespace


