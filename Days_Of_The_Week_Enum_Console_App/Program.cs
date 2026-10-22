using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_Of_The_Week_Enum_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DaysOfTheWeek today = new DaysOfTheWeek();
            bool isParsed = false;
            string userInput;

            while (!isParsed)
            {
                Console.WriteLine("Please enter a day of the week");
                userInput = Console.ReadLine();

                try
                {
                    // Attempts to parse the user input as a DaysOfTheWeek enum and ignores the case of the input
                    today = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput, true);

                    //If an exception doesn't happen above, the bool is switch to true and the loop can stop
                    isParsed = true;

                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred");
                }
            }

            Console.WriteLine(today);
            Console.ReadLine();
        }
        
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }
    }
}
