using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Palindrome
    {
        static void Main3(string[] args)
        {

            Console.WriteLine("Enter the string for palindrome scenario");
            String s =Console.ReadLine();

            //  Console.WriteLine(s.Reverse().ToArray());  
            char[] charArray = s.ToCharArray();
            int Left = 0;
            int Right = charArray.Length - 1;

            while (Left < Right) {

                char temp = charArray[Left];
                charArray[Left] = charArray[Right];
                charArray[Right] = temp;    
                Left++; 
                Right--;

                    

            }
           
            Console.WriteLine(charArray);
        }
    }
}
