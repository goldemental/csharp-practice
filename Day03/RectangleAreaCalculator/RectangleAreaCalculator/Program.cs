namespace Operators
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of the rectangle:");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the width of the rectangle:");
            int width = int.Parse(Console.ReadLine());

            int area = length * width;
            Console.WriteLine("The area of the rectangle is {0}.", area);
        }
    }
}
