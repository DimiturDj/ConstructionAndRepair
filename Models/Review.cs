using System.ComponentModel.DataAnnotations;

namespace RepairAndConstruction.Models
{
    public class Review
    {
        public int Id { get; set; }

        public int WorkerId { get; set; }
        public Worker Worker { get; set; }

        public string ReviewerName { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public string Comment { get; set; }
    }
}
