using Microsoft.Data.Entity;
using PaginaPerfil_V1_net_4_6.Modelo;

namespace PaginaPerfil_V1_net_4_6.Models
{
    public class PaginaPerfil_V1_net_4_6Context : DbContext
    {
        private static bool _created = false;

        public PaginaPerfil_V1_net_4_6Context()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }

        public DbSet<Contacto> Contacto { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Maps> Maps { get; set; }
    }
}
