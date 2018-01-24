from calculator import Calculator

# code from lecture
#my_calc = Calculator()
#value = ''
#while value != 'E':
#   value = raw_input('Press Number or E to Finish: ')
#   my_calc.input(value)
#   print my_calc.getOutput()
#   
   
    
myCal = Calculator()  



#  Main calculator program loop
userSelection = ""

while (userSelection != "E" and userSelection != "e"):               #& userSelection != "e"
    myCal.screenDisplay()
    userSelection = raw_input("Please make a selection: ")
    #print("\n\n")
    userSelection =  userSelection.upper()
    #print("You entered: %s" %userSelection)
    #1userInput = raw_input("Waiting....")    
    
    
    # Addition - Selection 1
    if (userSelection == "1"):
        print ("\n\n-------------------------")
        print ("Addition: (add 2 numbers)")
        print ("-------------------------")
        
        print ("Please enter 1st number: ")
        firstNum = myCal.getUserNumber()
        print ("Please enter 2nd number: ");
        secondNum = myCal.getUserNumber()
                        
        result = myCal.add(firstNum, secondNum);
        print("----------------------------------")
        print("\n%s added to %s equals: %s" %(firstNum, secondNum, result))
        userInput = raw_input("\nWaiting....any key to continue.")


    # Subtraction - Selection 2    
    elif (userSelection == "2"):
        print ("\n\n---------------------------------------------------")
        print ("Subtraction: Subtract 2nd number from 1st number:")        
        print ("---------------------------------------------------")
        print ("\nPlease enter 1st number: ")
        firstNum = myCal.getUserNumber()
        print ("\nPlease enter 2nd number: ");
        secondNum = myCal.getUserNumber()
                        
        result = myCal.subtract(firstNum, secondNum);
        print("-------------------------------------------------")
        print("\n%s minus %s equals: %s" %(firstNum, secondNum, result))        
        userInput = raw_input("\nWaiting....any key to continue.")


    # Multiplication - Selection 3
    elif (userSelection == "3"):
        print ("\n\n----------------------------------------------------")
        print ("Multiplication: 1st number multiplied by 2nd number:")
        print ("----------------------------------------------------")
        print ("\nPlease enter 1st number: ")
        firstNum = myCal.getUserNumber()
        print ("\nPlease enter 2nd number: ");
        secondNum = myCal.getUserNumber()
                        
        result = myCal.multiply(firstNum, secondNum);
        print("------------------------------------------------------------")
        print("\n%s multiplied by %s equals: %s" %(firstNum, secondNum, result))
        userInput = raw_input("\nWaiting....any key to continue.")
        
         
    # Division - Selection 4
    elif (userSelection == "4"):
        print ("\n\n----------------------------------------------------")
        print ("Division: 1st number divided by 2nd number:")
        print ("----------------------------------------------------")
        print ("\nPlease enter 1st number: ")
        firstNum = myCal.getUserNumber()
        print ("\nPlease enter 2nd number: ");
        secondNum = myCal.getUserNumber()                        
        result = myCal.divide(firstNum, secondNum);
        print("------------------------------------------------------------")
        print("\n%s divided by %s equals: %s" %(firstNum, secondNum, result))
        userInput = raw_input("\nWaiting....any key to continue.")
                
    
    # Percentage Change - Selection 5    
    elif (userSelection == "5"):
        print ("\n\n-------------------------------------------------------------------------------")
        print ("Percentages: 1st number is increased / decreased by percentage of 2nd number:")
        print ("-------------------------------------------------------------------------------")
        print ("\nPlease enter 1st number: ")
        firstNum = myCal.getUserNumber()
        print ("\nPlease enter 2nd number: ");
        secondNum = myCal.getUserNumber()                        
        result = myCal.percentage(firstNum, secondNum);
        print("------------------------------------------------------------")
        print("\n%s increased / decreased by %s percent equals: %s" %(firstNum, secondNum, result))       
        userInput = raw_input("\nWaiting....any key to continue.")
        
     
    # Square Root - Selection 6
    elif (userSelection == "6"):
        print ("\n\n---------------------------------------------------")
        print ("Square Root: Calculate the square root of a number:")
        print ("---------------------------------------------------")
        print ("\nPlease enter a number: ")
        firstNum = myCal.getUserNumber()
        
        if firstNum < 0:
            print("Invalid - square root of a negativr number produces Nan")            
        else:
            result = myCal.square_root(firstNum);
            print("------------------------------------------------------------")
            print("\nSquare root of %s equals: %s" %(firstNum, result))       
        userInput = raw_input("\nWaiting....any key to continue.")
       
      
    # Square a number - Selection 7
    elif (userSelection == "7"):
        print ("\n\n-----------------------------------------")
        print ("Square: Calculate the square of a number:")
        print ("-----------------------------------------")
        print ("\nPlease enter a number: ")
        firstNum = myCal.getUserNumber()
        result = myCal.square(firstNum);
        print("------------------------------------------------------------")
        print("\nSquare of %s equals: %s" %(firstNum, result))        
        userInput = raw_input("\nWaiting....any key to continue.")
        

    elif (userSelection == "8"):
        print ("\n\n---------------------------------------------------------------")
        print ("Exponentiate: raise 1st number to the power of the 2nd number.")
        print ("---------------------------------------------------------------")
        print ("\nPlease enter 1st number: ")
        firstNum = myCal.getUserNumber()
        print ("\nPlease enter 2nd number: ");
        secondNum = myCal.getUserNumber()                        
        result = myCal.exponentiate(firstNum, secondNum);
        print("------------------------------------------------------------")
        print("\n%s to the power of %s equals: %s" %(firstNum, secondNum, result))
        userInput = raw_input("\nWaiting....any key to continue.")


    elif (userSelection == "9"):
        print ("\n\n-------------------------------------")
        print ("Cube: Calculate the cube of a number:")
        print ("-------------------------------------")
        print ("\nPlease enter a number: ")
        firstNum = myCal.getUserNumber()
        result = myCal.cube(firstNum);
        print("------------------------------------------------------------")
        print("\nCube of %s equals: %s" %(firstNum, result))    
        userInput = raw_input("\nWaiting....any key to continue.")


    elif (userSelection == "10"):
        print ("\n\n-------------------------------------")
        print ("Log10: Calculate the log of a number:")
        print ("-------------------------------------")
        print ("\nPlease enter a number: ")
        firstNum = myCal.getUserNumber()
        if (firstNum < 0):
            print ("You entered a negative numbers - only positive numbers are allowed for this selection.")
        else:
            result = myCal.log10(firstNum)
            print("------------------------------------------------------------")
            print("\nBase 10 Log of %s equals: %s" %(firstNum, result))
        userInput = raw_input("\nWaiting....any key to continue.")
        
        
    elif (userSelection == "E"):
        print ("You selected EXIT")
        #userInput = raw_input("Waiting....press a key to continue.")

    else:
        print("\nInvalid selection.\n")
        userInput = raw_input("Please select option 1 - 10 above .....any key to continue.")



