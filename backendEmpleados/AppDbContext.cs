using Microsoft.EntityFrameworkCore;

namespace backendEmpleados
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
