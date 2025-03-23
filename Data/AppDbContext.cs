using Microsoft.EntityFrameworkCore;
using RepairAndConstruction.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Worker> Workers { get; set; }
    public DbSet<JobOffer> JobOffers { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<AppUser> AppUsers { get; set; }
    
}
