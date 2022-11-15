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
            set { _Name = value; }
        }
        public long CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }
        public DateTime BornDate
        {
            get { return _BornDate; }
            set { _BornDate = value; }
        }
        public float MonthlyIncome
        {
            get { return _MonthlyIncome; }
            set { _MonthlyIncome = value; }
        }
        public char MaritalStatus
        {
            get { return _MaritalStatus; }
            set { _MaritalStatus = value; }
        }
        public int NumberOfDependents
        {
            get { return _NumberOfDependents; }
            set { _NumberOfDependents = value; }
        }

        public void NameValidate(Client C)
        {
            Console.WriteLine("Insira o nome do cliente: ");
            C.Name = Console.ReadLine();
            string name = C._Name;
            switch (name.Length)
            {
                case 0:
                    Console.WriteLine("O nome não pode ser vazio!");
                    NameValidate(C);
                    break;
                case <5:
                    Console.WriteLine("O nome deve possuir pelo menos 5 caracteres");
                    NameValidate(C);
                    break;
                case >= 5:
                    C.Name = _Name;
                    break;
            }           
        }

        public void CPFValidate(Client C)
        {
            Console.WriteLine("Insira o CPF: ");
            string inputCPF = Console.ReadLine();
            switch (inputCPF.Length)
            {
                case 11:
                    C.CPF = Convert.ToInt64(inputCPF);
                    C.CPF = _CPF;
                    break;
                default:
                    Console.WriteLine("Favor insira um CPF válido (11 caracteres, apenas números).");
                    CPFValidate(C);
                    break;
            }
        }

        public void BirthDateValidate(Client C)
        {
            Console.WriteLine("Insira a data de nascimento (DD/MM/AAAA):");
            DateTime inputBirthDate = Convert.ToDateTime(Console.ReadLine());
        }

        public void IncomeValidate(Client C)
        {
            Console.WriteLine("Insira a renda mensal: ");
            C.MonthlyIncome = (float)Convert.ToDouble(Console.ReadLine());
            //if (C.MonthlyIncome < DateTimeKind(1,1,2002)) { }
        }

        public void StatusValidate(Client C)
        {
            Console.WriteLine("Insira o estado civil (C, S, V ou D): ");           
            char inputStatus = Convert.ToChar(Console.ReadLine());
            switch (Char.ToUpper(inputStatus))
            {
                case 'C':
                    C.MaritalStatus = 'C';
                    C.MaritalStatus = _MaritalStatus;
                    break;
                case 'S':
                    C.MaritalStatus = 'S';
                    C.MaritalStatus = _MaritalStatus;
                    break;
                case 'V':
                    C.MaritalStatus = 'V';
                    C.MaritalStatus = _MaritalStatus;
                    break;
                case 'D':
                    C.MaritalStatus = 'D';
                    C.MaritalStatus = _MaritalStatus;
                    break;
                default:
                    Console.WriteLine("Favor insira um estado civil válido (C, S, V ou D).");
                    StatusValidate(C);
                    break;
            }
        }

        public void DependentsValidate(Client C)
        {
            Console.WriteLine("Insira o número de dependentes (de 0 a 10): ");
            C.NumberOfDependents = Convert.ToInt32(Console.ReadLine());
            NumberOfDependents = C._NumberOfDependents;
            if (NumberOfDependents >= 0 && NumberOfDependents <= 10)
            {
                C.NumberOfDependents = _NumberOfDependents;
            }
            else
            {
                Console.WriteLine("Favor insira um valor válido (entre 0 e 10).");
                DependentsValidate(C);
            }
        }
    }
}
