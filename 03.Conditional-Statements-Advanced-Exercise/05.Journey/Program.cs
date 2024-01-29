namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double totalCost = 0;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    totalCost = budget * 0.3;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {totalCost:F2}");
                }
                else if (season == "winter")
                {
                    totalCost = budget * 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {totalCost:F2}");
                }
            }
            if (budget <= 1000 && budget > 100)
            {
                if (season == "summer")
                {
                    totalCost = budget * 0.4;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {totalCost:F2}");
                }
                else if (season == "winter")
                {
                    totalCost = budget * 0.8;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {totalCost:F2}");
                }
            }
            if (budget > 1000)
            {
                totalCost = budget * 0.9;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {totalCost:F2}");
            }
        }
    }
}
