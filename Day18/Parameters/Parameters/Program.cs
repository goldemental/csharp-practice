using System;

namespace Parameters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            GreetUser(name);
        }

        static void GreetUser(string userName)
        {
            Console.WriteLine("Hello, {0}! Welcome.", userName);
        }
    }
}