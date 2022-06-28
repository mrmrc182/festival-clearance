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
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetName(), employees[i].GetClearanceLevel()));
            }
        }
        public static void MakeCSV(List<Employee> employees)
        {

            using (StreamWriter file = new StreamWriter("data/employees.csv"))
            {
                if (!Directory.Exists("data"))
                {
                    Directory.CreateDirectory("data");
                }
                file.WriteLine("Name, Clearance Level");
                for (int i = 0; i < employees.Count; i++)
                {
                    string template = "{0}, {1}";
                    file.WriteLine(String.Format(template, employees[i].GetName(), employees[i].GetClearanceLevel()));
                }
            }
        }
    }
}