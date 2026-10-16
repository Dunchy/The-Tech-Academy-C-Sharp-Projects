using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Person_Program
{
    public class Employee: Person
    {

        public override void SayName()
        {
            Console.WriteLine("My name is {0} {1}", FirstName, LastName);
        }
    }
}
