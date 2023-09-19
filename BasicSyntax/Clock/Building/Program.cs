using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            for (int f = floor; f >= 1; f--)
            {
                for (int r = 0; r < rooms; r++)
                {
                    if (f==floor)
                    {
                        Console.Write($"L{f}{r} ");
                    }
                    else if (f%2==1)
                    {
                        Console.Write($"A{f}{r} ");
                    }
                    else
                    {
                        Console.Write($"O{f}{r} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
