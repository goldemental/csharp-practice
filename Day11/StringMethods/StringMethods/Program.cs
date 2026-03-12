using System;

namespace StringMethods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter your full name:");
            string fullName = Console.ReadLine();

            string upperName = fullName.ToUpper();

            Console.WriteLine("Your name in uppercase is: {0}", upperName);
        }
    }
}