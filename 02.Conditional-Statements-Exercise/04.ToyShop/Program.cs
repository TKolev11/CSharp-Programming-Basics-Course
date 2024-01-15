using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            int puzzlesCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());


            double puzzlePrice = 2.60;
            double dollPrice = 3.00;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2.00;


            double totalCost = puzzlesCount * puzzlePrice +
                              dollsCount * dollPrice +
                              bearsCount * bearPrice +
                              minionsCount * minionPrice +
                              trucksCount * truckPrice;


            if (puzzlesCount + dollsCount + bearsCount + minionsCount + trucksCount >= 50)
            {
                totalCost -= totalCost * 0.25;
            }


            totalCost -= totalCost * 0.10;


            if (totalCost >= excursionPrice)
            {
                double remainingMoney = totalCost - excursionPrice;
                Console.WriteLine($"Yes! {remainingMoney:F2} lv left.");
            }
            else
            {
                double neededMoney = excursionPrice - totalCost;
                Console.WriteLine($"Not enough money! {neededMoney:F2} lv needed.");
            }
        }
    }
}
