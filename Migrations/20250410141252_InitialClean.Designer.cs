﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace RepairAndConstruction.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250410141252_InitialClean")]
    partial class InitialClean
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RepairAndConstruction.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "admin123",
                            Role = "Admin",
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Password = "worker123",
                            Role = "Worker",
                            Username = "worker1"
                        });
                });

            modelBuilder.Entity("RepairAndConstruction.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("JobOfferId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("JobOfferId");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookingDate = new DateTime(2025, 4, 10, 17, 12, 52, 14, DateTimeKind.Local).AddTicks(599),
                            CustomerId = 1,
                            JobOfferId = 1,
                            Status = "Confirmed"
                        },
                        new
                        {
                            Id = 2,
                            BookingDate = new DateTime(2025, 4, 11, 17, 12, 52, 14, DateTimeKind.Local).AddTicks(640),
                            CustomerId = 2,
                            JobOfferId = 2,
                            Status = "Pending"
                        },
                        new
                        {
                            Id = 3,
                            BookingDate = new DateTime(2025, 4, 12, 17, 12, 52, 14, DateTimeKind.Local).AddTicks(643),
                            CustomerId = 3,
                            JobOfferId = 3,
                            Status = "Confirmed"
                        },
                        new
                        {
                            Id = 4,
                            BookingDate = new DateTime(2025, 4, 13, 17, 12, 52, 14, DateTimeKind.Local).AddTicks(645),
                            CustomerId = 4,
                            JobOfferId = 4,
                            Status = "Pending"
                        },
                        new
                        {
                            Id = 5,
                            BookingDate = new DateTime(2025, 4, 14, 17, 12, 52, 14, DateTimeKind.Local).AddTicks(647),
                            CustomerId = 1,
                            JobOfferId = 5,
                            Status = "Confirmed"
                        });
                });

            modelBuilder.Entity("RepairAndConstruction.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "mark@email.com",
                            FullName = "Mark Williams",
                            Phone = "0888123456"
                        },
                        new
                        {
                            Id = 2,
                            Email = "sara@email.com",
                            FullName = "Sara Miller",
                            Phone = "0899123456"
                        },
                        new
                        {
                            Id = 3,
                            Email = "alex@email.com",
                            FullName = "Alex Green",
                            Phone = "0876234567"
                        },
                        new
                        {
                            Id = 4,
                            Email = "olivia@email.com",
                            FullName = "Olivia Black",
                            Phone = "0888777888"
                        });
                });

            modelBuilder.Entity("RepairAndConstruction.Models.JobOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkerId");

                    b.ToTable("JobOffers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Fixing leaks and pipes",
                            Price = 100m,
                            Title = "Plumbing Service",
                            WorkerId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Installing new wiring",
                            Price = 150m,
                            Title = "Electrical Installation",
                            WorkerId = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "Fixing roof leaks and damage",
                            Price = 250m,
                            Title = "Roof Repair",
                            WorkerId = 3
                        },
                        new
                        {
                            Id = 4,
                            Description = "Interior and exterior painting services",
                            Price = 200m,
                            Title = "Home Painting",
                            WorkerId = 4
                        },
                        new
                        {
                            Id = 5,
                            Description = "Building new walls or repairing damaged walls",
                            Price = 300m,
                            Title = "Wall Construction",
                            WorkerId = 5
                        });
                });

            modelBuilder.Entity("RepairAndConstruction.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkerId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Excellent service!",
                            Rating = 5,
                            ReviewerName = "John",
                            WorkerId = 1
                        },
                        new
                        {
                            Id = 2,
                            Comment = "Good work but could improve communication.",
                            Rating = 4,
                            ReviewerName = "Sara",
                            WorkerId = 2
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Did a great job with my roof!",
                            Rating = 4,
                            ReviewerName = "Alex",
                            WorkerId = 3
                        },
                        new
                        {
                            Id = 4,
                            Comment = "Highly recommend this painter, very professional.",
                            Rating = 5,
                            ReviewerName = "Olivia",
                            WorkerId = 4
                        },
                        new
                        {
                            Id = 5,
                            Comment = "The wall construction was done perfectly!",
                            Rating = 5,
                            ReviewerName = "Mark",
                            WorkerId = 5
                        });
                });

            modelBuilder.Entity("RepairAndConstruction.Models.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Workers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "John Doe",
                            Location = "Sofia",
                            Profession = "Plumber",
                            Rating = 5.0
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Jane Smith",
                            Location = "Plovdiv",
                            Profession = "Electrician",
                            Rating = 4.0
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Mike Johnson",
                            Location = "Varna",
                            Profession = "Carpenter",
                            Rating = 4.0
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Emma Brown",
                            Location = "Burgas",
                            Profession = "Painter",
                            Rating = 4.0
                        },
                        new
                        {
                            Id = 5,
                            FullName = "Liam White",
                            Location = "Ruse",
                            Profession = "Mason",
                            Rating = 5.0
                        });
                });

            modelBuilder.Entity("RepairAndConstruction.Models.Booking", b =>
                {
                    b.HasOne("RepairAndConstruction.Models.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RepairAndConstruction.Models.JobOffer", "JobOffer")
                        .WithMany()
                        .HasForeignKey("JobOfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("JobOffer");
                });

            modelBuilder.Entity("RepairAndConstruction.Models.JobOffer", b =>
                {
                    b.HasOne("RepairAndConstruction.Models.Worker", "Worker")
                        .WithMany("JobOffers")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("RepairAndConstruction.Models.Review", b =>
                {
                    b.HasOne("RepairAndConstruction.Models.Worker", "Worker")
                        .WithMany("Reviews")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("RepairAndConstruction.Models.Customer", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("RepairAndConstruction.Models.Worker", b =>
                {
                    b.Navigation("JobOffers");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
