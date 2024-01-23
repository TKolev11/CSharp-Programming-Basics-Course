namespace _02.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celsium = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string outfit;
            string shoes;
            if (10 <= celsium && celsium <= 18)
            {
                if (timeOfDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                    Console.WriteLine($"It's {celsium} degrees, get your {outfit} and {shoes}.");
                }
                else if (timeOfDay == "Afternoon" || timeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {celsium} degrees, get your {outfit} and {shoes}.");
                }
            }
            else if (18 < celsium && celsium <= 24)
            {
             if (timeOfDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine($"It's {celsium} degrees, get your {outfit} and {shoes}.");
                }
             else if (timeOfDay == "Morning" || timeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {celsium} degrees, get your {outfit} and {shoes}.");
                }
            }
            else if (celsium >= 25)
            {
              if (timeOfDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine($"It's {celsium} degrees, get your {outfit} and {shoes}.");
                }
              else if (timeOfDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                    Console.WriteLine($"It's {celsium} degrees, get your {outfit} and {shoes}.");
                }
             else if (timeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {celsium} degrees, get your {outfit} and {shoes}.");
                }

            }
            
        }
    }
}
