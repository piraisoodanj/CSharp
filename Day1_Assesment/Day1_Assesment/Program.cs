using System.Xml.Schema;

namespace Day1_Assesment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  Input basic salary of an employee and calculate its Gross salary

            /*   long BasicSalary;
               Double GrossSalary, HRA=0, DA=0;
               Console.WriteLine("Enter the Basic Salary");
               BasicSalary = Convert.ToInt64(Console.ReadLine());

               // HRA = 20% and DA=80%
               if(BasicSalary <=10000)
               {
                    HRA = BasicSalary * 20 / 100;
                    DA = BasicSalary * 80 / 100;


               }

               else if(BasicSalary <=20000)
                   {

                    HRA = BasicSalary * 25 / 100;
                    DA = BasicSalary * 90 / 100;


               } 
               else if(BasicSalary > 20000)
               {
                    HRA = BasicSalary * 30 / 100;
                    DA = BasicSalary * 95 / 100;

               }

               GrossSalary = BasicSalary + HRA + DA;
               Console.WriteLine(Convert.ToDouble(GrossSalary));
            */

            // Add character Front and back of the given string

            /*  String InputStr;
              Console.WriteLine("Enter the Input String");
              InputStr = Console.ReadLine();

             if(!string.IsNullOrEmpty(InputStr))
              {
                  char FirstChar = InputStr[0];
                  InputStr = FirstChar + InputStr + FirstChar;
                  Console.WriteLine(InputStr);
              }
              else
              {
                  Console.WriteLine("String is null or empty");
              }

           */

            // exchange first and last character of a given string
            /*  String InputStr;
              Console.WriteLine("Enter the Input String");
              InputStr = Console.ReadLine();

              if (!string.IsNullOrEmpty(InputStr) & InputStr.Length>1)
              {
                  char[] charArray = InputStr.ToCharArray();
                  char FirstChar = InputStr[0];
                  char LastChar = InputStr[InputStr.Length - 1];
                  charArray[0] = LastChar;
                  charArray[InputStr.Length - 1] = FirstChar; 

                  string result= charArray.ToString();

                  Console.WriteLine(charArray);
              }
              else
              {
                  Console.WriteLine(InputStr);
              }

              */

            // return the string with 3 character addded to front and back.

            String InputStr;
            Console.WriteLine("Enter the Input String");
            InputStr = Console.ReadLine();

            if (!string.IsNullOrEmpty(InputStr) & InputStr.Length > 2)
            {
                string Addon = InputStr.Substring(0, 3);
        

                Console.WriteLine(Addon+InputStr+Addon);
            }
            else
            {
                string Addon = InputStr.Substring(0, InputStr.Length);


                Console.WriteLine(Addon + InputStr + Addon);
       
            }

        }
    }
}