using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{

  public interface IVehiculo
    {

        void Drive();
        bool Refuel(int gasamount);
       
       
    }
  public class Car : IVehiculo
    {

        public void Drive(int gasoline)
        {
            if (gasoline > 0)
            {

                Console.WriteLine("The car is Driving");
            }
            else
            {
                Console.WriteLine("No fuel");
            }
        }

        public bool Refuel()

        {
            //  int  gasoline++;
            return true;
        }
    }
    internal class InterfaceTest
    {
        public static void Main(string[] args)
        {
            Car c = new Car();
            c.Refuel();
        }
     
       
        //c.Drive();
    }
}
