namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalAmount = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "NoMoreMoney")
                {
                    break;
                }

                double amount;
                if (double.TryParse(input, out amount) && amount >= 0)
                {
                    totalAmount += amount;
                    Console.WriteLine($"Increase: {amount:F2}");
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
            }
            Console.WriteLine($"Total: {totalAmount:F2}");
        }
    }
}
