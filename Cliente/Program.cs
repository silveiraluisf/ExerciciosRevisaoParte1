namespace Cliente
{
    public class Program
    {
        public static void Main()
        {
            Client clientA= new Client();
           

            Console.WriteLine("---- BEM-VINDO AO SISTEMA DE CADASTRO ----");
            Console.WriteLine("");
        
            clientA.NameValidate(clientA);
            Console.WriteLine($"O nome {clientA.Name} foi cadastrado.");
            Console.WriteLine("");

            clientA.CPFValidate(clientA);
            Console.WriteLine($"O CPF {clientA.CPF} foi cadastrado.");
            Console.WriteLine("");

            clientA.BirthDateValidate(clientA);  
            Console.WriteLine($"A data de nascimento {clientA.BornDate} foi cadastrada.");
            Console.WriteLine("");

            clientA.IncomeValidate(clientA);    
            Console.WriteLine($"A renda de {clientA.MonthlyIncome:F2} $ por mês foi cadastrada.");
            Console.WriteLine("");

            clientA.StatusValidate(clientA);
            Console.WriteLine($"O estado civil {clientA.MaritalStatus} foi cadastrado.");
            Console.WriteLine("");

            clientA.DependentsValidate(clientA);
            Console.WriteLine($"O(s) {clientA.NumberOfDependents} dependente(s) foi(ram) cadastrado(s).");
            Console.WriteLine("");

            Console.WriteLine("---- RESUMO DO CASTRO ----");
            Console.WriteLine($"Nome: {clientA.Name}");
            Console.WriteLine($"CPF: {clientA.CPF}");
            Console.WriteLine($"Data de nascimento: {clientA.BornDate}");
            Console.WriteLine($"Renda mensal: {clientA.MonthlyIncome}");
            Console.WriteLine($"Estado civil: {clientA.MaritalStatus}");
            Console.WriteLine($"Número de dependentes: {clientA.NumberOfDependents}");
        }
    }
}
