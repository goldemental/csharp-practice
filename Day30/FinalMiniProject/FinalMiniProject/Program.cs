using System;

namespace FinalMiniProjectDay30
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[5];

            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine("\nResults:");
            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Average: {0}", average);
        }
    }
}