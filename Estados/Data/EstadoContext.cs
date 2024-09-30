using Estados.Models;
using Microsoft.EntityFrameworkCore;

namespace Estados.Data
{
    public class EstadoContext : DbContext
    {
        public EstadoContext(DbContextOptions<EstadoContext> options) : base(options)
        {
        }
        public DbSet<EstadoModel> Estados { get; set; }
    }
}
