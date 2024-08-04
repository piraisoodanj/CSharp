using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    class Employee
    {
        public int Id { get; set; }


        public void GetData()
        {
            Console.WriteLine("Please enter the employe ID");
            Id = Convert.ToInt32(Console.ReadLine());
        }

    }
    internal class GenericCollections
    {

        public static void Main2()
        {
            List<Employee> list = new List<Employee>(); 
            for (int i = 0; i < 2; i++)
            {
                Employee e = new Employee();
                e.GetData();
                list.Add(e);
            }

            foreach (var item in  list)
            {
                Console.WriteLine("ID :" + item.Id);
            }
        }
    }
}
