class Pyramid
{
    private int N;

    public int NdeAndares
    {
        get
        {
            return N;
        }
        set
        {
            if (value > 0)
                N = value;
        }
    }

    public void BuildPyramid()
    {
            for (int i = 1; i <= N; i++)
            {
                // Laço de repeticao para os espacos
                for (int j = 1; j <= (N - i); j++)
                    Console.Write(" ");
                // Aumenta o valor do numero
                for (int Number = 1; Number <= i; Number++)
                    Console.Write(Number);
                // Diminui o valor no numero
                for (int Number = (i - 1); Number >= 1; Number--)
                    Console.Write(Number);
                Console.WriteLine();
            }
        }

    public static void Main()
    {
        Pyramid pyramid = new Pyramid();
        pyramid.N = 6;
        pyramid.BuildPyramid();

    }

}