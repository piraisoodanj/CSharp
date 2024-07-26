using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Maxofthreenumbers
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("tst");
            Console.WriteLine(MaxMonnu(5,6,3));
        }

        public static int MaxMonnu(int a, int b, int c)
        {
           
            if(a>b && a>c)
            {
                return a;
            }
            else if(b>a && b>c) {
                return b;

            }
            else
            {
                return c;
            }
        }
    }
}
