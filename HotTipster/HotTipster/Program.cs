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
    class Program
    {
        public static List<HorseBet> ListOfHorseBets = new List<HorseBet>();


        static void Main(string[] args)
        {

            //bool userFileExists =  MyFileIO.CheckFileExists("testBinary1");
            //Console.WriteLine("User file exists: {0}", userFileExists);

            //bool isFileCreated = MyFileIO.CreateFileStream("testBinary1");
            //Console.WriteLine("File created: {0}", isFileCreated);


            MyFileIO.CheckFileExists("testBinary1");
            MyFileIO.CreateFileStream("testBinary1");


            // Import original data into List of HorseBet objects by calling ImportData();
            //List<HorseBet> ListOfHorseBets = ImportDefaultData.ImportData();
            ListOfHorseBets = ImportDefaultData.ImportData();

            //// KEEP - Display complete / original HorseBet List
            //foreach (HorseBet hb in ListOfHorseBets)
            //{
            //    Console.WriteLine(hb.ToString());
            //}
            //Console.WriteLine("\n\n\n\n");
            //Console.ReadLine();



            //// Create a HorseBet and add to ListOfHorseBets
            //ListOfHorseBets.Add(CreateHorseBet.Method1());



            //// Write out ListOfHorseBets To Binary file
            //MyFileIO.WriteToBinaryFile(ListOfHorseBets);
            //// Creat in ListOfHorseBets from Binary file
            //MyFileIO.ReadFromBinaryFile();





            Console.ReadLine();
            Console.WriteLine("Report - Win / Loss Breakdown by Year:");

            // Call GetAnnualResult method using ListOfHorseBets list & Year & win/lose bool
            Console.WriteLine(ReportingMethods.GetAnnualResult(ListOfHorseBets, 2017, true));
            Console.WriteLine(ReportingMethods.GetAnnualResult(ListOfHorseBets, 2017, false));

            Console.WriteLine(ReportingMethods.GetAnnualResult(ListOfHorseBets, 2016, true));
            Console.WriteLine(ReportingMethods.GetAnnualResult(ListOfHorseBets, 2016, false));

            // Call GetMostPopularRaceCourse method using ListOfHorseBets
            //Console.WriteLine(ReportingMethods.GetMostPopularRaceCourse());

            //------------------------------------------------------------------------------------










            Console.ReadLine();
            //------------------------------------------------------------------------------------


            // DisplayAllBetsInDateOrder            
            var AllBetsInDateOrderList =
                from HorseBet in ListOfHorseBets
                orderby HorseBet.RaceDate   // default oldest to newest  // descending =  newest to oldest          
                select (HorseBet);

            foreach (var HorseBet in AllBetsInDateOrderList)
            {
                Console.WriteLine(HorseBet);
            }

            Console.ReadLine();
            //  --------------------------------------------------------------------------------------------


            // Provide another report that displays the highest amount won 
            // for a bet laid and the most lost for a bet laid.

            // Select whether Winning Or Losing race is required
            bool wonRace = false;

            // Find the largest amount won or lost
            var highestAmountWonOrLostOnARace =
                (from HorseBet in ListOfHorseBets
                 where HorseBet.RaceWasWon == wonRace
                 select HorseBet.BalanceChange).Max();
                      
            // Find race(s) associated with largest amount
            var largestWinningOrLosingRace =
                from HorseBet in ListOfHorseBets
                where HorseBet.BalanceChange == highestAmountWonOrLostOnARace
                select HorseBet;

            // Display largest amount won or lost
            Console.WriteLine("Highest Amount {0} on a race: {1}",
                wonRace ? "WON" : "LOST" ,
                highestAmountWonOrLostOnARace.ToString());
            
            // Display racecourse associated with largest amount
            foreach (var HorseBet in largestWinningOrLosingRace)
            {
                Console.WriteLine("At RaceCourse: {0}", HorseBet);
            }
            Console.ReadLine();

















            //  --------------------------------------------------------------------------------------------


            //Provide a report that shows the most popular race course for bets.
            //The most popular race course is the one with the most bets placed on it.



            // List of totals for each RaceCourse (ignores wins/losses status)
            var noOfBetsPerRaceCourse =
                from HorseBet in ListOfHorseBets
                group HorseBet by HorseBet.RaceCourse into myNewGroup
                //    orderby r.TotalNoOfBetPerRaceCOurse descending

                select new
                {
                    raceCourse = myNewGroup.Key,
                    totalBetsPerCourse = myNewGroup.Count()                  
                };


            foreach (var item in noOfBetsPerRaceCourse)
            {
                Console.WriteLine(string.Format("::::::::::::::::::::::{0}: {1}",
                    item.raceCourse, item.totalBetsPerCourse));
            }
           
            

            
            // get the single highest amount of bets for any racecourse in the list
            var maxSingleAmountOfBetsOfAnyRaceCourse =
                (from rrr in noOfBetsPerRaceCourse

                 select (rrr.totalBetsPerCourse)).Max();     // select MAX or MIN here

            
            // Assign maxSingleAmountOfBetsOfAnyRaceCourse to integer max
            int maxSingleAmountInt = maxSingleAmountOfBetsOfAnyRaceCourse;
            Console.WriteLine("Max: {0}", maxSingleAmountOfBetsOfAnyRaceCourse.ToString());               
           


            // Use MAX number THEN return query based on that max number  // (use multiple MINIMUM entries to verify
            var mostPopularRaceCourseList =
                from result in noOfBetsPerRaceCourse
                where result.totalBetsPerCourse == maxSingleAmountInt
                select result;

            
            // Display RacesCourses with most bets
            Console.WriteLine("Results of racecourse query");
            foreach (var item in mostPopularRaceCourseList)
            {
                Console.WriteLine(item);
            }
            
            
            




            //Console.WriteLine(Utility.AddTwoNums(5, 3));
        }// end Main
    }// end class Program
}// end Namespace
