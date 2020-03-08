
using System.Globalization;

namespace ExerciciosClasse
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AlmentarSalario( double porcentagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }


        public override string ToString()
        {
            return Nome + ", R$: " + SalarioLiquido().ToString("F2");
        }
    }
}
