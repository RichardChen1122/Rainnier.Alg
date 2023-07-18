using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.graph.model
{
    public class Vertex
    {
        public int Data { get; set; }

        public bool Visited { get; set; }

        public Vertex(int data)
        {
            Data = data;
            Visited = false;
        }
    }
}
