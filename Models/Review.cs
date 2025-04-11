using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace RepairAndConstruction.Models
{
    public class Review
    {
        public int Id { get; set; }

        public int WorkerId { get; set; }
        [ValidateNever]
        public Worker Worker { get; set; }

        public string ReviewerName { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public string Comment { get; set; }
    }
}
