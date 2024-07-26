using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class StarPrinting
    {

        static void Main5(string[] args)
        {


            /*for (int i = 0; i <=4; i++) 
             {
                 for(int j=1; j<=i;j++)
                 {
                     Console.Write("*");
                 }

                 Console.WriteLine();


             }
            */

            // 
            int size = 10;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == 0 || i == size - 1 || (j == i && i <= size - 1))
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }


                }
                Console.WriteLine();
            }


        }     
    }

}