using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HotTipster
{
    public static class MyFileIO
    {

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






        // open file with write access via FileStream







    }// end class




}// end Namespace
