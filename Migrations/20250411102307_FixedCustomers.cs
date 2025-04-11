using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepairAndConstruction.Migrations
{
    /// <inheritdoc />
    public partial class FixedCustomers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Customers");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "BookingDate",
                value: new DateTime(2025, 4, 10, 17, 12, 52, 14, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "BookingDate",
                value: new DateTime(2025, 4, 11, 17, 12, 52, 14, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                column: "BookingDate",
                value: new DateTime(2025, 4, 12, 17, 12, 52, 14, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "BookingDate",
                value: new DateTime(2025, 4, 13, 17, 12, 52, 14, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                column: "BookingDate",
                value: new DateTime(2025, 4, 14, 17, 12, 52, 14, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Phone" },
                values: new object[] { "mark@email.com", "0888123456" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Phone" },
                values: new object[] { "sara@email.com", "0899123456" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Phone" },
                values: new object[] { "alex@email.com", "0876234567" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Phone" },
                values: new object[] { "olivia@email.com", "0888777888" });
        }
    }
}
