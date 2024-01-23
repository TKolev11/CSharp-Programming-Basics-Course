namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double roses = 5.00;
            double dahlias = 3.80;
            double tulips = 2.80;
            double narcissus = 3.00;
            double gladiolus = 2.50;

            string flower = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double totalCost = 0;
            double discount = 0;
            switch (flower)
            {
                case "Roses":
                    {
                        totalCost = quantity * roses;
                        if (quantity > 80)
                        {
                            discount = totalCost * 0.10;
                            totalCost -= discount;
                        }
                        break;
                    }
                case "Dahlias":
                    {
                        totalCost = quantity * dahlias;
                        if (quantity > 90)
                        {
                            discount = totalCost * 0.15;
                            totalCost -= discount;
                        }
                        break;
                    }
                case "Tulips":
                    {
                        totalCost = quantity * tulips;
                        if (quantity > 80)
                        {
                            discount = totalCost * 0.15;
                            totalCost -= discount;
                        }
                        break;
                    } 
                case "Narcissus":
                    {
                        totalCost = quantity * narcissus;
                        if (quantity < 120)
                        {
                            discount = totalCost * 0.15;
                            totalCost += discount;
                        }
                        break;
                    }
                case "Gladiolus":
                    {
                        totalCost = quantity * gladiolus;
                        if (quantity < 80)
                        {
                            discount = totalCost * 0.20;
                            totalCost += discount;
                        }
                        break;
                    }
            }
            if (totalCost > budget)
            {
                Console.WriteLine($"Not enough money, you need {totalCost - budget:F2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {(double)budget - totalCost:F2} leva left.");
            }
        }
    }
}
