using System;
using System.IO;
using System.Net;
using System.Drawing;
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
                Console.WriteLine(String.Format(template, employees[i].GetClearanceLevel(), employees[i].GetName()));
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
                file.WriteLine("Clearance Level, Name");
                for (int i = 0; i < employees.Count; i++)
                {
                    string template = "{0}, {1}";
                    file.WriteLine(String.Format(template, employees[i].GetClearanceLevel(), employees[i].GetName()));
                }
            }
        }
    }
}