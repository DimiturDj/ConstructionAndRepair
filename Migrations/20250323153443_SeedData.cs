using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RepairAndConstruction.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FullName", "Phone" },
                values: new object[,]
                {
                    { 1, "mark@email.com", "Mark Williams", "0888123456" },
                    { 2, "sara@email.com", "Sara Miller", "0899123456" }
                });

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "Id", "FullName", "Location", "Profession", "Rating" },
                values: new object[,]
                {
                    { 1, "John Doe", "Sofia", "Plumber", 5.0 },
                    { 2, "Jane Smith", "Plovdiv", "Electrician", 4.0 },
                    { 3, "Mike Johnson", "Varna", "Carpenter", 4.0 }
                });

            migrationBuilder.InsertData(
                table: "JobOffers",
                columns: new[] { "Id", "Description", "Price", "Title", "WorkerId" },
                values: new object[,]
                {
                    { 1, "Fixing leaks and pipes", 100m, "Plumbing Service", 1 },
                    { 2, "Installing new wiring", 150m, "Electrical Installation", 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "Rating", "ReviewerName", "WorkerId" },
                values: new object[,]
                {
                    { 1, "Excellent service!", 5, "John", 1 },
                    { 2, "Good work but could improve communication.", 4, "Sara", 2 }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BookingDate", "CustomerId", "JobOfferId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 23, 17, 34, 42, 732, DateTimeKind.Local).AddTicks(28), 1, 1, "Confirmed" },
                    { 2, new DateTime(2025, 3, 24, 17, 34, 42, 732, DateTimeKind.Local).AddTicks(69), 2, 2, "Pending" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
