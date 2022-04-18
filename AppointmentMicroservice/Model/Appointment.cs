using System.ComponentModel.DataAnnotations;

namespace AppointmentMicroservice.Model
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string AppointmentDate { get; set; }
        [Required]

        public string Slot { get; set; }
        [Required]
        public string CounseledBefore { get; set; }
    }
}
