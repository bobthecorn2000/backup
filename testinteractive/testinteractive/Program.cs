//tyler forsgren
//8/25/22
using System;

namespace testinteractive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter score 1");
            double test1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter score 2");
            double test2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter score 3");
            double test3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter score 4");
            double test4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter score 5");
            double test5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter score 6");
            double test6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter score 7");
            double test7 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter score 8");
            double test8 = Convert.ToDouble(Console.ReadLine());
            double testadded = test1 + test2 + test3 + test4 + test5 + test6 + test7 + test8;
            // double testfinal = Math.Round(testadded / 8, 2);
            double testfinal = testadded / 8;
            Console.WriteLine("average test score is {0}", testfinal.ToString("f"));
        }
    }
}
