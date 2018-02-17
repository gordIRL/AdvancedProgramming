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
        public static string fullPathFileName = @"C:\dbs\my1stBinaryFile.bin";



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



        




        






        public static void WriteToBinaryFile(List<HorseBet> horseBetList)
        {
            // FileName & Location fo file to write out to
            


            // open file with write access via FileStream
            FileStream output = new FileStream(fullPathFileName, FileMode.OpenOrCreate, FileAccess.Write);
            Console.WriteLine("IO Stream created.");


            // Create a BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            Console.WriteLine("BinaryFormatter created.");


            // Iterate through HorseBet List & write out to binary file
            int counterWriteToBinary = 0;
            foreach (HorseBet hb in horseBetList)
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






        public static void ReadFromBinaryFile()
        {
            Console.WriteLine("Read in from Binary file");
            Console.ReadLine();

            // open file with write access via FileStream
            FileStream input = new FileStream(fullPathFileName, FileMode.OpenOrCreate, FileAccess.Read);
            Console.WriteLine("\n\nInput stream created.");

            // Create a BinaryFormatter (Reader)
            BinaryFormatter reader = new BinaryFormatter();
            Console.WriteLine("BinaryFormatter (Reader) created.");


            // Set up counter that is the length of the binary file
            int counter = (int)input.Length - 1;

            // Create a list to store HorseBets in
            List<HorseBet> HorseBetList = new List<HorseBet>();

            // Read in data until end of binary file is detected
            while (input.Position < input.Length)
            {
                HorseBet tempHorseBet = new HorseBet();
                tempHorseBet = (HorseBet)reader.Deserialize(input);
                HorseBetList.Add(tempHorseBet);
                Console.WriteLine(tempHorseBet.ToString());
                
            }// end while


            // Close the FileStream
            input.Close();     // close FileStream
            Console.WriteLine("Filestream Closed.");
        }// end ReadFromBinaryFile












    }// end class
}// end Namespace
