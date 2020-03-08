using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            
            if (resp == 's' || resp == 'S') {

                Console.Write("Entre o valor de depósito inicial: ");
                double valor = double.Parse(Console.ReadLine());
                conta1 = new Conta(numeroConta, nome, valor);
            }
            else
            {
                conta1 = new Conta(numeroConta, nome) ;
            }

            Console.WriteLine("\nDados da conta:\n"+conta1);

            Console.Write("\nEntre um valor para depósito: ");
            conta1.Deposito(double.Parse(Console.ReadLine()));

            Console.WriteLine("\nDados da conta:\n" + conta1);

            Console.Write("\nEntre um valor para saque: ");
            conta1.Saque(double.Parse(Console.ReadLine()));

            Console.WriteLine("\nDados da conta:\n" + conta1);


        }
    }
}
