using System;
using System.IO;
// using System.Net;
// using System.Drawing;
using System.Collections.Generic;

namespace Festival.Clearance
{
    class Util
    {
        public static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                string template = "{0}, {1}";
                Console.WriteLine(String.Format(template, employees[i].GetName(), employees[i].GetClearanceLevel()));
            }
        }
        public static void MakeCSV(List<Employee> employees)
        {
            if (!Directory.Exists("data"))
                {
                    Directory.CreateDirectory("data");
                }
            using (StreamWriter file = new StreamWriter("data/employees.csv"))
            {
                file.WriteLine("Name, Clearance Level");
                for (int i = 0; i < employees.Count; i++)
                {
                    string template = "{0},{1}";
                    file.WriteLine(String.Format(template, employees[i].GetName(), employees[i].GetClearanceLevel()));
                }
            }
        }
    }
}