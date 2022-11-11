namespace Vertice
{
    internal class Vertex
    {
        private int _X;
        private int _Y;

        public Vertex(int coordinateX, int coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }

        public int CoordinateX
        {
            get { return _X; }
            private set { _X = value; }
        }

        public int CoordinateY
        {
            get { return _Y; }
            private set { _Y = value; }
        }

        static public double Distance(Vertex A, Vertex B)
        {
            //formula: d (P, Q) = √ ((XQ - XP) ^ 2 + (YQ - YP) ^ 2)
            double distance = Math.Sqrt(Math.Pow((A.CoordinateX - B.CoordinateX), 2) + Math.Pow((A.CoordinateY - B.CoordinateY), 2));
            return distance;
        }

        static public Vertex Move(Vertex A, Vertex B)
        {
            A.CoordinateX = B.CoordinateX;
            A.CoordinateY = B.CoordinateY;
            return A;
        }

        static public bool IsEqual(Vertex A, Vertex B)
        {
            //Console.WriteLine(A.CoordinateX == B.CoordinateX && A.CoordinateY == B.CoordinateY);
            return (A.CoordinateX == B.CoordinateX && A.CoordinateY == B.CoordinateY);
        }
    }
}
