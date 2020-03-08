using System;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar? ");
            double cotacao =double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dólares você vai comprar?");
            double quantia = double.Parse(Console.ReadLine());

            double result =  ConversorDeMoeda.DolarParaReal(cotacao,quantia);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2")); 
            
        }
    }
}
