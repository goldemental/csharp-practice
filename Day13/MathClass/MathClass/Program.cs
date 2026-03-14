using System;

namespace MathClass
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            double number = double.Parse(Console.ReadLine());

            double squareRoot = Math.Sqrt(number);

            Console.WriteLine("The square root of {0} is {1}.", number, squareRoot);
        }
    }
}