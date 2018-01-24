using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDT_Calculator;

namespace TDD_Calculator_UnitTests_1
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Test_Add_Numbers_1()
        {
            //arrange            
            Calculator myCalculator = new Calculator();
            // act           
            double result = myCalculator.AddNumbers(2, 2);
            //assert
            double expected = 4;
            Assert.AreEqual(expected, result);
        }   //endTest_Add_Numbers_1


        [TestMethod]
        public void Test_Add_Numbers_2()
        {
            //arrange            
            Calculator myCalculator = new Calculator();
            // act          
            double result = myCalculator.AddNumbers(2, 3);
            //assert
            double expected = 5;
            Assert.AreEqual(expected, result);
        }   //endTest_Add_Numbers_2



        [TestMethod]
        public void Test_Add_Numbers_3()
        {
            //arrange            
            Calculator myCalculator = new Calculator();
            // act           
            double result = myCalculator.AddNumbers(2, -3);
            //assert
            double expected = -1;
            Assert.AreEqual(expected, result);
        }   //endTest_Add_Numbers_3


        [TestMethod]
        public void Test_Add_Numbers_4()
        {
            //arrange            
            Calculator myCalculator = new Calculator();
            // act           
            double result = myCalculator.AddNumbers(2, -2);
            //assert
            double expected = 0;
            Assert.AreEqual(expected, result);
        }   //endTest_Add_Numbers_4


        [TestMethod]
        public void Test_Add_Numbers_5()
        {
            //arrange            
            Calculator myCalculator = new Calculator();
            // act           
            double result = myCalculator.AddNumbers(2, 0);
            //assert
            double expected = 2;
            Assert.AreEqual(expected, result);
        }   //endTest_Add_Numbers_5


        [TestMethod]
        public void Test_Add_Numbers_6()
        {
            //arrange            
            Calculator myCalculator = new Calculator();
            // act           
            double result = myCalculator.AddNumbers(-2, -3);
            //assert
            double expected = -5;
            Assert.AreEqual(expected, result);
            // end Test_Add_Numbers method
        }   //endTest_Add_Numbers_6

//--------------------------------------------------------------------------------------




        [TestMethod]
        public void Test_Subtract_Numbers_1()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.SubtractNumbers(2, 2);
            // assert
            double expected = 0;
            Assert.AreEqual(expected, result);
        }   //Test_Subtract_Numbers_1


        [TestMethod]
        public void Test_Subtract_Numbers_2()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.SubtractNumbers(2, 3);
            // assert
            double expected = -1;
            Assert.AreEqual(expected, result);
        }   // Test_Subtract_Numbers_2



        [TestMethod]
        public void Test_Subtract_Numbers_3()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.SubtractNumbers(2, -3);
            // assert
            double expected = 5;
            Assert.AreEqual(expected, result);
        }   // Test_Subtract_Numbers_3


        [TestMethod]
        public void Test_Subtract_Numbers_4()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.SubtractNumbers(2, -2);
            // assert
            double expected = 4;
            Assert.AreEqual(expected, result);
        }   // Test_Subtract_Numbers_4


        [TestMethod]
        public void Test_Subtract_Numbers_5()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.SubtractNumbers(2, 0);
            // assert
            double expected = 2;
            Assert.AreEqual(expected, result);
        }   // Test_Subtract_Numbers_5


        [TestMethod]
        public void Test_Subtract_Numbers_6()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.SubtractNumbers(-2, -3);
            // assert
            double expected = 1;
            Assert.AreEqual(expected, result);
        }   // Test_Subtract_Numbers_6

//  --------------------------------------------------------------------------------------------



        [TestMethod]
        public void Test_Multiply_Numbers_1_Pos_Same()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.MultiplyNumbers(2, 2);
            // assert
            double expected = 4;
            Assert.AreEqual(expected, result);
        } // end Test_Multiply_Numbers_1



        [TestMethod]
        public void Test_Multiply_Numbers_2_Pos_Different()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.MultiplyNumbers(2, 3);
            // assert
            double expected = 6;
            Assert.AreEqual(expected, result);
        } // end Test_Multiply_Numbers_2



        [TestMethod]
        public void Test_Multiply_Numbers_3_Pos_x_Neg_Different()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.MultiplyNumbers(2, -3);
            // assert
            double expected = -6;
            Assert.AreEqual(expected, result);
        } // end Test_Multiply_Numbers_3


        [TestMethod]
        public void Test_Multiply_Numbers_4_Pos_x_Neg_Same()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.MultiplyNumbers(2, -2);
            // assert
            double expected = -4;
            Assert.AreEqual(expected, result);
        } // end Test_Multiply_Numbers_4



        [TestMethod]
        public void Test_Multiply_Numbers_5_Pos_x_Zero()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.MultiplyNumbers(2, 0);
            // assert
            double expected = 0;
            Assert.AreEqual(expected, result);
        } // end Test_Multiply_Numbers_5


        [TestMethod]
        public void Test_Multiply_Numbers_6_Neg_x_Neg_Different()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.MultiplyNumbers(-2, -3);
            // assert
            double expected = 6;
            Assert.AreEqual(expected, result);
        } // end Test_Multiply_Numbers_6


        [TestMethod]
        public void Test_Multiply_Numbers_7_Pos_x_1()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.MultiplyNumbers(2, 1);
            // assert
            double expected = 2;
            Assert.AreEqual(expected, result);
        } // end Test_Multiply_Numbers_7


        [TestMethod]
        public void Test_Multiply_Numbers_8_Pos_x_Decimal()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.MultiplyNumbers(2, 1.5);
            // assert
            double expected = 3;
            Assert.AreEqual(expected, result);
        } // end Test_Multiply_Numbers_8

//  -----------------------------------------------------------------------------------------




        [TestMethod]
        public void Test_Divide_Numbers_1_Pos_Pos_same()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.DivideNumbers(2, 2);
            // assert
            double expected = 1;
            Assert.AreEqual(expected, result);
        } // end Test_Divide_Numbers_1


        [TestMethod]
        public void Test_Divide_Numbers_2_Pos_Pos_different()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.DivideNumbers(7, 2);
            // assert
            double expected = 3.5;
            Assert.AreEqual(expected, result);
        } // end Test_Divide_Numbers_2


        [TestMethod]
        public void Test_Divide_Numbers_3_Pos_Neg_same()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.DivideNumbers(2, -2);
            // assert
            double expected = -1;
            Assert.AreEqual(expected, result);
        } // end Test_Divide_Numbers_3


        [TestMethod]
        public void Test_Divide_Numbers_4_Pos_Neg_different()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.DivideNumbers(7, -2);
            // assert
            double expected = -3.5;
            Assert.AreEqual(expected, result);
        } // end Test_Divide_Numbers_4



        [TestMethod]        
        public void Test_Divide_Numbers_5_divide_by_Zero()
        {
            // arrange
            Calculator mc = new Calculator();
            double result = 0;
            // act
            result = mc.DivideNumbers(2, 0);
            //// assert            
            Assert.AreEqual(double.PositiveInfinity, result);                              
        } // end Test_Divide_Numbers_5



        [TestMethod]
        public void Test_Divide_Numbers_6_Neg_Neg_different()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.DivideNumbers(-3, -2);
            // assert
            double expected = 1.5;
            Assert.AreEqual(expected, result);
        } // end Test_Divide_Numbers_6


        [TestMethod]
        public void Test_Divide_Numbers_7_divide_by_1()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.DivideNumbers(2, 1);
            // assert
            double expected = 2;
            Assert.AreEqual(expected, result);
        } // end Test_Divide_Numbers_7


        [TestMethod]
        public void Test_Divide_Numbers_8_divide_by_decimal()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.DivideNumbers(4, 1.5);
            // assert
            double expected = 2.6666666666666666666666666667;
            Assert.AreEqual(expected, result);
        } // end Test_Divide_Numbers_8

//  ---------------------------------------------------------------------------------
        

        [TestMethod]
        public void Test_Percentage_Button_1_Increase_by_Percent()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Percentage_Change(200, 20);
            // assert
            double expected = 240;
            Assert.AreEqual(expected, result);
        } // end Test_Percentage_Button_1



        [TestMethod]
        public void Test_Percentage_Button_2_Decrease_by_Percent()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Percentage_Change(200, -20);
            // assert
            double expected = 160;
            Assert.AreEqual(expected, result);
        } // end Test_Percentage_Button_2



//  -------------------------------------------------------------------------------


        [TestMethod]
        public void Test_Square_Root_1_Round_Result()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Square_Root(9);
            // assert
            double expected = 3;
            Assert.AreEqual(expected, result);
        } // end Test_Square_Root_1



        [TestMethod]
        public void Test_Square_Root_2_SQR_of_1()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Square_Root(1);
            // assert
            double expected = 1;
            Assert.AreEqual(expected, result);
        } // end Test_Square_Root_2


        [TestMethod]
        public void Test_Square_Root_3_SQR_of_zero()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Square_Root(0);
            // assert
            double expected = 0;
            Assert.AreEqual(expected, result);
        } // end Test_Square_Root_3



        [TestMethod]
        public void Test_Square_Root_4_inc_decimal_place()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Square_Root(5.0625);
            // assert
            double expected = 2.25;
            Assert.AreEqual(expected, result);
        } // end Test_Square_Root_4



        [TestMethod]
        public void Test_Square_Root_5_Negative()
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Square_Root(-1);
            // assert            
            Assert.AreEqual(double.NaN, result);
        } // end Test_Square_Root_5



        [TestMethod]
        public void Test_Square_Root_6()   
        {
            // arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Square_Root(2);
            // assert
            double expected = 1.4142135623731;   // (13 decimal places)
            double delta    = 0.00000000000001;  // accepable difference between expected & result
            Assert.AreEqual(expected, result, delta);
        } // end Test_Square_Root_6



// ------------------------------------------------------------------------------------
        [TestMethod]
        public void Test_Square_1_Positive()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Square(2);
            // assert
            double expected = 4;
            Assert.AreEqual(expected, result);
        } // end Test_Square_1


        [TestMethod]
        public void Test_Square_2_One()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Square(1);
            // assert
            double expected = 1;
            Assert.AreEqual(expected, result);
        } // end Test_Square_2


        [TestMethod]
        public void Test_Square_3_Zero()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Square(0);
            // assert
            double expected = 0;
            Assert.AreEqual(expected, result);
        } // end Test_Square_3


        [TestMethod]
        public void Test_Square_4_Negative()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Square(-2);
            // assert
            double expected = 4;
            Assert.AreEqual(expected, result);
        } // end Test_Square_4



        [TestMethod]
        public void Test_Square_5_Decimal()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Square(2.5);
            // assert
            double expected = 6.25;
            Assert.AreEqual(expected, result);
        } // end Test_Square_5


        [TestMethod]
        public void Test_Square_6_Negative_Decimal()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Square(-2.5);
            // assert
            double expected = 6.25;
            Assert.AreEqual(expected, result);
        } // end Test_Square_6

//  ---------------------------------------------------------------------------

        [TestMethod]
        public void Test_Exponentiate_1_Pos_Pos_same()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Exponentiate(2,2);
            // assert
            double expected = 4;
            Assert.AreEqual(expected, result);
        } // end Test_Exponentiate_1



        [TestMethod]
        public void Test_Exponentiate_2_Pos_One()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Exponentiate(2, 1);
            // assert
            double expected = 2;
            Assert.AreEqual(expected, result);
        } // end Test_Exponentiate_2


        [TestMethod]
        public void Test_Exponentiate_3_Pos_Zero_()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Exponentiate(2, 0);
            // assert
            double expected = 1;
            Assert.AreEqual(expected, result);
        } // end Test_Exponentiate_3



        [TestMethod]
        public void Test_Exponentiate_4_Neg_Zero_()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Exponentiate(-2, 0);
            // assert
            double expected = 1;
            Assert.AreEqual(expected, result);
        } // end Test_Exponentiate_4


        [TestMethod]
        public void Test_Exponentiate_5_Pos_Pos_different_()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Exponentiate(2, 4);
            // assert
            double expected = 16;
            Assert.AreEqual(expected, result);
        } // end Test_Exponentiate_5



        [TestMethod]
        public void Test_Exponentiate_6_Pos_NegExpon()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Exponentiate(2, -4);
            // assert
            double expected = 0.0625;
            Assert.AreEqual(expected, result);
        } // end Test_Exponentiate_6



        [TestMethod]
        public void Test_Exponentiate_7_Neg_PosExpon_even()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Exponentiate(-2, 4);
            // assert
            double expected = 16;
            Assert.AreEqual(expected, result);
        } // end Test_Exponentiate_7


        [TestMethod]
        public void Test_Exponentiate_8_Neg_PosExpon_odd()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Exponentiate(-2, 3);
            // assert
            double expected = -8;
            Assert.AreEqual(expected, result);
        } // end Test_Exponentiate_8



        [TestMethod]
        public void Test_Exponentiate_9_Neg_NegExpon_even()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Exponentiate(-2, -2);
            // assert
            double expected = 0.25;
            Assert.AreEqual(expected, result);
        } // end Test_Exponentiate_9


        [TestMethod]
        public void Test_Exponentiate_10_Neg_NegExpon_odd()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Exponentiate(-2, -3);
            // assert
            double expected = -0.125;
            Assert.AreEqual(expected, result);
        } // end Test_Exponentiate_10

//  ------------------------------------------------------------------------------------

        [TestMethod]
        public void Test_Cube_1_Positive()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Cube(2);
            // assert
            double expected = 8;
            Assert.AreEqual(expected, result);
        } // end Test_Cube_1



        [TestMethod]
        public void Test_Cube_2_One()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Cube(1);
            // assert
            double expected = 1;
            Assert.AreEqual(expected, result);
        } // end Test_Cube_2



        [TestMethod]
        public void Test_Cube_3_Zero()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Cube(0);
            // assert
            double expected = 0;
            Assert.AreEqual(expected, result);
        } // end Test_Cube_3


        [TestMethod]
        public void Test_Cube_4_Negative()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Cube(-2);
            // assert
            double expected = -8;
            Assert.AreEqual(expected, result);
        } // end Test_Cube_4



        [TestMethod]
        public void Test_Cube_5_Decimal()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Cube(2.5);
            // assert
            double expected = 15.625;
            Assert.AreEqual(expected, result);
        } // end Test_Cube_5


        [TestMethod]
        public void Test_Cube_6_Decimal()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Cube(-2.5);
            // assert
            double expected = -15.625;
            Assert.AreEqual(expected, result);
        } // end Test_Cube_6

//  -------------------------------------------------------------------------

        [TestMethod]
        public void Test_Log_1_whole_num_result()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Log10(100);
            // assert
            double expected = 2;
           Assert.AreEqual(expected, result);
        } // end Test_Log_1


        [TestMethod]
        public void Test_Log_2_decimal_result()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Log10(18);
            // assert
            double expected = 1.25527250510331;   // (14 decimal places)
            double delta = 0.00000000000001;   // accepable difference between expected & result
            Assert.AreEqual(expected, result, delta);
        } // end Test_Log_2



        [TestMethod]
        public void Test_Log_3_Negative_number()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.Log10(-100);
            // assert
            Assert.AreEqual(double.NaN, result);
        } // end Test_Log_3


        [TestMethod]
        public void Test_GetUser_Number()
        {
            //arrange
            Calculator mc = new Calculator();
            // act
            double result = mc.GetUserNumber("45");
            // assert
            Assert.AreEqual(45, result);
            Assert.AreEqual(0, mc.GetCurrentIndex());
        } // end Test_GetUser_Number



        //[TestMethod]
        //public void Test_GetUser_Number2()
        //{
        //    //arrange
        //    Calculator mc = new Calculator();
           
        //    // act
        //    mc.SetTestValues(new Object[] { "abcd", 45 });
        //    double result = mc.GetUserNumber("45");
        //    Assert.AreEqual(45, result);
        //    Assert.AreEqual(1, mc.GetCurrentIndex());

        //} // end Test_GetUser_Number2




    } // end class UnitTest1
} // end Namespace
