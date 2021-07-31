using Microsoft.EntityFrameworkCore;
using ModeloDesSoftware.Repositorio.Entidade;
using System.Reflection;

namespace ModeloDesSoftware.Repositorio.Context
{
    public class EFContexto : DbContext
    {
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public EFContexto(DbContextOptions options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Assembly assemblyWithConfigurations = GetType().Assembly; //get whatever assembly you want
            modelBuilder.ApplyConfigurationsFromAssembly(assemblyWithConfigurations);
        }
    }
}
