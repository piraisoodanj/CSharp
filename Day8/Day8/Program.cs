﻿namespace Day8
{
    public abstract class Animal
    {
        public abstract string Sound { get; }

        public virtual void Move()
        {
            Console.WriteLine("Animal is moving in base class");
        }
    }

    public class Cat : Animal
    {
        public override string Sound => "Meow";
        public override void Move()
        {
            Console.WriteLine("Cat is moving in derived class");

        }
    }
    public class Doggy : Animal
    {
        public override string Sound => "Bark";
        public override void Move()
        {
            Console.WriteLine("Dog is moving in derived class");

        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            Animal[] animals = new Animal[] { new Cat(), new Doggy() };

            foreach (var anim in animals)
            {
                Console.WriteLine($"The {anim.GetType().Name} goes {anim.Sound}");
                anim.Move();
            }
        }
    }
}