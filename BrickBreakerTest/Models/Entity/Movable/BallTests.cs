using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using BrickBreaker;

namespace BrickBreakerTest.Models.Entity.Movable
{
    [TestClass]
    public class BallTests
    {
        [TestMethod]
        public void Ball_HeightAndWidth_Test()
        {
            //arrange
            Ball B = new Ball(15, 15);

            //act
            int width = B.Width;
            int height = B.Height;

            //assert
            Assert.AreEqual(4, width);
            Assert.AreEqual(4, height);
        }
    }
}
