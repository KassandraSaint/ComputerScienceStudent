using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScienceStudent
{
    class CompSciStudent : Student
    {
        // Initializing constants to hold hours required
        private double MATH_HOURS = 20;
        private double CS_HOURS = 40;
        private double GEN_HOURS = 60;

        // Initializing variable academicTrack
        private string _academicTrack;

        // Creating a constructor for Computer Science Student
        public CompSciStudent (string name, string id, string track) : base (name, id)
        {
            AcademicTrack = track;
        }
        // Property for academic track
        public string AcademicTrack { get; set; }

        // Overriding required hours property from Student class
        public override double RequiredHours
        {
            // Returning accumulated student's required hours
            get { return MATH_HOURS + CS_HOURS + GEN_HOURS; }
        }
    }
}
