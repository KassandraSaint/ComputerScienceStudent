using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScienceStudent
{
    abstract class Student
    {
        // Creating a constructor for a Student class
        public Student (string name, string id)
        {
            Name = name;
            ID = id;
        }

        // Class properties
        public string Name { get; set; }
        public string ID { get; set; }

        // Property to get required hourse
        public abstract double RequiredHours { get; }
    }
}
