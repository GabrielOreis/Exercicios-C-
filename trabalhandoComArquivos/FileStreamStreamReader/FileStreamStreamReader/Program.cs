using System;
using System.IO;

namespace FileStreamStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gabri\source\repos\Exercicios C#\trabalhandoComArquivos\AquivosCriados\file1.txt";
            //FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //fs = new FileStream(path,FileMode.Open);
                sr = File.OpenText(path);
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("an error ocurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                //  if (fs != null) sr.Close();
                if (sr != null) sr.Close();
            }
        }
    }
}
