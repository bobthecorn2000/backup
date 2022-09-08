//tyler forsgren
// 9/6/22
using System;
using System.Data;
using static System.Console;

namespace DailyTemp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int dailytemp;
            int total = 0;
            int counter = 0;
            double average;

            WriteLine("Enter a daily temperature or 999 to exit ");
            dailytemp = Convert.ToInt32(ReadLine());

            while (dailytemp != 999)
            {
                if (dailytemp <= -20 || dailytemp >= 130)
                    WriteLine("* Invalid temperature - Must be between -20 and 130 *");
                else
                {
                    total += dailytemp;
                    ++counter;
                }
                WriteLine("Enter a credit score or 999 to exit: ");
                dailytemp = Convert.ToInt32(ReadLine());
            }
            average = (double)total / counter;
            WriteLine("The average credit score is: {0}", average.ToString("f2"));


        }
    }
}
