using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Employee_Console_App
{
    internal class Employee<T>: Person
    {
        public List<T> Things { get; set; }
    }
}
