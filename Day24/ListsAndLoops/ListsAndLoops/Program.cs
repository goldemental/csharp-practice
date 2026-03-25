using System;
using System.Collections.Generic;

namespace ListsAndLoopsDay24
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = new List<int>
            {
                1,
                4,
                2,
                6,
                3
            };

            Console.WriteLine("Numbers greater than 3:");

            foreach (int number in numbers)
            {
                if (number > 3)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}