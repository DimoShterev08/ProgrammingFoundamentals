using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourTest = int.Parse(Console.ReadLine());
            int minuteTest = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minuteArrivel = int.Parse(Console.ReadLine());
            int testTotalMinutes = hourTest * 60 + minuteTest;
            int totalMinutes = hourArrival * 60 + minuteArrivel;
            int totalTime = testTotalMinutes - totalMinutes;
            if (totalTime<0)
            {
                Console.WriteLine("Late");
                int timeAbsolute = Math.Abs(totalTime);
                if (timeAbsolute<60)
                {
                    Console.WriteLine($"{timeAbsolute} minutes after the start");
                }
                else
                {
                    int hour = timeAbsolute / 60;
                    int minutes = timeAbsolute % 60;
                    Console.WriteLine($"{hour}:{minutes:D2} hours after the start");
                }
            }
            else if (totalTime>30)
            {
                Console.WriteLine("Early");
                if (totalTime<60)
                {
                    Console.WriteLine($"{totalTime} minutes before the start");
                }
                else
                {
                    int hour = totalTime / 60;
                    int minutes = totalTime % 60;
                    Console.WriteLine($"{hour}:{minutes:D2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
                if (totalTime>0)
                {
                    Console.WriteLine($"{totalTime} minutes before the start");
                }
               

            }
        }
    }
}
