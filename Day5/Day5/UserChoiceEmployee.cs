using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day5
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }

    class UserChoiceEmployee
    {
        static Employee[] employees = new Employee[100]; // Assuming we can store up to 100 employees
        static int count = 0;

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. List Employees");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        UpdateEmployee();
                        break;
                    case 3:
                        DeleteEmployee();
                        break;
                    case 4:
                        ListEmployees();
                        break;
                    case 5:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }

            } while (choice != 5);
        }

        static void AddEmployee()
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter Employee ID:");
            emp.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            emp.Name = Console.ReadLine();

            Console.WriteLine("Enter Employee Department:");
            emp.Department = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary:");
            emp.Salary = double.Parse(Console.ReadLine());

            employees[count] = emp;
            count++;
        }

        static void UpdateEmployee()
        {
            Console.WriteLine("Enter Employee ID to update:");
            int id = int.Parse(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (employees[i].Id == id)
                {
                    Console.WriteLine("Enter new Employee Name:");
                    employees[i].Name = Console.ReadLine();

                    Console.WriteLine("Enter new Employee Department:");
                    employees[i].Department = Console.ReadLine();

                    Console.WriteLine("Enter new Employee Salary:");
                    employees[i].Salary = double.Parse(Console.ReadLine());

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Employee not found.");
            }
        }

        static void DeleteEmployee()
        {
            Console.WriteLine("Enter Employee ID to delete:");
            int id = int.Parse(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (employees[i].Id == id)
                {
                    // Shift elements to the left to overwrite the deleted employee
                    for (int j = i; j < count - 1; j++)
                    {
                        employees[j] = employees[j + 1];
                    }
                    count--;
                    found = true;
                    Console.WriteLine("Employee deleted.");
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Employee not found.");
            }
        }

        static void ListEmployees()
        {
            if (count == 0)
            {
                Console.WriteLine("No employees to display.");
            }
            else
            {
                Console.WriteLine("List of Employees:");
                Console.WriteLine("ID\tName\tDepartment\tSalary");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"{employees[i].Id}\t{employees[i].Name}\t{employees[i].Department}\t{employees[i].Salary}");
                }
            }
        }
    }

}