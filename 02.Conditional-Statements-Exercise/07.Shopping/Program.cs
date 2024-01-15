namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double videoCardPrice = 250;
            double peterBudget = double.Parse(Console.ReadLine());
            int quanityVideoCard = int.Parse(Console.ReadLine());
            int quanityProcessor = int.Parse(Console.ReadLine());
            int quanityRAM = int.Parse(Console.ReadLine());

            double videoCardCost = videoCardPrice * quanityVideoCard;
            double processorDiscount = 0.35;
            double ramDiscount = 0.10;

            double totalCost = videoCardCost + (videoCardCost * processorDiscount * quanityProcessor) + (videoCardCost * ramDiscount * quanityRAM);

            if (quanityVideoCard > quanityProcessor)
            {
                totalCost -= totalCost * 0.15;
            }
            if (peterBudget >= totalCost)
            {
                Console.WriteLine($"You have {peterBudget - totalCost:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalCost - peterBudget:F2} leva more!");
            }
        }
    }
}
