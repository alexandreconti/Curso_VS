using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesChallenge
{
    class Boss : Employee
    {
        protected string CompanyCar { get; set; }

        public Boss(string name, string firstName, double salary, string companyCar) :
            base(name, firstName, salary)
        {
            CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("{0} é o chefe.", this.FirstName);
        }
    }
}
