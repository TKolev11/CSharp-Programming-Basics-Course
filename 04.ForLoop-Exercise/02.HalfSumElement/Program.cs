namespace _02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nNumbers = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sum = 0;
            int num = 0;
            
            for (int i = 0; i < nNumbers; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > maxNumber)
                {
                    maxNumber = num;
                }                             
            }
            if (sum - maxNumber == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                sum -= maxNumber;
                Console.WriteLine("No");                   
                Console.WriteLine($"Diff = {Math.Abs(maxNumber - sum)}");       
            }
        }
    }
}
