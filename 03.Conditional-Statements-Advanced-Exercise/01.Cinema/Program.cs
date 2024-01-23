namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double premiere = 12.00;
            double normal = 7.50;
            double discount = 5;

            string typeOfScreening = Console.ReadLine();
            int colums = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            double income = 0;

            if (typeOfScreening == "Premiere")
            {
                income = colums * rows * premiere;
            }
            else if (typeOfScreening == "Normal")
            {
                income = colums * rows * normal;
            }
            else if (typeOfScreening == "Discount")
            {
                income = colums * rows * discount;
            }

            Console.WriteLine($"{income:F2}");
        }
    }
}
