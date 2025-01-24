using Microsoft.EntityFrameworkCore;
using SalaCinemaAPI.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalaCinemaAPI.Infra
{
    public class ConnectionDB : DbContext
    {
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<SalaFilme> SalaFilme { get; set; }   

        public ConnectionDB(DbContextOptions<ConnectionDB> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sala>().HasKey(s => s.IdSala);
            modelBuilder.Entity<Filme>().HasKey(f => f.Id);

           /* modelBuilder.Entity<Filme>()
                .HasOne(f => f.Id)
                .WithMany(s => s.Filmes); */
            base.OnModelCreating(modelBuilder);
        }
    }
}
