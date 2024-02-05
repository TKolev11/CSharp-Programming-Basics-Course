namespace _06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
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
                    if (currentNumber > maxNumber) 
                    {
                        maxNumber = currentNumber;
                    }
                   
                }                
            }
            Console.WriteLine(maxNumber);
        }
    }
}
