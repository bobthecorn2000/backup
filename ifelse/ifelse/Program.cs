using System;
using static System.Console;
namespace ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("enter a number");
            int num = int.Parse(ReadLine());
            if (num >= 0)
            {
                Console.WriteLine(num + " is a positive number");
            }
            else
            {
                Console.WriteLine(num + " is a negative number");
            }
        }
    }
}
