class Vertice {

    private int X;
    private int Y;

    public Vertice(int coordinateX, int coordinateY)
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
            value = X; 
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
            value = Y;
        }
    }

    public void Distance()
    {
        Console.WriteLine("A distância é: ");
    }

    public void Move()
    {
        Console.WriteLine("Moveu!");
    }

    static void Main()
    {
        Console.WriteLine("Programa vertice");
    }
}