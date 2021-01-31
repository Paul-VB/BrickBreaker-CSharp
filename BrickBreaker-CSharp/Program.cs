using BrickBreaker_CSharp.Classes;
using System;

namespace BrickBreaker_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTimeOffset.Now.ToUnixTimeMilliseconds());
            //GameLoop.NewGame(100,100);
            foreach(Entity e in Entity.listOfAllEntities)
            {
                e.Draw();
            }
            Console.Read();
        }
    }
}
