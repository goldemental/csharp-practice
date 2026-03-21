using System;

namespace TryCatch
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("You entered: {0}", number);
            }
            catch
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }
    }
}