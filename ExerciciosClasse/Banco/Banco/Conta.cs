using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class Conta
    {
        public int NumeroDaConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numeroDaConta, string nomeTitular)
        {
            NumeroDaConta = numeroDaConta;
            NomeTitular = nomeTitular;
        }
        public Conta(int numeroDaConta, string nomeTitular, double depositoInicial) :this(numeroDaConta,nomeTitular)
        {
            Deposito(depositoInicial);
        }

        public void Saque( double quantia )
        {
            Saldo -= quantia + 5.00 ;
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public override string ToString()
        {
            return "Conta " + NumeroDaConta.ToString() + ", Titular:"+ NomeTitular + ", Saldo: $ "+ Saldo.ToString("F2");
        }


    }
}
