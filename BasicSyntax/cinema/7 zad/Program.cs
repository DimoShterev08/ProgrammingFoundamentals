using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_zad
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double pricePerNightStudio = 0;
            double pricePerNightAp = 0;
            if (month == "May" || month == "October")
            {
                pricePerNightStudio = 50;
                pricePerNightAp = 65;
                if (nights > 7 && nights < 14)
                {
                    pricePerNightStudio = pricePerNightStudio - (pricePerNightStudio * 0.05);
                }
                else if (nights > 14)
                {
                    pricePerNightStudio = pricePerNightStudio - (pricePerNightStudio * 0.3);
                }
            }
            else if (month == "June" || month == "September")
            {
                pricePerNightStudio = 75.20;
                pricePerNightAp = 68.70;
                if (nights > 14)
                {
                    pricePerNightStudio = pricePerNightStudio - (pricePerNightStudio * 0.2);
                }

            }
            else if (month == "July" || month == "August")
            {
                pricePerNightStudio = 76;
                pricePerNightAp = 77;
            }

            if (nights > 14)
            {
                pricePerNightAp = pricePerNightAp - (pricePerNightAp * 0.1);
            }

            double totalPriceStudio = nights * pricePerNightStudio;
            double totalPriceAp = nights * pricePerNightAp;
            
            Console.WriteLine($"Apartment: {totalPriceAp:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");

        }
    }
}
