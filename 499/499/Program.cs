﻿
//tyler forsgren
//10/11/22
using System;
using static System.Console;
class ExceptionsOnPurpose
{
    static void Main()
    {
        int answer = 0;
        int result;
        int zero = 0;
        try
        {
            Write("Enter an integer >> ");
            answer = Convert.ToInt32(ReadLine());
            result = answer / zero;
        }
        catch (Exception e)
        {
            WriteLine(e.Message);
            WriteLine("the answer is " + answer);

        }
    }
}
