using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTipster
{
    [Serializable]   // Enables objects of this class to be utilised by BinaryFornatter
    public class HorseBet
    {
        public string RaceCourse { get; set; }
        public DateTime RaceDate { get; set; }
        public decimal BalanceChange { get; set; }
        public bool RaceWasWon { get; set; }


        public HorseBet()
        {
            // empty constructor
        }   



        public HorseBet(string raceCourse, DateTime raceDate, decimal balanceChange, bool raceWasWon)
        {
            RaceCourse = raceCourse;
            RaceDate = raceDate;
            BalanceChange = balanceChange;
            RaceWasWon = raceWasWon;
        }


        public override string ToString()
        {
            return string.Format("{0}  {1}  {2}  {3}",
                RaceCourse, RaceDate.ToShortDateString(), BalanceChange, RaceWasWon); 
        }


    }// end class HorseBet
}// end Namespace
