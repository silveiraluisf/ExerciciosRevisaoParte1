using Vertice;

namespace Triangulo
{
    public class Program
    {
        static void Main()
        {
            Vertex vertexA = new(1, 1);
            Vertex vertexB = new(1, 1);
            Vertex vertexC = new(1, 1);
            
            Triangle triangleA = new(vertexA, vertexB, vertexC);
            Triangle triangleB = new(vertexA, vertexB, vertexC);

            Console.WriteLine(triangleA.Area);
            Console.WriteLine(triangleB.TriangleType);
            Console.WriteLine(Triangle.IsEqual(triangleA, triangleB));
        }
    }
}