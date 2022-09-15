using System;
using static System.Console;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = ReadLine();
            int i = name.Length;
            Console.Write("\nwww.");
            for (int j = 0; j < i; j++)
            {
                if (name.Substring(j, 1) == " ")
                {
                    continue;
                }
                else
                {
                    Console.Write(name.Substring(j, 1));
                }

            }
            Console.Write(".com");
        }
    }
}
