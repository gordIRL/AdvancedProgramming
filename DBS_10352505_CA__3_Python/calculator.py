import math


class Calculator:

    def __init__(self):
        self.__input = '0'
        self.__operation = ''

    def add(self, first, second):
        return first + second

    def multiply(self, first, second):
        return first * second

    def subtract(self, first, second):
        return first - second
    
    def divide(self, first, second):
        return first / second
        
    def percentage(self, first, percent_change):
        return first + ( (first /100) * percent_change )

    def square_root(self, first):
        if first < 0:
            return 0
        else:
            return  math.sqrt(first) 

    def square(self, first):
        return first * first
    
    def exponentiate(self, baseNum, exponentNum):
        return math.pow(baseNum, exponentNum)
    
    def cube(self, baseNum):
        return math.pow(baseNum, 3)
    
    def log10(self, first):
        if first < 0:
            return 0
        else:
            return math.log10(first)
        #math.log10(x) - Return the base-10 logarithm of x. 
        #This is usually more accurate than log(x, 10).



# --------------------------------------------------------------------------
    
    def screenDisplay(self):
        print '\n' * 50	
        print "\n\n\n\n\n"
        print ("******************************************")
        print ("************** Calculator ****************")
        print ("******************************************\n\n")
    
        print ("1)  Addition")
        print ("2)  Subtraction")
        print ("3)  Multiplication")
        print ("4)  Division")
        print ("5)  Percentage")
        print ("6)  Square Root")
        print ("7)  Square")
        print ("8)  Exponentiate")
        print ("9)  Cube")
        print ("10) Log10\n")
        print ("E to exit.\n")


 
    # function to confirm user has entered a valid number
    def getUserNumber(self):
        isANumber = False
        
        while (isANumber == False):
            userInput = raw_input()                
            try:
                number = float(userInput)
                print ("You entered %s"  %number)
                return number
                isANumber = True
            except:
                print("%s is not a valid number - please enter again: " %userInput)    
                
                
                
            
    # Addition - Selection 1
    def User_Addition(self):
        # Get user input
        print ("\n\n-------------------------")
        print ("Addition: (add 2 numbers)")
        print ("-------------------------")    
    
        print ("Please enter 1st number: ")
        firstNum = self.getUserNumber()
        print ("\nPlease enter 2nd number: ");
        secondNum = self.getUserNumber()
        
        #call the add function to add 2 numbers together                
        result = self.add(firstNum, secondNum);
        
        # Output result of AddNums calculation
        print("----------------------------------")
        print("\n%s added to %s equals: %s" %(firstNum, secondNum, result))
        userInput = raw_input("\nWaiting....Press Enter to continue.")
     
        
        
    # Subtraction - Selection 2       
    def User_Subtraction(self):        
        # Get user input
        print ("\n\n---------------------------------------------------")
        print ("Subtraction: Subtract 2nd number from 1st number:")        
        print ("---------------------------------------------------")
        print ("\nPlease enter 1st number: ")
        firstNum = self.getUserNumber()
        print ("\nPlease enter 2nd number: ");
        secondNum = self.getUserNumber()
         
        # call the SubtractNumbers function to subtract 1 number from another               
        result = self.subtract(firstNum, secondNum);
        
        # Output result of SubtractNumbers calculation
        print("-------------------------------------------------")
        print("\n%s minus %s equals: %s" %(firstNum, secondNum, result))        
        userInput = raw_input("\nWaiting....Press Enter to continue.")
    
    
    
    # Multiplication - Selection 3   
    def User_Multiplication(self):
        # Get user input    
        print ("\n\n----------------------------------------------------")
        print ("Multiplication: 1st number multiplied by 2nd number:")
        print ("----------------------------------------------------")
        print ("\nPlease enter 1st number: ")
        firstNum = self.getUserNumber()
        print ("\nPlease enter 2nd number: ");
        secondNum = self.getUserNumber()
                  
        # call the multiply function to multiply 1 number by another
        result = self.multiply(firstNum, secondNum);
        
        # Output result of multiply calculation
        print("------------------------------------------------------------")
        print("\n%s multiplied by %s equals: %s" %(firstNum, secondNum, result))
        userInput = raw_input("\nWaiting....Press Enter to continue.")
        
        
        
    # Division - Selection 4
    def User_Division(self):
        # Get user input
        print ("\n\n----------------------------------------------------")
        print ("Division: 1st number divided by 2nd number:")
        print ("----------------------------------------------------")
        print ("\nPlease enter 1st number: ")
        firstNum = self.getUserNumber()
        print ("\nPlease enter 2nd number: ");
        secondNum = self.getUserNumber()                        
            
        #avoid divide by zero error
        if (secondNum == 0):
            print("\nYou cannot divide by zero - calculation cancelled");
        else:
            # call divide method to divide 1st number by 2nd number
            result = self.divide(firstNum, secondNum);
            
            # Output result of divide calculation
            print("------------------------------------------------------------")
            print("\n%s divided by %s equals: %s" %(firstNum, secondNum, result))
            userInput = raw_input("\nWaiting....Press Enter to continue.")
        
        
            
    # Percentage Change - Selection 5          
    def User_Percentage_Change(self):
         # Get user input
         print ("\n\n-------------------------------------------------------------------------------")
         print ("Percentages: 1st number is increased / decreased by percentage of 2nd number:")
         print ("-------------------------------------------------------------------------------")
         print ("\nPlease enter 1st number: ")
         firstNum = self.getUserNumber()
         print ("\nPlease enter 2nd number: ");
         secondNum = self.getUserNumber()                        
         
         # call percentage method to increase 1st number by 2nd-number-percentage
         result = self.percentage(firstNum, secondNum);
         
         # Output result of percentage calculation
         print("------------------------------------------------------------")
         print("\n%s increased / decreased by %s percent equals: %s" %(firstNum, secondNum, result))       
         userInput = raw_input("\nWaiting....Press Enter to continue.")
        
        
        
    ## Square Root - Selection 6
    def User_Square_Root(self):
        # Get user input   
        print ("\n\n---------------------------------------------------")
        print ("Square Root: Calculate the square root of a number:")
        print ("---------------------------------------------------")
        print ("\nPlease enter a number: ")
        firstNum = self.getUserNumber()
        
        # #avoid getting square_root of a negative number error
        if firstNum < 0:
            print("Invalid - square root of a negativr number produces Nan")            
        else:
            # call square_Root method to return square root of number
            result = self.square_root(firstNum);
            
            # Output result of square_Root calculation
            print("------------------------------------------------------------")
            print("\nSquare root of %s equals: %s" %(firstNum, result))       
        userInput = raw_input("\nWaiting....Press Enter to continue.")
    

    
    # Square a number - Selection 7    
    def  User_Square(self):
        # Get user input         
        print ("\n\n-----------------------------------------")
        print ("Square: Calculate the square of a number:")
        print ("-----------------------------------------")
        print ("\nPlease enter a number: ")
        firstNum = self.getUserNumber()
        
        # call square method to return square of number
        result = self.square(firstNum);
        
        #  Output result of square calculation
        print("------------------------------------------------------------")
        print("\nSquare of %s equals: %s" %(firstNum, result))        
        userInput = raw_input("\nWaiting....Press Enter to continue.")
        
        
    # Exponentiate - Selection 8
    def User_Exponentiate(self):        
        # Get user input 
        print ("\n\n---------------------------------------------------------------")
        print ("Exponentiate: raise 1st number to the power of the 2nd number.")
        print ("---------------------------------------------------------------")
        print ("\nPlease enter 1st number: ")
        firstNum = self.getUserNumber()
        print ("\nPlease enter 2nd number: ");
        secondNum = self.getUserNumber()                        
        
        # call xxponentiate method to return 1st number by exponentiate of 2nd number
        result = self.exponentiate(firstNum, secondNum);
        
        # Output result of exponentiate calculation
        print("------------------------------------------------------------")
        print("\n%s to the power of %s equals: %s" %(firstNum, secondNum, result))
        userInput = raw_input("\nWaiting....Press Enter to continue.")
        
        
    
    # Cube - Selection 9
    def User_Cube(self):
        # Get user input    
        print ("\n\n-------------------------------------")
        print ("Cube: Calculate the cube of a number:")
        print ("-------------------------------------")
        print ("\nPlease enter a number: ")
        firstNum = self.getUserNumber()
        
        # call cube method to return cube of a number
        result = self.cube(firstNum);
        
        # // Output result of cube calculation
        print("------------------------------------------------------------")
        print("\nCube of %s equals: %s" %(firstNum, result))    
        userInput = raw_input("\nWaiting....Press Enter to continue.")
        
        
    # Log - Selection 10
    def User_Log(self):
        # Get user input 
        print ("\n\n-------------------------------------")
        print ("Log10: Calculate the log of a number:")
        print ("-------------------------------------")
        print ("\nPlease enter a number: ")
        firstNum = self.getUserNumber()
        
        
        if (firstNum < 0):
            print ("You entered a negative numbers - only positive numbers are allowed for this selection.")
        else:
            result = self.log10(firstNum)
            print("------------------------------------------------------------")
            print("\nBase 10 Log of %s equals: %s" %(firstNum, result))
        userInput = raw_input("\nWaiting....Press Enter to continue.")
        
        
        