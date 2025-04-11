using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace RepairAndConstruction.Models
{
    public class JobOffer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [Display(Name = "Job Title")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Range(0, 10000, ErrorMessage = "Price must be between 0 and 10,000")]
        [Display(Name = "Price (лв.)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please select a worker")]
        [Display(Name = "Assigned Worker")]
        public int WorkerId { get; set; }

        [ValidateNever]
        public Worker Worker { get; set; }
    }
}
