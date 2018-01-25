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
            Calculator calculatorInstance = new Calculator();
                        

            // Main calculator program loop
            string userSelection = string.Empty;


            while (userSelection != "E" && userSelection != "e")
            {
                calculatorInstance.ScreenDisplay();
                Console.Write("Please make a selection: ");
                userSelection = Console.ReadLine();                
                userSelection = userSelection.ToUpper();
                Console.WriteLine("\n\n");
                

                switch (userSelection)
                {
                    case "1":
                        calculatorInstance.User_Addition();
                        calculatorInstance.PauseScreenForUser();
                        break;
                        
                    case "2":
                        calculatorInstance.User_Subtraction();
                        calculatorInstance.PauseScreenForUser();
                        break;                   
                        
                    case "3":
                        calculatorInstance.User_Multiplication();
                        calculatorInstance.PauseScreenForUser();                   
                        break;
                        
                    case "4":
                        calculatorInstance.User_Division();
                        calculatorInstance.PauseScreenForUser();
                        break;
                                                
                    case "5":
                        calculatorInstance.User_Percentage_Change();
                        calculatorInstance.PauseScreenForUser();
                        break;
                        
                    case "6":
                        calculatorInstance.User_Square_Root();
                        calculatorInstance.PauseScreenForUser();
                        break;
                        
                    case "7":
                        calculatorInstance.User_Square();
                        calculatorInstance.PauseScreenForUser();
                        break;
                                                
                    case "8":
                        calculatorInstance.User_Exponentiate();
                        calculatorInstance.PauseScreenForUser();
                        break;
                                                
                    case "9":
                        calculatorInstance.User_Cube();
                        calculatorInstance.PauseScreenForUser();
                        break;
                        
                    case "10":
                        calculatorInstance.User_Log();
                        calculatorInstance.PauseScreenForUser();
                        break;
                        
                    case "E":
                        Console.WriteLine("Exit.");                        
                        break;
                        
                    default:
                        Console.Write("Invalid Selection - Press a key to re-enter selection: ");
                        Console.ReadKey();
                        break;

                } // end switch block
            } // end outer user selection loop           

        } // end Main
    } // end class Program
} // end Namespace 
