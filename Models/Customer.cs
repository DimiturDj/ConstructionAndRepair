using System.ComponentModel.DataAnnotations;

namespace RepairAndConstruction.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }

}
