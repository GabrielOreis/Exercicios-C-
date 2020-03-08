using System;
using System.Collections.Generic;
using System.Text;
using WorkerContract.Entities.Enums;

namespace WorkerContract.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Department Departament { get; set; }

        public Worker(string name, WorkerLevel level, double baseSalary, Department departamentWorker)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departamentWorker;
            Contracts = new List<HourContract>();
        }

        public Worker() { }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double income(int year, int month)
        {

            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)

            {
                if (contract.Date.Year == year && contract.Date.Month == month)

                {
                    sum += contract.TotalValue();
                }
            }

            return sum ;
        }

    }
}
