using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int count= int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double priceFlower = 0;

            switch(typeFlower)
            {
                case "Roses":
                    priceFlower = 5;
                    break;
                case "Dahlias":
                    priceFlower = 3.80;
                    break;
                case "Tulips":
                    priceFlower = 2.80;
                    break;
                case "Narcissus":
                    priceFlower = 3;
                    break;
                case "Gladiolus":
                    priceFlower = 2.50;
                    break;

            }
            double totalPrice = count * priceFlower;

            if (count > 80 && typeFlower == "Roses")
            {
                totalPrice = totalPrice - 0.10 * totalPrice;
            }
            else if (count > 90 && typeFlower == "Dahlias") 
            {
                totalPrice = totalPrice - 0.15 * totalPrice;
            }
            else if (count > 80 && typeFlower == "Tulips")
            {
                totalPrice = totalPrice - 0.15 * totalPrice;
            }
            else if (count < 120 && typeFlower == "Narcissus")
            {
                totalPrice = totalPrice + 0.15 * totalPrice;
            }
            else if (count < 80 && typeFlower == "Gladiolus")
            {
                totalPrice = totalPrice + 0.20 * totalPrice;
            }
            if (budget>=totalPrice)
            {
                double leftSum = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {count} {typeFlower} and {leftSum:f2} leva left.");
                
               
            }
            else
            {
                double needSum = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {needSum:f2} leva more.");

            }
        }
    }
}
