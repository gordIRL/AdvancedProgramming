using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTipster
{
    public static class SwitchLoop
    {
        // Instantiate 2 lists used throught all methods & options below:
        public static List<HorseBet> ListOfHorseBets = new List<HorseBet>();
        public static List<HorseBet> NewAdditionsToHorseBetList = new List<HorseBet>();        

        public static bool MainLoop(string userSelection)
        {            
            userSelection = userSelection.ToUpper();
            bool continueProgram = true;

            switch (userSelection)
            {
                case "1":

                    // Import original data into List of HorseBet objects by calling ImportData();
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("\nOption 1) Load Original Data From Text File:\n\n");

                        // Load data into a tempory list
                        List<HorseBet> tempHorsebetList = new List<HorseBet>(ImportDefaultData.ImportData());

                        //Iterate through tempory list & add data to both lists for 1)Reports 
                        // & 2) to enable saving to binary file
                        foreach (var item in tempHorsebetList)
                        {
                            ListOfHorseBets.Add(item);
                            NewAdditionsToHorseBetList.Add(item);
                        }
                        Console.WriteLine("Default data loaded to memory.");
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option 1 - ListOfHorseBets = ImportDefaultData.ImportData()");
                    }
                    return continueProgram = true;

                case "2":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("\nOption 2)  Load HorseBet list from BinaryFile\n\n");

                        // Read in ListOfHorseBets from Binary file
                        ListOfHorseBets = MyFileIO.ReadFromBinaryFile();
                        return continueProgram = true;
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option 2 - Load HorseBet list from BinaryFile");
                    }                    
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
                        return continueProgram = true;
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option 3 - View current HorseBet list (in memory)");
                    }                                        
                    break;
                    
                case "4":
                    Console.Clear();
                    try
                    {                        
                        Console.WriteLine("\nOption 4)  Create new HorseBet and add to NewAdditionsHorseBetList & ListOfHorseBets \n\n");
                        
                        //Create a HorseBet 
                        HorseBet tempHorseBet = CreateHorseBet.CreateNewHorseBet();

                        // Add to ListOfHorseBets (for display purposes & to be included in Reports queries)
                        ListOfHorseBets.Add(tempHorseBet);

                        // Add to NewAdditionsToHorseBetList (to enable save updates & changes to binary file)
                        NewAdditionsToHorseBetList.Add(tempHorseBet);
                        return continueProgram = true;
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option 4 - Create new HorseBet and add to NewAdditionsHorseBetList & ListOfHorseBets");
                    }
                    break;                    

                case "5":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("\nOption 5)  View New Additions to HorseBet list (unsaved changes)\n\n");

                        // Alert user if HorseBet List is empty
                        if (NewAdditionsToHorseBetList.Count == 0)
                            Console.WriteLine("New Additions HorseBet List Status: Empty");

                        // Display list if it contains data
                        foreach (var HorseBet in NewAdditionsToHorseBetList)
                        {
                            Console.WriteLine(HorseBet);
                        }
                        return continueProgram = true;
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option 5 - View New Additions to HorseBet list (unsaved changes)");
                    } 
                    break;
                    
                case "6":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("\nOption 6)  Save NewAdditionsToHorseBetList to BinaryFile\n\n");

                        if(NewAdditionsToHorseBetList.Count > 0)
                            {
                            // Write out ListOfHorseBets To Binary file                    
                            MyFileIO.WriteToBinaryFile(NewAdditionsToHorseBetList);
                            Console.WriteLine("NewAdditions have been written to BinaryFile");

                            // Clear NewAdditions list and alert user
                            NewAdditionsToHorseBetList.Clear();
                            Console.WriteLine("NewAdditions is now empty.");
                        }
                        else
                        {
                            Console.WriteLine("There is no unsaved data to save.");
                        }
                        return continueProgram = true;
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option 6 - Save NewAdditionsToHorseBetList to BinaryFile - DATA NOT SAVED");
                        Console.WriteLine("\nFile.Delete error “The process cannot access the file because it is being used by another process”");
                        Console.WriteLine("Occurs after deleting the binary file & then trying to save to it again.");
                    }
                    break;

                case "7":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("\nOption 7)  Results of GetMostPopularRaceCourse query\n\n");
                        Console.WriteLine(ReportingMethods.GetMostPopularRaceCourse(ListOfHorseBets));
                        return continueProgram = true;
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option 7 - Please load in default data before running report queries.");
                    }                                                            
                    break;

                case "8":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("\nOption 8)  Report - Win / Loss Breakdown by Year:\n\n");
                        if(ListOfHorseBets.Count == 0)
                        {
                            Console.WriteLine("Error Option 8 - Please load in default data before running report queries.");
                            break;
                        }
                        
                        // Create a list of type int to store the result of ListOfYears query
                        List<int> ListOfYears = ReportingMethods.ListOfYears(ListOfHorseBets);

                        // Iterate through ListOfYears & for each year & 
                        // Call GetAnnualResult method on ListOfHorseBets & win/lose bool
                        foreach (var bettingYear in ListOfYears)
                        {                            
                            Console.WriteLine(ReportingMethods.GetAnnualResult(ListOfHorseBets, bettingYear, true));
                            Console.WriteLine(ReportingMethods.GetAnnualResult(ListOfHorseBets, bettingYear, false)); 
                        }
                        return continueProgram = true;
                    }
                    catch
                    {
                        Console.WriteLine("Error Option 8 - Please load in default data before running report queries.");
                    }                    
                    break;

                case "9":
                    Console.Clear();
                    if (ListOfHorseBets.Count == 0)
                    {
                        Console.WriteLine("Error Option 9)  - Please load in default data before running report queries.");
                        break;
                    }
                    try
                    {
                        Console.WriteLine("Option 9) Display all bets in date order (oldest to newest): \n\n");

                        // Get list of bets in date order & store in a new list 'BetsInDateOrder'
                        List<HorseBet> BetsInDateOrder = ReportingMethods.DisplayAllBetsInDateOrder(ListOfHorseBets);

                        // Display list
                        foreach (var item in BetsInDateOrder)
                        {
                            Console.WriteLine(item);
                        }
                        return continueProgram = true;
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option 9 - Please load in default data before running report queries.");
                    }
                    break;

                case "10":
                    Console.Clear();
                    if (ListOfHorseBets.Count == 0)
                    {
                        Console.WriteLine("Error Option 10)  - Please load in default data before running report queries.");
                        break;
                    }
                    try
                    {
                        Console.WriteLine("Option 10) Display highest amount won or lost on a race \n\n");

                        // Greatest amount won or lost on a race
                        Console.WriteLine("Highest Amount Won Query:");
                        Console.WriteLine(ReportingMethods.HighestAmountWonOrLostOnARace(ListOfHorseBets, true)); // wins
                        Console.WriteLine();
                        Console.WriteLine("Highest Amount Lost Query:");
                        Console.WriteLine(ReportingMethods.HighestAmountWonOrLostOnARace(ListOfHorseBets, false)); // loses 
                        return continueProgram = true;
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option 10 - Please load in default data before running report queries.");
                    }
                    break;
                    
                case "11":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Option 11) HotTipster Success Level:\n");
                        Console.WriteLine(ReportingMethods.HotTipsterSuccessLevel(ListOfHorseBets));
                        return continueProgram = true;
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option 11 - Please load in default data before running report queries.");
                    }
                    break;

                case "12":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Option 12)  Delete Binary File\n");
                        MyFileIO.DeleteBinaryFile();
                        Console.WriteLine("Binary file has been deleted.");
                        return continueProgram = true;
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option 12 - MyFileIO.DeleteBinaryFile()");
                    }
                    break;

                case "13":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Option 13) Clear all data from memory:\n");
                        ListOfHorseBets.Clear();
                        NewAdditionsToHorseBetList.Clear();
                        Console.WriteLine("All data has been cleared from memory.");
                        return continueProgram = true;
                    }
                    catch
                    {
                        Console.WriteLine("Error - Option 13 - Clear all data from memory");
                    }
                    break;

                case "E":
                    Console.WriteLine("Exiting Application\n");
                    return continueProgram = false;   
                    
                default:
                    Console.WriteLine("That is not a valid selection - ENTER to continue");                                      
                    return continueProgram = true;
            }
            // return bool to indicate whether to quit or continue to run program
            return continueProgram; 
        }
    }
}
