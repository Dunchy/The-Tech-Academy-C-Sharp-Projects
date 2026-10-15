using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Console_App
{
    internal class Algebraic
    {
        public static int DogYears(int age)
        {
            int dogyearMultiplier = 7;
            // It used to be that people would say that 1 human year was 7 dog years. That might not be the case anymore.
            return age * dogyearMultiplier;
        }

        public static int Y2K(int age)
        {
            int yearsSinceY2K = 26;
            int ageY2K = age - yearsSinceY2K;

            return ageY2K;
        }

        // I actually couldn't think of a third thing so I am making this up on this spot
        public static int FindGeneration(int age)
        {
            int babyKey = 0;
            int alphaKey = 1;
            int zoomerKey = 2;
            int millennialKey = 3;
            int genxKey = 4;
            int boomerKey = 5;
            int silentKey = 6;
            int elderlyKey = 7;

            int alphaMin = 2;
            int alphaMax = 13;
            int zoomerMin = 14;
            int zoomerMax = 29;
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
                return alphaKey;
            }
            else if (age >= zoomerMin && age <= zoomerMax)
            {
                return zoomerKey;
            }
            else if (age >= millennialMin && age <= millennialMax)
            {
                return millennialKey;
            }
            else if (age >= genxMin && age <= genxMax)
            {
                return genxKey;
            }
            else if (age >= boomerMin && age <= boomerMax)
            {
                return boomerKey;
            }
            else if (age >= silentMin && age <= silentMax)
            {
                return silentKey;
            }
            else if (age > silentMax)
            {
                return elderlyKey;
            }
            else
            {
                return babyKey;
            }
        }

        public static int IntInputParse(string age)
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
