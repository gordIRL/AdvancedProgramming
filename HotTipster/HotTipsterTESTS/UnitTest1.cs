using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using HotTipster;

namespace HotTipsterTESTS
{
    [TestClass]
    public class UnitTest1
    {     

        [TestMethod]
        public void Test_Add_Numbers_1()
        {
            //arrange            
            //Calculator myCalculator = new Calculator();
            
            // act           
            double result = Utility.AddTwoNums(5, 2);
            
            //assert
            double expected = 7;
            Assert.AreEqual(expected, result);
        }//endTest_Add_Numbers_1



        [TestMethod]
        // Test to confirm bool true if file exists
        public void Test_BinaryWriter_1_ExistingFile()
        {
            //arrange            
            File.Create(@"C:\dbs\my1stBinaryFile.bin");

            // act         
            bool result = MyFileIO.CheckFileExists("my1stBinaryFile.bin");
            
            //assert
            bool expected = true;
            Assert.AreEqual(expected, result);

        }//end Test_BinaryWriter_1



        [TestMethod]
        // Test to confirm bool false if no file exists
        public void Test_BinaryWriter_2_NonexistentFile()
        {
            //arrange            
            
            // act         
            bool result = MyFileIO.CheckFileExists("myNonexistentFile.bin");

            //assert
            bool expected = false;
            Assert.AreEqual(expected, result);

        }//end Test_BinaryWriter_1














        [TestMethod]
        // Test to confirm bool true if new file has been created
        public void Test_BinaryWriter_3_TestForFileCreated()
        {
            //arrange      
            if (File.Exists(@"C:\dbs\testBinary1.bin"))
            {
                File.Delete(@"C:\dbs\testBinary1.bin");
            }


            // act         
            bool result = MyFileIO.CreateFileStream ("testBinary1.bin");

            //assert
            bool expected = true;
            Assert.AreEqual(expected, result);

        }//end Test_BinaryWriter_3_TestForFileCreated
        


        [TestMethod]
        // not working - [ExpectedException(typeof(System.NotSupportedException))]        
        // Test to confirm bool true if new file has been created
        public void Test_BinaryWriter_4_TestForFileCreatedExceptionThrown()
        {
            // act                     
            bool result = MyFileIO.CreateFileStream(@"Z:\dbs\testBinary1.bin");

            //assert(not working)
            // provided above by including   [ExpectedException(typeof(System.NotSupportedException))]

            //assert(working)
            bool expected = false;
            Assert.AreEqual(expected, result);

        }//end Test_BinaryWriter_3_TestForFileCreated





        
        [TestMethod]       
        public void HorseBet_1_Constructor()
        {
            //arrange          
            HorseBet horseBetTest = new HorseBet("Sandown", new DateTime(2017, 08, 07), 25.00m, false);

            // act         
            object result = horseBetTest.GetType();

            //assert
            object expected = typeof(HorseBet);
            Assert.AreEqual(expected, result);

        }//end TestHorseBetConstructor




        [TestMethod]
        public void HorseBet_2_ToString()
        {
            //arrange          
            HorseBet horseBetTest = new HorseBet("Sandown", new DateTime(2017, 08, 07), 25.00m, false);

            // act         
            string result = "Sandown  07/08/2017  25.00  False";

            //assert
            string expected = horseBetTest.ToString();
            Assert.AreEqual(expected, result);

        }//end TestHorseBetToString


















        ////Where your method SHOULD throw an exception for given input, use the 
        ////following annotation to specify this:

        ////[TestMethod]
        ////[ExpectedException(typeof(ArgumentOutOfRangeException))]








    }// end class
}// end Namespace
