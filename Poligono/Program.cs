using Vertice;

namespace Poligono
{
    public class Program
    {
        static void Main()
        {
            Vertex vertexA = new(1, 5);
            Vertex vertexB = new(3, 10);
            Vertex vertexC = new(2, 4);
            Vertex vertexD = new(1, 8);

            List<Vertex> vertices = new() 
            { 
                vertexA,
                vertexB,
                vertexC,
                vertexD
            };

            Polygon polygonA = new(vertices);
            //Testes dos métodos de criação de polígono
            foreach(Vertex vertex in vertices)
            {
                Console.WriteLine($"Vértice: {vertex.CoordinateX} {vertex.CoordinateY}");              
            }
            Console.WriteLine($"Quantidade de vértices = {polygonA.QtdVertex}");
            Console.WriteLine($"Perímetro do polígono = {polygonA.CalculatePerimeter()}");

            //Testes do método de adicionar vértice
            Vertex vertexE = new(21, 18);
            Console.WriteLine($"Tentando adicionar o vértice {vertexE.CoordinateX} {vertexE.CoordinateY}");
            Console.WriteLine($"Adicionou? {polygonA.AddVertex(vertexE)}");
            Console.WriteLine($"Quantidade de vértices = {polygonA.QtdVertex}");
            Console.WriteLine($"Perímetro do polígono = {polygonA.CalculatePerimeter()}");
            foreach (Vertex vertex in vertices)
            {
                Console.WriteLine($"Vértice: {vertex.CoordinateX} {vertex.CoordinateY}");
            }

            //Testes do método de adicionar vértice
            Console.WriteLine($"Tentando adicionar o mesmo vértice de novo {vertexE.CoordinateX} {vertexE.CoordinateY}");
            Console.WriteLine($"Adicionou? {polygonA.AddVertex(vertexE)}");         

            //Teste do método de remover vértice
            Console.WriteLine($"Tentando remover o vértice {vertexE.CoordinateX} {vertexE.CoordinateY}");
            Console.WriteLine($"Removeu? {polygonA.RemoveVertex(vertexE)}");
            Console.WriteLine($"Quantidade de vértices = {polygonA.QtdVertex}");
            Console.WriteLine($"Perímetro do polígono = {polygonA.CalculatePerimeter()}");
            foreach (Vertex vertex in vertices)
            {
                Console.WriteLine($"Vértice: {vertex.CoordinateX} {vertex.CoordinateY}");
            }

            //Teste do método de remover vértice com polígono com 3 vértices
            //Console.WriteLine($"Tentando remover o vértice {vertexD.CoordinateX} {vertexD.CoordinateY}");
            //Console.WriteLine($"Removeu? {polygonA.RemoveVertex(vertexD)}");
            //Console.WriteLine($"Tentando remover o vértice {vertexC.CoordinateX} {vertexC.CoordinateY}");
            //Console.WriteLine($"Removeu? {polygonA.RemoveVertex(vertexC)}");
            //foreach (Vertex vertex in vertices)
            //{
            //    Console.WriteLine($"Vértice: {vertex.CoordinateX} {vertex.CoordinateY}");
            //}
        }
    }
}
