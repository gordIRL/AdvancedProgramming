import unittest
#import math
from calculator import Calculator

class CalculatorTest(unittest.TestCase):
    def testAdd(self):
        calculator = Calculator()
        self.assertEqual(4, calculator.add(2, 2))
        self.assertEqual(5, calculator.add(2, 3))
        self.assertEqual(-1, calculator.add(2, -3))
        self.assertEqual(0, calculator.add(2, -2))
        self.assertEqual(2, calculator.add(2, 0))
        self.assertEqual(-5, calculator.add(-2, -3))


    def testSubtract(self):
        calculator = Calculator()
        self.assertEqual(0, calculator.subtract(2, 2))
        self.assertEqual(-1, calculator.subtract(2, 3))
        self.assertEqual(5, calculator.subtract(2, -3))
        self.assertEqual(4, calculator.subtract(2, -2))
        self.assertEqual(2, calculator.subtract(2, 0))
        self.assertEqual(1, calculator.subtract(-2, -3))


    def testMultiply(self):
        calculator = Calculator()
        self.assertEqual(4, calculator.multiply(2, 2))
        self.assertEqual(6, calculator.multiply(2, 3))
        self.assertEqual(-6, calculator.multiply(2, -3))
        self.assertEqual(-4, calculator.multiply(2, -2))
        self.assertEqual(0, calculator.multiply(2, 0))
        self.assertEqual(6, calculator.multiply(-2, -3))
        self.assertEqual(2, calculator.multiply(2, 1))
        self.assertEqual(3, calculator.multiply(2, 1.5))

        
    def testDivide(self):
        calculator = Calculator()
        self.assertEqual(1, calculator.divide(2,2))
        self.assertEqual(3.5, calculator.divide(7,2.0))
        self.assertEqual(-1, calculator.divide(2, -2))
        self.assertEqual(-3.5, calculator.divide(7, -2.0))        
        self.assertEqual(1.5, calculator.divide(-3, -2.0))
        self.assertEqual(2, calculator.divide(2,1))
        self.assertEqual(2.6666666666666666666666666667, calculator.divide(4,  1.5))  

        
    def testDivideByZero(self):
        calculator = Calculator()
        try:
            calculator.divide(2, 0.0)          
#        
        except ZeroDivisionError as detail:         # Exception:
            print ('Caught Gordon\'s Handling run-time ZeroDivisionError error:', detail)
            
   
    def testPercentage(self):
        calculator = Calculator()
        self.assertEqual(240, calculator.percentage(200,20))
        self.assertEqual(160, calculator.percentage(200,-20))
        
        
    def testSquare_root(self):
        calculator = Calculator()
        self.assertEqual(3, calculator.square_root(9))
        self.assertEqual(1, calculator.square_root(1))
        self.assertEqual(0, calculator.square_root(0))
        self.assertEqual(2.25, calculator.square_root(5.0625))                
        self.assertEqual(1.4142135623730951, calculator.square_root(2))
        self.assertEqual(0 , calculator.square_root(-1))


    def testSquare(self):
        calculator = Calculator()
        self.assertEqual(4 , calculator.square(2))
        self.assertEqual(1 , calculator.square(1))
        self.assertEqual(0 , calculator.square(0))
        self.assertEqual(4 , calculator.square(-2))
        self.assertEqual(6.25 , calculator.square(2.5))
        self.assertEqual(6.25 , calculator.square(-2.5))


    def testExponentiate(self):
        calculator = Calculator()
        self.assertEqual(4 , calculator.exponentiate(2,2))
        self.assertEqual(2 , calculator.exponentiate(2,1))
        self.assertEqual(1 , calculator.exponentiate(2,0))
        self.assertEqual(1 , calculator.exponentiate(-2,0))
        self.assertEqual(16 , calculator.exponentiate(2,4))
        self.assertEqual(0.0625 , calculator.exponentiate(2,-4))
        self.assertEqual(16 , calculator.exponentiate(-2,4))
        self.assertEqual(-8 , calculator.exponentiate(-2,3))
        self.assertEqual(0.25 , calculator.exponentiate(-2,-2))
        self.assertEqual(-0.125 , calculator.exponentiate(-2,-3))
#
#
    def testCube(self):
        calculator = Calculator()
        self.assertEqual(8 , calculator.cube(2))
        self.assertEqual(1 , calculator.cube(1))
        self.assertEqual(0 , calculator.cube(0))
        self.assertEqual(-8 , calculator.cube(-2))
        self.assertEqual(15.625 , calculator.cube(2.5))
        self.assertEqual(-15.625 , calculator.cube(-2.5))


    def testLog(self):
        calculator = Calculator()
        self.assertEqual(2 , calculator.log10(100))
        self.assertEqual(1.255272505103306, calculator.log10(18))        
        self.assertEqual(0, calculator.log10(-100))



unittest.main()
