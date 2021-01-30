using BrickBreaker_CSharp.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreaker_CSharp
{
    public static class GameLoop
    {
        private const double TGTFPS = 60;
        public static void NewGame(int fieldWidth, int fieldHeight)
        {
            //setup the screen
            SetWindowSizeSafely(fieldWidth, fieldHeight);
            //setup the game pieces
            Paddle paddle = new Paddle(fieldWidth / 2, fieldHeight);
            Ball ball = new Ball(paddle.XPos, paddle.YPos - 1);

        }

        public static void Play()
        {
            while (true)
            {

            }
        }

        private static void FrameRatePause(double startTime)
        {

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
