namespace WhileLoop
{
    internal class Program
        {
            private static void Main(string[] args)
            {
                Console.WriteLine("please enter a number:");
                int number = int.Parse(Console.ReadLine());
                int counter = 1;
                
                while (counter <= number)
                { 
                        Console.WriteLine(counter);
                        counter++; 
                }
            }
        }
}
