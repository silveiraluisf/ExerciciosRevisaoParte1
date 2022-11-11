using static Calculations.Vertex; 

class Triangle
{
    private Calculations.Vertex A;
    private Calculations.Vertex B;
    private Calculations.Vertex C;

    public Triangle(Calculations.Vertex A, Calculations.Vertex B, Calculations.Vertex C) 
    {
        VertexA = A;
        VertexB = B;
        VertexC = C;
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
}
