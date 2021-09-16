using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sorteador.DAL;
using Sorteador.DAL.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sorteador.BLL
{
    public class ParticipanteService
    {
        private readonly SorteadorContext _SorteadorContext;

        public ParticipanteService (SorteadorContext sorteadorContext)
        {
            _SorteadorContext = sorteadorContext;
        }

       public async Task<List<Participante>> GetParticipantes()
       {
            var response = await _SorteadorContext.Participantes.ToListAsync();
            return response;
       }

       public async Task<Participante> CriarParticipantes(Participante model)
        {
            var participante = new Participante
            {
                ParticipanteId = new Guid(),
                Nome = model.Nome
            };

            await _SorteadorContext.Participantes.AddAsync(participante);
            await _SorteadorContext.SaveChangesAsync();

            return participante;
        }
    }
}
