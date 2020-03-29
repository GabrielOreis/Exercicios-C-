using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioComInteface.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount,double months);
    }
}
