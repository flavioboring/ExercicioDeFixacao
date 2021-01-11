using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioDeFixação
{
    class ContaBancaria
    {
        public int Conta { get; private set; }
        public  string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }
        public ContaBancaria(int conta, string titular, double depositoInicial) : this(conta, titular)
        {
            Deposito(depositoInicial);
        }
        public void  Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.00;
        }
        public override string ToString()
        {
            return "Conta "
                + Conta
                + ", Titular "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
