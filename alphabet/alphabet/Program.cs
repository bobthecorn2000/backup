using System;
using static System.Console;
namespace alphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character");
            char alph = char.Parse(ReadLine());

            if (alph >= 'A' && alph <= 'Z')
            {
                WriteLine("Uppercase");
            }
            else if (alph >= 'a' && alph <= 'z')
            {
                WriteLine("lowercase");
            }
            else 
            {
                WriteLine("Character is not alphabet");
            }

        }
    }
}
