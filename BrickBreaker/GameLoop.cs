using BrickBreaker.Classes;
using BrickBreaker.Classes.Walls;
using BrickBreaker.Models.Moveable;
using System;
using System.Diagnostics;
using System.Threading;

namespace BrickBreaker
{
    public static class GameLoop
    {
        private static int fieldWidth;
        private static int fieldHeight;

        //todo get rid of this. do it better
        private static Paddle player;

        private const double TGTFPS = 30;
        public static void NewGame(int fieldWidth, int fieldHeight)
        {
            GameLoop.fieldWidth = fieldWidth;
            GameLoop.fieldHeight = fieldHeight;
            //setup the screen
            SetWindowSizeSafely(fieldWidth, fieldHeight);
            //setup the bounding walls
            //create the top wall
            for (int i = 1; i < fieldWidth - 1; i++)
            {
                new HorizontalWall(i, 0);
            }

            //create the side walls
            for (int i = 1; i <= fieldHeight; i++)
            {
                new VertialWall(0, i);
                new VertialWall(fieldWidth - 1, i);
            }






            //setup the game pieces

            player = new Paddle(fieldWidth / 2, fieldHeight);
            Ball ball = new Ball(player.XPos, player.YPos - 15);
            //ball.XMomentum = 0.5;
            //ball.YMomentum = 0.1;

        }

        public static void Play()
        {
            //start rendering thread
            ThreadStart render = new ThreadStart(RenderLoop);
            Thread renderThread = new Thread(render);
            renderThread.Start();

            //get user input thread
            ThreadStart input = new ThreadStart(InputLoop);
            Thread inputThread = new Thread(input);
            inputThread.Start();

            //start userInputThread
            Console.CursorVisible = false;
            Stopwatch sw = new Stopwatch();
            //we will need a variable to hold true time delta between the previous frame and the current frame
            double frameDeltaMultiplier = 1;
            while (true)
            {


                sw.Start();
                //get the time delta between the start of the previous frame and the start of the current frame

                //do game shit
                foreach (Entity e in Entity.listOfAllEntities)
                {
                    if (e is Ball)
                    {
                        Ball b = (Ball)e;
                        b.updatePos(frameDeltaMultiplier);
                    }

                }
                Thread.Sleep((int)(1000 / TGTFPS));


                sw.Stop();
            }

        }
        public static void RenderLoop()
        {
            double frameDeltaMultiplier = 1;
            while (true)
            {
                //get the time delta between the start of the previous frame and the start of the current frame

                //do game shit
                foreach (Moveable m in Moveable.listOfAllMovables)
                {
                    m.updatePos(frameDeltaMultiplier);
                }

                //draw shit
                ConsoleBufferedFrame buffer = new ConsoleBufferedFrame(GameLoop.fieldWidth + 1, GameLoop.fieldHeight + 1);
                foreach (Entity e in Entity.listOfAllEntities)
                {
                    buffer.AddEntity(e);

                }

                //the buffer has been setup, but not quite rendered
                string nextFrame = buffer.ToString();

                //now we're ready to clear the screen and display the new rendered buffer
                Console.Clear();
                Console.WriteLine(nextFrame);

                Thread.Sleep((int)(1000 / TGTFPS));

            }


        }

        public static void InputLoop()
        {
            double frameDeltaMultiplier = 1;
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKey pressed = Console.ReadKey(true).Key;
                    if (pressed == ConsoleKey.A)
                    {
                        player.XMomentum -=0.1;
                    }
                    if (pressed == ConsoleKey.D)
                    {
                        player.XMomentum += 0.1;
                    }
                }
            }
        }
        /// <summary>
        /// Safely sets the size of the console window.
        /// If the zoom level is too big, it will keep asking the user to zoom out
        /// so we can set the console window to the desired size.
        /// </summary>
        /// <param name="width">The desired width of the Console Window.</param>
        /// <param name="height">the desired height of the Console Window.</param>
        public static void SetWindowSizeSafely(int width, int height)
        {
            while (Console.LargestWindowWidth < width || Console.LargestWindowHeight < height)
            {
                Console.WriteLine("Please Zoom out! (Hold the CTRL key down and scroll mouse-wheel back)!");
            }
            Console.Clear();
            Console.SetWindowSize(width, height);
        }

    }
}
