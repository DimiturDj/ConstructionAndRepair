using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using RepairAndConstruction.Models;
using System.ComponentModel.DataAnnotations;

namespace RepairAndConstruction.Models;

public class Booking
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    [ValidateNever]
    public Customer Customer { get; set; }

    public int JobOfferId { get; set; }

    [ValidateNever]
    public JobOffer JobOffer { get; set; }

    public DateTime BookingDate { get; set; }

    public string Status { get; set; }

    [Required(ErrorMessage = "Phone Number is mandatory")]
    [Phone(ErrorMessage = "Please,Enter a Valid Phone number.")]
    [Display(Name = "Phone Number")]
    public string CustomerPhone { get; set; }
}
