using Microsoft.EntityFrameworkCore;
namespace Regback.Models
{
    public class RegistrationDbContext : DbContext
    {
        public RegistrationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Registration> registrations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=RASHID-DESKTOP\\SQLEXPRESS01;Initial Catalog=registration;Integrated Security=True;Trust Server Certificate=True");
        }
    }
   
}
