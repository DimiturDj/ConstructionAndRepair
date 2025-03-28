using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RepairAndConstruction.Migrations
{
    /// <inheritdoc />
    public partial class SeededMoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "BookingDate",
                value: new DateTime(2025, 3, 29, 0, 38, 27, 694, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "BookingDate",
                value: new DateTime(2025, 3, 30, 0, 38, 27, 694, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FullName", "Phone" },
                values: new object[,]
                {
                    { 3, "alex@email.com", "Alex Green", "0876234567" },
                    { 4, "olivia@email.com", "Olivia Black", "0888777888" }
                });

            migrationBuilder.InsertData(
                table: "JobOffers",
                columns: new[] { "Id", "Description", "Price", "Title", "WorkerId" },
                values: new object[] { 3, "Fixing roof leaks and damage", 250m, "Roof Repair", 3 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "Rating", "ReviewerName", "WorkerId" },
                values: new object[] { 3, "Did a great job with my roof!", 4, "Alex", 3 });

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "Id", "FullName", "Location", "Profession", "Rating" },
                values: new object[,]
                {
                    { 4, "Emma Brown", "Burgas", "Painter", 4.0 },
                    { 5, "Liam White", "Ruse", "Mason", 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BookingDate", "CustomerId", "JobOfferId", "Status" },
                values: new object[] { 3, new DateTime(2025, 3, 31, 0, 38, 27, 694, DateTimeKind.Local).AddTicks(7297), 3, 3, "Confirmed" });

            migrationBuilder.InsertData(
                table: "JobOffers",
                columns: new[] { "Id", "Description", "Price", "Title", "WorkerId" },
                values: new object[,]
                {
                    { 4, "Interior and exterior painting services", 200m, "Home Painting", 4 },
                    { 5, "Building new walls or repairing damaged walls", 300m, "Wall Construction", 5 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "Rating", "ReviewerName", "WorkerId" },
                values: new object[,]
                {
                    { 4, "Highly recommend this painter, very professional.", 5, "Olivia", 4 },
                    { 5, "The wall construction was done perfectly!", 5, "Mark", 5 }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BookingDate", "CustomerId", "JobOfferId", "Status" },
                values: new object[,]
                {
                    { 4, new DateTime(2025, 4, 1, 0, 38, 27, 694, DateTimeKind.Local).AddTicks(7299), 4, 4, "Pending" },
                    { 5, new DateTime(2025, 4, 2, 0, 38, 27, 694, DateTimeKind.Local).AddTicks(7300), 1, 5, "Confirmed" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "BookingDate",
                value: new DateTime(2025, 3, 23, 17, 34, 42, 732, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "BookingDate",
                value: new DateTime(2025, 3, 24, 17, 34, 42, 732, DateTimeKind.Local).AddTicks(69));
        }
    }
}
