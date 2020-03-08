using System;
using System.Collections.Generic;


namespace RegistraFuncionarios
{
    class Program

    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionariosLista = new List<Funcionario>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Funcionario funcionario = new Funcionario();

                Console.WriteLine("\nEmplyoee #{0}: ", i);

                Console.Write("Id: ");
                funcionario.Id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                funcionario.Name = Console.ReadLine();
                Console.Write("Salary: ");
                funcionario.Salary = double.Parse(Console.ReadLine());

                funcionariosLista.Add(funcionario);

            }


            Console.WriteLine("\nEnter the employee id that will have salary increase :");
            int id = int.Parse(Console.ReadLine());

            int idfunc = funcionariosLista.FindIndex(x => x.Id == id);

            if (idfunc >= 0 )
            {
                Console.Write("Enter the percentage:");
                double pocentage = double.Parse(Console.ReadLine());
                funcionariosLista[idfunc].IncreaseSalary(pocentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }


            /*
             Funcionario emp = list.Find(x => x.Id == id);

            if (emp != null) {

                Console.Write("Enter the percentage: ");

                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                emp.IncreaseSalary(percentage);

            }

            else {

                Console.WriteLine("This id does not exist!");

            }
             */

            Console.WriteLine("\nUpdated list of employees:");
            foreach (Funcionario func in funcionariosLista)
            {
                Console.WriteLine(func);
            }

        }
    }
}
