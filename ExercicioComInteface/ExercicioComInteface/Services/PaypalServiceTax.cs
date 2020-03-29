using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioComInteface.Services
{
    class PaypalServiceTax : IOnlinePaymentService
    {

        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, double months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
