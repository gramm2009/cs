using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Graph
    {
        List<Vertex> Vertexes = new List<Vertex>();
        List<Edge> Edges = new List<Edge>();

        public int VertexCoutn => Vertexes.Count;
        public int EdgeCoutn => Edges.Count;

        public void AddVertex(Vertex vertex)
        {
            Vertexes.Add(vertex);
        }

        public void AddEdge(Vertex from, Vertex to)
        {
            Edge edge = new Edge(from, to);
            Edges.Add(edge);
        }

        // Матрица
        public int[,] GetMatrix()
        {
            //строим двумерный массив (графы идут зеркально слева на право,  с верху в низ
            int[,] matrix = new int[Vertexes.Count, Vertexes.Count];

            //отмечаем в матрице связи (проставляя вес он у нас по условию всегда 1)
            foreach (Edge edge in Edges)
            {
                int row = edge.From.Number - 1; // -1 это потому что граф 1 но он должен идти в 0 индекс
                int colum = edge.To.Number - 1;

                matrix[row, colum] = edge.Weight;
            }

            return matrix;
        }

        // Список смежных вершин (передаем вершину и получаем список вершин с которыми она связана)
        public List<Vertex> GetVertexList(Vertex vertex)
        {
            List<Vertex> result = new List<Vertex>();

            foreach (Edge edge in Edges)
            {
                if (edge.From == vertex)
                {
                    result.Add(edge.To);
                }
            }

            return result;
        }

    }
}
