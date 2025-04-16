using RepairAndConstruction.Models;

public class SearchViewModel
{
    public string Query { get; set; }
    public List<Worker> Workers { get; set; }
    public List<JobOffer> JobOffers { get; set; }
    public List<Review> Reviews { get; set; }
}
