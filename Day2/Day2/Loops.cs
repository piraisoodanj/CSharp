using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Loops
    {
        static void Main3(string[] args) {

           //for loops

            for(int index=0; index < 10; index++)
            {
                Console.Write(index+" ");

            }
            Console.WriteLine("-------");


            int whileindex = 0;
            while(whileindex<10)
                {
                Console.Write(whileindex+" ");
                whileindex++;
            }
            Console.WriteLine("-------");

            int dowhile = 0;
            do
            {
                Console.Write(dowhile+" ");
                dowhile++;

            }
            while (dowhile < 10);
        }
    }
}
