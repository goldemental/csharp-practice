using System;

namespace GuessingGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101);

            int guess = 0;

            while (guess != secretNumber)
            {
                Console.WriteLine("Guess the number (1-100):");
                guess = int.Parse(Console.ReadLine());

                if (guess > secretNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("Correct! You guessed the number.");
                }
            }
        }
    }
}