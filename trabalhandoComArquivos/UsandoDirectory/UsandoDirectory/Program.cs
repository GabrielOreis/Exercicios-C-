using System;
using System.IO;
using System.Collections.Generic;

namespace UsandoDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gabri\source\repos\Exercicios C#\trabalhandoComArquivos\UsandoDirectory\myfolder";

            try
            {

                /*IEnumerable <string>*/
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(@"C:\Users\gabri\source\repos\Exercicios C#\trabalhandoComArquivos\UsandoDirectory\myfolder\newfolder");

                // Directory.CreateDirectory(path + @"\newfolder ou \\newfolder")
            }
            catch (IOException e)
            {
                Console.WriteLine("an error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
