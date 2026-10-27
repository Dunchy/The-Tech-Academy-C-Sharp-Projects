using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hours;
            bool inputWasParsed = false;
            DateTime startingTime = DateTime.Now;
            Console.WriteLine(startingTime);
            Console.Write("Give me a number and I will tell you what time it will be in that many hours: ");

            while (!inputWasParsed)
            {
                if (double.TryParse(Console.ReadLine().ToLower(), out hours))
                {
                    Console.WriteLine("In {0} hours it will be {1}", hours, startingTime.AddHours(hours));

                }
                else
                {
                    Console.Write("The number you entered was not valid. Please enter a whole number: ");
                }
            }
            Console.ReadLine();
        }
    }
}
