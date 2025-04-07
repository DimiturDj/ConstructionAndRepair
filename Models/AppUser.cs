using System.ComponentModel.DataAnnotations;

namespace RepairAndConstruction.Models
{
    public class AppUser
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; } = string.Empty;

    }


}
