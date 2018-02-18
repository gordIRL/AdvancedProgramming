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
        

        static void Main(string[] args)
        {
            bool runProgram = true;            

            while (runProgram)
            {
                Utility.ScreenDisplay();
                string userSelection = Console.ReadLine();
                runProgram = SwitchLoop.MainLoop(userSelection);                
            }           
        }
    }
}




//  Issue with   Option 6)  Save NewAdditionsToHorseBetList to BinaryFile

    // Issue with Annual Reports - only works for 2016 & 2017 - hard-coded!!
