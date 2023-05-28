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
            // Aqui você pode adicionar configurações adicionais, como chaves primárias compostas ou restrições.
            // Por exemplo, se desejar definir uma chave primária composta na tabela HistoricoCargo:
            // modelBuilder.Entity<HistoricoCargo>().HasKey(hc => new { hc.Id, hc.ColaboradorId });
        }
    }
}
