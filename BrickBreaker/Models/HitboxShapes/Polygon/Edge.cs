using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreaker.Models.HitboxShapes.Polygon
{
    public class Edge
    {
        /// <summary>
        /// One of two vertexes that make up this edge.
        /// </summary>
        public Vertex VertexA { get; set; }

        /// <summary>
        /// One of two vertexes that make up this edge.
        /// </summary>
        public Vertex VertexB { get; set; }

        public Vertex CenterPoint
        {
            get
            {
                double centerX = (VertexA.XPos + VertexB.XPos) / 2.0;
                double centerY = (VertexA.YPos + VertexB.YPos) / 2.0;
                return new Vertex(centerX, centerY);
            }
        }

        /// <summary>
        /// gets the slope of this edge given the algebraic equation m=(y2-y1)/(x2-x1).
        /// </summary>
        public double Slope
        {
            get
            {
                return (VertexB.YPos - VertexA.YPos) / (VertexB.XPos - VertexA.XPos);
            }
        }

        public double YIntercept//aka b
        {
            get
            {
                //b = y-mx
                return VertexA.YPos - (Slope * VertexA.XPos);
            }
        }
        //Equasion of a line is y - y1 = m(x - x1)

        public Edge(Vertex vertexA, Vertex vertexB)
        {
            this.VertexA = vertexA;
            this.VertexB = vertexB;
        }
        public bool CheckCircleCollision(Circle c)
        {
            //the checking is done in 2 stages
            //stage 1. Assume this edge extends infinitly. Would the circle intersect it?
            bool endlessLineCollision = c.radius < this.DistanceToPoint(c.XPos, c.YPos);
            //stage 2. assume there is a circle (d) centered on this edge. it's radus is half the length of the edge. Is the CENTER of circle c within circle d?
            //todo bro this naming sucks
            bool buh = DistanceBetweenPoints(this.CenterPoint.XPos, this.CenterPoint.YPos, c.XPos, c.YPos) < DistanceBetweenPoints(this.VertexA.XPos, this.VertexA.YPos, this.VertexB.XPos, this.VertexB.YPos) / 2.0;
            return endlessLineCollision && buh;

        }

        /// <summary>
        /// Given a vertex, this method returns the distance between this edge and that vertex
        /// </summary>
        /// <param name="v">The vertex to measure.</param>
        /// <returns></returns>
        public double DistanceToVertex(Vertex v)
        {
            //if some dingbat tries to measure the distance between this edge and one of the vertexes that DEFINES the edge, well we know the distance is zero.
            if (v == this.VertexA || v == this.VertexB)
            {
                return 0.0;
            }
            return this.DistanceToPoint(v.XPos, v.YPos);


        }
        /// <summary>
        /// Given a Cartesian co-ordinate point (x,y), get the distance between that point and this edge (line)
        /// </summary>
        /// <param name="x">x co-ordinate of the point</param>
        /// <param name="y">y co-ordinate of the point</param>
        /// <returns></returns>
        public double DistanceToPoint(double x, double y)
        {
            //equation of a line
            double A = 1;
            double B = -1 / this.Slope;
            double C = -B * this.YIntercept;
            //double top = Math.Abs((this.Slope * v.XPos) + v.YPos + this.YIntercept);
            double top = Math.Abs((A * x) + (B * y) + C);
            //double bottom = Math.Sqrt(Math.Pow(this.Slope, 2) + 1);
            double bottom = Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
            double distance = top / bottom;

            return distance;

        }

        public double DistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
    }
}
