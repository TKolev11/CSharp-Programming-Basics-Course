﻿namespace _04.EvenPowersof2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine((int)Math.Pow(2, i));
                }                              
            }

        }
    }
}
