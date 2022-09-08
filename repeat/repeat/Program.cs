using System;
using static System.Console;
namespace repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to repeat: ");
            string value = ReadLine();
            Console.Write("\nEnter how many times to repeat the string: ");
            int i = int.Parse(ReadLine());
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine(value);
            }
            
        }
    }
}
