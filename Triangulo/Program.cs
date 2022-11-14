using Vertice;

namespace Triangulo
{
    public class Program
    {
        static void Main()
        {
            Vertex vertexA = new(1, 5);
            Vertex vertexB = new(3, 10);
            Vertex vertexC = new(2, 4);
            
            Triangle triangleA = new(vertexA, vertexB, vertexC);
            Triangle triangleB = new(vertexA, vertexB, vertexC);

            Console.WriteLine(triangleA.Area);
            Console.WriteLine(triangleB.TriangleType);
            Console.WriteLine(Triangle.IsEqual(triangleA, triangleB));
        }
    }
}