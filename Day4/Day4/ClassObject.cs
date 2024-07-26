using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Employee

    {
        public int EmpID;
        public string Name;
        public int salary;
        public string Location;

        public void GetData(string Employee)
        {
            EmpID=Convert.ToInt32(Console.ReadLine());
            Name= Console.ReadLine();
            salary= Convert.ToInt32(Console.ReadLine());
            Location = Console.ReadLine();
    }

    public void PrintData(string Employee)
    {
        Console.WriteLine("Enter the EmpID"+EmpID);
        Console.WriteLine("Enter the Name"+Name);
        Console.WriteLine("Enter the salary"+salary);
        Console.WriteLine("Enter the location"+Location);


    }

}

internal class ClassObject
    {
        //  public int EmpID;
        // public string Name;
        //public int salary;
        //public string Location;


  public static void Main(string[] args) { 
        
            Employee emp = new Employee();
            emp.GetData(Employee);
            emp.PrintData(emp);


                
        }
            

}

    
}


