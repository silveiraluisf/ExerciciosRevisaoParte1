// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Teste");

class Piramide
{
    private int N;

    public int NdeAndares { 
        get{
            return N;
                }
        set
        {
            if (value > 0)
                N = value;
            else return null;
        }
    }

}