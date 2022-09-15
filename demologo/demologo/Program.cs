//tyler forsgren
// 9/14/22
using System.Runtime.Intrinsics.X86;
using static System.Console;

class DemoLogo
{
    static void Main()
    {
        Write("Our company is ");
        DisplayCompanyLogo();
    }
    private static void DisplayCompanyLogo()
    {
        WriteLine("See Sharp Optical");
        WriteLine("We prize your eyes");
    }
}


