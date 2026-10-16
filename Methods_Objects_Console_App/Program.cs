using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Objects_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee TestStudent = new Employee() { FirstName = "Sample", LastName = "Student", ID = 117323 };

            TestStudent.SayName();
        }
    }
}
