using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banda.domain.DTO;
using Banda.domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Banda.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BandaTocarController : ControllerBase
    {
        private readonly IGrupoServico _grupoServico;

        public BandaTocarController(IGrupoServico grupoServico)
        {
            _grupoServico = grupoServico;
        }

        [HttpPost]
        public IActionResult Inserir (GrupoDTO grupoDTO){
            
            _grupoServico.Inserir(grupoDTO);

            return StatusCode(StatusCodes.Status201Created);
        }
    }
}