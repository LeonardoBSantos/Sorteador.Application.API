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

       public async Task<IEnumerable<Participante>> GetParticipantes()
       {
            var response = await _SorteadorContext.Participantes.ToListAsync();
            return response;
       }

       public async Task<Participante> CriarParticipantes(Participante model)
        {
            // Na camada de BLL (Business Logic Layer) deveriam também estar as validações de negócio
            // Então teria que ter as regras de validação do model recebido
            // Se o nome for uma string em branco, vai permitir que seja gravado, ou terá que retornar uma mensagem de erro?
            // Como será enviada uma mensagem de erro para quem fez essa requisição?


            // Algumas empresas utilizam as Exceptions como padrão de notificação de erro
            // Outras utilizam o NotificationPattern
            // Existe também o FluentValidation que ajuda a fazer validações em qualquer Pattern escolhido
            if (string.IsNullOrEmpty(model.Nome))
            {
                throw new Exception("Nome é obrigatório");
            }


            var participante = new Participante
            {
                Nome = model.Nome
            };



            // Geralmente se utiliza o Repository Pattern na camada de Data Access (DAL), e na BLL não utilizamos diretamente
            // As classes do EntityFramework


            // Se está usando o padrão assíncrono, utilize os métodos Async em conjunto como await
            await _SorteadorContext.AddAsync(participante);

            // Não esqueça de salvar as alterações após Add, Update e Remove
            await _SorteadorContext.SaveChangesAsync();

            return participante;
        }
    }
}
