using System;

namespace multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test(1.25);
        }
        static void test(string args) {
            Console.WriteLine(args);
        }
        static void test(int args) {
            Console.WriteLine(args);
        }
    }
}
