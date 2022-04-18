using AppointmentMicroservice.Model;
using Microsoft.EntityFrameworkCore;

namespace AppointmentMicroservice.Data
{
   public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Vaccination> Vaccinations { get; set; }
    }
}
