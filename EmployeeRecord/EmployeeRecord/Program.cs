using System;
using EmployeeRecord.Entities;
using System.Collections.Generic;

namespace EmployeeRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char result = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePorHour = double.Parse(Console.ReadLine());

                if (result == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valuePorHour, additional));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePorHour));
                }
            }
            Console.WriteLine("\nPAYMENTS:");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name+" -  $"+emp.Payment().ToString("F2"));
            }
        }
    }
}
