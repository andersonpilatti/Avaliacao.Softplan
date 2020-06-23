using Avaliacao.Cross.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Avaliacao.API02.Controllers
{
    [Route("/")]
    [ApiController]
    public class CalculoController : ControllerBase
    {
        [HttpGet]
        [Route("/CalculaJuros")]
        public async Task<ActionResult> CalculaJuros(double valorInicial, int meses)
        {
            if (valorInicial == 0 ||
                meses == 0)
            {
                return NotFound();
            }

            try
            {
                var client = RestService.For<ITaxaService>("https://localhost:44388/");
                double taxa = await client.GetTaxaJuros();
                double result = Avaliacao.Core.API02.Juros.CalcularComposto(valorInicial, taxa, meses);

                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("/ShowMeTheCode")]
        public async Task<ActionResult> ShowMeTheCode()
        {
            return Ok(Request.Path);
        }
    }
}
