// tyler forsgren
//9/22/22
using System;
using static System.Console;
namespace TylerForsgrenFinalProject
{
    internal class Program
    {
        
        

        static void Main(string[] args)
        {
            int ticks = 0;
            double total = 0;
            bool endearly = false;
            double[] numbers = new double[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                int connum = 0;
                Getnum(out connum);
                ticks++;
                if (connum == 999)
                {
                    endearly = true;
                    break;
                }
                numbers[i] = connum;
            }
            for (int i = 0; i != numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    Write($"{numbers[i]}, ");
                    
                }
                
            }
            if (endearly == true)
            {
                ticks--;
            }
            Stats(numbers,ticks, out double high, out double low, out double avg, out double sum);
            Console.WriteLine($"\nThe array has {ticks} values");
            ;
            
            Console.WriteLine($"The highest value is {high}");
            
            Console.WriteLine($"The lowest value is {low}");

            Console.WriteLine($"The total value is {sum}");

            Console.WriteLine($"the average is {avg}");
        }
        static void Getnum( out int connum)
        {
            
            connum = 0;
            bool worked = false;
            while (worked == false)
            {
                
                Console.Write($"Please enter an integer 999 to quit>> ");
                worked = int.TryParse(ReadLine(), out connum);
                if (worked == false)
                {
                    Console.WriteLine("\t***Invalid entry***");
                }

            }
            
            
            //WriteLine(ticks);
        }
        static void Stats(double[] numbers,int ticks,out double high, out double low, out double avg, out double sum)
        {
            high = 0;
            low = 0;
            avg = 0;
            sum = 0;
            
            Array.Sort(numbers);
            Array.Reverse(numbers);
            high = numbers[0];
            Array.Reverse(numbers);


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    low = numbers[i];
                    break;
                }

            }
            for (int i = 0; i != numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    
                    sum = sum + numbers[i];
                }

            }
            avg = sum / ticks; 


        }
    }
}
