﻿namespace _10.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 0 || number >= 100  && number <= 200)
            {
                
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
