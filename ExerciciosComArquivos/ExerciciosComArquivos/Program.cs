using System;
using System.IO;
using System.Globalization;
using ExerciciosComArquivos.Entities;

namespace ExerciciosComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler o caminho de um arquivo .csv
             contendo os dados de itens vendidos. Cada item possui um
             nome, preço unitário e quantidade, separados por vírgula. Você
             deve gerar um novo arquivo chamado "summary.csv", localizado
             em uma subpasta chamada "out" a partir da pasta original do
             arquivo de origem, contendo apenas o nome e o valor total para
             aquele item (preço unitário multiplicado pela quantidade),
             conforme exemplo.                        
             */
            try
            {
                Console.Write("Digite o caminho: ");
                string sourceFilePath = Console.ReadLine();

                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.txt";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {

                        string[] fields = line.Split(',');
                        string nome = fields[0];
                        double valor = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantidade = int.Parse(fields[2]);


                        Product prod = new Product(nome, valor, quantidade);

                        sw.WriteLine(prod.Nome + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("an error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
