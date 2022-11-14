using Intervalo;

namespace ListaIntervalos
{
    internal class TimeIntervalsList
    {
        private List<TimeInterval> _L;

        public List<TimeInterval> InvervalsList
        {
            get { return _L; }
            set { _L = value; }
        }
        public TimeIntervalsList(List<TimeInterval> TimeLIst) 
        {
            _L = TimeLIst;
        }

        public void AddInterval(TimeInterval A)
        {
            foreach (TimeInterval interval in _L) 
            {
                if (TimeInterval.HasInersection(A, interval))
                {
                    throw new Exception("Não é possível adicionar um intervalo de tempo que faça interseção com outro!");
                }
            }
            _L.Add(A);
        }

        public void PrintList(List<TimeInterval> _L)
        {
            foreach (TimeInterval A in _L)
            {
                Console.WriteLine($"{A.InicialDate} , {A.FinalDate}");
            }
        }
    }
}
