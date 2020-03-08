using System;
using System.Globalization;

namespace ExerciciosClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EXERCÍCIO 01:
             * Fazer um programa para ler os valores da largura e altura de um retângulo. 
             * Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. 
             * Usar uma classe como mostrado no projeto ao lado. 
             */

            /*
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            retangulo.Altura = double.Parse(Console.ReadLine());
            retangulo.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = " + retangulo.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            */

            /*------------------------------------------------------------------------------------
            EXERCÍCIO 02: 
            Fazer um programa para ler os dados de um funcionário(nome, salário bruto e imposto). 
            Em seguida, mostrar os dados do funcionário(nome e salário líquido).
            Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada
            (somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados 
            do funcionário.Use a classe projetada abaixo.
            */

            /*
            Funcionario func = new Funcionario();

            Console.Write("Nome:");
            func.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("\nFuncionário: " + func + "\n");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            func.AlmentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: " + func);
            */

            //--------------------------------------------------------------------------------
            /* EXERCÍCIO 03: 
             Fazer um programa para ler o nome de um aluno e as três notas que ele obteve
             nos três trimestres do ano (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada).
             Ao final, mostrar qual a nota final do aluno no ano. Dizer também se o aluno está
             APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo 
             para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver este problema. 
             */

            /*
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 =double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());
            */
            

        }
    }
}
