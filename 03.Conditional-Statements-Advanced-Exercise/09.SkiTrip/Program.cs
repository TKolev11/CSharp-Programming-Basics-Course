namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 0;

            int stayDays = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string rate = Console.ReadLine();
            
            switch (typeOfRoom)
            {
                case "room for one person":
                    {
                        stayDays -= 1;
                        price = stayDays * 18;
                        break;
                    }
                case "apartment":
                    {
                        stayDays -= 1;
                        price = stayDays * 25;
                        if (stayDays < 10)
                        {
                            price -= price * 0.3;
                        }
                        else if (stayDays >= 10 && stayDays <= 15)
                        {
                            price -= price * 0.35;
                        }
                        else
                        {
                            price -= price * 0.5;
                        }
                         break;
                    }
                case "president apartment":
                    {
                        stayDays -= 1;
                        price = stayDays * 35;
                        if (stayDays < 10)
                        {
                            price -= price * 0.1;
                        }
                        else if (stayDays >= 10 && stayDays <= 15)
                        {
                            price -= price * 0.15;
                        }
                        else
                        {
                            price -= price * 0.20;
                        }
                        break;
                    }
            }
            if (rate == "positive")
            {
                price += price * 0.25;
            }
            else
            {
                price -= price * 0.10;
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}
