using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using RepairAndConstruction.Models;
using System.ComponentModel.DataAnnotations;

namespace RepairAndConstruction.Models;

public class Worker
{
    public int Id { get; set; }

    [Required]
    public string FullName { get; set; }

    [Required]
    public string Profession { get; set; }

    public string Location { get; set; }

    public double Rating { get; set; }

    [ValidateNever]
    public ICollection<JobOffer> JobOffers { get; set; }
    [ValidateNever]
    public ICollection<Review> Reviews { get; set; }
}
