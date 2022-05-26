using Microsoft.EntityFrameworkCore;
using ProjetoConcessionaria.Lib.Models;
namespace ProjetoConcessionaria.Lib.Data
{
    public class ConcessionariaContext : DbContext
    {
        public ConcessionariaContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Carro>().ToTable("carros");
            modelBuilder.Entity<Moto>().ToTable("motos");
            modelBuilder.Entity<Cliente>().ToTable("clientes");
            modelBuilder.Entity<Funcionario>().ToTable("funcionarios");
            modelBuilder.Entity<Venda>().ToTable("vendas");
        }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Moto> Motos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}