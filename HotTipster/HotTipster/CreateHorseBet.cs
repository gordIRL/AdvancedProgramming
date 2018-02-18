using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTipster
{
    public static class CreateHorseBet
    {
        public static HorseBet Method1()
        {
            // User inputs RaceCourse Name
            Console.Write("Please enter RaceCourse Name: ");
            string tempRaceCourse =  Console.ReadLine();


            // User inputs date of race
            bool successfulEntry = false;
            DateTime tempRaceDate = new DateTime();
            while (!successfulEntry)
            {
                Console.Write("Please enter Date of Race:format (YYYY, MM, DD)");
                string tempRaceDateString = Console.ReadLine();
                try
                {
                    tempRaceDate = Convert.ToDateTime(tempRaceDateString);
                    successfulEntry = true;
                }
                catch
                {
                    Console.WriteLine("Invalid date entry");
                }
            }// end while loop

            


            // User inputs amount that was won or lost
            successfulEntry = false;
            decimal tempBalanceChange = 0;
            while (!successfulEntry)
            {
                Console.Write("Please enter amount won or lost: ");
                string tempBalanceChangeString = Console.ReadLine();
                try
                {
                    tempBalanceChange = decimal.Parse(tempBalanceChangeString);
                    successfulEntry = true;
                }
                catch
                {
                    Console.WriteLine("Invalid - please enter a valid number");
                }
            }// end while loop





            // User inputs true or false to indicate if amount was won or lost
            successfulEntry = false;
            bool tempRaceWasWon = false;
            while (!successfulEntry)
            {
                Console.Write("Please enter W or L (for win or lose): ");
                string tempRaceWasWonString = Console.ReadLine();
                tempRaceWasWonString = tempRaceWasWonString.ToUpper();

                if (tempRaceWasWonString == "W")
                {
                    tempRaceWasWon = true;
                    successfulEntry = true;
                }
                else if (tempRaceWasWonString == "L")
                {
                    tempRaceWasWon = false;
                    successfulEntry = true;
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                }
            }// end while loop


            HorseBet horseBet1 = new HorseBet(tempRaceCourse, tempRaceDate, tempBalanceChange, tempRaceWasWon);
            Console.WriteLine();
            Console.WriteLine(horseBet1.ToString());


            Console.WriteLine("\nHorseBet created with the following data:");
            Console.WriteLine("{0}  {1}  {2}  {3}",
                tempRaceCourse, tempRaceDate, tempBalanceChange, tempRaceWasWon);
            Console.ReadLine();
            
            
            // return newly created HorseBet
            return horseBet1;

        }// end Method1
    }// end CreateHorseBet
}// end Namespace
