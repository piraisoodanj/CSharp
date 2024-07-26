using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Switch
    {
        static void Main2(string[] args)
        {

            Console.WriteLine("Enter the input");
            int Number = Convert.ToInt32(Console.ReadLine());

            switch(Number)
            {
                case 1:
                    Console.WriteLine("1 chosen");
                    break;
                case 2:
                    Console.WriteLine("2 chosen");
                    break;
                 default: 
                    Console.WriteLine("no input");
                    break; 
            }

        }
    }

}