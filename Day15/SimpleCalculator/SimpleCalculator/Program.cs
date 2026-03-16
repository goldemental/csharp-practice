using System;

namespace SimpleCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an operator (+, -, *, /):");
            string op = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            int number2 = int.Parse(Console.ReadLine());

            int result = 0;

            if (op == "+")
            {
                result = number1 + number2;
            }
            else if (op == "-")
            {
                result = number1 - number2;
            }
            else if (op == "*")
            {
                result = number1 * number2;
            }
            else if (op == "/")
            {
                result = number1 / number2;
            }

            Console.WriteLine("Result: {0}", result);
        }
    }
}