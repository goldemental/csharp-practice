using System;

namespace TwoDArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] matrix =
            {
                {1, 2},
                {3, 4}
            };

            Console.WriteLine("Matrix elements:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(matrix[i, j]);
                }
            }
        }
    }
}