using Vertice;

namespace Triangulo
{
    public class Program
    {
        static void Main()
        {
            Vertex vertexA = new(4, 5);
            Vertex vertexB = new(2, 3);
            Vertex vertexC = new(6, 8);
            
            Triangle triangleA = new(vertexA, vertexB, vertexC);
            Triangle triangleB = new(vertexA, vertexB, vertexC);

            Console.WriteLine(triangleA.Area);
            Console.WriteLine(triangleB.TriangleType);
            Console.WriteLine(Triangle.IsEqual(triangleA, triangleB));
        }
    }
}