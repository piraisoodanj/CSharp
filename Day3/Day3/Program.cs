namespace Day3
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 100, b = 300;
          swap(ref a,ref b);
          Console.WriteLine("a -" + a + "b -" + b);
            Console.WriteLine("Ref followed by out");
            Swapout(a, b, out a, out b);
            Console.WriteLine("a -" + a + "b -" + b);
        }

        //Ref  
        public static void swap(ref int a,ref int b)
        {
            int temp;
            temp =a;
            a = b;
            b = temp;
       

        }

        //Out
        public static void Swapout(int a, int b, out int x, out int y)

        {

            x = b;
            y = a;
        }
            
            
            
            

        
    }
}