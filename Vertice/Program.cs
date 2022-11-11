namespace Calculations { 
    public class Vertex {

        private int X;
        private int Y;

        public Vertex(int coordinateX, int coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }

        public int CoordinateX {
            get { return X;}
            private set { X = value; } 
        }

        public int CoordinateY
        {
            get { return Y;}
            private set { Y = value;}
        }

        static public double Distance(Vertex A, Vertex B)
        {
            //formula: d (P, Q) = √ ((XQ - XP) ^ 2 + (YQ - YP) ^ 2)
            double distante = Math.Sqrt(Math.Pow((A.CoordinateX - B.CoordinateX), 2) + Math.Pow((A.CoordinateY - B.CoordinateY), 2));    
            Console.WriteLine($"A distância entre o vértice A e B é de {distante} unidade(s) de medida");
            return distante;
        }

        static public Vertex Move(Vertex A, Vertex B)
        {
            Console.WriteLine($"Posição atual do vértice = {A.CoordinateX} , {A.CoordinateY}");
            A.CoordinateX = B.CoordinateX;
            A.CoordinateY = B.CoordinateY;
            Console.WriteLine("Moveu!");
            Console.WriteLine($"Nova posiçã do vértice = {A.CoordinateX} , {A.CoordinateY}");
            return A;
        }

        static public bool IsEqual(Vertex A, Vertex B)
        {
            Console.WriteLine(A == B);
            return (A == B);
        }

        static void Main()
        {
            Console.WriteLine("Programa vertice");
            Vertex vertexA = new(4, 5);
            Vertex vertexB = new(2, 3);
            Console.WriteLine("Função que calcula a distância entre dois vértices:");
            Vertex.Distance(vertexA, vertexB);
            Console.WriteLine("Função que move a posição de um vértice:");
            Vertex.Move(vertexA, vertexB);
            Console.WriteLine("Função que verifica se dois vértices são iguais:");
            Vertex.IsEqual(vertexA, vertexB);
        }
    }
}