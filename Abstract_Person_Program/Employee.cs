using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Person_Program
{
    public class Employee: Person, IQuittable
    {

        public override void SayName()
        {
            Console.WriteLine("My name is {0} {1}", FirstName, LastName);
        }

        public void Quit()
        {
            Console.WriteLine("I {0} {1} officially quit this job! GOODBYE!", FirstName, LastName);
        }
    }
}
