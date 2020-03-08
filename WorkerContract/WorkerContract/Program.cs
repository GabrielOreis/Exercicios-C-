using System;
using WorkerContract.Entities.Enums;
using WorkerContract.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace WorkerContract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            Department department = new Department(Console.ReadLine());

            Console.Write("Enter worker data: ");

            Console.Write("\nName:");
            string name = Console.ReadLine();

            Console.Write("Level(Junior/ MidLevel / Senior): ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine().ToUpper());

            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            Worker worker = new Worker(name, workerLevel, salary, department);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter # {n} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double hourValue = double.Parse(Console.ReadLine());

                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, hourValue, duration);

                worker.addContract(contract);
            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));


            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Departament.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.income(year, month).ToString("F2")); 


        }

    }
}
