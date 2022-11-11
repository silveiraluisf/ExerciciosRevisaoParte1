using static Calculations.Vertex; 

class Triangle
{
    private Calculations.Vertex A;
    private Calculations.Vertex B;
    private Calculations.Vertex C;
    private double P;
    private double Ar;
    private Type T; 

    public Triangle(Calculations.Vertex A, Calculations.Vertex B, Calculations.Vertex C, double perimeter, double area) 
    {
        VertexA = A;
        VertexB = B;
        VertexC = C;
        Perimeter = perimeter;
        Area = area;
    }

    public Calculations.Vertex VertexA
    {
        get { return VertexA;}
        set { VertexA = value; }
    }
    public Calculations.Vertex VertexB
    {
        get { return VertexB; }
        set { VertexB = value; }
    }
    public Calculations.Vertex VertexC
    {
        get { return VertexC;}
        set { VertexC = value; }
    }

    public double Perimeter
    {
        get { return Perimeter; }
        set { Perimeter = value; }
    }

    public double Area
    {
        get { return Area; }
        set { Area = value; }
    }

    static public bool IsEqual(Triangle a, Triangle b)
    {
        return a == b;
    }

    static public double CalculatePerimeter(Calculations.Vertex A, Calculations.Vertex B, Calculations.Vertex C) 
    {
        double P = (Calculations.Vertex.Distance(A, B) + Calculations.Vertex.Distance(A, C) + Calculations.Vertex.Distance(B, C));
        return P;
    }
}
