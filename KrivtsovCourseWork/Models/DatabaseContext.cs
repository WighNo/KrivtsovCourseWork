using KrivtsovCourseWork.Models.DatabaseModel;
using Microsoft.EntityFrameworkCore;

namespace KrivtsovCourseWork.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }

        public DbSet<Diagnosis> Diagnoses { get; private set; }
        public DbSet<JobTitle> JobTitle { get; private set; }
        public DbSet<Doctor> Doctors { get; private set; }
        public DbSet<Patient> Patient { get; private set; }
        public DbSet<Visit> Visits { get; private set; }
    }
}