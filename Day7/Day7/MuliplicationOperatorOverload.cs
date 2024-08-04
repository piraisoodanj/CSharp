using Day_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{

    class Multiply
    {
        int Number1; int Number2;

        public Multiply(int a, int b)
        {
            Number1 = a; Number2 = b;
        }
        public void Print()
        {
            Console.WriteLine("Number 1 :" + Number1 + " \n Number 2: " + Number2);
        }

        public static Multiply operator *(Multiply s1, Multiply s2)
        {
            Multiply s3 = new Multiply(0, 0);
            s3.Number1 = s1.Number1 * s2.Number2;
            s3.Number2 = s1.Number2 * s2.Number2;
            return s3;

        }
    }

    internal class MuliplicationOperatorOverload
    {
        public static void Main(string[] args)
        {
            Multiply s1 = new Multiply(1, 2);
            Multiply s2 = new Multiply(2, 4);
            Multiply s3 = s1 * s2;
            s3.Print();
        }
      
    }
}
