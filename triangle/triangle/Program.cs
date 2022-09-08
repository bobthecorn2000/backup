using System;
using static System.Console;

namespace triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            WriteLine("Enter a value for Side 1");
            int side1 = int.Parse(ReadLine());
            WriteLine("Enter a value for Side 2");
            int side2 = int.Parse(ReadLine());
            WriteLine("Enter a value for Side 3");
            int side3 = int.Parse(ReadLine());
            if (side1 == side2 && side2 == side3)
            {
                WriteLine("Equilateral triangle; All sides are equal");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                WriteLine("Isosceles triangle: Two sides are equal");
            }
            else if (side1 != side2 && side1 != side3 && side2 != side3)
            {
                WriteLine("no sides are equal");
            }
            else 
            {
                WriteLine("you done goofed");
            } 
        }
    }
}
