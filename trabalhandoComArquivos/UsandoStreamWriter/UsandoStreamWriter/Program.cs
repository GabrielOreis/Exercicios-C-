using System;
using System.IO;

namespace UsandoStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\gabri\source\repos\Exercicios C#\trabalhandoComArquivos\AquivosCriados\file1.txt";
            string targetPath = @"C:\Users\gabri\source\repos\Exercicios C#\trabalhandoComArquivos\AquivosCriados\file3.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines) {
                        sw.WriteLine(line.ToUpper());
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
