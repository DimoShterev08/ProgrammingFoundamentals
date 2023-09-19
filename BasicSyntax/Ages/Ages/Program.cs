namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek= Console.ReadLine();
            double priceOnePerson = 0;
            double totalPrice = 0;
            if (typeOfGroup=="Students")
            {
                if (dayOfWeek == "Friday")
                {
                    priceOnePerson = 8.45;
                }
                else if (dayOfWeek =="Saturday")
                {
                    priceOnePerson = 9.80;
                }
                else if(dayOfWeek =="Sunday")
                {
                    priceOnePerson = 10.46;
                }
                totalPrice = countPeople * priceOnePerson;
                if (countPeople>=30) 
                {
                    totalPrice=totalPrice * 0.85;
                }
            }
            if(typeOfGroup=="Business")
            {
                if (dayOfWeek == "Friday")
                {
                    priceOnePerson = 10.9;
                }
                else if (dayOfWeek == "Saturday")
                {
                    priceOnePerson = 15.6;
                }
                else if (dayOfWeek == "Sunday")
                {
                    priceOnePerson = 16;
                }
                totalPrice = countPeople * priceOnePerson;
                if (countPeople>=100)
                {
                    totalPrice = (countPeople - 10) * priceOnePerson;
                }
            }
            if (dayOfWeek =="Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    priceOnePerson = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    priceOnePerson = 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    priceOnePerson = 22.50;
                }
                totalPrice = countPeople * priceOnePerson;
                if (countPeople>=10 && countPeople<=20) 
                {
                    totalPrice = totalPrice * 0.95; 
                }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}