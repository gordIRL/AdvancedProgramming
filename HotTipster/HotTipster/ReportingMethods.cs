using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTipster
{
    public static class ReportingMethods
    {

        //3.    Provide a report that lists years, total won and total lost, 
        //      e.g., the output will look like the following:



        // Create a 'distinct' list of all years in which bet were placed
        public static List<int> ListOfYears(List<HorseBet> ListOfHorseBets)
        {
            List<int> ListOfYears = new List<int>();


            var ListOfYearsQuery =
                (from HorseBet in ListOfHorseBets
                 select HorseBet.RaceDate.Year).Distinct();
            

            // Add each year from query to a ListOfYears
            Console.WriteLine("Years in which bets were placed:");
            foreach (var bettingYear in ListOfYearsQuery)
            {
                ListOfYears.Add(bettingYear);
                Console.WriteLine(bettingYear);
            }
            Console.WriteLine();

            return ListOfYears;

        }// end ListOfYears


        

        public static string GetAnnualResult(List<HorseBet> ListOfHorseBets,   int year, bool winLoseStatus)
        {
            decimal totalAnualResult =
                (from HorseBet in ListOfHorseBets
                 where HorseBet.RaceDate.Year == year && HorseBet.RaceWasWon == winLoseStatus
                 orderby HorseBet.BalanceChange
                 select (HorseBet.BalanceChange)).Sum();

            return string.Format("Annual result for year: {0} total: {1} {2}", year, totalAnualResult,
                 winLoseStatus ? "Profit" : "Loss");  // uses C# ternary / conditional operator

        }// end GetAnnualResult

       





















        // 4.   Provide a report that shows the most popular race course for bets.
        //      The most popular race course is the one with the most bets placed on it.

        public static string GetMostPopularRaceCourse(List<HorseBet> ListOfHorseBets)
        {
            

            // List of totals for each RaceCourse (ignores wins/losses status)
            var noOfBetsPerRaceCourse =
                from HorseBet in ListOfHorseBets
                group HorseBet by HorseBet.RaceCourse into myNewGroup               
                select new
                {
                    raceCourse = myNewGroup.Key,
                    totalBetsPerCourse = myNewGroup.Count()
                };

            //// Display no of bets placed at each racecourse - for testing only
            //Console.WriteLine("No of bets placed at each racecourse:\n\n");
            //foreach (var item in noOfBetsPerRaceCourse)
            //{
            //    Console.WriteLine(string.Format("{0}: {1}",
            //        item.raceCourse, item.totalBetsPerCourse));
            //}
            

            // get the single highest amount of bets for any racecourse in the list
            var maxSingleAmountOfBetsOfAnyRaceCourse =
                (from rrr in noOfBetsPerRaceCourse
                 select (rrr.totalBetsPerCourse)).Max();     // select MAX or MIN here
            

            // Assign maxSingleAmountOfBetsOfAnyRaceCourse to integer max
            int maxSingleAmountInt = maxSingleAmountOfBetsOfAnyRaceCourse;
            

            // Use MAX number THEN return query based on that max number  // (use multiple MINIMUM entries to verify
            var mostPopularRaceCourseList =
                from result in noOfBetsPerRaceCourse
                where result.totalBetsPerCourse == maxSingleAmountInt
                select result;


            // return string containing RaceCourse(s) with most bets placed
            string mostPopularRaceCourseString = string.Empty;
            foreach (var item in mostPopularRaceCourseList)
            {
                mostPopularRaceCourseString += string.Format("\nRacecourse: {0} - No of bets placed: {1}", 
                    item.raceCourse, item.totalBetsPerCourse);
            }   
            return (mostPopularRaceCourseString);
        }// end GetMostPopularRaceCourse







        //  5.  Provide a report that shows the bets in date order.
        public static List<HorseBet> DisplayAllBetsInDateOrder(List<HorseBet> ListOfHorseBets)
        {          

            // DisplayAllBetsInDateOrder            
            var AllBetsInDateOrderList =
                from HorseBet in ListOfHorseBets
                orderby HorseBet.RaceDate   // default oldest to newest  // descending =  newest to oldest          
                select (HorseBet);

            // Create temporary list to store result
            List<HorseBet> returnListAllBetsInDateOrder = new List<HorseBet>();

            // Add result items to temporary list
            foreach (var HorseBet in AllBetsInDateOrderList)
            {
                returnListAllBetsInDateOrder.Add(HorseBet);
                //Console.WriteLine(HorseBet);
            }

            // return the list
            return returnListAllBetsInDateOrder;
        }// end DisplayAllBetsInDateOrder





        // 6.   Provide another report that displays the highest amount won 
        //      for a bet laid and the most lost for a bet laid.

        public static string HighestAmountWonOrLostOnARace(List<HorseBet> ListOfHorseBets, bool wonRace)
        {
            string displayResultString = string.Empty;

            try
            {
                

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

            //// Display largest amount won or lost - testing only
            //Console.WriteLine("Highest Amount {0} on a race: {1}",
            //    wonRace ? "WON" : "LOST",    highestAmountWonOrLostOnARace.ToString());


            // Create string to return result
            displayResultString = string.Format("Highest Amount {0} on a race: {1}",
                wonRace ? "WON" : "LOST", highestAmountWonOrLostOnARace.ToString());


            // Add racecourse associated with largest amount to string
            foreach (var HorseBet in largestWinningOrLosingRace)
            {
                //Console.WriteLine("At RaceCourse: {0}", HorseBet);  // display for testing only
                displayResultString += string.Format("\nRaceCourse: {0}\nDate: {1}",
                    HorseBet.RaceCourse, HorseBet.RaceDate.ToShortDateString());
            }
        }// end try
             catch
            {
                displayResultString = "Unknown - No data available to query.";
            }

            return displayResultString;
        }// end HighestAmountWonOrLostOnARace




        //7.Provide a report to indicate how successful HotTipster is at horse betting.
        //  This should display the total number of races alongside the number of races 
        //  that HotTipster has won a bet on.

        public static string HotTipsterSuccessLevel(List<HorseBet> ListOfHorseBets)
        {
            // Total number of bets places
            int totalNoOfRaces = ListOfHorseBets.Count();
            Console.WriteLine("Total number of races: {0}", totalNoOfRaces);

            // Total number of winning bets
            var noOfWinningRaces =
                (
                from HorseBet in ListOfHorseBets
                where HorseBet.RaceWasWon == true
                select HorseBet
                ).Count();

            decimal winningRatio = (noOfWinningRaces * 100) / totalNoOfRaces;

            //// Display results - testing only
            //Console.WriteLine("Total number of winning bets: {0}", noOfWinningRaces);            
            //Console.WriteLine("Win / Lose Ratio: {0}%", winningRatio);

            // Add result to string & return
            string successLevel = string.Format("Total number of winning bets: {0}", noOfWinningRaces);
            successLevel += string.Format("\nWin / Lose Ratio: {0}%", winningRatio);

            return successLevel;
        }// end HotTipsterSuccessLevel



    }// end class ReportingMethods
}// end Namespace
