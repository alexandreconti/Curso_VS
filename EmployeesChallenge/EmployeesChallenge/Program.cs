using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee rafael = new Employee("Rafael De Conti", "Rafael", 3000);

            rafael.Work();
            rafael.Pause();

            Boss lorenzo = new Boss("Lorenzo De Conti", "Lorenzo", 12345.45, "Fiat");

            lorenzo.Lead();

            Trainees alexandre = new Trainees("Alexandre De Conti", "Alexandre", 666, 4, 4);

            alexandre.Learn();
            alexandre.Work();


            Console.ReadKey();
        }
    }
}

/*Inheritance Challenge 2 - Employees, Bosses and Trainees
Seção 8, aula 81
Create a main class with a Main Method, then a base class Employee with the properties Name, 
FirstName, Salary and the methods Work() and Pause().

Create a deriving class boss with the propertie CompanyCar and the method Lead(). 
Create another deriving class of employees - trainees with the properties 
WorkingHours and SchoolHourse and a method Learn().

Override the methods Work() of the trainee class so that it indicates the working 
hours of the trainee.

Don’t forget to create the constructors.

Create an object of each of the three classes (with arbitrary values)

and call the methods, Lead() of Boss and Work() of Trainee.

Just print out the respective text, what the respective employees do.*/
