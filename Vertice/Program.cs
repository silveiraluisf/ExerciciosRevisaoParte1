namespace Vertice { 
    public class Program {
        static void Main()
        {
            Vertex vertexA = new(2, 3);
            Vertex vertexB = new(2, 3);
            Console.WriteLine("Programa vertice");
            Console.WriteLine($"Primeiro vértice: {vertexA.CoordinateX} {vertexA.CoordinateY}");           
            Console.WriteLine($"Segundo vértice: {vertexB.CoordinateX} {vertexB.CoordinateY}");
            Vertex.Distance(vertexA, vertexB);
            Console.WriteLine($"A distância entre dois vértices é: {Vertex.Distance(vertexA, vertexB)}");
            Vertex.Move(vertexA, vertexB);
            Console.WriteLine("O primeiro vértice foi movido para a posição do segundo");
            Console.WriteLine("Função que verifica se dois vértices são iguais:");
            Console.WriteLine($"São iguais? {Vertex.IsEqual(vertexA, vertexB)}");
        }
    }
}