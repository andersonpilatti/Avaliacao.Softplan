using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao.Cross.Interfaces
{
    public interface ITaxaService
    {
        [Get("/TaxaJuros")]
        Task<double> GetTaxaJuros();
    }
}
