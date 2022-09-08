using System;
using static System.Console;

namespace Parttime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("How many hours do you work per week");
            int hours = int.Parse(ReadLine());
            string workertype = null;
            if (hours >= 40)
            {
                workertype = "full-time";
            }
            else if (hours < 40)
            {
                workertype = "part-time";
            }
            else
            {
                WriteLine("well {0} is not valid", hours);
            }
            WriteLine("you are a {0} employee", workertype);
        }
    }
}
