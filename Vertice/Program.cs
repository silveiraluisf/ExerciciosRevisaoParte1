class Vertex {

    private int X;
    private int Y;

    public Vertex(int coordinateX, int coordinateY)
    {
        CoordinateX = coordinateX;
        CoordinateY = coordinateY;
    }

    public int CoordinateX {
        get
        {
            return X;
        }
        set 
        {
            X = value; 
        } 
    }

    public int CoordinateY
    {
        get
        {
            return Y;
        }
        set
        {
            Y = value;
        }
    }

    static public void Distance(Vertex A, Vertex B)
    {
        //d (P, Q) = √ ((XQ - XP) ^ 2 + (YQ - YP) ^ 2)
        double distante = Math.Sqrt(Math.Pow((A.CoordinateX - B.CoordinateX), 2) + Math.Pow((A.CoordinateY - B.CoordinateY), 2));    
        Console.WriteLine($"A distância entre o vértice A e B é de {distante} unidade(s) de medida");

    }

    public void Move()
    {
        Console.WriteLine("Moveu!");
    }

    static void Main()
    {
        Console.WriteLine("Programa vertice");
        Vertex vertexA = new(4, 5);
        Vertex vertexB = new(2, 3);
        Vertex.Distance(vertexA, vertexB);
    }
}