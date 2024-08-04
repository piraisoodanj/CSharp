using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{

    public abstract class Animals
    {
        public  string Name { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;

        }

        public abstract void Eat();

    }

   public class Dog : Animals
    {
        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
    }

    internal class AbstractClassAssesmnet
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the dog name");
            string dogname = Console.ReadLine();    
            Dog dog = new Dog();
            dog.SetName(dogname);
            Console.WriteLine(dog.GetName());
            dog.Eat();
        }
    }
}
