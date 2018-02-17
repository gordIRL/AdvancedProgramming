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

        public static bool MainLoop(string userSelection)
        {
            userSelection = userSelection.ToUpper();
            bool continueProgram = true;

            switch (userSelection)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("\nOption 1) Load Original Data From File & Display:\n\n");

                    ////bool userFileExists = MyFileIO.CheckFileExists("testBinary1");
                    ////Console.WriteLine("User file exists: {0}", userFileExists);

                    ////bool isFileCreated = MyFileIO.CreateFileStream("testBinary1");
                    ////Console.WriteLine("File created: {0}", isFileCreated);

                    //MyFileIO.CheckFileExists("testBinary1");
                    //MyFileIO.CreateFileStream("testBinary1");

                    //Console.WriteLine("Option One - Completed");
                    //Utility.WaitForUserAndClearScreen();


                    // Import original data into List of HorseBet objects by calling ImportData();
                    ListOfHorseBets = ImportDefaultData.ImportData();

                    // Display complete / original HorseBet List
                    foreach (HorseBet hb in ListOfHorseBets)
                    {
                        Console.WriteLine(hb.ToString());
                    }
                    Utility.WaitForUserAndClearScreen();                    
                    break;


                    
                case "2":
                    Console.Clear();
                    Console.WriteLine("\nOption 2)  Create new HorseBet and add to ListOfHorseBets\n\n");
                    //Create a HorseBet and add to ListOfHorseBets
                    ListOfHorseBets.Add(CreateHorseBet.Method1());

                    Utility.WaitForUserAndClearScreen();
                    break;



                case "3":
                    Console.Clear();
                    Console.WriteLine("\nOption 3)  View current HorseBet list (in memory)\n\n");
                    foreach (var HorseBet in ListOfHorseBets)
                    {
                        Console.WriteLine(HorseBet);
                    }
                    Utility.WaitForUserAndClearScreen();
                    break;



                case "4":
                    Console.Clear();
                    Console.WriteLine("\nOption 4)  Save current HorseBet list to BinaryFile\n\n");

                    // Write out ListOfHorseBets To Binary file
                    MyFileIO.WriteToBinaryFile(ListOfHorseBets);

                    Utility.WaitForUserAndClearScreen();
                    break;



                case "5":
                    Console.Clear();
                    Console.WriteLine("\nOption 5)  Load HorseBet list from BinaryFile\n\n");

                    // Read in ListOfHorseBets from Binary file
                    MyFileIO.ReadFromBinaryFile();

                    Utility.WaitForUserAndClearScreen();
                    break;



                case "6":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("\nOption 6)  Results of GetMostPopularRaceCourse query\n\n");
                        Console.WriteLine(ReportingMethods.GetMostPopularRaceCourse(ListOfHorseBets));
                    }
                    catch
                    {
                        Console.WriteLine("Error - Please load in default data before running report queries.");
                    }
                    Utility.WaitForUserAndClearScreen();                                           
                    break;



                case "7":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("\nOption 7)  Report - Win / Loss Breakdown by Year:\n\n");

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



                case "8":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Display all bets in date order (oldest to newest): \n\n");

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


                    
                case "9":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Display highest amount won or lost on a race \n\n");

                        // Greatest amount won or lost on a race
                        Console.WriteLine(ReportingMethods.HighestAmountWonOrLostOnARace(ListOfHorseBets, true)); // wins
                        Console.WriteLine();
                        Console.WriteLine(ReportingMethods.HighestAmountWonOrLostOnARace(ListOfHorseBets, false)); // loses 
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
                        Console.WriteLine("HotTipster Success Level:\n");
                        Console.WriteLine(ReportingMethods.HotTipsterSuccessLevel(ListOfHorseBets));
                    }
                    catch
                    {
                        Console.WriteLine("Error - Please load in default data before running report queries.");
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
