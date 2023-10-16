using Microsoft.EntityFrameworkCore;

namespace Registro.Models
{
    public class RegistroContext : DbContext
    {
        public DbSet<Estudiante> Estudiante { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=jhonson;Database=PrograII;Trusted_Connection=SSPI;MultipleActiveResultSets=true;TrustServerCertificate=true;");
        }
    }
}
