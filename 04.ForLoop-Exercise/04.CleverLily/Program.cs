namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double moneySaved = 0;
      
            int toysCounter = 0;
            int brotherTax = 1;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneySaved += (i / 2) * 10.00 - 1.00;
                }
                else
                {
                    toysCounter++;
                }
            }

            moneySaved += toysCounter * toyPrice;


            if (moneySaved >= laundryPrice)
            {
                Console.WriteLine($"Yes! {moneySaved - laundryPrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {laundryPrice - moneySaved:F2}");
            }
    
        }
    }
}
