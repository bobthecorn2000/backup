using System;
using static System.Console;
namespace gradecalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Total points for physics");
            double phy = double.Parse(ReadLine());
            WriteLine("Total points for Chemisty");
            double chem = double.Parse(ReadLine());
            WriteLine("Total points for biology");
            double bio = double.Parse(ReadLine());
            WriteLine("Total points for math");
            double math = double.Parse(ReadLine());
            WriteLine("Total points for Computing");
            double comp = double.Parse(ReadLine());
            double per = (phy + chem + bio + math + comp) / 5.0;
            WriteLine(per);
            if (per >= 90)
            {
                WriteLine("Grade: A");
            }
            else if (per >= 80 && per <= 89)
            {
                WriteLine("Grade: B");
            }
           else if (per >= 70 && per <= 79)
            {
                WriteLine("Grade: C");
            }
            else if (per >= 60 && per <= 69)
            {
                WriteLine("Grade: D");
            }
        }
    }
}
