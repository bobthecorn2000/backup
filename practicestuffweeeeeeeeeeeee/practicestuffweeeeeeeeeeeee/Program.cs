using System;
using System.Diagnostics;

namespace terminal
{
    internal class Program
    {
        enum Daysoftheweek { Monday, Tuesday, Wensday, Thursday, Friday, Saterday, Sunday };
        static void Main(string[] args)
        {
            start();
            /* while (1 == 1)
             {
                 Console.WriteLine("enter number");
                 var num = Convert.ToInt32(Console.ReadLine());
                 var newthing = (char)num;
                 Console.WriteLine(newthing); 

             }*/

            static void start()
            {
                Console.Write("A:\\ApertureLabs-"+Environment.MachineName+"\\"+Environment.UserName+"\\CommandCenter> ");
                var command = Console.ReadLine();
                if (command == "WordSeperate")
                {
                    Console.WriteLine("Word to seperate");
                    var word = Console.ReadLine();
                    var length = word.Length;
                    var l = length;
                    var i = 0;
                    while (i < l)
                    {
                        Console.WriteLine("letter " + i + " is " + word.Substring(i, 1));
                        i++;
                    }
                    start();
                }
                else if (command == "backWord")
                {
                    Console.WriteLine("Word to reverse");
                    var word = Console.ReadLine();
                    var length = word.Length;
                    var l = length;
                    var i = length;
                    while (i > 0)
                    {
                        Console.Write(word.Substring(i - 1, 1));

                        i--;
                    }
                    Console.WriteLine();
                    start();
                }
                else if (command == "Swap")
                {
                    Console.WriteLine("Word to Swap");
                    var word = Console.ReadLine();
                    var length = word.Length;
                    var l = length;
                    var i = 1;
                    Console.Write(word.Substring(l - 1, 1));
                    while (i < l - 1)
                    {

                        Console.Write(word.Substring(i, 1));

                        i++;
                    }
                    Console.Write(word.Substring(0, 1));

                    Console.WriteLine();
                    start();
                }
                else if (command == "exit") { }
                else if (command == "sts")
                {
                    Process.Start("SlideToShutdown.exe");
                    start();
                }
                else if (command == "rick")
                {
                    System.Diagnostics.Process.Start(new ProcessStartInfo
                    {
                        FileName = "https://www.youtube.com/watch?v=dQw4w9WgXcQ",
                        UseShellExecute = true
                    });
                    start();
                }
                else if (command == "enumTest")
                {

                    Day();

                }
                else if (command == "")
                {
                    start();
                }
                else if (command == "clear") { Console.Clear(); start(); }
                else if (command == "check") { Console.WriteLine("test"); start(); }
                else

                {
                    Console.WriteLine("Not a command");
                    start();
                }




                static void Day()
                {





                    string enterday;
                    int daynum;

                    Console.Write("enterdaynumber: ");
                    enterday = Console.ReadLine();
                    daynum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The name of the day {0} is {1}", daynum, (Daysoftheweek)daynum);
                    Console.WriteLine("The name of the day {0} is {1}", daynum, (Daysoftheweek)4);
                    start();


                }
            }
        }
    }
}


