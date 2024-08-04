using System.Collections;

namespace Day10
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            ArrayList al = new ArrayList();
            string str = "Vikash Verma";
            int x = 7;
            DateTime d = DateTime.Parse("03-08-2024");

            al.Add(str);
            al.Add(x);
            al.Add(d);

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===============================");
            Hashtable ht = new Hashtable();
            ht.Add("ora", "Oracle");
            ht.Add("vb", "vb.net");
            ht.Add("cs", "cs.net");
            ht.Add("asp", "asp.net");

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine("===============================");
            SortedList sl = new SortedList();
            sl.Add("ora", "Oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine("===============================");
            Stack sk = new Stack();
            sk.Push("Oracle");
            sk.Push("vb.net");
            sk.Push("cs.net");
            sk.Push("asp.net");

            foreach (var item in sk)
            {
                Console.WriteLine(item) ;
            }
        }
    }
}