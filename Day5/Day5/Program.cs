using System.Security.Cryptography.X509Certificates;

namespace Day5
{

    class Employees
    {
        public int Id;
        public string Name;
        public string Location;
        
        public Employees(int id, string name, string location)
        {
            Id = id; 
            Name = name;
            Location = location;

        }
        public void PrintEmployeeData()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);

            Console.WriteLine(Location);

        }

    }
    internal class Program
    {
        static void Main1(string[] args)


        {

            Employees emp = new Employees(132, "pirai","Location");
            emp.PrintEmployeeData();
            Console.WriteLine(emp.Id);

            //Console.WriteLine("Hello, World!");
        }
    }
}