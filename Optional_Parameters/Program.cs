using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1;
            string num2;

            Console.WriteLine("Im going to add two numbers together. Give me 1 or 2 numbers:");
            Console.WriteLine("Enter the first number: ");

            num1 = Console.ReadLine();

            Console.WriteLine("Enter the second number or just press enter: ");

            num2 = Console.ReadLine();

            if (num2 != "" && num2 != null)
            {
                int firstNumber;
                int secondNumber;

                bool firstParseSuccess;
                bool secondParseSuccess;

                firstParseSuccess = int.TryParse(num1, out firstNumber);
                secondParseSuccess = int.TryParse(num2, out secondNumber);

                if (!firstParseSuccess || !secondParseSuccess)
                {
                    Console.WriteLine("One of the numbers you entered was not formatted right. Try to use whole numbers next time");
                }

                Console.WriteLine("Result: " + Optionality.Mathing(firstNumber, secondNumber));
            }
            else
            {
                int firstNumber;
                bool firstParseSuccess;

                firstParseSuccess = int.TryParse(num1, out firstNumber);

                if (!firstParseSuccess)
                {
                    Console.WriteLine("The number you entered was not formatted right. Try to use whole numbers next time");
                }

                Console.WriteLine("Result: " + Optionality.Mathing(firstNumber));
            }
        }
    }
}
