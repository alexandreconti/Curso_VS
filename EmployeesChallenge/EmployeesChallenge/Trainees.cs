using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesChallenge
{
    class Trainees : Employee
    {
        protected int WorkingHours { get; set; }

        protected int SchoolHours { get; set; }

        public Trainees(string name, string firstName, double salary, int workingHours, int schoolHours) :
            base(name, firstName, salary)
        {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }


        public void Learn()
        {
            Console.WriteLine("{0} está estudando", this.FirstName);
        }

        public void Work()
        {
            Console.WriteLine("{0} está trabalhando", this.FirstName);
        }
    }
}
