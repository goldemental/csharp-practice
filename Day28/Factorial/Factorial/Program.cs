using System;

namespace Factorial
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            int result = Factorial(number);

            Console.WriteLine("Factorial of {0} is {1}", number, result);
        }

        static int Factorial(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }

            return result;
        }
    }
}