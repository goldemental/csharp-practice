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
                result = Add(number1, number2);
            }
            else if (op == "-")
            {
                result = Subtract(number1, number2);
            }
            else if (op == "*")
            {
                result = Multiply(number1, number2);
            }
            else if (op == "/")
            {
                result = Divide(number1, number2);
            }

            Console.WriteLine("Result: {0}", result);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}