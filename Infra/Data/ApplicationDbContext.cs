using Microsoft.EntityFrameworkCore;
using WebNet.Domain;

namespace WebNet.Infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
        protected override void ConfigureConvertions(ModelConfigurationBuilder config)
        {
            config.Properties<string>().HaveMaxLength(100);
        }
    }
}
