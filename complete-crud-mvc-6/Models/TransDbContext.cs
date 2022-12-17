using Microsoft.EntityFrameworkCore;

namespace complete_crud_mvc_6.Models
{
    public class TransDbContext:DbContext
    {
        public TransDbContext(DbContextOptions<TransDbContext>options):base(options)
        {

        }
        public DbSet<Trans> Trans { get; set; }
    }
}
