using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class FileHandling
    {
        public static void Main(string[] args)
        {
            string Path = @"D:text.txt";

            //FileStream file = new FileStream(Path, FileMode.Create);
            //byte[] byteData = Encoding.Default.GetBytes("Hello i am pirai");
            //file.Write(byteData,0,byteData.Length);
            //file.Close();

            //FileStream file = new FileStream(Path, FileMode.Open, FileAccess.Read);
            //string Data;
            //using (StreamReader sr = new StreamReader(file))
            //{

            //    Data = sr.ReadToEnd();
            //}
            //Console.WriteLine(Data);
            //file.Close();

            //StreamWriter sw = new StreamWriter(Path,true);
            //Console.WriteLine("Enter the string to write into the file:");
            //string Inputdata = Console.ReadLine();
            //sw.WriteLine(Inputdata);
            //sw.Flush();
            //sw.Close();

            StreamReader streamReader = new StreamReader(Path);
            Console.WriteLine("Content from the file");
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
            string strdata = streamReader.ReadLine();
            while (strdata != null)
            {
                Console.WriteLine(strdata);
                strdata = streamReader.ReadLine();
            }

            string destinationPath = @"D:\new\text.txt";

            if(File.Exists(Path))
            {
                File.Delete(destinationPath);
                File.Copy(Path, destinationPath);
            }
            else
            {
                Console.WriteLine("File doesn't exists");
            }

            DirectoryInfo d1 = new DirectoryInfo(destinationPath);
            d1.Delete();
        }
    }
}
