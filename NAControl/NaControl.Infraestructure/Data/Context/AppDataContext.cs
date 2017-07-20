using NaControl.Domain.Models;
using NaControl.Infraestructure.Data.Map;
using System.Data.Entity;

namespace NaControl.Infraestructure.Data
{
    public class AppDataContext: DbContext
    {
        public AppDataContext() : base("AppConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMapa());
        }
    }
}
