using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{

    interface IDemo
    {
       public  void print()
        {
            Console.WriteLine("Hello");
        }
    }

    class Example : IDemo
    {
        public void print()
        {
            Console.WriteLine("Hi");
        }
    }
        internal class Interface
    {

        public static void Main5()
        {
            Example e  = new Example();
       
            e.print();

        }
    }
}
