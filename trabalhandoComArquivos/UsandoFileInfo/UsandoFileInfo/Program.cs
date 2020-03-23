using System;
using System.IO;

namespace UsandoFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\gabri\source\repos\Exercicios C#\trabalhandoComArquivos\AquivosCriados\file1.txt";
            string targetPath = @"C:\Users\gabri\source\repos\Exercicios C#\trabalhandoComArquivos\AquivosCriados\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
