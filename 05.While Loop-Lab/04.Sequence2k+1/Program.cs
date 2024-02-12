using System.Runtime.InteropServices;

namespace _04.Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currentNumber = 0;                  
            while (currentNumber < number)
            {
                currentNumber = currentNumber * 2 + 1;
                if (currentNumber > number)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(currentNumber);
                }
            }          
        }
    }
}
