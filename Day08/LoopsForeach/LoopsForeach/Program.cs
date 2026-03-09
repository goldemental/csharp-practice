namespace LoopsForeach
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] names = { "Alice", "Bob", "Charlie", "David", "Emma" };

            Console.WriteLine("Names in the list:");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
