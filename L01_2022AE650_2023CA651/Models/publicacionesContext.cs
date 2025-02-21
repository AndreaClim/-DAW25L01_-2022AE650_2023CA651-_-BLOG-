using Microsoft.EntityFrameworkCore;

namespace L01_2022AE650_2023CA651.Models
{
    public class publicacionesContext : DbContext
    {
        public publicacionesContext(DbContextOptions<publicacionesContext> options) : base(options)
        {
        }
        public DbSet<publicaciones> publicaciones { get; set; }
    }
}
