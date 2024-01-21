namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            switch (city)
            {
                case "Sofia":
                    {
                        if (0 <= sales && sales <= 500) {
                            Console.WriteLine($"{sales * 0.05:F2}");
                        }
                        else if (500 < sales && sales <= 1000)
                        {
                            Console.WriteLine($"{sales * 0.07:F2}");
                        }
                        else if (1000 < sales && sales <= 10000)
                        {
                            Console.WriteLine($"{sales * 0.08:F2}");
                        }
                        else if (sales > 10000)
                        {
                            Console.WriteLine($"{sales * 0.12:F2}");
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    }
                case "Varna":
                    {
                        if (0 <= sales && sales <= 500)
                        {
                            Console.WriteLine($"{sales * 0.045:F2}");
                        }
                        else if (500 < sales && sales <= 1000)
                        {
                            Console.WriteLine($"{sales * 0.075:F2}");
                        }
                        else if (1000 < sales && sales <= 10000)
                        {
                            Console.WriteLine($"{sales * 0.10:F2}");
                        }
                        else if (sales > 10000)
                        {
                            Console.WriteLine($"{sales * 0.13:F2}");
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    }
                case "Plovdiv":
                    {
                        if (0 <= sales && sales <= 500)
                        {
                            Console.WriteLine($"{sales * 0.055:F2}");
                        }
                        else if (500 < sales && sales <= 1000)
                        {
                            Console.WriteLine($"{sales * 0.08:F2}");
                        }
                        else if (1000 < sales && sales <= 10000)
                        {
                            Console.WriteLine($"{sales * 0.12:F2}");
                        }
                        else if (sales > 10000)
                        {
                            Console.WriteLine($"{sales * 0.145:F2}");
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("error");
                        break;
                    }
            }
        }
    }
}
