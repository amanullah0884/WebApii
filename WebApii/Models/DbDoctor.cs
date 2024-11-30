using Microsoft.EntityFrameworkCore;

namespace WebApii.Models
{
    public class DbDoctorContext : DbContext
       

    {
        public DbDoctorContext()
        {

        }
        public DbDoctorContext(DbContextOptions<DbDoctorContext> options) : base(options)
        {

        }
        
        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            optionsBuilder.UseSqlServer("DefaultConnection");

        } 
    }
}
