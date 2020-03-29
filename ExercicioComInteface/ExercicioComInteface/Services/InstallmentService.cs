using System;
using System.Collections.Generic;
using ExercicioComInteface.Entities;

namespace ExercicioComInteface.Services
{
    class InstallmentService
    {
   

        private PaypalServiceTax _taxService;

        public InstallmentService( PaypalServiceTax taxService)
        {
     
            _taxService = taxService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.Value / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.ContractDate.AddMonths(i);
                double updatedQuota = basicQuota + _taxService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _taxService.PaymentFee(updatedQuota);
                contract.addInstallment(new Installment(date, fullQuota));
            }
        }

    }
}
