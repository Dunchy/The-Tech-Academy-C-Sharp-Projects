using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int userNumber;

            List<int> numeratorList = new List<int>
            {
                67, 660, 440, 550, 323, 8, 1, 88, 984580958
            };

            Console.WriteLine("Enter a number to divide each number in the list by: ");
            userInput = Console.ReadLine();


            try
            {
                foreach (int number in numeratorList)
                {
                    userNumber = int.Parse(userInput);
                    Console.WriteLine(number / userNumber);
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please only enter whole numbers.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DON'T TRY TO DIVIDE BY ZERO ARE YOU CRAZY!?!?");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unknown error has occured. Please check your input and make sure you entered a whole, non-zero number");
            }
            finally
            {
                Console.WriteLine("The dividing program has been completed");
            }

            // This is here incase the finally section doesn't count as "outside" the try/catch block
            Console.WriteLine("Goodbye!");
        }
    }
}

