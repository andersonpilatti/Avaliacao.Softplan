using System;

namespace Avaliacao.Core.API02
{
    public class Juros
    {
        public static double CalcularComposto(double valorInicial, double taxa, int meses, int precisao = 2)
        {
            return Math.Round(valorInicial * Math.Pow((double)(1 + taxa), meses), precisao);
        }
    }
}
