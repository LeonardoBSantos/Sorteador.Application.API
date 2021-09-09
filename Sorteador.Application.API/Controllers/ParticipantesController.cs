using Microsoft.AspNetCore.Mvc;
using Sorteador.BLL;
using Sorteador.DAL.Model;
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
            // Esse return Ok( objeto ) já vai retornar um ActionResult, e o objeto passado como parâmetro vai estar no body
            // da resposta, então não precisa vir um ActionResult da camada de negócio (BLL)
            return Ok(_participanteService.GetParticipantes());
        }

        [HttpPost("criar")]
        public async Task<IActionResult> CriarParticipante(Participante model)
        {
            var result = await _participanteService.CriarParticipantes(model);
            return Ok(result);
        }
    }
}
