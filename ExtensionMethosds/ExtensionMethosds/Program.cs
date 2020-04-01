using System;
//using ExtensionMethosds.Extensions;

namespace ExtensionMethosds
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * DEMO 1
             Vamos criar um extension method chamado "ElapsedTime()" no struct
             DateTime para apresentar um objeto DateTime na forma de tempo
             decorrido, podendo ser em horas (se menor que 24h) ou em dias caso
             contrário. Por exemplo:
             
             DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
             Console.WriteLine(dt.ElapsedTime());
             "4.5 hours"
             "3.2 days"
             */

            /*
             DEMO 2
             Vamos criar um extension method chamado "Cut(int)" na classe String
             para receber um valor inteiro como parâmetro e gerar um recorte do
             string original daquele tamanho. Por exemplo:

             String s1 = "Good morning dear students!";
             Console.WriteLine(s1.Cut(10));

             "Good morni..."
             */


            DateTime dt = new DateTime(2020, 04, 01, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            String s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));

        }
    }
}
