using System;
using static System.Console;

namespace zort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pnights = { 200, 200, 180, 180, 160, 160, 160, 145 };
            WriteLine("how many nights");
            int stay = int.Parse(ReadLine());
            int x = Array.BinarySearch(pnights, stay);
            
            if (stay >= 8)
            {
                WriteLine($"price per night is $145.00");
                WriteLine($"total for {stay} nights is {(145 * stay).ToString("c")}");
                
            }

            else 
            {
                if (x == -1)
                {
                    WriteLine($"price per night is {pnights[stay - 1]}");
                    WriteLine($"total for {stay} nights is {(pnights[stay - 1] * stay).ToString("c")}");
                }
                else WriteLine(x);
                

            }
            WriteLine($"would you like to make another reservation: ");
            string yus = ReadLine();
                while (yus == "y")
                {
                    WriteLine("how many nights");
                    stay = int.Parse(ReadLine());
                    x = Array.BinarySearch(pnights, stay);
                    if (stay >= 8)
                    {
                        WriteLine($"price per night is $145.00");
                        WriteLine($"total for {stay} nights is {(145 * stay).ToString("c")}");
                    
                    }
                    else
                    {
                        if (x == -1)
                        {
                            WriteLine($"price per night is {pnights[stay - 1]}");
                            WriteLine($"total for {stay} nights is {(pnights[stay - 1] * stay).ToString("c")}");
                        }
                        
                    }
                WriteLine($"would you like to make another reservation: ");
                yus = ReadLine();
            }
            
        }
    }
}
