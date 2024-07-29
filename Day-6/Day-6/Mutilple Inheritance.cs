using Day_6;

namespace Day_6
{

    public class car
    {
        public car()
        {
            Console.WriteLine("MiniCooper");

        }

    }
    class car2 : car
    {
        public car2()
        {
            Console.WriteLine("Lexas");
        }
    }

    class car3 : car2
    {
        public car3()
        {
            Console.WriteLine("Benz");
        }
    }
}


internal class Mutilple_Inheritance
{
    public static void Main3()
    {
        car3 c = new car3();

    }
}

