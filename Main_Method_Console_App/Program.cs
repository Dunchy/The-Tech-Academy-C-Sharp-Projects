using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInt;
            float userFloat;
            string userString;

            Console.WriteLine("Time to do some math!\nFirst off, give me an integer");

            int.TryParse(Console.ReadLine(), out userInt);

            Console.WriteLine("{0} minus 7 is {1}", userInt, Overloaded.Mathmatical(userInt));

            Console.WriteLine("Now enter a decimal value");

            float.TryParse(Console.ReadLine(), out userFloat);

            Console.WriteLine("{0} multiplied by 100 is {1}", userInt, Overloaded.Mathmatical(userFloat));

            Console.WriteLine("Now enter another integer");

            userString = Console.ReadLine();

            Console.WriteLine("{0} plus 666 is {1}", userString, Overloaded.Mathmatical(userString));
        }
    }
}
