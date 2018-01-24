using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDT_Calculator
{

    class CalculatorApp
    {
        static void Main(string[] args)
        {
                        
            // Instantiate calculator object
            Calculator mc = new Calculator();
            double firstNum = 0;
            double secondNum = 0;
            double result = 0;
            

            // Main calculator program loop
            string userSelection = string.Empty;

            while (userSelection != "E" && userSelection != "e")
            {
                mc.ScreenDisplay();
                Console.Write("Please make a selection: ");
                userSelection = Console.ReadLine();
                Console.WriteLine("\n\n");
                userSelection = userSelection.ToUpper();
                //Console.WriteLine("You selected: {0}", userSelection);


                switch (userSelection)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Addition: (add 2 numbers)\n\n");


                        Console.Write("\nPlease enter 1st number: ");
                        string userInput = Console.ReadLine();
                        firstNum = mc.GetUserNumber(userInput);


                        Console.Write("\nPlease enter 2nd number: ");
                        userInput = Console.ReadLine();
                        secondNum = mc.GetUserNumber(userInput);

                        result = mc.AddNums(firstNum, secondNum);

                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("\n{0} added to {1} equals: {2}", firstNum, secondNum, result);
                        

                        Console.Write("\n\nPress a key to continue: ");
                        Console.ReadKey();
                        break;



                    //case "2":
                    //    Console.Clear();
                    //    Console.WriteLine("Subtraction: Subtract 2nd number from 1st number:\n\n");
                        
                    //    Console.Write("\nPlease enter 1st number: ");
                    //    firstNum = mc.getUserNumber();  

                    //    Console.Write("\nPlease enter 2nd number: ");
                    //    secondNum = mc.getUserNumber();

                    //    result = mc.SubtractNumbers(firstNum, secondNum);

                    //    Console.WriteLine("------------------------------------------------------------");
                    //    Console.WriteLine("\n{0} minus {1} equals: {2}", firstNum, secondNum, result);


                    //    Console.Write("\n\nPress a key to continue: ");
                    //    Console.ReadKey();
                    //    break;


                    //case "3":                        
                    //    Console.Clear();
                    //    Console.WriteLine("Multiplication: 1st number multiplied by 2nd number:\n\n");

                    //    Console.Write("\nPlease enter 1st number: ");
                    //    firstNum = mc.getUserNumber();

                    //    Console.Write("\nPlease enter 2nd number: ");
                    //    secondNum = mc.getUserNumber();

                    //    result = mc.MultiplyNumbers(firstNum, secondNum);

                    //    Console.WriteLine("------------------------------------------------------------");
                    //    Console.WriteLine("\n{0} times {1} equals: {2}", firstNum, secondNum, result);


                    //    Console.Write("\n\nPress a key to continue: ");
                    //    Console.ReadKey();
                    //    break;




                    //case "4":
                    //    Console.Clear();
                    //    Console.WriteLine("Division: 1st number divided by 2nd number:\n\n");

                    //    Console.Write("\nPlease enter 1st number: ");
                    //    firstNum = mc.getUserNumber();

                    //    Console.Write("\nPlease enter 2nd number: ");
                    //    secondNum = mc.getUserNumber();

                    //    // avoid dived by zero error
                    //    if (secondNum == 0)
                    //    {
                    //        Console.WriteLine("\nYou cannot divide by zero - calculation cancelled");
                    //    }
                    //    else
                    //    {
                    //        result = mc.DivideNumbers(firstNum, secondNum);
                    //        Console.WriteLine("------------------------------------------------------------");
                    //        Console.WriteLine("\n{0} divided by {1} equals: {2}", firstNum, secondNum, result);
                    //    }            


                    //    Console.Write("\n\nPress a key to continue: ");
                    //    Console.ReadKey();
                    //    break;



                    //case "5":
                    //    Console.Clear();
                    //    Console.WriteLine("Percentages: 1st number is increased / decreased by percentage of 2nd number:\n\n");

                    //    Console.Write("\nPlease enter 1st number: ");
                    //    firstNum = mc.getUserNumber();

                    //    Console.Write("\nPlease enter 2nd number: ");
                    //    secondNum = mc.getUserNumber();

                    //    result = mc.Percentage_Change(firstNum, secondNum);

                    //    Console.WriteLine("------------------------------------------------------------");
                    //    Console.WriteLine("\n{0} increased / decreased by {1}% equals: {2}", firstNum, secondNum, result);


                    //    Console.Write("\n\nPress a key to continue: ");
                    //    Console.ReadKey();
                    //    break;





                    //case "6":                        
                    //    Console.Clear();
                    //    Console.WriteLine("Square Root: Calculate the square root of a number:\n\n");

                    //    Console.Write("\nPlease enter a number: ");
                    //    firstNum = mc.getUserNumber();                      

                    //    result =mc.Square_Root(firstNum);

                    //    Console.WriteLine("------------------------------------------------------------");
                    //    Console.WriteLine("\nSquare root of {0} equals: {1}", firstNum, result);


                    //    Console.Write("\n\nPress a key to continue: ");
                    //    Console.ReadKey();
                    //    break;






                    //case "7":
                    //    Console.Clear();
                    //    Console.WriteLine("Square: Calculate the square of a number:\n\n");

                    //    Console.Write("\nPlease enter a number: ");
                    //    firstNum = mc.getUserNumber();

                    //    result = mc.Square(firstNum);

                    //    Console.WriteLine("------------------------------------------------------------");
                    //    Console.WriteLine("\nSquare of {0} equals: {1}", firstNum, result);


                    //    Console.Write("\n\nPress a key to continue: ");
                    //    Console.ReadKey();
                    //    break;
                        
                        
                        
                    //case "8":
                    //    Console.Clear();
                    //    Console.WriteLine("Exponentiate: raise 1st number to the power of the 2nd number.\n\n");

                    //    Console.Write("\nPlease enter 1st number: ");
                    //    firstNum = mc.getUserNumber();

                    //    Console.Write("\nPlease enter 2nd number: ");
                    //    secondNum = mc.getUserNumber();

                    //    result = mc.Exponentiate(firstNum, secondNum);

                    //    Console.WriteLine("------------------------------------------------------------");
                    //    Console.WriteLine("\n{0} to the power of {1} equals: {2}", firstNum, secondNum, result);


                    //    Console.Write("\n\nPress a key to continue: ");
                    //    Console.ReadKey();
                    //    break;





                    //case "9":
                    //    Console.Clear();
                    //    Console.WriteLine("Cube: Calculate the cube of a number:\n\n");

                    //    Console.Write("\nPlease enter a number: ");
                    //    firstNum = mc.getUserNumber();

                    //    result = mc.Cube(firstNum);

                    //    Console.WriteLine("------------------------------------------------------------");
                    //    Console.WriteLine("\nCube of {0} equals: {1}", firstNum, result);
                        
                    //    Console.Write("\n\nPress a key to continue: ");
                    //    Console.ReadKey();
                    //    break;




                    //case "10":
                    //    Console.Clear();
                    //    Console.WriteLine("Log10: Calculate the log of a number:\n\n");

                    //    Console.Write("\nPlease enter a number: ");
                    //    firstNum = mc.getUserNumber();

                    //    result = mc.Log10(firstNum);

                    //    Console.WriteLine("------------------------------------------------------------");
                    //    Console.WriteLine("\nBase 10 Log of {0} equals: {1}", firstNum, result);

                    //    Console.Write("\n\nPress a key to continue: ");
                    //    Console.ReadKey();
                    //    break;






                    case "E":
                        Console.WriteLine("Exit.");
                        //Console.ReadLine();
                        break;

                    default:
                        Console.Write("Invalid Selection - Press a key to re-enter selection: ");
                        Console.ReadLine();
                        break;

                } // end switch block
            } // end outer user selection loop           

        } // end Main
    } // end class Program
} // end Namespace 
