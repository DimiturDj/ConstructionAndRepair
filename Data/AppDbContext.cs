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
        base.OnModelCreating(modelBuilder); // Call base method
        SeedData(modelBuilder);  // Seed method
    }

    public static void SeedData(ModelBuilder modelBuilder)
    {
        // Seed for Workers
        modelBuilder.Entity<Worker>().HasData(
            new Worker { Id = 1, FullName = "John Doe", Profession = "Plumber", Location = "Sofia", Rating = 5 },
            new Worker { Id = 2, FullName = "Jane Smith", Profession = "Electrician", Location = "Plovdiv", Rating = 4 },
            new Worker { Id = 3, FullName = "Mike Johnson", Profession = "Carpenter", Location = "Varna", Rating = 4 },
            new Worker { Id = 4, FullName = "Emma Brown", Profession = "Painter", Location = "Burgas", Rating = 4 },
            new Worker { Id = 5, FullName = "Liam White", Profession = "Mason", Location = "Ruse", Rating = 5 }
        );

        // Seed for JobOffers
        modelBuilder.Entity<JobOffer>().HasData(
            new JobOffer { Id = 1, Title = "Plumbing Service", Description = "Fixing leaks and pipes", Price = 100, WorkerId = 1 },
            new JobOffer { Id = 2, Title = "Electrical Installation", Description = "Installing new wiring", Price = 150, WorkerId = 2 },
            new JobOffer { Id = 3, Title = "Roof Repair", Description = "Fixing roof leaks and damage", Price = 250, WorkerId = 3 },
            new JobOffer { Id = 4, Title = "Home Painting", Description = "Interior and exterior painting services", Price = 200, WorkerId = 4 },
            new JobOffer { Id = 5, Title = "Wall Construction", Description = "Building new walls or repairing damaged walls", Price = 300, WorkerId = 5 }
        );

        // Seed for Customers
        modelBuilder.Entity<Customer>().HasData(
            new Customer { Id = 1, FullName = "Mark Williams", Email = "mark@email.com", Phone = "0888123456" },
            new Customer { Id = 2, FullName = "Sara Miller", Email = "sara@email.com", Phone = "0899123456" },
            new Customer { Id = 3, FullName = "Alex Green", Email = "alex@email.com", Phone = "0876234567" },
            new Customer { Id = 4, FullName = "Olivia Black", Email = "olivia@email.com", Phone = "0888777888" }
        );

        // Seed for Bookings
        modelBuilder.Entity<Booking>().HasData(
            new Booking { Id = 1, JobOfferId = 1, CustomerId = 1, BookingDate = DateTime.Now, Status = "Confirmed" },
            new Booking { Id = 2, JobOfferId = 2, CustomerId = 2, BookingDate = DateTime.Now.AddDays(1), Status = "Pending" },
            new Booking { Id = 3, JobOfferId = 3, CustomerId = 3, BookingDate = DateTime.Now.AddDays(2), Status = "Confirmed" },
            new Booking { Id = 4, JobOfferId = 4, CustomerId = 4, BookingDate = DateTime.Now.AddDays(3), Status = "Pending" },
            new Booking { Id = 5, JobOfferId = 5, CustomerId = 1, BookingDate = DateTime.Now.AddDays(4), Status = "Confirmed" }
        );

        // Seed for Reviews
        modelBuilder.Entity<Review>().HasData(
            new Review { Id = 1, WorkerId = 1, ReviewerName = "John", Rating = 5, Comment = "Excellent service!" },
            new Review { Id = 2, WorkerId = 2, ReviewerName = "Sara", Rating = 4, Comment = "Good work but could improve communication." },
            new Review { Id = 3, WorkerId = 3, ReviewerName = "Alex", Rating = 4, Comment = "Did a great job with my roof!" },
            new Review { Id = 4, WorkerId = 4, ReviewerName = "Olivia", Rating = 5, Comment = "Highly recommend this painter, very professional." },
            new Review { Id = 5, WorkerId = 5, ReviewerName = "Mark", Rating = 5, Comment = "The wall construction was done perfectly!" }
        );

        // Seed for AppUser (with Id included)
        modelBuilder.Entity<AppUser>().HasData(
            new AppUser { Id = 1, Username = "admin", Password = "admin123", Role = "Admin" },
            new AppUser { Id = 2, Username = "worker1", Password = "worker123", Role = "Worker" }
        );
    }



}

