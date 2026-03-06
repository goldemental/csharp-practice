namespace SwitchStatement
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a day number (1-7):");
            int dayNumber = int.Parse(Console.ReadLine());

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Day {0} is Monday.", dayNumber);
                    break;
                case 2:
                    Console.WriteLine("Day {0} is Tuesday.", dayNumber);
                    break;
                case 3:
                    Console.WriteLine("Day {0} is Wednesday.", dayNumber);
                    break;
                case 4:
                    Console.WriteLine("Day {0} is Thursday.", dayNumber);
                    break;
                case 5:
                    Console.WriteLine("Day {0} is Friday.", dayNumber);
                    break;
                case 6:
                    Console.WriteLine("Day {0} is Saturday.", dayNumber);
                    break;
                case 7:
                    Console.WriteLine("Day {0} is Sunday.", dayNumber);
                    break;

                default:
                    Console.WriteLine("Invalid day number. Please enter a number between 1 and 7.");
                    break;
            }
        }
    }
}