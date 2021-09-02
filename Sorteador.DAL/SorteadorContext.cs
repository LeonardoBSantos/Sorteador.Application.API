using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteador.DAL
{
    public class SorteadorContext: DbContext
    {
        public SorteadorContext(DbContextOptions<SorteadorContext> options) : base(options) { }

        DbSet<Participante> Participantes { get; set; }
        DbSet<Sala> Salas { get; set; }
        DbSet<Sorteio> Sorteios { get; set; }
        DbSet<SorteioDetalhe> SorteioDetalhes { get; set; }
        DbSet<Usuario> Usuarios { get; set; }

    }
}
