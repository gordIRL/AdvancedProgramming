using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTipster
{
    public static class Utility
    {
        public static void WaitForUserAndClearScreen()
        {
            Console.Write("\n\nPress ENTER to continue: ");
            Console.ReadLine();
            Console.Clear();            
        }


        public static bool ScreenDisplay()
        {
            Console.Clear();
            Console.WriteLine("********************************************************");
            Console.WriteLine("***********************Hot Tipster**********************");
            Console.WriteLine("********************************************************\n");
            Console.WriteLine();
            Console.WriteLine("Option 1)  Load Original Data From File");
            Console.WriteLine();

            Console.WriteLine("Option 2)  Load HorseBet list from BinaryFile");
            Console.WriteLine();

            Console.WriteLine("Option 3)  View current HorseBet list (in memory)");
            Console.WriteLine();

            Console.WriteLine("Option 4)  Create new HorseBet and add to NewAdditionsHorseBetList & ListOfHorseBets");
            Console.WriteLine("Option 5)  View New Additions to HorseBet list (unsaved changes)");
            Console.WriteLine("Option 6)  Save NewAdditionsToHorseBetList to BinaryFile");
            Console.WriteLine();
            
            Console.WriteLine("Option 7)  Get Most Popular Race Course");
            Console.WriteLine("Option 8)  Win / Loss Breakdown by Year");
            Console.WriteLine("Option 9)  Display all bets ordered by date (oldest to newest)");
            Console.WriteLine("Option 10) Display highest amount won or lost on a race");
            Console.WriteLine("Option 11) HotTipster Success Level");
            Console.WriteLine();

            Console.WriteLine("Option 12) DeleteBinaryFile - (leaves temporary data in memory)");
            Console.WriteLine("Option 13) Clear all data from memory");
            Console.WriteLine();
            
            Console.WriteLine("\nOption 'E') EXIT Program");

            Console.Write("\n\nEnter selection: ");

            return true;
        }
    }
}
