﻿namespace _05.Number100_200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            if (num1 < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (num1 >= 100 && num1 <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
