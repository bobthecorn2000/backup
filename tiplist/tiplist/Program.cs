using System;
using System.Linq;
using static System.Console;

namespace tiplist
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] Day = { "Sunday", "Monday", "Tuesday", "Wendsday", "Thursday", "Friday", "Saterday" };
            double[] tips = new double[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Enter tip for {Day[i]}");
                
                tips[i] = double.Parse(ReadLine());

            }
            Console.WriteLine($"your average tip was {tips.Average().ToString("c")}");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"{Day[i]}'s tip was " + (tips.Average() - tips[i]).ToString("c") + " from average");

                

            }
        }
    }
}
