using System;

namespace StringFormatting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your name is {name} and you are {age} years old.");
        }
    }
}