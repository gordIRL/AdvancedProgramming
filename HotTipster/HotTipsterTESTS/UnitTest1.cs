using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using HotTipster;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;



namespace HotTipsterTESTS
{

    [TestClass]
    public class UnitTest1
    {




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
            bool result = MyFileIO.CreateFileStream("testBinary1.bin");

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






        public static List<HorseBet> CreateHorseBetListForTestClasses()
        {
            //Create list for result horsebetlist

           List < HorseBet > horsbetList = new List<HorseBet>();

           // Create 2 new horsebets
           HorseBet horseBet1 = new HorseBet("Dublin", new DateTime(2017, 03, 06), 200, true);
           HorseBet horseBet2 = new HorseBet("Galway", new DateTime(2018, 03, 06), 200, true);

            // Add horsebets to list
            horsbetList.Add(horseBet1);
            horsbetList.Add(horseBet2);

            return horsbetList;
        }




        //[TestMethod]
        //public void ReportingMethods_ListOfYears()
        //{
        //    // arrange
        //    //List<int> ResultYears = new List<int>() { 2017, 2018 };
        //    List<int> expected = new List<int>() { 2017, 2018 };           

        //    //Act 
        //    List<int> result = new List<int>();
        //    List<HorseBet> tempList = new List<HorseBet>(CreateHorseBetListForTestClasses);
        //    result = ReportingMethods.ListOfYears(CreateHorseBetListForTestClasses);

        //    // assert
        //    CollectionAssert.AreEqual(expected, result);
        //}



        ////Where your method SHOULD throw an exception for given input, use the 
        ////following annotation to specify this:

        ////[TestMethod]
        ////[ExpectedException(typeof(ArgumentOutOfRangeException))]






        [TestMethod]
        public void Utility_ScreenDisplay()
        {
            //arrange 
            // act           
            bool result = Utility.ScreenDisplay();

            //assert
            bool expected = true;

            Assert.AreEqual(expected, result);
        }//endTest_Add_Numbers_1








        [TestMethod]
        public void SwitchMainLoop_1()
        {
            //arrange 
            // act           
            bool result = SwitchLoop.MainLoop("E");

            //assert
            bool expected = false;

            Assert.AreEqual(expected, result);

        }//end SwitchMainLoop_1


        [TestMethod]
        public void SwitchMainLoop_2()
        {
            //arrange 
            // act           
            bool result = SwitchLoop.MainLoop("e");

            //assert
            bool expected = false;

            Assert.AreEqual(expected, result);
        }//endTest_Add_Numbers_1



        [TestMethod]
        public void SwitchMainLoop_3()
        {
            //arrange 
            // act           
            bool result = SwitchLoop.MainLoop("3");

            //assert
            bool expected = true;

            Assert.AreEqual(expected, result);
        }//endTest_Add_Numbers_1



        [TestMethod]
        public void SwitchMainLoop_4()
        {
            //arrange 
            // act           
            bool result = SwitchLoop.MainLoop("5");

            //assert
            bool expected = true;

            Assert.AreEqual(expected, result);
        }//endTest_Add_Numbers_1


        //-------------------------------------------------------------------------------------

        


        //     [TestMethod]
        //public void SwitchMainLoop_4()
        //{
        //    //arrange 
        //    // act           
        //    bool result = ReportingMethods.GetAnnualResult();

        //    //assert
        //    bool expected = true;

        //    Assert.AreEqual(expected, result);
        //}//end








    }// end class UnitTest1
}// end Namespace
