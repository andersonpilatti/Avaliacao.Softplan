using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Avaliacao.API02.Controllers
{
    [Route("/")]
    [ApiController]
    public class CalculoController : ControllerBase
    {
        [HttpGet]
        [Route("/CalculaJuros")]
        public async Task<double> CalculaJuros(double valorInicial, int meses)
        {
            //double taxa = await _taxaService.GetTaxaJuros();

            //var _taxaService = RestService.For<ITaxaService>("https://localhost:44388/");
            //double taxa = await _taxaService.GetTaxaJuros();

            //return Avaliacao.Core.API02.Juros.CalcularComposto(valorInicial, taxa, meses);

            return 0;
        }

        [HttpGet]
        [Route("/ShowMeTheCode")]
        public string ShowMeTheCode()
        {
            return Request.Path;
        }
    }
}
