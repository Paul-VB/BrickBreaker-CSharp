using System;
using System.IO;
using System.Reflection;

namespace BrickBreaker
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Debug.WriteLine($"before fix, CWD is: {System.Environment.CurrentDirectory}");
            //we have to do this because ASP.NET Core 2.2 has a bug
            System.Environment.CurrentDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location + @"\..\..\..\..\");
            System.Diagnostics.Debug.WriteLine($"after fix, CWD is: {System.Environment.CurrentDirectory}");

            GameLoop.NewGame(100, 100);
            GameLoop.Play();
            Console.Read();
            
        }
    }
}