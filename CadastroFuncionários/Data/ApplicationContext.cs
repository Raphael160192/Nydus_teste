using CadastroFuncionários.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CadastroFuncionários.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<HistoricoCargo> HistoricoCargos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HistoricoCargo>()
            .HasOne(hc => hc.Cargo)
            .WithMany()
            .HasForeignKey(hc => hc.CargoId);

            modelBuilder.Entity<HistoricoCargo>()
            .HasOne(hc => hc.Colaborador)
            .WithMany(c => c.HistoricoCargos)
            .HasForeignKey(hc => hc.ColaboradorId);
        }
    }
}
