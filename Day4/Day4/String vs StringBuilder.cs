using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class String_vs_StringBuilder
    {

        static void Main2(string[] args)
        {
            //String

            string s = string.Empty;
            Console.WriteLine(s);

            s = "Pirai";
           // Console.WriteLine(s);

            s.ToUpper();
           // Console.WriteLine(s);
           // Console.WriteLine(s.ToUpper()); 

            StringBuilder sb = new StringBuilder();
            sb.Append(s);
            sb.Insert(5, "t");
           // sb.Clear();
            Console.WriteLine(sb.ToString());

            for (int i =0; i < sb.Length; i++) {
                Console.WriteLine(s[i]);    
            }  

        }
    }
}
