using System;

namespace Intervalo
{
    internal class TimeInterval
    {
        private DateTime _I;
        private DateTime _F;

        public DateTime InicialDate
        {
            get { return _I; }
            set { _I = value; }
        }

        public DateTime FinalDate { 
            get { return _F; }
            set
            {
                if (value >= _I)
                    _F = value;
                else throw new Exception("A data final não pode ser anterior à data inicial!");
            }
        }

        public TimeSpan Duration
        {
            get {                
                return _F - _I; 
            }
        } 
        
        public TimeInterval(DateTime dateI, DateTime dateF)
        {
            _I = dateI;
            _F = dateF;
        }

        static public bool HasInersection(TimeInterval A, TimeInterval B) 
        { 
            return A.InicialDate <= B.FinalDate && B.InicialDate <= A.FinalDate; 
        }

        static public bool IsEqual(TimeInterval A, TimeInterval B) 
        {
            return A.InicialDate == B.InicialDate && A.FinalDate == B.FinalDate;
        }
    }
}
