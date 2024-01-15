namespace _5.GodzillavsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int numOfExtras = int.Parse(Console.ReadLine());
            double dressForExtras = double.Parse(Console.ReadLine());

            double decorCost = filmBudget * 0.10;
            double dressCost = dressForExtras * numOfExtras;
            double discount = 0.0;
            if (numOfExtras > 150)
            {
                discount = dressCost * 0.10;
            }
            double totalCost = (decorCost + dressCost) - discount;
            if (totalCost > filmBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalCost - filmBudget:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {filmBudget - totalCost:F2} leva left.");
            }
        }
    }
}
