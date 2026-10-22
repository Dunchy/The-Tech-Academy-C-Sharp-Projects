using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
            new Employee { ID = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { ID = 2, FirstName = "Sarah", LastName = "Connor" },
            new Employee { ID = 3, FirstName = "Joe", LastName = "Miller" },
            new Employee { ID = 4, FirstName = "Elena", LastName = "Reyes" },
            new Employee { ID = 5, FirstName = "Marcus", LastName = "Vance" },
            new Employee { ID = 6, FirstName = "Sammy", LastName = "Granger" },
            new Employee { ID = 7, FirstName = "Juan", LastName = "Martinez" },
            new Employee { ID = 8, FirstName = "Andrew", LastName = "Dodd" },
            new Employee { ID = 9, FirstName = "Russell", LastName = "Jones" },
            new Employee { ID = 10, FirstName = "Xavier", LastName = "Vance" }
            };

            List<Employee> joeList = new List<Employee>();

            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    joeList.Add(emp);
                    Console.WriteLine(emp.FirstName + " " + emp.LastName);
                }
            }

            List<Employee> lambdaJoeList = employees.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee joe in lambdaJoeList)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName);
            }

            List<Employee> newEmployees = employees.Where(x => x.ID > 5).ToList();

            foreach (Employee emp in newEmployees)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }
        }
    }
}
