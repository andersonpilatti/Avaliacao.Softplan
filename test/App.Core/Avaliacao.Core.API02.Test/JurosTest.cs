using System;
using Xunit;

namespace Avaliacao.Core.API02.Test
{
    public class JurosTest
    {
        [Fact]
        public void CalculaJurosTest()
        {
            int meses = 5;
            double taxa = 0.01;

            double valorInicial = 100;
            double valorCalculado = Avaliacao.Core.API02.Juros.CalcularComposto(valorInicial, taxa, meses);
            double valorEsperado = 105.10;

            Assert.Equal(valorEsperado, valorCalculado);
        }
    }
}
