using System;
using System.Collections.Generic;
using static System.Console;

namespace largenum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 4, 2, 7, 1 };
            int[] Array2 = { 20, 70, 40, 90 };
            int[] Array3 = { 1, 2, 0 };
            Write("Array Values: ");
            for (int i = 0; i < Array1.Length; i++)
            {
                Console.Write($"{Array1[i]}, ");
            }
            Write("\nArray Values: ");
            for (int i = 0; i < Array2.Length; i++)
            {
                Console.Write($"{Array2[i]}, ");
            }
            Write("\nArray Values: ");
            for (int i = 0; i < Array3.Length; i++)
            {
                Console.Write($"{Array3[i]}, ");
            }
            Array.Sort(Array1);
            Array.Reverse(Array1);
            Array.Sort(Array2);
            Array.Reverse(Array2);
            Array.Sort(Array3);
            Array.Reverse(Array3);
            WriteLine("\n\nThe Highest values in each line are");
            Console.Write($"{Array1[0]}, ");
            Console.Write($"{Array2[0]}, ");
            Console.WriteLine($"{Array3[0]}");
        }
    }
}
