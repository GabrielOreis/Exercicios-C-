using System;
using System.Collections.Generic;

namespace ExercicioConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A:");

            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                A.Add(value);
            }

            Console.Write("O curso B possui quantos alunos? ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B:");

            for (int i = 0; i < n1; i++)
            {
                int value = int.Parse(Console.ReadLine());
                B.Add(value);
            }

            Console.Write("O curso C possui quantos alunos? ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C:");

            for (int i = 0; i < n2; i++)
            {
                int value = int.Parse(Console.ReadLine());
                C.Add(value);
            }

            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(B);
            Novo.UnionWith(C); 

            Console.WriteLine("Total de Alunos: " + Novo.Count);

        }
    }
}
