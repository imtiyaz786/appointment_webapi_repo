using System.ComponentModel.DataAnnotations;

namespace AppointmentMicroservice.Model
{
    public class Vaccination
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public string DateOfVaccination { get; set; }
        [Required]
        public string VaccineName { get; set; }
        [Required]
        public string ChooseSlot { get; set; }
        [Required]
        public string IdProof { get; set; }
        [Required]
        public string UserMail { get; set; }
    }
}
