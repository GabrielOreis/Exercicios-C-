using System;
using System.IO;

namespace UsandoBlocoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gabri\source\repos\Exercicios C#\trabalhandoComArquivos\AquivosCriados\file1.txt";

            try
            {
                using ( StreamReader sr = File.OpenText(path) /*FileStream fs = new FileStream(path, FileMode.Open)*/)
                {
                    /* using (StreamReader sr = new StreamReader(fs))
                     {
                         string line = sr.ReadToEnd();
                         Console.WriteLine(line);
                     }
                     */
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadToEnd();
                        Console.WriteLine(line);
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
