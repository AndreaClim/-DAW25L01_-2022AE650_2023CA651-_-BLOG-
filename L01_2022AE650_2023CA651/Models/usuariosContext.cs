using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using L01_2022AE650_2023CA651.Models;
namespace L01_2022AE650_2023CA651.Models
{
    public class usuariosContext : DbContext
    {
        public usuariosContext(DbContextOptions<usuariosContext> options) : base(options)
        {
        }
        public DbSet<usuarios> usuarios { get; set; }
    }
}
