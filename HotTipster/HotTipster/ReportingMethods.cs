using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTipster
{
    public static class ReportingMethods
    {

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


        public static string GetMostPopularRaceCourse()
        {
            return string.Format("My Ultimate Race Course");

        }// end GetMostPopularRaceCourse





    }// end class ReportingMethods
}// end Namespace
