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
    [Migration("20250323153443_SeedData")]
    partial class SeedData
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

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");
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
                            BookingDate = new DateTime(2025, 3, 23, 17, 34, 42, 732, DateTimeKind.Local).AddTicks(28),
                            CustomerId = 1,
                            JobOfferId = 1,
                            Status = "Confirmed"
                        },
                        new
                        {
                            Id = 2,
                            BookingDate = new DateTime(2025, 3, 24, 17, 34, 42, 732, DateTimeKind.Local).AddTicks(69),
                            CustomerId = 2,
                            JobOfferId = 2,
                            Status = "Pending"
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
