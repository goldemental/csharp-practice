using System;

namespace BooleanMethods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            bool isPositive = IsPositive(number);

            Console.WriteLine("Is the number positive? {0}", isPositive);
        }

        static bool IsPositive(int number)
        {
            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}