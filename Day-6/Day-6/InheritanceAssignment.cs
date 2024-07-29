namespace Day_6
{

    public class Person
    {
        private int age;


        public void Greet()
        {
            Console.WriteLine("Hello");
        }

        public void setage(int age)
        { this.age = age; }
        public int Getage()
        {
            {
                //this.age = age;
                return age;
            }

        }
        public class Student : Person
        {
            public void Study()
            {
                Console.WriteLine("I'm studying");
            }
            public void ShowAge()
            {
                Console.WriteLine($"My age is: {Getage()} years old");
            }
        }
        public class Teacher : Person
        {
            public void Explain()
            {
                Console.WriteLine("I'm Explaining");
            }
        }

        internal class StudentProfessorTest
        {
            public static void Main4(string[] args)
            {
                Person person = new Person();
                person.Greet();
                Student student = new Student();
                student.setage(26);
                student.Greet();
                student.ShowAge();
                student.Study();
                //  student.Study();
                Teacher teacher = new Teacher();
                teacher.setage(27);
                teacher.Greet();

                teacher.Explain();

            }
        }
    }
}

