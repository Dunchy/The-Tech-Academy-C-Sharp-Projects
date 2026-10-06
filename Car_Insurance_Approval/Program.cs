using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Approval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            int speedingTickets;

            bool hasDUI;
            bool isQualified;

            Console.WriteLine("Follow along with this quick questionaire and we will let you know if you are approved for car insurance");

            age = IntInputParse("Question 1: What is your age?");
            hasDUI = BoolInputParse("Have you ever had a DUI");
            speedingTickets = IntInputParse("How many speeding tickets do you have?");

            if ((age > 15) && (hasDUI == false) && (speedingTickets <= 3))
            {
                isQualified = true;
            }

            else
            {
                isQualified = false;
            }



            Console.WriteLine("What is your age?");
            Console.WriteLine(age);
            Console.WriteLine("Have you ever had a DUI");
            Console.WriteLine(hasDUI);
            Console.WriteLine("How many speeding tickets do you have?");
            Console.WriteLine(speedingTickets);
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);

        }

        static int IntInputParse(string question)
        {
            int parsedInt;

            bool wasParsed = false;

            Console.WriteLine(question);

            while(!wasParsed)
            {
                if (!int.TryParse(Console.ReadLine(), out parsedInt))
                {
                    Console.WriteLine("Your input was invalid, try again");
                    Console.WriteLine(question);
                }

                else
                {
                    wasParsed = true;
                    return parsedInt;
                }
            }
            return 0;
        }

        static bool BoolInputParse(string question)
        {
            string answer;

            Console.WriteLine(question);
            answer = Console.ReadLine().ToLower();

            while ((answer != "yes") && (answer != "no"))
            {
                Console.WriteLine("Please Answer with either yes or no.");
                Console.WriteLine(question);
                answer = Console.ReadLine().ToLower();
            }
            
            if (answer == "yes")
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}