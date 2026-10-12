using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Six_Part_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[5];

            // Using the < symbol for the loop
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine($"Enter a sentence explaining one of your favorite things #{i + 1}: ");
                stringArray[i] = Console.ReadLine();
            }

            Console.WriteLine("Here are your favorite things: ");

            // Was a foreach loop but changed it to a for loop
            for (int i = 1; i <= stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i - 1]);
            }

            // At first it was stringArray[0] == stringArray[0] which was always true and now it checks to see if the first 2 strings are the same
            // and makes you change the second one if they are the same
            while (stringArray[0] == stringArray[1])
            {
                Console.WriteLine("You cannot list your one of your favorite things twice!");
                Console.WriteLine("Enter a different favorite thing.");
                stringArray[1] = Console.ReadLine();
            }

            List<string> songList = new List<string> { "Irreplaceable", "Umbrella", "The Sweet Escape", "Big Girls Don't Cry", "Buy U a Drank" };

            string userGuess;

            bool guessIsCorrect = false;

            Console.WriteLine("Try to guess the top 5 songs from the year 2007:");

            // The loop keeps going until a correct song is chosen
            while (guessIsCorrect == false)
            {
                userGuess = Console.ReadLine();

                for (int i = 0; i < songList.Count; i++)
                {
                    if (userGuess.ToLower() == songList[i].ToLower())
                    {
                        Console.WriteLine("Yes, the song " + songList[i] + " is number " + (i + 1) + " on the top 5 list at index " + i);
                        guessIsCorrect = true;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (!guessIsCorrect)
                {
                    Console.WriteLine("Incorrect. Try again.");
                }
            }

            string selectedAnimal;
            bool animalExists = false;

            List<string> animalList = new List<string> { "dog", "cat", "moose", "dog", "rabbit", "goat" };

            Console.WriteLine("Pick one of these animals and I will tell you at which index it is located: dog, cat, moose, rabbit, and goat");

            // Basically the same as the last one except there are repeat items in the list
            while (!animalExists)
            {
                selectedAnimal = Console.ReadLine();

                for (int i = 0; i < animalList.Count; i++)
                {
                    if (selectedAnimal.ToLower() == animalList[i])
                    {
                        Console.WriteLine("The animal " + selectedAnimal + " is located at index " + i);
                        animalExists = true;
                    }

                    else
                    {
                        continue;
                    }
                }

                if (animalExists != true)
                {
                    Console.WriteLine("You did not pick an animal from the list!");
                    Console.WriteLine("Pick one of these animals and I will tell you at which index it is located: dog, cat, moose, rabbit, and goat");
                }
            }

            List<string> videoGameList = new List<string> { "Minecraft", "Call of Duty", "Wardogs", "Minecraft", "Counter Strike", "Valorant", "Call of Duty" };
            // Since foreach loops are structured differently, this index is here to  track how many times the foreach loop has ran
            int gameIndex = 0;

            foreach (string game in videoGameList)
            {
                for (int i = 0; i < gameIndex; i++)
                {
                    if (game == videoGameList[i])
                    {
                        Console.WriteLine("The game " + game + " at index " + gameIndex + " has already appeared in the list at index " + i);
                    }
                }

                gameIndex++;
            }
        }
    }
}

