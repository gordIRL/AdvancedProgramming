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
        public double AddNumbers(double first, double second)
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

        public void PauseScreenForUser()
        {
            Console.Write("\n\nPress a key to continue: ");
            Console.ReadKey();
        }



        public void User_Addition()
        {
            // Get user input
            Console.Clear();
            Console.WriteLine("Addition: (add 2 numbers)\n\n");
            
            Console.Write("\nPlease enter 1st number: ");
            string userInput = Console.ReadLine();
            double firstNum = GetUserNumber(userInput);

            Console.Write("\nPlease enter 2nd number: ");
            userInput = Console.ReadLine();
            double secondNum = GetUserNumber(userInput);

            // call the AddNums function to add 2 numbers together
            double result = AddNumbers(firstNum, secondNum);

            // Output result of AddNums calculation
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\n{0} added to {1} equals: {2}", firstNum, secondNum, result);  
        }



        public void User_Subtraction()
        {
            // Get user input
            Console.Clear();
            Console.WriteLine("Subtraction: Subtract 2nd number from 1st number:\n\n");

            Console.Write("\nPlease enter 1st number: ");
            string userInput = Console.ReadLine();
            double firstNum = GetUserNumber(userInput);

            Console.Write("\nPlease enter 2nd number: ");
            userInput = Console.ReadLine();
            double secondNum = GetUserNumber(userInput);

            // call the SubtractNumbers function to subtract 1 number from another
            double result = SubtractNumbers(firstNum, secondNum);

            // Output result of SubtractNumbers calculation
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\n{0} minus {1} equals: {2}", firstNum, secondNum, result);
        }



        public void User_Multiplication()
        {
            // Get user input
            Console.Clear();
            Console.WriteLine("Multiplication: 1st number multiplied by 2nd number:\n\n");

            Console.Write("\nPlease enter 1st number: ");
            string userInput = Console.ReadLine();
            double firstNum = GetUserNumber(userInput);

            Console.Write("\nPlease enter 2nd number: ");
            userInput = Console.ReadLine();
            double secondNum = GetUserNumber(userInput);

            // call the MultiplyNumbers function to multiply 1 number by another
            double result = MultiplyNumbers(firstNum, secondNum);

            // Output result of MultiplyNumbers calculation
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\n{0} times {1} equals: {2}", firstNum, secondNum, result);
        }


        public void User_Division()
        {
            // Get user input
            Console.Clear();
            Console.WriteLine("Division: 1st number divided by 2nd number:\n\n");

            Console.Write("\nPlease enter 1st number: ");
            string userInput = Console.ReadLine();
            double firstNum = GetUserNumber(userInput);

            Console.Write("\nPlease enter 2nd number: ");
            userInput = Console.ReadLine();
            double secondNum = GetUserNumber(userInput);

            // avoid dived by zero error
            if (secondNum == 0)
            {
                Console.WriteLine("\nYou cannot divide by zero - calculation cancelled");
            }
            else
            {
                // call DivideNumbers method to divide 1st number by 2nd umber
                double result = DivideNumbers(firstNum, secondNum);
                
                // Output result of DivideNumbers calculation
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("\n{0} divided by {1} equals: {2}", firstNum, secondNum, result);
            }
        }


        public void User_Percentage_Change()
        {
            // Get user input
            Console.Clear();
            Console.WriteLine("Percentages: 1st number is increased / decreased by percentage of 2nd number:\n\n");

            Console.Write("\nPlease enter 1st number: ");
            string userInput = Console.ReadLine();
            double firstNum = GetUserNumber(userInput);

            Console.Write("\nPlease enter 2nd number: ");
            userInput = Console.ReadLine();
            double secondNum = GetUserNumber(userInput);

            // call Percentage_Change method to increase 1st number by 2nd-number-percentage
            double result = Percentage_Change(firstNum, secondNum);

            // Output result of Percentage_Change calculation
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\n{0} increased / decreased by {1}% equals: {2}", firstNum, secondNum, result);
        }


        public void User_Square_Root()
        {
            // Get user input
            Console.Clear();
            Console.WriteLine("Square Root: Calculate the square root of a number:\n\n");

            Console.Write("\nPlease enter a number: ");
            string userInput = Console.ReadLine();
            double firstNum = GetUserNumber(userInput);

            // call Square_Root method to return square root of number
            double result = Square_Root(firstNum);

            // Output result of Square_Root calculation
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\nSquare root of {0} equals: {1}", firstNum, result);
        }



        public void User_Square()
        {
            // Get user input
            Console.Clear();
            Console.WriteLine("Square: Calculate the square of a number:\n\n");

            Console.Write("\nPlease enter a number: ");
            string userInput = Console.ReadLine();
            double firstNum = GetUserNumber(userInput);

            // call Square method to return square of number
            double result = Square(firstNum);

            // Output result of Square calculation
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\nSquare of {0} equals: {1}", firstNum, result);
        }

        public void User_Exponentiate()
        {
            // Get user input
            Console.Clear();
            Console.WriteLine("Exponentiate: raise 1st number to the power of the 2nd number.\n\n");

            Console.Write("\nPlease enter 1st number: ");
            string userInput = Console.ReadLine();
            double firstNum = GetUserNumber(userInput);

            Console.Write("\nPlease enter 2nd number: ");
            userInput = Console.ReadLine();
            double secondNum = GetUserNumber(userInput);

            // call Exponentiate method to return 1st number by exponentiate of 2nd number
            double result = Exponentiate(firstNum, secondNum);

            // Output result of Exponentiate calculation
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\n{0} to the power of {1} equals: {2}", firstNum, secondNum, result);
        }


        public void User_Cube()
        {
            // Get user input
            Console.Clear();
            Console.WriteLine("Cube: Calculate the cube of a number:\n\n");

            Console.Write("\nPlease enter a number: ");
            string userInput = Console.ReadLine();
            double firstNum = GetUserNumber(userInput);

            // call Cube method to return cube of a number
            double result = Cube(firstNum);

            // Output result of Cube calculation
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\nCube of {0} equals: {1}", firstNum, result);
        }



        public void User_Log()
        {
            // Get user input
            //    Console.Clear();
            Console.WriteLine("Log10: Calculate the log of a number:\n\n");

            Console.Write("\nPlease enter a number: ");
            string userInput = Console.ReadLine();
            double firstNum = GetUserNumber(userInput);

            // call Log10 method to return Log of number
            double result = Log10(firstNum);

            // Output result of Log calculation
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\nBase 10 Log of {0} equals: {1}", firstNum, result);
        }




    } //end class MyCalculator
} // end Namespace
