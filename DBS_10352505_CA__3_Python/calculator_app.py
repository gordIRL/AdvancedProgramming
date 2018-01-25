##
##          Developed using Python 2.7 - I have made extensive use of 
##          'raw_input' which I believe now isn't part of Python3.x
##
##

from calculator import Calculator

# Instantiate calculator class
calculatorInstance = Calculator()  


#  Main calculator program loop
userSelection = ""

while (userSelection != "E" and userSelection != "e"):
    calculatorInstance.screenDisplay()
    userSelection = raw_input("Please make a selection: ")
    userSelection =  userSelection.upper()   

    
    # Call user selected function 
    if (userSelection == "1"):
        calculatorInstance.User_Addition()
        
    elif (userSelection == "2"):
        calculatorInstance.User_Subtraction()
        
    elif (userSelection == "3"):
        calculatorInstance.User_Multiplication()
        
    elif (userSelection == "4"):
        calculatorInstance.User_Division()
        
    elif (userSelection == "5"):
        calculatorInstance.User_Percentage_Change()
        
    elif (userSelection == "6"):
        calculatorInstance.User_Square_Root()
        
    elif (userSelection == "7"):
        calculatorInstance.User_Square()
        
    elif (userSelection == "8"):
        calculatorInstance.User_Exponentiate()
        
    elif (userSelection == "9"):        
        calculatorInstance.User_Cube()
        
    elif (userSelection == "10"):     
        calculatorInstance.User_Log()
                
    elif (userSelection == "E"):
        print ("You selected EXIT")
        
    else:
        print("\nInvalid selection.\n")
        userInput = raw_input("Please select option 1 - 10 above .....Press Enter to continue.")
        
        
        