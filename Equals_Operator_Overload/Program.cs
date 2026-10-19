using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals_Operator_Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee test1 = new Employee();
            Employee test2 = new Employee();

            test1.FirstName = "Jackie";
            test1.LastName = "Chan";
            test1.ID = 426;

            test1.FirstName = "Jet";
            test1.LastName = "Li";
            test1.ID = 224;

            Console.WriteLine(test1 == test2);
            Console.WriteLine(test1 == test1);
            Console.WriteLine(test1 != test2);
            Console.WriteLine(test1 != test1);
        }
    }
}
