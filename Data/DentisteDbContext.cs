using Microsoft.EntityFrameworkCore;

namespace Dentiste.Data
{
    public class DentisteDbContext : DbContext
    {
        public DentisteDbContext(DbContextOptions options) : base(options) { }
    }
}
