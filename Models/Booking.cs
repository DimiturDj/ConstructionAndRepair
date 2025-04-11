using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using RepairAndConstruction.Models;

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

 

}
