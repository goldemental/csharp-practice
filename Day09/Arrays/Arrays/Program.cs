namespace ArraysDay9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 15, 20, 25 };

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            Console.WriteLine("The sum of the numbers is {0}.", sum);
        }
    }
}