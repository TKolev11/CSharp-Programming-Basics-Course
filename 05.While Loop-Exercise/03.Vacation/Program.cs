﻿using System;

namespace _03.Vacation
{
    internal class Program
    {
        private const int MaxSpendingCounter = 5;

        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int daysSpent = 0;
            int consecutiveSpendDays = 0;

            while (availableMoney < excursionPrice && consecutiveSpendDays < 5)
            {
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());

                if (action == "save")
                {
                    availableMoney += amount;
                    consecutiveSpendDays = 0;
                }
                else if (action == "spend")
                {
                    availableMoney -= amount;
                    consecutiveSpendDays++;
                }

                if (availableMoney < 0)
                {
                    availableMoney = 0;
                }

                daysSpent++;
            }

            if (consecutiveSpendDays == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysSpent);
            }
            else
            {
                Console.WriteLine($"You saved the money for {daysSpent} days.");
            }
        }
    }
}
