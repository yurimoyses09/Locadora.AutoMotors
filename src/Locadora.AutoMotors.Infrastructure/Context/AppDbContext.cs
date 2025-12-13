using Locadora.AutoMotors.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Locadora.AutoMotors.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Automovel> Automoveis { get; set; }
        public DbSet<Domain.Entities.Locadora> Locadoras { get; set; }

    }
}
