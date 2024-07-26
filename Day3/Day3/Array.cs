using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Array
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 2];
            //int value = 1;
            for (int i = 0; i < 2; i++)
            {
                {
                    for (int j = 0; j < 2; j++)
                    


                        array[i, j] = Convert.ToInt32(Console.ReadLine());
                   
                }

                }
            
                Console.WriteLine("----------");

            for (int i = 0; i < 2; i++)
            {
                {
                    for (int j = 0; j < 2; j++)
                    
                        Console.WriteLine(array[i, j] + "\t");
                    }


                
                Console.WriteLine();
            }

            }
    }
}
