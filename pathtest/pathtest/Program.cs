
using System;
using System.Diagnostics;
using System.IO;

namespace pathtest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Folder, where a file is created.  
            // Make sure to change this folder to your own folder  
            string appdata = Environment.ExpandEnvironmentVariables(@"%APPDATA%\");
            System.IO.Directory.CreateDirectory(appdata + @"Bobthecorn2000\testapp");
            string folder = appdata + @"\Bobthecorn2000\testapp\";
            // Filename  
            string fileName = @"test.bat";
            // Fullpath. You can direct hardcode it if you like.  
            string fullPath = folder + fileName;
            // An array of strings  
            string[] authors = { $"start \"MyProgram\" \"firefox.exe\"" };
            // Write array of strings to a file using WriteAllLines.  
            // If the file does not exists, it will create a new file.  
            // This method automatically opens the file, writes to it, and closes file  
            File.WriteAllLines(fullPath, authors);
            
           

        }
    }
}
