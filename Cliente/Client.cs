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
            get;
            private set;
        }
        public long CPF
        {
            get;
            private set;
        }
        public DateTime BornDate
        {
            get;
            private set;
        }
        public float MonthlyIncome
        {
            get;
            private set;
        }
        public char MaritalStatus
        {
            get;
            private set;
        }
        public int NumberOfDependents
        {
            get;
            private set;
        }


    }
}
