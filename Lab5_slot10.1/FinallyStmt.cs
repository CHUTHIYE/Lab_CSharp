using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project16
{
    class FinallyStmt
    {
        static void Main(string[] args)
        {
            FileStream outStream = null;
            FileStream inStream = null;
            try
            {
                //mở file để ghi dữ liệu
                outStream = File.OpenWrite("DestinationFile.txt");
                //mở file để đọc dl
                inStream = File.OpenRead("BogusInputFile.txt");
                //các câu lệnh đọc dl từ file
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (outStream != null)
                {
                    outStream.Close();
                    Console.WriteLine("outStream closed.");
                }
                if (inStream != null)
                {
                    inStream.Close();
                    Console.WriteLine("inStream closed.");
                }
            }

        }
    }
}
