using Microsoft.EntityFrameworkCore;
using ModeloDesSoftware.Repositorio.Entidade;
using System.Reflection;

namespace ModeloDesSoftware.Repositorio.Repositorio
{
    public class EFContexto : DbContext
    {
        public virtual DbSet<Cliente> Clientes { get; set; }
        public EFContexto(DbContextOptions options): base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder
            //    .UseSqlServer("Server=L-TO-THE-APTOP\\SQLEXPRESS;Database=Maloli;Trusted_Connection=True;MultipleActiveResultSets=true");

            //optionsBuilder.ConfigureWarnings(x => x.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
            Assembly assemblyWithConfigurations = GetType().Assembly; //get whatever assembly you want
            modelBuilder.ApplyConfigurationsFromAssembly(assemblyWithConfigurations);
        }
    }
}
