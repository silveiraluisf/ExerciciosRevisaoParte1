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
        public TimeIntervalsList(List<TimeInterval> TimeList) 
        {
            _L = TimeList;            
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

        public void PrintList(List<TimeInterval> L)
        {
            L = _L.OrderBy(e => e.InicialDate).ToList();
            foreach (TimeInterval A in L)
            {
                Console.WriteLine($"{A.InicialDate} , {A.FinalDate}");
            }
        }
    }
}
