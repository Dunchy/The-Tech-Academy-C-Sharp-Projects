using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Console_App
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string userAge;

            Console.WriteLine("Enter your age and I will tell you some fun facts about yourself");

            userAge = Console.ReadLine();

            Algebraic.DogYears(userAge);

            Algebraic.Y2K(userAge);

            Algebraic.FindGeneration(userAge);
        }


    }
}
