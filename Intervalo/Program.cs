namespace Intervalo
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Teste da classe intervalo:");

            DateTime a = new DateTime(2008, 3, 1, 7, 0, 0);
            DateTime b = new DateTime(2010, 3, 1, 7, 0, 0);

            DateTime c = new DateTime(2006, 3, 1, 7, 0, 0);
            DateTime d = new DateTime(2022, 3, 1, 7, 0, 0);

            DateTime e = new DateTime(2006, 3, 1, 7, 0, 0);
            DateTime f = new DateTime(2022, 3, 1, 7, 0, 0);

            TimeInterval tempoA = new(a, b);
            TimeInterval tempoB = new(c, d);
            TimeInterval tempoC = new(e, f);

            Console.WriteLine($"Intervalo 1: {tempoA.InicialDate} , {tempoA.FinalDate}");
            Console.WriteLine($"Intervalo 2: {tempoB.InicialDate} , {tempoB.FinalDate}");
            Console.WriteLine($"Tem interseção? {TimeInterval.HasInersection(tempoA, tempoB)}");
            Console.WriteLine($"Os intervalos 1 e 2 são iguais? {TimeInterval.IsEqual(tempoA, tempoB)}");
            Console.WriteLine("");

            Console.WriteLine($"Intervalo 2: {tempoB.InicialDate} , {tempoB.FinalDate}");
            Console.WriteLine($"Intervalo 3:  {tempoC.InicialDate} , {tempoC.FinalDate}");
            Console.WriteLine($"Os intervalos 2 e 3 são iguais? {TimeInterval.IsEqual(tempoB, tempoC)}");
            Console.WriteLine("");

            Console.WriteLine($"A duração do intervalo 1 é: {tempoA.Duration}");
            Console.WriteLine($"A duração do intervalo 2 é: {tempoB.Duration}");
            Console.WriteLine($"A duração do intervalo 3 é: {tempoC.Duration}");
        }
    }
}
