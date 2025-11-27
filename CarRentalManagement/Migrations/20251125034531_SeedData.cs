using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 11, 45, 31, 134, DateTimeKind.Local).AddTicks(7017), new DateTime(2025, 11, 25, 11, 45, 31, 134, DateTimeKind.Local).AddTicks(7028), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 11, 45, 31, 134, DateTimeKind.Local).AddTicks(7030), new DateTime(2025, 11, 25, 11, 45, 31, 134, DateTimeKind.Local).AddTicks(7030), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 11, 45, 31, 134, DateTimeKind.Local).AddTicks(9000), new DateTime(2025, 11, 25, 11, 45, 31, 134, DateTimeKind.Local).AddTicks(9005), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 11, 45, 31, 134, DateTimeKind.Local).AddTicks(9008), new DateTime(2025, 11, 25, 11, 45, 31, 134, DateTimeKind.Local).AddTicks(9009), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 11, 45, 31, 134, DateTimeKind.Local).AddTicks(9117), new DateTime(2025, 11, 25, 11, 45, 31, 134, DateTimeKind.Local).AddTicks(9117), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 11, 45, 31, 134, DateTimeKind.Local).AddTicks(9119), new DateTime(2025, 11, 25, 11, 45, 31, 134, DateTimeKind.Local).AddTicks(9120), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 25, 11, 45, 31, 134, DateTimeKind.Local).AddTicks(9121), new DateTime(2025, 11, 25, 11, 45, 31, 134, DateTimeKind.Local).AddTicks(9122), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 25, 11, 45, 31, 134, DateTimeKind.Local).AddTicks(9123), new DateTime(2025, 11, 25, 11, 45, 31, 134, DateTimeKind.Local).AddTicks(9124), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
