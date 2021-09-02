using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteador.DAL
{
    public class SorteioDetalhe
    {
        public int SorteioDetalheId { get; set; }
        public int SorteioId { get; set; }
        public int ParticipanteId { get; set; }
        public string EnderecoIP { get; set; }
        public int Pontos { get; set; }
        public bool ParticipacaoValida { get; set; }
        public DateTime DataParticipacao { get; set; }
        public Participante Participante { get; set; }
        public Sorteio Sorteio { get; set; }
    }
}
