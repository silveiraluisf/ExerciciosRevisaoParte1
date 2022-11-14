using Intervalo;

namespace ListaIntervalos
{
    public class Program
    {
        static void Main()
        {
            DateTime a = new DateTime(2008, 3, 1, 7, 0, 0);
            DateTime b = new DateTime(2010, 3, 1, 7, 0, 0);

            DateTime c = new DateTime(2020, 3, 1, 7, 0, 0);
            DateTime d = new DateTime(2022, 3, 1, 7, 0, 0);

            TimeInterval tempoA = new(a, b);
            TimeInterval tempoB= new(c, d); 

            List<TimeInterval> list = new List<TimeInterval>()
            {
                tempoA,
            };
            
            TimeIntervalsList timelist = new(list);

            Console.WriteLine("Lista de intervalos de tempo:");
            timelist.PrintList(list);

            Console.WriteLine($"Adição do intervalo {tempoB.InicialDate} , {tempoB.FinalDate} :");
            timelist.AddInterval(tempoB);

            Console.WriteLine("Lista de intervalos de tempo atualizada:");
            timelist.PrintList(list);


        }
        
    }
}