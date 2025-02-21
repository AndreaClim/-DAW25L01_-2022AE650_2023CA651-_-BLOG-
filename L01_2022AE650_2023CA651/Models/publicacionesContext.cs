using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using L01_2022AE650_2023CA651.Models;


namespace L01_2022AE650_2023CA651.Models
{
    public class publicacionesContext : DbContext
    {
        public publicacionesContext(DbContextOptions<publicacionesContext> options) : base(options)
        {
        }
        public DbSet<publicaciones> publicaciones { get; set; }
        public DbSet<comentarios> comentarios { get; set; }

        public DbSet<usuarios> usuarios { get; set; }
    }
}
