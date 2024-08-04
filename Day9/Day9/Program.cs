namespace Day9
{

    interface Bike
    {
        void price();
    }

    interface Car
    {
        void price();
    }

    class Buyer : Bike, Car
    {
        void Bike.price() {
            Console.WriteLine("I called the bike");

        }

        void Car.price()
        {

            Console.WriteLine("I called the car");
        }
    }


    internal class Program
    {
        static void Main1(string[] args)
        {

            Bike b = new Buyer();
            b.price();
            Car c = new Buyer();
            c.price();
            Console.WriteLine("Hello, World!");
        }
    }
}