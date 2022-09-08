using System;
using static System.Console; 

namespace generate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nEnter the number of digits to count");
            string entervalue = ReadLine();
            bool check = int.TryParse(entervalue, out int worthless);
            if (check == true)
            {
                WriteLine(entervalue + " has " + entervalue.Length + " digits");
            }
            else WriteLine("Failure");


            Console.WriteLine("\nDo you want to go again");
            string goagain = ReadLine().ToUpper();
            while (goagain == "Y")
            {
                Console.WriteLine("\nEnter the number of digits to count");
                entervalue = ReadLine();
                 check = int.TryParse(entervalue, out worthless);
                if (check == true)
                {
                    WriteLine(entervalue + " has " + entervalue.Length + " digits");
                }
                else WriteLine("Failure");
                Console.WriteLine("\nDo you want to go again");

                goagain = ReadLine().ToUpper();
            }

        }
    }
}
