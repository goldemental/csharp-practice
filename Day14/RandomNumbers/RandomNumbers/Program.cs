using System;

namespace RandomNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            Console.WriteLine("Guess the number (between 1 and 100):");
            int guess = int.Parse(Console.ReadLine());
            if (guess == randomNumber)
            {
                Console.WriteLine("Correct! You guessed the number.");
            }
            else
            {
                Console.WriteLine("Wrong guess. The number was {0}.", randomNumber);
            }
        }
    }
}