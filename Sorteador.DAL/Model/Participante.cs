using Newtonsoft.Json;
using System;

namespace Sorteador.DAL.Model
{
    public class Participante
    {
        public Guid ParticipanteId { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }
    }
}
