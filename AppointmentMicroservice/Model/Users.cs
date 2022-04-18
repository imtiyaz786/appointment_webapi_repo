using System.ComponentModel.DataAnnotations;

namespace AppointmentMicroservice.Model
{
    public class Users
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Category { get; set; }

    }
}
