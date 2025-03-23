using System.ComponentModel.DataAnnotations;

namespace RepairAndConstruction.Models
{
    public class JobOffer
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Range(0, 10000)]
        public decimal Price { get; set; }

        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
    }

}
