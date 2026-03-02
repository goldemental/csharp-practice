namespace DataTypes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            int number2 = int.Parse(Console.ReadLine());
            int sum = number1 + number2;
            
            Console.WriteLine("The sum of {0} and {1} is {2}.", number1, number2, sum);
        }
    }
}