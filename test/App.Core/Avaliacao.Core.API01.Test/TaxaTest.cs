using System;
using Xunit;

namespace Avaliacao.Core.API01.Test
{
    public class TaxaTest
    {
        [Fact]
        public void GetTaxaTest()
        {
            double valorEsperado = 0.01;
            double valorCalculado = Avaliacao.Core.API01.Taxa.Get();

            Assert.Equal(valorEsperado, valorCalculado);
        }
    }
}
