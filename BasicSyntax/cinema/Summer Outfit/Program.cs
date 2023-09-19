using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int deegre = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            if (timeOfDay=="Morning")
            {
                if (10 <= deegre && deegre <= 18) 
                {
                    Console.WriteLine($"It's {deegre} degrees, get your {"Sweatshirt"} and {"Sneakers"}.");
                }
                else if (18 < deegre&&deegre <= 24)
                {
                    Console.WriteLine($"It's {deegre} degrees, get your {"Shirt"} and {"Moccasins"}.");
                }
                else if (deegre >= 25)
                {
                    Console.WriteLine($"It's {deegre} degrees, get your {"T-Shirt"} and {"Sandals"}.");
                }
            }
            if (timeOfDay == "Afternoon")
            {
                if (10 <= deegre && deegre <= 18)
                {
                    Console.WriteLine($"It's {deegre} degrees, get your {"Shirt"} and {"Moccasins"}.");
                }
                else if (18 < deegre && deegre <= 24)
                {
                    Console.WriteLine($"It's {deegre} degrees, get your {"T-Shirt"} and {"Sandals"}.");
                }
                else if (deegre >= 25)
                {
                    Console.WriteLine($"It's {deegre} degrees, get your {"Swim Suit"} and {"Barefoot"}.");
                }
            }
            if (timeOfDay == "Evening")
            {
                if (10 <= deegre && deegre <= 18)
                {
                    Console.WriteLine($"It's {deegre} degrees, get your {"Shirt"} and {"Moccasins"}.");
                }
                else if (18 < deegre && deegre <= 24)
                {
                    Console.WriteLine($"It's {deegre} degrees, get your {"Shirt"} and {"Moccasins"}.");
                }
                else if (deegre >= 25)
                {
                    Console.WriteLine($"It's {deegre} degrees, get your {"Shirt"} and {"Moccasins"}.");
                }
            }
        }
    }
}
