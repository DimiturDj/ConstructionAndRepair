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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); // Запази базовата конфигурация
        SeedData(modelBuilder);  // Добави този ред за да се извика метода SeedData
    }

    public static void SeedData(ModelBuilder modelBuilder)
    {
        // Seed за Workers
        modelBuilder.Entity<Worker>().HasData(
            new Worker { Id = 1, FullName = "John Doe", Profession = "Plumber", Location = "Sofia", Rating = 5 },
            new Worker { Id = 2, FullName = "Jane Smith", Profession = "Electrician", Location = "Plovdiv", Rating = 4 },
            new Worker { Id = 3, FullName = "Mike Johnson", Profession = "Carpenter", Location = "Varna", Rating = 4 }
        );

        // Seed за JobOffers
        modelBuilder.Entity<JobOffer>().HasData(
            new JobOffer { Id = 1, Title = "Plumbing Service", Description = "Fixing leaks and pipes", Price = 100, WorkerId = 1 },
            new JobOffer { Id = 2, Title = "Electrical Installation", Description = "Installing new wiring", Price = 150, WorkerId = 2 }
        );

        // Seed за Customers
        modelBuilder.Entity<Customer>().HasData(
            new Customer { Id = 1, FullName = "Mark Williams", Email = "mark@email.com", Phone = "0888123456" },
            new Customer { Id = 2, FullName = "Sara Miller", Email = "sara@email.com", Phone = "0899123456" }
        );

        // Seed за Bookings
        modelBuilder.Entity<Booking>().HasData(
            new Booking { Id = 1, JobOfferId = 1, CustomerId = 1, BookingDate = DateTime.Now, Status = "Confirmed" },
            new Booking { Id = 2, JobOfferId = 2, CustomerId = 2, BookingDate = DateTime.Now.AddDays(1), Status = "Pending" }
        );

        // Seed за Reviews
        modelBuilder.Entity<Review>().HasData(
            new Review { Id = 1, WorkerId = 1, ReviewerName = "John", Rating = 5, Comment = "Excellent service!" },
            new Review { Id = 2, WorkerId = 2, ReviewerName = "Sara", Rating = 4, Comment = "Good work but could improve communication." }
        );
    }
}
