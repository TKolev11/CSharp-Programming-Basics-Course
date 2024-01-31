namespace _09.LeftandRight_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nNumbers = int.Parse(Console.ReadLine());
            int num = 0;
            int left = 0;
            int right = 0;
            for (int i = 0; i < nNumbers; i++)
            {
                num = int.Parse(Console.ReadLine());
                left += num;
            } 
            for (int i = 0; i < nNumbers; i++)
            {
                num = int.Parse(Console.ReadLine());
                right += num;
            }
            if (left == right)
            {
                Console.WriteLine($"Yes, sum = {left}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(right-left)}");
            }
        }
    }
}
