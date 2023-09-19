using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols =int.Parse(Console.ReadLine());
            double countTickets = rows * cols;
            double priceTickets = 0;
            switch(type)
            {
                case "Premiere":
                    priceTickets = 12.00;
                    break;
                case "Normal":
                    priceTickets = 7.50;
                    break;
                case "Discount":
                    priceTickets = 5.00;
                    break;
                    
            }
            double profit = countTickets * priceTickets;
            Console.WriteLine($"{profit:F2} leva");
        }
    }
}
