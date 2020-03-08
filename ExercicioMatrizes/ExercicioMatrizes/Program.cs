using System;

namespace ExercicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EXERCICIO 01
             * Fazer um programa para ler um número inteiro N e uma matriz de ordem N contendo números inteiros.
             * Em seguida, mostrar a diagonal principaleaquantidadedevaloresnegativosdamatriz.
             Ex:
             Input: 3 5 -3 
                    10 15 8
                    2 7  9 -4 

             Output: Main diagonal: 5 8 -4 
                     Negative numbers = 2
             */

            /*
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];
            int numerosNegativo = 0;

            Console.WriteLine("Digite os valores:");

            for (int i = 0; i < n; i++)
            {

                string[] values = Console.ReadLine().Split(' ');

                for (int a = 0; a < n; a++)
                {

                    int numero = int.Parse(values[a]);
                    if (numero < 0)
                    {
                        numerosNegativo++;
                    }
                    matriz[i, a] = numero;
                }
            }

            Console.WriteLine("Números na diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + matriz[i, i]);
            }

            Console.WriteLine("\nNúmeros negativos= " + numerosNegativo);

            */

            /* EXERCICIO 02
             * Fazer um programa para ler dois números inteiros M e N, e depois ler uma matriz de M linhas por N colunas 
             * contendo números inteiros, podendo haver repetições. Em seguida, ler um número inteiro X que pertence à matriz.
             * Para cada ocorrência de X, mostrar os valores à esquerda, acima, à direita e abaixo de X, quando houver, 
             * conforme exemplo.
             */

            Console.WriteLine("Digite dois número: ");
            int l = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int[,] matriz = new int[l, c];

            //preenche a matriz
            for (int i = 0; i < l; i++)
            {

                string[] values = Console.ReadLine().Split(' ');

                for (int a = 0; a < c; a++)
                {

                    int numero = int.Parse(values[a]);
                    matriz[i, a] = numero;
                }
            }

            //procura os números proximos ao número escolhido

            Console.WriteLine("Digite um numero: ");
            int numeroBusca = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++)
            {
                for (int a = 0; a < c; a++)
                {
                    if (matriz[i,a] == numeroBusca) {
                        Console.WriteLine("Position "+i+','+a);
                        if (a > 0) {
                            Console.WriteLine("Left: " + matriz[i, a - 1]);
                        }
                        if (a < c-1)
                        {
                            Console.WriteLine("Right: " + matriz[i, a + 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, a]);
                        }
                        if (i < l-1 )
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, a]);
                        }
                    }
                    
                   
                }
            }
        }
    }
}
