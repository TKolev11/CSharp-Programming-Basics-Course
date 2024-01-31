namespace _08.Numbersequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nNumbers = int.Parse(Console.ReadLine());
            int number = 0;
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            for (int i = 0; i < nNumbers; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                if (number < minNumber)
                {                 
                    minNumber = number;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
