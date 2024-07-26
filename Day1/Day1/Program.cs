namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello, World!");


            //   int num1, num2;

            /*    Console.WriteLine("Enter the Number1");
                num1 = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("Enter the Number2");
                 num2 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine($"{num1} and {num2}");
             */

            /*Console.WriteLine("Enter the Number to find odd or even");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number%2==0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            */

            Console.WriteLine("UnitCharges");
            Double UnitCharges = Convert.ToDouble(Console.ReadLine());
            Double TotalCharges;

            if(UnitCharges==50)
            {
                UnitCharges = 50*0.50;
         

            }
            else if (UnitCharges>50 & UnitCharges<=150)
                {
                UnitCharges = (50 * 0.500) + (100 * 0.75);

            }

            else if (UnitCharges>150 & UnitCharges<=250)

            {
                UnitCharges = (50 * 0.500) + (100 * 0.75) + (100 * 1.20);
            }           
          
            else if (UnitCharges>250)
            {
                UnitCharges = (50 * 0.500) + (100 * 0.75) + (100 * 1.20) + (UnitCharges -250 * 1.50);
            }


            TotalCharges = UnitCharges * 20 / 100;
            Console.WriteLine(Convert.ToDouble(TotalCharges+UnitCharges));
            }
        }

    }
