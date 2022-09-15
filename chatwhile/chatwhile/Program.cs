using System;
using static System.Console;
using System.Threading.Tasks.Dataflow;

namespace chatwhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] acode = { 262, 414, 608, 715, 815, 920 };
            double[] irate = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };

            WriteLine("what area code are you calling: ");
            bool worked = int.TryParse(ReadLine(), out int areac);
            if (worked == true)
            {
                //WriteLine(areac);
                int x = Array.BinarySearch(acode, areac);
                //WriteLine(x);
                if (x > -1)
                {
                    WriteLine("Enter the length of your call in minutes: ");
                    worked = int.TryParse(ReadLine(), out int call);
                    if (worked == true)
                    {
                       WriteLine($"your call to {areac} will cost {(call * irate[x]).ToString("c")}");
                        WriteLine($" the rate applied to the call was: {irate[x]}");
                    }
                     
                    
                }
                else WriteLine($"Error {areac} is not a valid code");
            }
            else WriteLine("nope");
        }
    }
}
