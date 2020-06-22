using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Avaliacao.API01.Controllers
{
    [Route("/")]
    [ApiController]
    public class TaxaController : ControllerBase
    {
        [HttpGet]
        [Route("/TaxaJuros")]
        public async Task<ActionResult> TaxaJuros()
        {
            return Ok(Avaliacao.Core.API01.Taxa.Get());
        }
    }
}
