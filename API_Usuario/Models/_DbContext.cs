using Microsoft.EntityFrameworkCore;

namespace API_Usuario.Models
{
    public class _DbContext : DbContext
    {
        public _DbContext(DbContextOptions<_DbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        } 
    
        public DbSet<Usuario> usuario { set; get; }
    }
}
