namespace Day2
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int Number = 5;
            
            Type type = typeof(int);
            
            //Implicit
            Double NumDouble=(int)Number; //Increment
            Console.WriteLine(NumDouble);

            //Explicit
            Number = (int)NumDouble; //Decrement

            Console.WriteLine(NumDouble);

            Number = Convert.ToInt32(NumDouble);

            Console.WriteLine(NumDouble);


        }
    }
}