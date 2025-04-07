using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepairAndConstruction.Migrations
{
    /// <inheritdoc />
    public partial class AdminAndWorkCust : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "BookingDate",
                value: new DateTime(2025, 4, 7, 23, 2, 17, 274, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "BookingDate",
                value: new DateTime(2025, 4, 8, 23, 2, 17, 274, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                column: "BookingDate",
                value: new DateTime(2025, 4, 9, 23, 2, 17, 274, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "BookingDate",
                value: new DateTime(2025, 4, 10, 23, 2, 17, 274, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                column: "BookingDate",
                value: new DateTime(2025, 4, 11, 23, 2, 17, 274, DateTimeKind.Local).AddTicks(5761));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
