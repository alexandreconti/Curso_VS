using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesChallenge
{
    class Employee
    {
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected double Salary { get; set; }

        public Employee()
        {
            Name = "Lorenzo De Conti";
            FirstName = "Lorenzo";
            Salary = 333;
        }
        public Employee(string name, string firstName, double salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("{0} está trabalhando.", this.FirstName);
        }

        public void Pause()
        {
            Console.WriteLine("{0} está descansando.", this.FirstName);
        }



    }
}
