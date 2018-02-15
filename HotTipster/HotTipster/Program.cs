using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Text.RegularExpressions;

namespace HotTipster
{
    class Program
    {
        static void Main(string[] args)
        {
            // FileName & Location fo file to write out to
            string fullPathFileName = @"C:\dbs\my1stBinaryFile.bin";


            //bool userFileExists =  MyFileIO.CheckFileExists("testBinary1");
            //Console.WriteLine("User file exists: {0}", userFileExists);

            //bool isFileCreated = MyFileIO.CreateFileStream("testBinary1");
            //Console.WriteLine("File created: {0}", isFileCreated);


            MyFileIO.CheckFileExists("testBinary1");            
            MyFileIO.CreateFileStream("testBinary1");

          




            // Import original data into List of HorseBet objects by calling ImportData();
            List<HorseBet> myNewList = ImportDefaultData.ImportData();


            myNewList.Add(CreateHorseBet.Method1());










            // Display complete HorseBet List
            foreach (HorseBet hb in myNewList)
            {
                Console.WriteLine(hb.ToString());
            }





















































            Console.WriteLine("\n\n\n\n");

            // open file with write access via FileStream
            FileStream output =  new FileStream(fullPathFileName, FileMode.OpenOrCreate, FileAccess.Write );
            Console.WriteLine("Output stream created.");


            // Create a record to serialize
            RecordSerializable recordWrite1 = new RecordSerializable();
            recordWrite1.Name = "Gord";
            recordWrite1.Age = 46;
            Console.WriteLine("1st Record Object created.");

           
            // Create a record to serialize
            RecordSerializable recordWrite2 = new RecordSerializable();
            recordWrite2.Name = "Alan";
            recordWrite2.Age = 43;
            Console.WriteLine("2nd Record Object created.");


            // Create a BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            Console.WriteLine("BinaryFormatter created.");


            // write Record to FileStream ( serialize object ) 
            formatter.Serialize(output, recordWrite1);
            Console.WriteLine("1st Record object has been serialized.");

            // write Record to FileStream ( serialize object ) 
            formatter.Serialize(output, recordWrite2);
            Console.WriteLine("2nd Record object has been serialized.");

            // Close the FileStream
            output.Close();     // close FileStream
            Console.WriteLine("Filestream Closed.");






            //// open file with write access via FileStream
            //FileStream input = new FileStream(fullPathFileName, FileMode.OpenOrCreate, FileAccess.Read);
            //Console.WriteLine("\n\nInput stream created.");

            //// Create a BinaryFormatter (Reader)
            //BinaryFormatter reader = new BinaryFormatter();
            //Console.WriteLine("BinaryFormatter (Reader) created.");


            //int counter = (int)input.Length -1;

            //while(input.Position < input.Length)
            //{
            //    RecordSerializable tempRecord = new RecordSerializable();
            //    tempRecord =   (RecordSerializable)reader.Deserialize(input);
            //    Console.WriteLine(tempRecord.Name + " " + tempRecord.Age);
            //}
            



            ////  Read in & 1st deserailized record
            //RecordSerializable recordRead1 = 
            //    (RecordSerializable)reader.Deserialize(input);
            //Console.WriteLine("Read in & deserailized - Completed");

            ////  Read in & 2nd deserailized record
            //RecordSerializable recordRead2 =
            //    (RecordSerializable)reader.Deserialize(input);
            //Console.WriteLine("Read in & deserailized - Completed");

            //// Should produce error !!             It DOES !!
            ////  Read in & 3rd NON-EXISTENT deserailized record
            //RecordSerializable recordRead3 =
            //    (RecordSerializable)reader.Deserialize(input);
            //Console.WriteLine("Read in & deserailized - Completed");

            //// Close the FileStream
            //input.Close();     // close FileStream
            //Console.WriteLine("Filestream Closed.");

            //Console.WriteLine(string.Format("\n\n{0}: {1}",
            //    recordRead1.Name, recordRead1.Age));
            //Console.WriteLine(string.Format("{0}: {1}\n",
            //    recordRead2.Name, recordRead2.Age));



            Console.WriteLine(Utility.AddTwoNums(5, 3));



        }// end Main
    }// end class Program
}// end Namespace
