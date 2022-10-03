using System;
using static System.Console;


namespace marshallmurals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intnum = 0, extnum = 0, month = 0;
            bool worked = false;
            bool coldtime = false;
            while (worked == false)
            {
                Write("enter the month>> ");
                worked = int.TryParse(ReadLine(), out month);
                if (worked == false)
                {
                    Console.WriteLine("error try again");
                }
                else if (month > 12 || month < 1 )
                {
                    Console.WriteLine("out of range");
                    worked = false;
                }
                 
            }
            worked = false;
            while (worked == false)
            {
                Write("Enter number of interior murals you want scheduled>> ");
                worked = int.TryParse(ReadLine(), out intnum);
                if (worked == false)
                {
                    Console.WriteLine("error try again");
                }
                else if (intnum > 31 || intnum < 0)
                {
                    Console.WriteLine("must be between 0 and 30");
                    worked = false;
                }

            }
            worked = false;
            if (month == 1 || month == 2 || month == 12)
            {
                coldtime = true;
                WriteLine("Due to the cold weather we are not doing exterior murals at this time\n");
            }
            else
            {
                while (worked == false)
                {
                    Write("Enter number of exterior murals you want scheduled>> ");
                    worked = int.TryParse(ReadLine(), out extnum);
                    if (worked == false)
                    {
                        Console.WriteLine("error try again");
                    }
                    else if (extnum > 31 || extnum < 0)
                    {
                        Console.WriteLine("must be between 0 and 30");
                        worked = false;
                    }
                }
            }
            double inttotal;
            double exttotal;
            double price1, price2;
            if (month == 7 || month == 8)
            {
                price1 = 450;
                inttotal = price1 * intnum;
            }
            else
            {
                price1 = 500;
                inttotal = price1 * intnum;
            }
            if (month == 4 || month == 5 || month == 9 || month == 10)
            {
                price2 = 699;
                exttotal = price2 * extnum;
            }
            else { 
                price2 = 750;
                exttotal = price2 * extnum;
            }
            Console.WriteLine($"{intnum} interior murals are scheduled at {price1:c} each for a total of {inttotal:c}");
            if (coldtime == false)
            {
                Console.WriteLine($"{extnum} exterior murals are scheduled at {price2:c} each for a total of {exttotal:c}");
            }
            Console.WriteLine($"Total revenue expected is {inttotal + exttotal:c}");
            bool greater = intnum > extnum;
            Console.WriteLine($"It is {greater} that there are more interior walls then exterior ones");

        }
    }
}
