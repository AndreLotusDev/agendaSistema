using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTE_PARA_DESENVOLVEDOR.Models;

namespace TESTE_PARA_DESENVOLVEDOR.Context
{
    public class AgendaContext : DbContext
    {
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Evento> Eventos{ get; set; }
        public virtual DbSet<Participante> Participantes{ get; set; }
        public virtual DbSet<EventoUsuario> EventosUsuarios{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString.Location);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //O nome de usuario tem q ser unico
            modelBuilder.Entity<Usuario>().Property(p => p.UsuarioId).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Usuario>().Property(p => p.NomeUsuario).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Usuario>().Property(p => p.SenhaUsuario).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Usuario>().HasIndex(hk => hk.NomeUsuario).IsUnique();
            //Evento
            modelBuilder.Entity<Evento>().Property(p => p.Nome).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Evento>().Property(p => p.Descricao).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Evento>().Property(p => p.HorarioComeco).IsRequired();
            modelBuilder.Entity<Evento>().Property(p => p.HorarioFim).IsRequired();
            modelBuilder.Entity<Evento>().Property(p => p.Local).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Evento>().Property(p => p.EventoTipo).IsRequired();
            //Participante
            modelBuilder.Entity<Participante>().Property(p => p.NomeParticipante).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Participante>().Property(p => p.EventoId).IsRequired();
            //EventoUsuario
            modelBuilder.Entity<EventoUsuario>().Property(p => p.EventoId).IsRequired();
            modelBuilder.Entity<EventoUsuario>().Property(p => p.UsuarioId).IsRequired();
            modelBuilder.Entity<EventoUsuario>().HasOne(ho => ho.Evento).WithMany().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EventoUsuario>().HasOne(ho => ho.Usuario).WithMany().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EventoUsuario>().Property(p => p.UsuarioPermitiuEventoNaLista).IsRequired().HasMaxLength(1);

            base.OnModelCreating(modelBuilder);
        }
    }
}
