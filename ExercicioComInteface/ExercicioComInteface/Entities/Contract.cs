using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioComInteface.Entities
{
    class Contract
    {
        public int NumberContract { get; set; }
        public DateTime ContractDate { get; set; }
        public double Value { get; set; }

        public List <Installment>  Installments { get; private set; } 

        public Contract(int number, DateTime contractDate, double value)
        {
            NumberContract = number;
            ContractDate = contractDate;
            Value = value;
            Installments = new List<Installment>();
        }

        public void addInstallment(Installment installment)
        {
            Installments.Add(installment);
        }

    }
}
