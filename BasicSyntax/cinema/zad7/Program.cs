using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string mathOperation = Console.ReadLine();
            switch(mathOperation)
            {
                case "+":
                    int sum = n1 + n2;
                    if (sum%2==0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {sum} - even");

                    }
                    else
                    {
                        Console.WriteLine($"{n1} + {n2} = {sum} - odd");
                    }
                    break;
                case "-":
                    int diff = n1 - n2;
                    if (diff%2==0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {diff} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} - {n2} = {diff} - odd");
                    }
                    break;
                case "*":
                    int po = n1 * n2;
                    if (po % 2 == 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {po} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} * {n2} = {po} - odd");
                    }
                    break;
                case "/":
                    if (n2==0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        double result = n1*1.0 / n2;
                        Console.WriteLine($"{n1} / {n2} = {result:f2}");
                    }
                   break;
                case "%":
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        int leftover = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {leftover}");
                    }
                    break;
            }
        }
    }
}
