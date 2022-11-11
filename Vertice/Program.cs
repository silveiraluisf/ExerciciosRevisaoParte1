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
        int distante = A.CoordinateX - B.CoordinateX;    
        Console.WriteLine($"A distância é: {distante} ");

    }

    public void Move()
    {
        Console.WriteLine("Moveu!");
    }

    static void Main()
    {
        Console.WriteLine("Programa vertice");
        Vertex vertexA = new(4, 5);
        Vertex vertexB = new(3, 6);
        Vertex.Distance(vertexA, vertexB);
    }
}