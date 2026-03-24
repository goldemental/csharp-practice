using System;

namespace LoopsWithArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter number {0}:", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("The sum of the numbers is {0}.", sum);
        }
    }
}