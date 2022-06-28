using System;
using System.Collections.Generic;

namespace Festival.Clearance
{
    class Program
    {
        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {

                Console.WriteLine("Please enter employee first name: (leave empty to exit): ");

                string firstName = Console.ReadLine();

                if (firstName == "")
                {
                    break;
                }
                Console.WriteLine("Please enter employee last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Please enter clearance level: ");
                int clearanceLevel = Int32.Parse(Console.ReadLine());
                Employee currentEmployee = new Employee(firstName, lastName, clearanceLevel);
                employees.Add(currentEmployee);
            }
            return employees;
        }
        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
        }
    }
}