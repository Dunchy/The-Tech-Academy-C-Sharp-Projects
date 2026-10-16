using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            int intNumerator;
            int intResult;

            float floatNumerator;
            float floatResult;

            Console.WriteLine("Enter a number that will be divided in half");
            userInput = Console.ReadLine();

            if (int.TryParse(userInput, out intNumerator))
            {
                CoolClass.DivideByTwo(intNumerator, out intResult);
                Console.WriteLine("Result: {0}", intResult);
            }

            else if(float.TryParse(userInput, out floatNumerator))
            {
                CoolClass.DivideByTwo(floatNumerator, out floatResult);
                Console.WriteLine("Result: {0}", floatResult);
                ;           }

            else
            {
                Console.WriteLine("Your input does not register as a number so default values will be used instead.");
                CoolClass.DivideByTwo(num: 10, out intResult);
                Console.WriteLine("Result: {0}", intResult);
            }
        }
    }
}
