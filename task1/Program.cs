using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace lab2task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "students.csv";

            var studentsList = File.ReadAllLines(filePath)
                .Select(line => new {
                    name = line.Split(',')[0],
                    Grades = line.Split(',').Skip(1).Select(int.Parse)
                })
                .Select(student => new {
                    student.name,
                    averageMark = student.Grades.Average()
                })
                .Where(student => student.averageMark >= 3)
                .ToList();

            foreach (var student in studentsList)
            {
                Console.WriteLine($"{student.name} average mark {student.averageMark}");
            }
        }
    }
}