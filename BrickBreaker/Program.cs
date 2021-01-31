using System;

namespace BrickBreaker
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
