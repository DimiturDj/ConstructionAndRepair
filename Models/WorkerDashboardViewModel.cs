using RepairAndConstruction.Models;

namespace RepairAndConstruction.ViewModels
{
    public class WorkerDashboardViewModel
    {
        public int TotalBookings { get; set; }
        public int TotalJobOffers { get; set; }

        public List<Booking> Bookings { get; set; } = new();
    }
}
