using System;

namespace BrickBreaker
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GameLoop.NewGame(100, 100);
            GameLoop.Play();
            Console.Read();
            
        }
    }
}