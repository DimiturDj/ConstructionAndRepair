using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepairAndConstruction.Migrations
{
    /// <inheritdoc />
    public partial class New : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "BookingDate",
                value: new DateTime(2025, 4, 17, 9, 35, 5, 304, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "BookingDate",
                value: new DateTime(2025, 4, 18, 9, 35, 5, 304, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                column: "BookingDate",
                value: new DateTime(2025, 4, 19, 9, 35, 5, 304, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "BookingDate",
                value: new DateTime(2025, 4, 20, 9, 35, 5, 304, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                column: "BookingDate",
                value: new DateTime(2025, 4, 21, 9, 35, 5, 304, DateTimeKind.Local).AddTicks(163));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "BookingDate",
                value: new DateTime(2025, 4, 11, 13, 23, 6, 612, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "BookingDate",
                value: new DateTime(2025, 4, 12, 13, 23, 6, 612, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                column: "BookingDate",
                value: new DateTime(2025, 4, 13, 13, 23, 6, 612, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "BookingDate",
                value: new DateTime(2025, 4, 14, 13, 23, 6, 612, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                column: "BookingDate",
                value: new DateTime(2025, 4, 15, 13, 23, 6, 612, DateTimeKind.Local).AddTicks(9590));
        }
    }
}
