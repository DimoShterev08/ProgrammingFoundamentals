using System.Data.SqlTypes;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputcoins = Console.ReadLine();
            double money = 0;
            while (inputcoins != "Start")
            {
                double amountOfCoin = double.Parse(inputcoins);
                if (amountOfCoin > 0.1)
                {
                    money += 0.1;
                }
                else if (amountOfCoin > 0.2)
                {
                    money += 0.1;
                }
                if (amountOfCoin > 0.5)
                {
                    money += 0.1;
                }
                if (amountOfCoin > 1)
                {
                    money += 2;
                }
    }
}