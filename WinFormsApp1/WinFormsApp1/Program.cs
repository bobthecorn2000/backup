using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            start();
        }



        enum Daysoftheweek { Monday, Tuesday, Wensday, Thursday, Friday, Saterday, Sunday };

        /* while (1 == 1)
         {
             Console.WriteLine("enter number");
             var num = Convert.ToInt32(Console.ReadLine());
             var newthing = (char)num;
             Console.WriteLine(newthing); 

         }*/


        static void start()
        {
            Console.Write("A:\\ApertureLabs-" + Environment.MachineName + "\\" + Environment.UserName + "\\CommandCenter> ");

            string input = Console.ReadLine();
            string command = input.ToLower();
            if (command == "wordseperate")
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
            else if (command == "backword")
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
            else if (command == "swap")
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
            else if (command == "enumtest")
            {

                Day();

            }
            else if (command == "")
            {
                start();
            }
            else if (command == "clear") { Console.Clear(); start(); }
            else if (command == "check") { Console.WriteLine("test"); start(); }
            else if (command == "triangle")
            {
                WriteLine("Enter a value for Side 1");
                int side1 = int.Parse(ReadLine());
                WriteLine("Enter a value for Side 2");
                int side2 = int.Parse(ReadLine());
                WriteLine("Enter a value for Side 3");
                int side3 = int.Parse(ReadLine());
                if (side1 == side2 && side2 == side3)
                {
                    WriteLine("Equilateral triangle; All sides are equal");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    WriteLine("Isosceles triangle: Two sides are equal");
                }
                else if (side1 != side2 && side1 != side3 && side2 != side3)
                {
                    WriteLine("no sides are equal");
                }
                else
                {
                    WriteLine("you done goofed");
                }
                start();
            }
            else

            {
                switch (command)
                {
                    case "new stuff":
                        newstuff();
                        start();
                        break;
                    default:
                        Console.WriteLine("Not a command");
                        start();
                        break;
                }


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


        static void newstuff()
        {
            WriteLine("success");
            return;
        }
    }
}




    
