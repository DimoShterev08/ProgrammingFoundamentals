using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination;
            string typeOfStay;
            if (budget<=100)
            {
                destination = "Bulgaria";
                if (season== "summer")
                {
                    budget = budget - (budget * 0.7);
                    typeOfStay = "Camp";
                }
                else
                {
                    budget = budget - (budget * 0.3);
                    typeOfStay = "Hotel";
                }
            }
            else if (budget<=1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    budget = budget - (budget * 0.6);
                    typeOfStay = "Camp";
                }
                else
                {
                    budget = budget - (budget * 0.2);
                    typeOfStay = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                budget = budget - (budget * 0.1); 
                typeOfStay = "Hotel";

            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfStay} - {budget:f2}");

        }
    }
}
