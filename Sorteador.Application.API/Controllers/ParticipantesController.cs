using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sorteador.BLL;
using Sorteador.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorteador.Application.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParticipantesController : Controller
    {
        private readonly ParticipanteService _participanteService;

        public ParticipantesController(ParticipanteService participanteService)
        {
            _participanteService = participanteService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var participantes = _participanteService.GetParticipantes();
            return Ok(participantes);
        }

        [HttpPost("criar")]
        public async Task<IActionResult> CriarParticipante(Participante model)
        {
            var result = await _participanteService.CriarParticipantes(model);
            return Ok(result);
        }
    }
}
