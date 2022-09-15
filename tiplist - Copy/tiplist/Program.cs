// tyler forsgren
// 9/12/22
using System;
using System.Linq;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;

namespace tiplist
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] test = { "Test #1", "Test #2", "Test #3", "Test #4", "Test #5", "Test #6", "Test #7", "Test #8" };
            double[] score = new double[8];
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Enter score for {test[i]}");
                
                score[i] = double.Parse(ReadLine());
                

            }
            Console.WriteLine($"your average tip was {score.Average().ToString("f3")}");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"{test[i]}'s score of {score[i]} was " + (score[i] - score.Average()).ToString("f3") + " from average");

                

            }
        }
    }
}
