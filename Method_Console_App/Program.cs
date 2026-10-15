using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Method_Console_App
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int userAge;

            int dogYears;
            int ageY2K;
            int generation;

            Console.WriteLine("Enter your age and I will tell you some fun facts about yourself");

            userAge = Algebraic.IntInputParse(Console.ReadLine());

            dogYears = Algebraic.DogYears(userAge);

            ageY2K = Algebraic.Y2K(userAge);

            generation = Algebraic.FindGeneration(userAge);

            Console.WriteLine("You are {0} in dog years", dogYears);

            if (ageY2K <= 0)
            {
                Console.WriteLine("You were either a baby or not born yet when Y2K happened");
            }
            else
            {
                Console.WriteLine("You were " + ageY2K + " years old when Y2K happened");
            }

            switch (generation)
            {
                case 0:
                    Console.WriteLine("You are probably too young to even read this so how did you even get this program to run?");
                    break;
                case 1:
                    Console.WriteLine("You are a part of Gen Alpha");
                    break;
                case 2:
                    Console.WriteLine("You are a Zoomer");
                    break;
                case 3:
                    Console.WriteLine("You are a Millennial");
                    break;
                case 4:
                    Console.WriteLine("You are a part of Gen X");
                    break;
                case 5:
                    Console.WriteLine("You are a Baby Boomer");
                    break;
                case 6:
                    Console.WriteLine("You are a part of the Silent Generation");
                    break;
                case 7:
                    Console.WriteLine("You are very very old. Hang in there!");
                    break;

            }

        }
    }
}
