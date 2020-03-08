using System;

namespace AluguelQuartos
{

    using System;

    namespace AluguelQuartos
    {
        class Program
        {
            static void Main(string[] args)
            {


                Estudante[] estudantes = new Estudante[10];

                Console.Write("Quantos quartos serão alugados? ");
                int n= int.Parse(Console.ReadLine());


                for (int i = 1; i <= n; i++)
                {
                    Estudante estudante = new Estudante();

                    Console.WriteLine($"\nAluguel #:{i}");

                    Console.Write("Nome : ");
                    estudante.Nome = Console.ReadLine();

                    Console.Write("Email : ");
                    estudante.Email = Console.ReadLine();

                    Console.Write("Room : ");

                    int quarto = int.Parse(Console.ReadLine()) -1;

                    bool rep = true;

                    while (rep)
                    {
                        if (estudantes[quarto] == null)
                        {
                            estudantes[quarto] = estudante;
                            rep = false;
                        }
                        else
                        {
                            Console.WriteLine("Quanto ocupado! \nDigite o numero do quarto: ");
                            quarto = int.Parse(Console.ReadLine()) - 1;
                        }
                    }
                }
                Console.WriteLine("\nQuartos ocupados: ");

                for (int i = 0; i < 10; i++)
                {
                    if (estudantes[i] != null)
                    {
                        Console.WriteLine(1+i + ": " + estudantes[i]);
                    }
                }
            }
        }
    }
}

