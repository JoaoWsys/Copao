using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Domain.Entities;

namespace Data
{
    public class CopaoDbContext : DbContext
    {
        private IConfiguration _configuration;

        public DbSet<Usuario> Users { get; set; }

        public CopaoDbContext(IConfiguration configuration, DbContextOptions options) : base(options)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySQL(connectionString);
        }
    }
}