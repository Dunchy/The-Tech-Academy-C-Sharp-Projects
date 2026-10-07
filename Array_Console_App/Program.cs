using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selectedIndex;
            bool keepPlaying = true;

            string[] stringArray = new string[] { "Minecraft", "Call of Duty", "League of Legends", "Wardogs", "Deadlock", "Overwatch", "Battlefield", "GTA", "Hytale", "World of Warcraft" };

            while (keepPlaying)
            {
                Console.WriteLine("Pick a number between 1 and 10 and I will recommend a game to play");
                selectedIndex = IndexSelector(Console.ReadLine());
                Console.WriteLine(stringArray[selectedIndex -1]);
                Console.WriteLine("Do you want to keep playing? yes/no");

                if (Console.ReadLine().ToLower() == "yes")
                {
                    continue;
                }

                else
                {
                    keepPlaying = false;
                }
            }

        }

        static int IndexSelector(string input)
        {
            int parsedInt;

            while (!int.TryParse(input, out parsedInt) || parsedInt < 1 || parsedInt > 10)
            {
                Console.WriteLine("Invalid entry. Please enter a number between 1 and 10:");
                input = Console.ReadLine();
            }

            return parsedInt;
        }
    }
}
