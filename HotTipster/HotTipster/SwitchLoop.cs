using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTipster
{
    public static class SwitchLoop
    {
        public static List<HorseBet> ListOfHorseBets = new List<HorseBet>();
        public static List<HorseBet> NewAdditionsToHorseBetList = new List<HorseBet>();
        

        public static bool MainLoop(string userSelection)
        {            
            userSelection = userSelection.ToUpper();
            bool continueProgram = true;

            switch (userSelection)
            {
                case "1":                    

                    ////bool userFileExists = MyFileIO.CheckFileExists("testBinary1");
                    ////Console.WriteLine("User file exists: {0}", userFileExists);

                    ////bool isFileCreated = MyFileIO.CreateFileStream("testBinary1");
                    ////Console.WriteLine("File created: {0}", isFileCreated);

                    //MyFileIO.CheckFileExists("testBinary1");
                    //MyFileIO.CreateFileStream("testBinary1");


                    // Import original data into List of HorseBet objects by calling ImportData();
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("\nOption 1) Load Original Data From Text File:\n\n");

                        // Load data into a tempory list
                        List<HorseBet> tempHorsebetList = new List<HorseBet>(ImportDefaultData.ImportData());

                        //Iterate through tempory list & add data to both lists for 1)Reports & 2) to enable saving to binary file
                        foreach (var item in tempHorsebetList)
                        {
                            ListOfHorseBets.Add(item);
                            NewAdditionsToHorseBetList.Add(item);
                        } 
                        Console.WriteLine("Default data loaded to memory.");
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option1 - ListOfHorseBets = ImportDefaultData.ImportData()");
                    }                    
                    Utility.WaitForUserAndClearScreen();                    
                    break;


                                        
                case "2":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("\nOption 2)  Load HorseBet list from BinaryFile\n\n");

                        // Read in ListOfHorseBets from Binary file
                        ListOfHorseBets = MyFileIO.ReadFromBinaryFile();
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option2 - Load HorseBet list from BinaryFile");
                    } 
                    Utility.WaitForUserAndClearScreen();
                    break;


                                        
                case "3":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("\nOption 3)  View current HorseBet list (in memory)\n\n");

                        // Alert user if HorseBet List is empty
                        if (ListOfHorseBets.Count == 0)
                            Console.WriteLine("HorseBet List Status: Empty");

                        // Display list if it contains data
                        foreach (var HorseBet in ListOfHorseBets)
                        {
                            Console.WriteLine(HorseBet);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option 3 - View current HorseBet list (in memory)");
                    }                    
                    Utility.WaitForUserAndClearScreen();
                    break;


                                        
                case "4":
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("\nOption 4)  Create new HorseBet and add to NewAdditionsHorseBetList & ListOfHorseBets \n\n");
                        
                        //Create a HorseBet 
                        HorseBet tempHorseBet = CreateHorseBet.Method1();

                        // Add to ListOfHorseBets (for display purposes & to be included in Reports queries)
                        ListOfHorseBets.Add(tempHorseBet);

                        // Add to NewAdditionsToHorseBetList (to enable save updates & changes to binary file)
                        NewAdditionsToHorseBetList.Add(tempHorseBet);
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option2 - Create a new HourseBet");
                    }
                    Utility.WaitForUserAndClearScreen();
                    break;

                    

                case "5":
                    Console.Clear();
                    Console.WriteLine("\nOption 5)  View New Additions to HorseBet list (unsaved changes)\n\n");

                    // Alert user if HorseBet List is empty
                    if (NewAdditionsToHorseBetList.Count == 0)
                        Console.WriteLine("New Additions HorseBet List Status: Empty");

                    // Display list if it contains data
                    foreach (var HorseBet in NewAdditionsToHorseBetList)
                    {
                        Console.WriteLine(HorseBet);
                    }
                    Utility.WaitForUserAndClearScreen();
                    break;


                    
                case "6":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("\nOption 6)  Save NewAdditionsToHorseBetList to BinaryFile\n\n");

                        // Write out ListOfHorseBets To Binary file                    
                        MyFileIO.WriteToBinaryFile(NewAdditionsToHorseBetList);
                        Console.WriteLine("NewAdditions have been written to BinaryFile");

                        // Clear NewAdditions list and alert user
                        NewAdditionsToHorseBetList.Clear();
                        Console.WriteLine("NewAdditions is now empty.");
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option 6 - Save NewAdditionsToHorseBetList to BinaryFile.");
                    }
                    Utility.WaitForUserAndClearScreen();
                    break;
                    


                case "7":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("\nOption 7)  Results of GetMostPopularRaceCourse query\n\n");
                        Console.WriteLine(ReportingMethods.GetMostPopularRaceCourse(ListOfHorseBets));
                    }
                    catch
                    {
                        Console.WriteLine("Error - Please load in default data before running report queries.");
                    }
                    Utility.WaitForUserAndClearScreen();                                           
                    break;



                case "8":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("\nOption 8)  Report - Win / Loss Breakdown by Year:\n\n");

                        //// Call GetAnnualResult method using ListOfHorseBets list & Year & win/lose bool
                        Console.WriteLine(ReportingMethods.GetAnnualResult(ListOfHorseBets, 2017, true));
                        Console.WriteLine(ReportingMethods.GetAnnualResult(ListOfHorseBets, 2017, false));

                        Console.WriteLine(ReportingMethods.GetAnnualResult(ListOfHorseBets, 2016, true));
                        Console.WriteLine(ReportingMethods.GetAnnualResult(ListOfHorseBets, 2016, false));
                    }
                    catch
                    {
                        Console.WriteLine("Error - Please load in default data before running report queries.");
                    }
                    Utility.WaitForUserAndClearScreen();
                    break;



                case "9":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Option 9) Display all bets in date order (oldest to newest): \n\n");

                        // Get list of bets in date order & store in a new list 'BetsInDateOrder'
                        List<HorseBet> BetsInDateOrder = ReportingMethods.DisplayAllBetsInDateOrder(ListOfHorseBets);

                        // Display list
                        foreach (var item in BetsInDateOrder)
                        {
                            Console.WriteLine(item);
                        }// end foreach
                    }
                    catch
                    {
                        Console.WriteLine("Error - Please load in default data before running report queries.");
                    }
                    Utility.WaitForUserAndClearScreen();
                    break;


                    
                case "10":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Option 10) Display highest amount won or lost on a race \n\n");

                        // Greatest amount won or lost on a race
                        Console.WriteLine("Highest Amount Won Query:");
                        Console.WriteLine(ReportingMethods.HighestAmountWonOrLostOnARace(ListOfHorseBets, true)); // wins
                        Console.WriteLine();
                        Console.WriteLine("Highest Amount Lost Query:");
                        Console.WriteLine(ReportingMethods.HighestAmountWonOrLostOnARace(ListOfHorseBets, false)); // loses 
                    }
                    catch
                    {
                        Console.WriteLine("Error - Please load in default data before running report queries.");
                    }
                    Utility.WaitForUserAndClearScreen();
                    break;


                    
                case "11":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Option 11) HotTipster Success Level:\n");
                        Console.WriteLine(ReportingMethods.HotTipsterSuccessLevel(ListOfHorseBets));
                    }
                    catch
                    {
                        Console.WriteLine("Error - Please load in default data before running report queries.");
                    }
                    Utility.WaitForUserAndClearScreen();
                    break;



                case "12":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Option 12) Delete Binary File\n");
                        MyFileIO.DeleteBinaryFile();
                        Console.WriteLine("Binary file has been deleted.");                        
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option 12 - MyFileIO.DeleteBinaryFile()");
                    }
                    Utility.WaitForUserAndClearScreen();
                    break;



                case "13":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Option 13) Clear all data from memory:\n");
                        ListOfHorseBets.Clear();
                        NewAdditionsToHorseBetList.Clear();
                        Console.WriteLine("All data has been cleared from memory.");
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option 12 - MyFileIO.DeleteBinaryFile()");
                    }
                    Utility.WaitForUserAndClearScreen();
                    break;



                case "E":
                    Console.WriteLine("Exiting Application\n");
                    continueProgram = false;                    
                    break;


                    
                default:
                    Console.WriteLine("That is not a valid selection - ENTER to continue");
                    Utility.WaitForUserAndClearScreen();
                    break;

            }// end switch

            // return bool to indicate whether to quit or continue to run program
            return continueProgram;           

        }// end method MainLoop
    }// end class SwitchLoop
}// end Namespace
