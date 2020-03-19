using System;
using System.IO;

namespace UsandoFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\gabri\source\repos\Exercicios C#\trabalhandoComArquivos\AquivosCriados\file1.txt";
            string targetPath = @"C:\Users\gabri\source\repos\Exercicios C#\trabalhandoComArquivos\AquivosCriados\file2.txt";

            try
            {
                File.Copy(sourcePath, targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string s in lines)
                {
                    Console.WriteLine(s);
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
