namespace Day_6
{

    class Persons
    {
        static
  public string Name;

        //Constructor
        public Persons(string name)
        {
            Name = name;
        }

        // Destructor
        ~Persons()
        {
            Name = string.Empty;
        }
        // overridng Tostring() method
        public override string ToString()
        {
            return $"Hello! My name is {Name}";
        }
    }


    internal class Program
    {
        static void Main1(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            Persons[] people = new Persons[3];

            // User to prompt names and create person objects

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine("Enter Name:");
                string Name = Console.ReadLine();
                people[i] = new Persons(Name);
            }

            // Display the name string using .tostring method

            foreach (Persons person in people)
            {
                Console.WriteLine(person.ToString());

            }

        }
    }
}