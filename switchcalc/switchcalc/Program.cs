
using System;
using static System.Console;

namespace switchcalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter first number: ");
            string read1 = ReadLine();
            if (double.TryParse(read1, out double num1) == true )
            {
                Console.WriteLine("enter an operator");
                if (char.TryParse(ReadLine(), out char op) == true)
                {
                    Console.Write("enter second number: ");
                    if (double.TryParse(ReadLine(), out double num2) == true)
                    {
                        switch (op)
                        {
                            case '*':
                                WriteLine("{0} * {1} = " + (num1 * num2), num1, num2);
                                break;
                            case '+':
                                WriteLine("{0} + {1} = " + (num1 + num2), num1, num2);
                                break;
                            case '/':
                                WriteLine("{0} / {1} = " + (num1 / num2), num1, num2);
                                break;
                            case '-':
                                WriteLine("{0} - {1} = " + (num1 - num2), num1, num2);
                                break;
                            default:
                                WriteLine("calculation error");
                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("not a number");
                    }
                    
                }
                else
                {
                    WriteLine("not a valid operator");
                }
            }
            else
            {
                Console.WriteLine("not a number");
            }
            
            
            
        }
    }
}
