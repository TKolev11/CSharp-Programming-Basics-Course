namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nNumbers = int.Parse(Console.ReadLine());
            int number = 0;
            double p1Nums = 0; double p2Nums = 0; double p3Nums = 0; double p4Nums = 0; double p5Nums = 0;
            

            for (int i = 1; i <= nNumbers; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1Nums++;
                }
                else if (number >= 200 &&  number <= 399)
                {
                    p2Nums++;
                } 
                else if (number >= 400 &&  number <= 599)
                {
                    p3Nums++;
                } 
                else if (number >= 600 &&  number <= 799)
                {
                    p4Nums++;
                }
                else
                {
                    p5Nums++;
                }
            }
  
            double p1Result = (p1Nums / nNumbers) * 100;
            double p2Result = (p2Nums / nNumbers) * 100;
            double p3Result = (p3Nums / nNumbers) * 100;
            double p4Result = (p4Nums / nNumbers) * 100;
            double p5Result = (p5Nums / nNumbers) * 100;
            Console.WriteLine($"{p1Result:F2}%");
            Console.WriteLine($"{p2Result:F2}%");
            Console.WriteLine($"{p3Result:F2}%");
            Console.WriteLine($"{p4Result:F2}%");
            Console.WriteLine($"{p5Result:F2}%");
        }
    }
}
