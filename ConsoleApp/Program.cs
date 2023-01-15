namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            Vertex v1 = new Vertex(1);
            Vertex v2 = new Vertex(2);
            Vertex v3 = new Vertex(3);
            Vertex v4 = new Vertex(4);
            Vertex v5 = new Vertex(5);
            Vertex v6 = new Vertex(6);
            Vertex v7 = new Vertex(7);


            graph.AddVertex(new Vertex(1));
            graph.AddVertex(new Vertex(2));
            graph.AddVertex(new Vertex(3));
            graph.AddVertex(new Vertex(4));
            graph.AddVertex(new Vertex(5));
            graph.AddVertex(new Vertex(6));
            graph.AddVertex(new Vertex(7));

            graph.AddEdge(v1, v2);
            graph.AddEdge(v1, v3);
            graph.AddEdge(v3, v4);
            graph.AddEdge(v2, v5);
            graph.AddEdge(v2, v6);
            graph.AddEdge(v6, v5);
            graph.AddEdge(v5, v6);

            int[,] matrix = graph.GetMatrix();

            for (int i = 0; i < graph.VertexCoutn; i++)
            {
                for (int k = 0; k < graph.VertexCoutn; k++)
                {
                    Console.Write(matrix[i, k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}