using BrickBreaker_CSharp.Classes;
using System;

namespace BrickBreaker_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball b = new Ball(20, 20);
            b.Draw();
            Console.Read();
        }
    }
}
