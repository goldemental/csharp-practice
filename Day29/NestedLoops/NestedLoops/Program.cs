using System;

namespace NestedLoops
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    int result = i * j;
                    Console.Write("{0}\t", result);
                }

                Console.WriteLine();
            }
        }
    }
}