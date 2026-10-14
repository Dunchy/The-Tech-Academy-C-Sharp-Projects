using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Console_App
{
    internal class Algebraic
    {
        public static void DogYears(string userAge)
        {
            int age = IntInputParse(userAge);
            // It used to be that people would say that 1 human year was 7 dog years. That might not be the case anymore.
            Console.WriteLine("You are " + (age * 7) + " in dog years");
        }

        public static void Y2K(string userAge)
        {
            int yearsSinceY2K = 26;
            int ageY2K = IntInputParse(userAge) - yearsSinceY2K;

            if (ageY2K <= 0)
            {
                Console.WriteLine("You were either a baby or not born yet when Y2K happened");
            }
            else
            {
                Console.WriteLine("You were " + ageY2K + " years old when YSK happened");
            }
        }

        // I actually couldn't think of a third thing so I am making this up on this spot
        public static void FindGeneration(string userAge)
        {
            int age = IntInputParse(userAge);

            int alphaMin = 2;
            int alphaMax = 13;
            int zoomerMin = 14;
            int zommerMax = 29;
            int millennialMin = 30;
            int millennialMax = 45;
            int genxMin = 46;
            int genxMax = 61;
            int boomerMin = 62;
            int boomerMax = 80;
            int silentMin = 81;
            int silentMax = 98;

            if (age >= alphaMin && age <= alphaMax)
            {
                Console.WriteLine("You are a part of Gen Alpha");
            }

            else if (age >= zoomerMin && age <= zommerMax)
            {
                Console.WriteLine("You are a Zoomer");
            }
            else if (age >= millennialMin && age <= millennialMax)
            {
                Console.WriteLine("You are a Millennial");
            }
            else if (age >= genxMin && age <= genxMax)
            {
                Console.WriteLine("You are a part of Gen X");
            }
            else if (age >= boomerMin && age <= boomerMax)
            {
                Console.WriteLine("You are a Baby Boomer");
            }
            else if (age >= silentMin && age <= silentMax)
            {
                Console.WriteLine("You are a part of the Silent Generation");
            }
            else if (age > silentMax)
            {
                Console.WriteLine("You are sadly probably not around anymore");
            }
            else
            {
                Console.WriteLine("You are probably too young to even read this so how did you even get this program to run?");
            }

        }

        static int IntInputParse(string age)
        {
            int parsedInt;

            bool wasParsed = false;

            while (!wasParsed)
            {
                if (!int.TryParse(age, out parsedInt))
                {
                    Console.WriteLine("Your input was invalid, try again");
                    Console.WriteLine("Enter your age and I will tell you some fun facts about yourself");

                    age = Console.ReadLine();
                }

                else
                {
                    wasParsed = true;
                    return parsedInt;
                }
            }
            return 0;
        }
    }
}
