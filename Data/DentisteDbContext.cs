using Dentiste.Models;
using Microsoft.EntityFrameworkCore;

namespace Dentiste.Data
{
    public class DentisteDbContext : DbContext
    {
        public DentisteDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Dentist> Dentists { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Observation> Observations { get; set; }

    }
}
