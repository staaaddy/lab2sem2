using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace lab2task2
{
    class Program
    {
        static void Main()
        {
            string filePath = "experience.csv";
            List<Employee> employees = File.ReadAllLines(filePath)
                .Select(line => new Employee(line.Split(',')[0], int.Parse(line.Split(',')[1])))
                .ToList();
            employees = employees.OrderBy(e => e.Experience).ToList();

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name} experience - {employee.Experience} years");
            }
        }
    }
}