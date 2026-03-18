using System;

namespace ReturnValues
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int number2 = int.Parse(Console.ReadLine());

            int largerNumber = GetLargerNumber(number1, number2);

            Console.WriteLine("The larger number is {0}.", largerNumber);
        }

        static int GetLargerNumber(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}