using System.Runtime.Intrinsics.Arm;

namespace _01.ReadText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                input = Console.ReadLine();
                if (input != "Stop")
                {
                    Console.WriteLine(input);
                }                
            } while (input != "Stop");
        }
    }
}
