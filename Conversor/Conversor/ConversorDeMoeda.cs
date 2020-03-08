using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor
{
    class ConversorDeMoeda
    {

        public static double Iof = 6.0;

        public static double DolarParaReal(double quantia , double dolar) {
            double total = quantia * dolar;
            return total + total * Iof / 100.0  ;
        }
    }
}
