
using BrickBreaker.Models.HitboxShapes.Polygon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreakerTest.Models.HitboxShapes
{
    [TestClass]
    public class EdgeTests
    {
        [DataTestMethod]
        [DataRow(4, 5, 8, 7, 3,0.5)]
        [DataRow(-6, 7, -9, 8, 5,-0.3333)]
        [DataRow(-3, 6, 15, -6, 4,-0.6666)]
        [DataRow(45, 57, -10, 5, 14.4545,0.9454)]
        public void YIntercept_Slope_Test(double x1, double y1, double x2, double y2, double expectedYIntercept,double expectedSlope)
        {
            //arrange
            Vertex a = new Vertex(x1, y1);
            Vertex b = new Vertex(x2, y2);
            Edge e = new Edge(a, b);

            //act
            double actualYIntercept = e.YIntercept;
            double actualSlope = e.Slope;

            //assert
            Assert.AreEqual(expectedYIntercept, actualYIntercept, 0.0001);
            Assert.AreEqual(expectedSlope, actualSlope, 0.0001);
        }

        [DataTestMethod]
        [DataRow(4, 5, 8, 7, 10,15, 6.261)]
        [DataRow(-9, 8,-6, 7, 10, 15, 12.6491)]
        [DataRow(-3, 6, 15, -6, 10,15, 14.6996)]
        [DataRow(45, 57, -10, 5, -15,-100, 72.8628)]
        public void DistanceToPoint_Test(double x1, double y1, double x2, double y2, double xt, double yt, double expectedDistance)
        {
            //arrange
            Vertex a = new Vertex(x1, y1);
            Vertex b = new Vertex(x2, y2);
            Edge e = new Edge(a, b);

            //act
            double actualDistance = e.DistanceToPoint(xt,yt);

            //assert
            Assert.AreEqual(expectedDistance, actualDistance,0.0001);
        }
    }
}
