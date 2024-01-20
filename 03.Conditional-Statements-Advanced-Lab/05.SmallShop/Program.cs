﻿namespace _05.SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string product = Console.ReadLine();
         
            string city = Console.ReadLine();
         
            double quantity = double.Parse(Console.ReadLine());
          
            double price = 0.0;

            switch (city)
            {
                case "Sofia":
                    switch (product.ToLower())
                    {
                        case "coffee":
                            price = 0.50;
                            break;
                        case "water":
                            price = 0.80;
                            break;
                        case "beer":
                            price = 1.20;
                            break;
                        case "sweets":
                            price = 1.45;
                            break;
                        case "peanuts":
                            price = 1.60;
                            break;
                        default:                            
                            return;
                    }
                    break;
                case "Plovdiv":
                    switch (product.ToLower())
                    {
                        case "coffee":
                            price = 0.40;
                            break;
                        case "water":
                            price = 0.70;
                            break;
                        case "beer":
                            price = 1.15;
                            break;
                        case "sweets":
                            price = 1.30;
                            break;
                        case "peanuts":
                            price = 1.50;
                            break;
                        default:                          
                            return;
                    }
                    break;
                case "Varna":
                    switch (product.ToLower())
                    {
                        case "coffee":
                            price = 0.45;
                            break;
                        case "water":
                            price = 0.70;
                            break;
                        case "beer":
                            price = 1.10;
                            break;
                        case "sweets":
                            price = 1.35;
                            break;
                        case "peanuts":
                            price = 1.55;
                            break;
                        default:                            
                            return;
                    }
                    break;
                default:                   
                    return;
            }

            
            double totalPrice = quantity * price;
            Console.WriteLine(totalPrice);
        }

    }
   
}
