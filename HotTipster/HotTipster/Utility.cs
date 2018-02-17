using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTipster
{
    public static class Utility
    {
        public static double AddTwoNums(double num1, double num2)
        {
            return num1 + num2;
        }


        public static void WaitForUserAndClearScreen()
        {
            Console.Write("\n\nPress ENTER to continue: ");
            Console.ReadLine();
            Console.Clear();
        }

        public static void ScreenDisplay()
        {
            Console.Clear();
            Console.WriteLine("********************************************************");
            Console.WriteLine("***********************Hot Tipster**********************");
            Console.WriteLine("********************************************************\n\n");
            Console.WriteLine("Option 1)  Load Original Data From File & Display");
            Console.WriteLine("Option 2)  Create new HorseBet and add to ListOfHorseBets");
            Console.WriteLine("Option 3)  View current HorseBet list (in memory)");
            Console.WriteLine("Option 4)  Save current HorseBet list to BinaryFile");
            Console.WriteLine("Option 5)  Load HorseBet list from BinaryFile");
            Console.WriteLine("Option 6)  Get Most Popular Race Course");
            Console.WriteLine("Option 7)  Win / Loss Breakdown by Year");
            Console.WriteLine("Option 8)  Display all bets ordered by date (oldest to newest)");
            Console.WriteLine("Option 9)  Display highest amount won or lost on a race");
            Console.WriteLine("Option 10) HotTipster Success Level");
            
            Console.WriteLine("\nOption 'E') EXIT Program");


            Console.Write("\n\nEnter selection: ");
        }// end ScreenDisplay






    }// end class
}// end Namespace
