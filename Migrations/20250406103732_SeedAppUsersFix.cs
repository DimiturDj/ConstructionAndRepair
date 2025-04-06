using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RepairAndConstruction.Migrations
{
    /// <inheritdoc />
    public partial class SeedAppUsersFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "admin123", "Admin", "admin" },
                    { 2, "worker123", "Worker", "worker1" }
                });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "BookingDate",
                value: new DateTime(2025, 4, 6, 13, 37, 31, 753, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "BookingDate",
                value: new DateTime(2025, 4, 7, 13, 37, 31, 753, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                column: "BookingDate",
                value: new DateTime(2025, 4, 8, 13, 37, 31, 753, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "BookingDate",
                value: new DateTime(2025, 4, 9, 13, 37, 31, 753, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                column: "BookingDate",
                value: new DateTime(2025, 4, 10, 13, 37, 31, 753, DateTimeKind.Local).AddTicks(9743));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AppUsers");

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

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                column: "BookingDate",
                value: new DateTime(2025, 3, 31, 0, 38, 27, 694, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "BookingDate",
                value: new DateTime(2025, 4, 1, 0, 38, 27, 694, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                column: "BookingDate",
                value: new DateTime(2025, 4, 2, 0, 38, 27, 694, DateTimeKind.Local).AddTicks(7300));
        }
    }
}
