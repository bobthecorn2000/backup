using System;
using static System.Console;

namespace animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("enter an amount of legs");
            int num = int.Parse(ReadLine());
            if (num == 2)
            {
                Console.WriteLine("your animal is a mammal");
            }
            else
            {
                Console.WriteLine("your animal is a reptile");
            }
        }
    }
}
