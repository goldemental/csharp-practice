using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> fruits = new List<string>
            {
                "Apple",
                "Banana",
                "Peach",
                "Dragon Fruit",
                "Strawberry"
            };

            Console.WriteLine("My favorite fruits:");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}