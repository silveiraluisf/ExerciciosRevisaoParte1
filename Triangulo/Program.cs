using Vertice;

namespace Triangulo
{
    public class Triangle
     {
        private Vertex _A;
        private Vertex _B;
        private Vertex _C;

        public Vertex VertexA
        {
            get { return _A; }
            set { _A = value; }
        }
        public Vertex VertexB
        {
            get { return _B; }
            set { _B = value; }
        }
        public Vertex VertexC
        {
            get { return _C; }
            set { _C = value; }
        }

        public double D1
        {
            get { return Vertex.Distance(_A, _B); }
        }

        public double D2
        {
            get { return Vertex.Distance(_A, _C); }
        }

        public double D3
        {
            get { return Vertex.Distance(_B, _C); }
        }

        public double Perimeter
        {
            get { return D1 + D2 + D3; }    
        }

        public double Area
        {
            get { return Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - D1) * (Perimeter / 2 - D2) * (Perimeter / 2 - D3)); }           
        }

        public Triangle(Vertex vertexA, Vertex vertexB, Vertex vertexC)
        {
            _A = vertexA;
            _B = vertexB;
            _C = vertexC;
        }

        static public bool IsEqual(Triangle a, Triangle b)
            {
                return a == b;
            }

        static public double CalculatePerimeter(Vertice.Vertex A, Vertice.Vertex B, Vertice.Vertex C)
        {
            double P = (Vertice.Vertex.Distance(A, B) + Vertice.Vertex.Distance(A, C) + Vertice.Vertex.Distance(B, C));
            return P;
        }
     }
}