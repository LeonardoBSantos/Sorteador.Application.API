using Microsoft.EntityFrameworkCore;
using Sorteador.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteador.DAL
{
    public class SorteadorContext: DbContext
    {
        public SorteadorContext()
        {
        }

        public SorteadorContext(DbContextOptions<SorteadorContext> options) : base(options) { }

        public DbSet<Participante> Participantes { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Sorteio> Sorteios { get; set; }
        public DbSet<SorteioDetalhe> SorteioDetalhes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Participante>().Property(p => p.ParticipanteId).HasDefaultValueSql("NEWID()");
        }
    }
}
