using System;
using static System.Console;
namespace admission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("whats your gpa");
            double gpa = double.Parse(ReadLine());
            Console.WriteLine("enter test score");
            double score = double.Parse(ReadLine());
            if (gpa >= 3.0)
            {
                
                
                if (score >= 60)
                {
                    WriteLine("accept");
                }
                else WriteLine("Reject");
            }
            else 
                
            
            if ( score >= 80 )
            {
                WriteLine("accept");
            }
            else WriteLine("Reject");
        }
    }
}
