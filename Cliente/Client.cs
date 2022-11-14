namespace Cliente
{
    public class Client
    {
        private string _Name;
        private long _CPF;
        private DateTime _BornDate;
        private float _MonthlyIncome;
        private char _MaritalStatus;
        private int _NumberOfDependents;

        public string Name
        {
            get { return _Name; }
            private set { _Name = value; }
        }
        public long CPF
        {
            get { return _CPF; }
            private set { _CPF = value; }
        }
        public DateTime BornDate
        {
            get { return _BornDate; }
            private set { _BornDate = value; }
        }
        public float MonthlyIncome
        {
            get { return _MonthlyIncome; }
            private set { _MonthlyIncome = value; }
        }
        public char MaritalStatus
        {
            get { return _MaritalStatus; }
            private set { _MaritalStatus = value; }
        }
        public int NumberOfDependents
        {
            get { return _NumberOfDependents; }
            private set { _NumberOfDependents = value; }
        }


    }
}
