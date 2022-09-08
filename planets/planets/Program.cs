// tyler forsgren
// 8/25/22
using System;

namespace planets
{
    internal class Program
    {
        enum planets{Mercury, Venus, Earth,Mars,Jupiter, Saturn, Uranus,Neptune }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number 1 through 8 ");
            int planetnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The name of planet {0} is {1}", planetnum, (planets)planetnum - 1);
        }
    }
}
