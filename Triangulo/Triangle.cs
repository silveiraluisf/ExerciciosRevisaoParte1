using Vertice;

namespace Triangulo
{
    public class Triangle
    {
        private Vertex _A;
        private Vertex _B;
        private Vertex _C;
        private TriangleTypes T;

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

        public Enum TriangleType
        {
            get
            {
                return T;
            }
        }

        public Triangle(Vertex vertexA, Vertex vertexB, Vertex vertexC)
        {
            _A = vertexA;
            _B = vertexB;
            _C = vertexC;
        }

        static public bool IsEqual(Triangle T1, Triangle T2)
        {
            return (T1.VertexA == T2.VertexA && T1.VertexB == T2.VertexB && T1.VertexC == T2.VertexC);
        }

        public void DefineTriangleType()
        {
            if (D1 == D2 && D2 == D3) { T = TriangleTypes.Equilatero; }
            if (D1 == D2 || D2 == D3 || D3 == D1) { T = TriangleTypes.Isoseles; }
            else T = TriangleTypes.Escaleno;      
        }
    }

    public enum TriangleTypes
    {
        Equilatero,
        Isoseles,
        Escaleno,
    }
}
