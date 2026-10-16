using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Person_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee example = new Employee() { FirstName = "Sample", LastName = "Student" };
            IQuittable Dan = new Employee() { FirstName = "Dan", LastName = "Theman"};

            example.SayName();
            example.Quit();

            Dan.Quit();
        }
    }
}
