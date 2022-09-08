using System;
using static System.Console;
namespace zero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(ReadLine());
            if (num < 0)
            {
                Console.WriteLine("the value of {0} is less then 0", num);
            }
            else if (num == 0)
            {
                Console.WriteLine("the value of {0} is equal to 0", num);
            }
            else
            {
                Console.WriteLine("the value of {0} is greater then 0", num);
            }
        }
    }
}
