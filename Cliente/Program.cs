using System;

namespace Cliente
{
    public class Program
    {
        public static void Main()
        {
            Client clientA= new Client();
            _ = clientA.Name;
            _ = clientA.CPF;
            _ = clientA.BornDate;
            _ = clientA.MonthlyIncome;
            _ = clientA.MaritalStatus;
            _ = clientA.NumberOfDependents;

            Console.WriteLine("---- BEM-VINDO AO SISTEMA DE CADASTRO ----");
            Console.WriteLine("");

            Console.WriteLine("Insira o nome do cliente: ");
            string name = Console.ReadLine();
            Console.WriteLine($"O nome {name} foi cadastrado.");
            Console.WriteLine("");

            Console.WriteLine("Insira o CPF: ");
            long cpf = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"O CPF {cpf} foi cadastrado.");
            Console.WriteLine("");

            Console.WriteLine("Insira a data de nascimento (DD/MM/AAAA): ");
            DateTime born = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine($"A data de nascimento {born} foi cadastrada.");
            Console.WriteLine("");

            Console.WriteLine("Insira a renda mensal: ");
            float income = (float) Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A renda de {income:F2} $ por mês foi cadastrada.");
            Console.WriteLine("");

            Console.WriteLine("Insira o estado civil (C, S, V ou D): ");
            char status = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"O estado civil {status} $ foi cadastrado.");
            Console.WriteLine("");

            Console.WriteLine("Insira o número de dependentes (de 0 a 10): ");
            int dependents = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O(s) {dependents} $ dependente(s) foi(ram) cadastrado(s).");
            Console.WriteLine("");

            Console.WriteLine("---- RESUMO DO CASTRO ----");
            Console.WriteLine($"Nome: {name}");
            Console.WriteLine($"CPF: {cpf}");
            Console.WriteLine($"Data de nascimento: {born}");
            Console.WriteLine($"Renda mensal: {income}");
            Console.WriteLine($"Estado civil: {status}");
            Console.WriteLine($"Número de dependentes: {dependents}");
        }
    }
}
