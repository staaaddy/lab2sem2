using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;


namespace lab2task2
{
    class Employee
    {
        public string Name { get; set; }
        public int Experience { get; set; }

        public Employee(string name, int experience)
        {
            Name = name;
            Experience = experience;
        }
    }
}