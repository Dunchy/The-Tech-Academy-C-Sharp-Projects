using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Package_Shipping_Quote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packageWeight;
            int packageWidth;
            int packageHeight;
            int packageLength;
            int packageQuote;

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the weight of the package:");
            packageWeight = VerifyPackageWeight(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
            }

            else
            {
                Console.WriteLine("Please enter the width of your package:");
                packageWidth = VerifyPackageDimensions(Console.ReadLine());

                Console.WriteLine("Please enter the height of your package:");
                packageHeight = VerifyPackageDimensions(Console.ReadLine());

                Console.WriteLine("Please enter the length of your package:");
                packageLength = VerifyPackageDimensions(Console.ReadLine());

                packageQuote = (packageHeight * packageWidth * packageLength * packageWeight) / 100;

                Console.WriteLine("Your estimated total for shipping this package is: $" + packageQuote + ".00");
            }



        }

        static int VerifyPackageWeight(string weight)
        {
            int parsedInt;

            bool wasParsed = false;

            while (!wasParsed)
            {
                if (!int.TryParse(weight, out parsedInt))
                {
                    Console.WriteLine("Your input ws invalid. Please enter a whole number value for the weight:");
                    weight = Console.ReadLine();
                }

                else
                {
                    wasParsed = true;
                    return parsedInt;
                }
            }

            return 51;
        }
        static int VerifyPackageDimensions(string size)
        {
            int parsedInt;

            bool wasParsed = false;

            while (!wasParsed)
            {
                if (!int.TryParse(size, out parsedInt))
                {
                    Console.WriteLine("Your input was invalid. Please enter a number:");
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
