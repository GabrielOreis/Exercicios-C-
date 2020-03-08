using System;
using System.Collections.Generic;
using System.Text;

namespace RegistraFuncionarios
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get;set; }

        public Funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public Funcionario()
        {
        }

        public void IncreaseSalary(double percentage) {
            Salary += Salary  *  percentage / 100.0;
        }

        public override string ToString()
        {
            return  Id.ToString()+ ", " + Name + ", "+ Salary.ToString("F2");
        }
    }
}
