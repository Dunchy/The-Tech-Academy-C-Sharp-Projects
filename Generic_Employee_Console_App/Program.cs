using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Employee_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee<string> emp1 = new Employee<string>();
            Employee<int> emp2 = new Employee<int>();

            emp1.Things = new List<string> { "random", "dropables", "vindicator", "temporary" };
            emp2.Things = new List<int> { 5, 20, 40, 445 };

            foreach (string s in emp1.Things)
            {
                Console.WriteLine(s);
            }

            foreach (int num in emp2.Things)
            {
                Console.WriteLine(num);
            }
        }
    }
}
