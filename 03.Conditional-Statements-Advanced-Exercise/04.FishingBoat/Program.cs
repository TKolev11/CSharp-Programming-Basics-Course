namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());

            double boatRent = 0;

            switch (season)
            {
                case "Spring":
                    boatRent = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    boatRent = 4200;
                    break;
                case "Winter":
                    boatRent = 2600;
                    break;
            }

        
            if (fishermenCount <= 6)
            {
                boatRent *= 0.9;
            }
            else if (fishermenCount <= 11)
            {
                boatRent *= 0.85;
            }
            else
            {
                boatRent *= 0.75;
            }

            if (fishermenCount % 2 == 0 && season != "Autumn")
            {
                boatRent *= 0.95;
            }

            double remainingBudget = budget - boatRent;

            if (remainingBudget >= 0)
            {
                Console.WriteLine($"Yes! You have {remainingBudget:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(remainingBudget):F2} leva.");
            }
        }
    }
}
