using System;
using System.Collections.Generic;
using System.IO;
using UsandoOIComparable.Entities;

namespace UsandoOIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gabri\source\repos\Exercicios C#\UsandoOIComparable\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
