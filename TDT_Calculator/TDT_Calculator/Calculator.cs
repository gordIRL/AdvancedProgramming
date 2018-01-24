using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDT_Calculator
{
    public class Calculator
    {

        bool IsTesting = false;
        Object[] Values;
        int CurrentIndex = 0;

        public int GetCurrentIndex()
        {
            return CurrentIndex;
        }

        public void SetTestValues(Object[] values)
        {
            IsTesting = true;
            Values = values;
        }

        // 1) AddNums Method - add 2 numbers and returns the result
        public double AddNums(double first, double second)
        {
            return first + second;
        } // end AddNums method


        // 2) SubTractNumbers Method - subtracts 2nd number from 1st number
        public double SubtractNumbers(double first, double second)
        {
            return first - second;
        } // end SubtractNumbers method


        // 3) Multiply_Numbers Method - subtracts 2nd number from 1st number
        public double MultiplyNumbers(double first, double second)
        {
            return first * second;
        } // end MultiplyNumbers method



        // 4) Divide_Numbers Method - subtracts 2nd number from 1st number
        public double DivideNumbers(double first, double second)
        {
            return first / second;
        } // end DivideNumbers method




        // 5) Percentages Button
        public double Percentage_Change(double first, double percent_change)
        {
            return first + ((first / 100) * percent_change);
        }


        // 6) Square Root
        public double Square_Root(double first)
        {
            return Math.Sqrt(first);
        }


        // 7) Square a number
        public double Square(double first)
        {
            return first * first;
        }


        // 8) Exponentiate
        public double Exponentiate(double baseNum, double exponentNum)
        {
            return Math.Pow(baseNum, exponentNum);
        }

        // 9) Cube
        public double Cube(double first)
        {
            return Math.Pow(first, 3);
        }


        // 10) Log10
        public double Log10(double first)
        {
            return Math.Log10(first);
        }






        // method to get a valid number from the user.
        public double GetUserNumber(string userInput)
        {
            bool isANumber = false;            
            double userNumber = 0;

            while (!isANumber)
            {
                isANumber = double.TryParse(userInput, out userNumber);
                if (!isANumber)
                {
                    userInput = GetNextValue();
                }
            }
            return userNumber;
        }

        public string GetNextValue()
        {
            if (!IsTesting)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number: ");
                return Console.ReadLine();
            }
            return Values[CurrentIndex++].ToString();
        }

        public void ScreenDisplay()
        {
            Console.Clear();
            Console.WriteLine("******************************************");
            Console.WriteLine("***************Calculator*****************");
            Console.WriteLine("******************************************\n\n");

            Console.WriteLine("1)  Addition");
            Console.WriteLine("2)  Subtraction");
            Console.WriteLine("3)  Multiplication");
            Console.WriteLine("4)  Division");
            Console.WriteLine("5)  Percentage");
            Console.WriteLine("6)  Square Root");
            Console.WriteLine("7)  Square");
            Console.WriteLine("8)  Exponentiate");
            Console.WriteLine("9)  Cube");
            Console.WriteLine("10) Log10\n");
            Console.WriteLine("E to exit.\n\n");
        }








    } //end class MyCalculator
} // end Namespace
