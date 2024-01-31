namespace _07.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nNumbers = int.Parse(Console.ReadLine());
            int number = 0;
            int result = 0;
            for (int i = 0; i < nNumbers; i++) 
            {
                number = int.Parse(Console.ReadLine());
                result += number;
            }
            Console.WriteLine(result);
        }
    }
}
