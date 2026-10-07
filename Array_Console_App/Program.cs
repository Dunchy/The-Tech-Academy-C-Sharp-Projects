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

            string[] stringArray = new string[] { "Minecraft", "Call of Duty", "League of Legends", "Wardogs", "Deadlock", "Overwatch", "Battlefield", "GTA", "Hytale", "World of Warcraft" };
            int[] intArray = new int[] { 1, 5, 43, 67, 420, 360, 720, 12, 20, 4566};
            List<string> stringList = new List<string> {"red", "blue", "yellow", "purple", "green", "orange", "cyan", "beige", "violet", "grey"};

            Console.WriteLine("Pick a number between 1 and 10 and I will pick a gamet that you must play.");
            selectedIndex = IndexSelector(Console.ReadLine());
            Console.WriteLine("You must play " + stringArray[selectedIndex - 1]);

            Console.WriteLine("Pick a number between 1 and 10 to see how many hours you have to play that game.");
            selectedIndex = IndexSelector(Console.ReadLine());
            Console.WriteLine("You must play the game for " + intArray[selectedIndex - 1] + " hours.");

            Console.WriteLine("Pick a one last number and I'll guess your favorite color.");
            selectedIndex = IndexSelector(Console.ReadLine());
            Console.WriteLine("I guess that your favorite color is " + stringList[selectedIndex - 1]);
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
