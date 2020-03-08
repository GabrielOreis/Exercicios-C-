

namespace ExerciciosClasse
{
    class Aluno
    {
        public double Nota1,Nota2,Nota3;
        public string Nome;

        public string NotaFinal() {

            double notafinal = Nota1 + Nota2 + Nota3;

            if (notafinal >= 60.0)
            {
                return "Nota final = " + notafinal.ToString("F2") + "\nAPROVADO";
            }
            else
            {
                double falta = 60.0 - notafinal;
                return "Nota final = " + notafinal.ToString("F2") + "\nREPROVADO \nFaltaram = "+falta.ToString("F2") ;
            }
        }




    }
}
