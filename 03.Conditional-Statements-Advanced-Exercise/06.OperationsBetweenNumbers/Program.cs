using System;

namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            string oddOrEven;
  
            if (operation == '+' || operation == '-' || operation == '*')
            {
                int result = 0;
                if (operation == '+')
                    result = n1 + n2;
                else if (operation == '-')
                    result = n1 - n2;
                else if (operation == '*')
                    result = n1 * n2;
                oddOrEven = result % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"{n1} {operation} {n2} = {result} - {oddOrEven}");
            }
            else if (operation == '/')
            {
                if (n2 == 0)
                    Console.WriteLine($"Cannot divide {n1} by zero");
                else
                {
                    double result = (double)n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {result:F2}");
                }
            }
            else if (operation == '%')
            {
                if (n2 == 0)
                    Console.WriteLine($"Cannot divide {n1} by zero");
                else
                {
                    int result = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
            }
            else
            {
               
            }

        }
    }
}
