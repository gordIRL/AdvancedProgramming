using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace HotTipster
{
    public static class MyFileIO
    {
        public static string fullPathForBinaryFile = @"C:\dbs\HotTipsterData.bin";



        public static bool CheckFileExists(string userFileName)
        {
            // concatenate user chosen file name with file path
            string fullPathFileName = @"C:\dbs\" + userFileName;

            if (File.Exists(fullPathFileName))
                return true;
            else
                return false;
        }// end CheckFileExists



        public static bool CreateFileStream(string userFileName)
        {
            // concatenate user chosen file name with file path
            string fullPathFileName = @"C:\dbs\" + userFileName;

            try
            {
                FileStream output = new FileStream(fullPathFileName, FileMode.OpenOrCreate, FileAccess.Write);
                //Console.WriteLine("Output stream created.");
                return true;
            }
            catch (System.NotSupportedException)
            {
                return false;
            }
        }// end CreateFileStream

        






        public static void WriteToBinaryFile(List<HorseBet> horseBetListLocal)
        {
            // FileName & Location fo file to write out to            

            if (!File.Exists(fullPathForBinaryFile))
            {
                File.Create(fullPathForBinaryFile);
            }


            // open file with write access via FileStream
            FileStream output = new FileStream(fullPathForBinaryFile, FileMode.Append, FileAccess.Write);  // FileMode.OpenOrCreate
            Console.WriteLine("IO Stream created.");


            // Create a BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            Console.WriteLine("BinaryFormatter created.");


            // Iterate through NewAdditionsToHorseBetList & write out to binary file
            int counterWriteToBinary = 0;
            foreach (HorseBet hb in horseBetListLocal)
            {                
                formatter.Serialize(output, hb);   
                Console.WriteLine("Horsebet no: {0} written to file  -  {1}",
                   counterWriteToBinary, hb.ToString());
                counterWriteToBinary++;
            }

            // Close the FileStream
            output.Close();     // close FileStream
            Console.WriteLine("Filestream Closed.");

            Console.ReadLine();
        }// end WriteToBinaryFile






        public static List<HorseBet> ReadFromBinaryFile()
        {
            Console.WriteLine("Read data from Binary file");
            Console.ReadLine();

            // open file with write access via FileStream
            FileStream input = new FileStream(fullPathForBinaryFile, FileMode.OpenOrCreate, FileAccess.Read);
            //Console.WriteLine("\n\nInput stream created.");  // use for testing

            // Create a BinaryFormatter (Reader)
            BinaryFormatter reader = new BinaryFormatter();
            //Console.WriteLine("BinaryFormatter (Reader) created.");  // use for testing


            // Alert user if data file is empty
            if(input.Length == 0)
            {
                Console.WriteLine("\n\nNo data currently in file.\n\n");
            }

            // Set up counter that is the length of the binary file
            //int counter = (int)input.Length - 1;//int counter = (int)input.Length - 1;

            // Create a list to store HorseBets in
            List<HorseBet> tempHorseBetList = new List<HorseBet>();

            // Read in data until end of binary file is detected & add to tempHorseBetList
            
            while (input.Position < input.Length)
            {
                HorseBet tempHorseBet = new HorseBet();
                tempHorseBet = (HorseBet)reader.Deserialize(input);
                tempHorseBetList.Add(tempHorseBet);  
                Console.WriteLine(tempHorseBet.ToString());                
            }// end while


            // Close the FileStream
            input.Close();     // close FileStream
            //Console.WriteLine("Filestream Closed.");   // use for testing

            // return HorseBet list
            return tempHorseBetList;

        }// end ReadFromBinaryFile


        public static void DeleteBinaryFile()
        {
            if (File.Exists(fullPathForBinaryFile))
            {
                //// Open Stream
                //FileStream output = new FileStream(fullPathForBinaryFile, FileMode.Open, FileAccess.Write);      

                // Delete Binary file
                File.Delete(fullPathForBinaryFile);                

                // Calls to void :              File.Delete error 
                // “The process cannot access the file because it is being used by another process”

                ////Close Stream
                //output.Close();              
            }
        }// end DeleteBinaryFile



    }// end class MyFileIO
}// end Namespace
