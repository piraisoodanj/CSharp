using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{


    internal class Dictionarys
    {
        public static void Main()
        {
            Dictionary<string, string> mydic = new Dictionary<string, string>();
            mydic.Add("pirai", "soodan");
            mydic.Add("Manish", "R");

            foreach(KeyValuePair<string, string> kvp in mydic)
            {
                Console.WriteLine("Key : {0}, Value: {1}",kvp.Key, kvp.Value);
                
            }

            Console.WriteLine("=================");
            HashSet<string> myset = new HashSet<string>();
            myset.Add("one");
            myset.Add("two");
            myset.Add("three");
            myset.Add("one");

            foreach (var item in  myset)
            {
                Console.WriteLine(item);
            }

            Queue<string> strings = new Queue<string>();
            strings.Enqueue("onequwuw");
            strings.Enqueue("twoqueuw");
            strings.Enqueue("threequeue");

            while(strings.Count > 0)
            {
                Console.WriteLine("Dequeued - " + strings.Dequeue());

            }
           

            Stack<string> mystack = new Stack<string>();
            mystack.Push("one");
            mystack.Push("two");
            mystack.Push("three");

            while(mystack.Count> 0)
            {
                Console.WriteLine("Poped - " + mystack.Pop());
            }

           

        }

    }
}
