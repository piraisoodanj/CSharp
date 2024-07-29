namespace Day_6
{

    class movie
    {
        protected string moviename;
        public movie()
        {
            moviename = "DeadPool";
        }


    }

    class staring : movie
    {
        public void Print()
        {
            Console.WriteLine(moviename);
        }
    }




    internal class Single_and_multilevel_Inheritance
    {
        public static void Main2()
        {
            staring m = new staring();
            m.Print();
        }
    }
}
