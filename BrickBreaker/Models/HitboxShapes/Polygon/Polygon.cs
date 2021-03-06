using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreaker.Models.HitboxShapes.Polygon
{
    public class Polygon : ICartesianable
    {
        List<Vertex> vertices = new List<Vertex>();
        List<Edge> edges = new List<Edge>();

        public double XPos { get; set; }
        public double YPos { get; set; }

        public Polygon(double xPos, double yPos,List<Vertex> vertices)
        {
            this.RedefineEdges(vertices);
            this.XPos = xPos;
            this.YPos = yPos;
        }

        public void RedefineEdges(List<Vertex> vertices)
        {
            //a polygon MUST have at least 3 vertices
            if (vertices.Count < 3)
            {
                throw new ArgumentException("The list of vertices must be 3 or greater");
            }
            //now we copy the vertices from the input parameter into this.vertcieis
            foreach(Vertex v in vertices)
            {
                this.vertices.Add(new Vertex(v.XPos, v.YPos, this));
            }
            //now we set aside the first and last vertices. we will create an edge between them in just a minute
            Vertex firstVertex = this.vertices[0];
            Vertex lastVertex = this.vertices[this.vertices.Count-1];
            //create all edges except the last edge
            for (int i = 0; i < this.vertices.Count - 2; i++)
            {
                this.edges.Add(new Edge(this.vertices[i],this.vertices[i+1]));
            }
            //create the last edge
            this.edges.Add(new Edge(lastVertex, firstVertex));//yes they go in this order
        }




    }
}
