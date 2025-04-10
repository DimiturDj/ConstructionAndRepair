using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RepairAndConstruction.Migrations
{
    /// <inheritdoc />
    public partial class InitialClean : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profession = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobOffers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WorkerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobOffers_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkerId = table.Column<int>(type: "int", nullable: false),
                    ReviewerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    JobOfferId = table.Column<int>(type: "int", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_JobOffers_JobOfferId",
                        column: x => x.JobOfferId,
                        principalTable: "JobOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "admin123", "Admin", "admin" },
                    { 2, "worker123", "Worker", "worker1" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FullName", "Phone" },
                values: new object[,]
                {
                    { 1, "mark@email.com", "Mark Williams", "0888123456" },
                    { 2, "sara@email.com", "Sara Miller", "0899123456" },
                    { 3, "alex@email.com", "Alex Green", "0876234567" },
                    { 4, "olivia@email.com", "Olivia Black", "0888777888" }
                });

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "Id", "FullName", "Location", "Profession", "Rating" },
                values: new object[,]
                {
                    { 1, "John Doe", "Sofia", "Plumber", 5.0 },
                    { 2, "Jane Smith", "Plovdiv", "Electrician", 4.0 },
                    { 3, "Mike Johnson", "Varna", "Carpenter", 4.0 },
                    { 4, "Emma Brown", "Burgas", "Painter", 4.0 },
                    { 5, "Liam White", "Ruse", "Mason", 5.0 }
                });

            migrationBuilder.InsertData(
                table: "JobOffers",
                columns: new[] { "Id", "Description", "Price", "Title", "WorkerId" },
                values: new object[,]
                {
                    { 1, "Fixing leaks and pipes", 100m, "Plumbing Service", 1 },
                    { 2, "Installing new wiring", 150m, "Electrical Installation", 2 },
                    { 3, "Fixing roof leaks and damage", 250m, "Roof Repair", 3 },
                    { 4, "Interior and exterior painting services", 200m, "Home Painting", 4 },
                    { 5, "Building new walls or repairing damaged walls", 300m, "Wall Construction", 5 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "Rating", "ReviewerName", "WorkerId" },
                values: new object[,]
                {
                    { 1, "Excellent service!", 5, "John", 1 },
                    { 2, "Good work but could improve communication.", 4, "Sara", 2 },
                    { 3, "Did a great job with my roof!", 4, "Alex", 3 },
                    { 4, "Highly recommend this painter, very professional.", 5, "Olivia", 4 },
                    { 5, "The wall construction was done perfectly!", 5, "Mark", 5 }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BookingDate", "CustomerId", "JobOfferId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 10, 17, 12, 52, 14, DateTimeKind.Local).AddTicks(599), 1, 1, "Confirmed" },
                    { 2, new DateTime(2025, 4, 11, 17, 12, 52, 14, DateTimeKind.Local).AddTicks(640), 2, 2, "Pending" },
                    { 3, new DateTime(2025, 4, 12, 17, 12, 52, 14, DateTimeKind.Local).AddTicks(643), 3, 3, "Confirmed" },
                    { 4, new DateTime(2025, 4, 13, 17, 12, 52, 14, DateTimeKind.Local).AddTicks(645), 4, 4, "Pending" },
                    { 5, new DateTime(2025, 4, 14, 17, 12, 52, 14, DateTimeKind.Local).AddTicks(647), 1, 5, "Confirmed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_JobOfferId",
                table: "Bookings",
                column: "JobOfferId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOffers_WorkerId",
                table: "JobOffers",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_WorkerId",
                table: "Reviews",
                column: "WorkerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "JobOffers");

            migrationBuilder.DropTable(
                name: "Workers");
        }
    }
}
