namespace _07.MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }
                int currentNumber = 0;
                if (int.TryParse(input, out currentNumber))
                {
                    if (currentNumber < minNumber)
                    {
                        minNumber = currentNumber;
                    }

                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
