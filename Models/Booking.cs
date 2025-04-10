using RepairAndConstruction.Models;

namespace RepairAndConstruction.Models;

public class Booking
{
    public int Id { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    public int JobOfferId { get; set; }
    public JobOffer JobOffer { get; set; }

    public DateTime BookingDate { get; set; }

    public string Status { get; set; } = "Pending";

 

}
