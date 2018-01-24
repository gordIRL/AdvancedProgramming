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

        
        
        
    

    def input(self, value):
        if value == '#':
            self.__input = '0'
        elif value == '+':
            self.__operation = value
        elif self.__operation != '':
            self.__input = str(self.add(int(self.__input), int(value)))
        else:
            self.__input += str(value)
        #print self.__input

    def getOutput(self):
        if self.__input == '0E':
            return 0
        return int(self.__input)

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
    
    
 