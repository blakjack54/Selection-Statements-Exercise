using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Favorite Number Guessing Game
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Guess my favorite number between 1 and 1000:");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too low.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high.");
            }
            else
            {
                Console.WriteLine("You guessed it!!!");
            }

            // Part 2: Favorite School Subject
            Console.WriteLine("\nWhat is your favorite school subject?");
            var subject = Console.ReadLine();

            // Switch statement to handle different subjects
            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is a great subject for problem-solving!");
                    break;
                case "science":
                    Console.WriteLine("Science helps us understand the world around us!");
                    break;
                case "history":
                    Console.WriteLine("History is essential to understand our past.");
                    break;
                case "english":
                    Console.WriteLine("English helps improve communication skills.");
                    break;
                case "art":
                    Console.WriteLine("Art encourages creativity and expression.");
                    break;
                default:
                    Console.WriteLine("That's an interesting subject!");
                    break;
            }
        }
    }
}