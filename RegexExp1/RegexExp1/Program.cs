using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexExp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GITHUB Test");

            //string expression = "[A-Za-z0-9]";
            string expression = "z?";

            string inputString = "zzzzzz";

            Console.WriteLine("RegEx Pattern: {0}", expression);
            Console.WriteLine("Text to check: {0}\n", inputString);
            
            Regex regExEngine = new Regex(expression);
            Match regExMatch = regExEngine.Match(inputString);
            
            while (regExMatch.Success)
            {
                Console.WriteLine("Successful match: {0}", regExMatch.Success);
                Console.WriteLine("Index: {0}", regExMatch.Index);
                Console.WriteLine("Length: {0}\n\n", regExMatch.Length);

                regExMatch =  regExMatch.NextMatch();
            }


            
            
            //Console.WriteLine("Result: {0}", regExMatch.Result);


        } // end main
    } // end class program
} // end Namespace
