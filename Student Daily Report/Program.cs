using System;

namespace Student_Daily_Report
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \n");
            Console.WriteLine("Student Daily Report \n \n");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine($"What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine($"What page number?");
            short pageNumber = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Do you need help with anything? Please answer \"true\" or \"false\"");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine();
            Console.WriteLine($"Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine($"How many hours did you study today?");
            short hoursStudied = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
