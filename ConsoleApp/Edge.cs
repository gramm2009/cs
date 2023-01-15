using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Edge
    {
        public Vertex From { get; set; } //от вершины
        public Vertex To { get; set; } // до вершины
        public int Weight { get; set; } // вес ребра если нет по по дефолту 1

        public Edge(Vertex from, Vertex to, int weight = 1)
        {
            From = from;
            To = to;
            Weight = weight;
        }


        public override string ToString()
        {
            return $"({From}; {To})";
        }
    }
}
