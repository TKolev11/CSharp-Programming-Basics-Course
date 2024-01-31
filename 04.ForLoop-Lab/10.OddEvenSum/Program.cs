namespace _10.OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nNums = int.Parse(Console.ReadLine());
            int result1 = 0;
            int result2 = 0;
            for (int i = 0; i < nNums; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    result1 += num;
                }
                else
                {
                    result2 += num;
                }
            }
           if (result1 == result2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {result1}");
            }
           else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(result1 - result2)}");
            }
        }
    }
}
