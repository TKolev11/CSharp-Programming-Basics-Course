namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int input = 0;
            int sum = 0;
            do
            {
                input = int.Parse(Console.ReadLine());
                sum += input;
            }   while (sum < number);

            Console.WriteLine(sum);
        }
    }
}
