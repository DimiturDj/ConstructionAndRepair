using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepairAndConstruction.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerPhoneNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerPhone",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Not provided");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "BookingDate",
                value: new DateTime(2025, 4, 18, 17, 39, 37, 236, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "BookingDate",
                value: new DateTime(2025, 4, 19, 17, 39, 37, 236, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                column: "BookingDate",
                value: new DateTime(2025, 4, 20, 17, 39, 37, 236, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "BookingDate",
                value: new DateTime(2025, 4, 21, 17, 39, 37, 236, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                column: "BookingDate",
                value: new DateTime(2025, 4, 22, 17, 39, 37, 236, DateTimeKind.Local).AddTicks(1633));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerPhone",
                table: "Bookings");

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
    }
}
