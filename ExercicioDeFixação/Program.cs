using System;
using System.Globalization;


namespace ExercicioDeFixação
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria numero;

            Console.Write("Digite o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            if(resposta == 's' || resposta == 'S')
            {
                Console.Write("Digite o valor do deposito inicial: ");
                double depositoinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                numero = new ContaBancaria(conta, titular, depositoinicial);
            }
            else
            {
                numero = new ContaBancaria(conta, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            numero.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(numero);

            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            numero.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(numero);



        }
    }
}
