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

    public ICollection<JobOffer> JobOffers { get; set; }
    public ICollection<Review> Reviews { get; set; }
}
