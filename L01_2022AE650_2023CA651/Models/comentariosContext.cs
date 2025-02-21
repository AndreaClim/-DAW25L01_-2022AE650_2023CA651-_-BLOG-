using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using L01_2022AE650_2023CA651.Models;
namespace L01_2022AE650_2023CA651.Models
{
    public class comentariosContext : DbContext
    {
        public comentariosContext(DbContextOptions<comentariosContext> options) : base(options)
        {
        }
        public DbSet<comentarios> comentarios { get; set; }
    }
}
