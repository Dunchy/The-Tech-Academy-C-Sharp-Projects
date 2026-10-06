using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p1hourlyRate;
            int p1weeklyHours;
            int p1totalWage;
            int p2hourlyRate;
            int p2weeklyHours;
            int p2totalWage;

            bool moreMoney;

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("\nPerson 1");
            Console.WriteLine("Enter the hourly wage:");
            if (!int.TryParse(Console.ReadLine(), out p1hourlyRate))
            {
                Console.WriteLine("Your input was invalid. Please ty again this is your last chance!");
                Console.WriteLine("\nEnter the hourly wage:");
                int.TryParse(Console.ReadLine(), out p1hourlyRate);
            }
            Console.WriteLine("Enter the hours worked per week:");
            if (!int.TryParse(Console.ReadLine(), out p1weeklyHours))
            {
                Console.WriteLine("Your input was invalid. Please ty again this is your last chance!");
                Console.WriteLine("\nEnter the hours worked per week:");
                int.TryParse(Console.ReadLine(), out p1weeklyHours);
            }

            Console.WriteLine("\nPerson 2");
            Console.WriteLine("Enter the hourly wage:");
            if (!int.TryParse(Console.ReadLine(), out p2hourlyRate))
            {
                Console.WriteLine("Your input was invalid. Please ty again this is your last chance!");
                Console.WriteLine("\nEnter the hourly wage:");
                int.TryParse(Console.ReadLine(), out p2hourlyRate);
            }
            Console.WriteLine("Enter the hours worked per week:");
            if (!int.TryParse(Console.ReadLine(), out p2weeklyHours))
            {
                Console.WriteLine("Your input was invalid. Please ty again this is your last chance!");
                Console.WriteLine("\nEnter the hours worked per week:");
                int.TryParse(Console.ReadLine(), out p2weeklyHours);
            }

            p1totalWage = p1hourlyRate * p1weeklyHours * 52;
            //Apparently there are 52 weeks per year
            Console.WriteLine("Annual Salary of Person 1:\n" + p1totalWage);

            p2totalWage = p2hourlyRate * p2weeklyHours * 52;
            Console.WriteLine("Annual Salary of Person 2:\n" + p2totalWage);

            moreMoney = p1totalWage > p2totalWage;
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + moreMoney);
        }
    }
}
