using System;

namespace Methods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            int result = Square(number);

            Console.WriteLine("The square of {0} is {1}.", number, result);
        }

        static int Square(int number)
        {
            return number * number;
        }
    }
}