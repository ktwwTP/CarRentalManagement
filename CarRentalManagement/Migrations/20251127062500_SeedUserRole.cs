using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "654ce5c1-aba3-4911-b4c2-e1567894954d", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEC8BsgpTzQ+l5pEliqeO8IeeXOFPDl/Q6cTq8Bq8Jg0fU0cbAMsVyTLTHp+rcp4jDw==", null, false, "0a3cfc61-2fd6-4d44-ab13-aad35bd9cb01", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 24, 59, 281, DateTimeKind.Local).AddTicks(8046), new DateTime(2025, 11, 27, 14, 24, 59, 281, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 24, 59, 281, DateTimeKind.Local).AddTicks(8068), new DateTime(2025, 11, 27, 14, 24, 59, 281, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 24, 59, 281, DateTimeKind.Local).AddTicks(8339), new DateTime(2025, 11, 27, 14, 24, 59, 281, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 24, 59, 281, DateTimeKind.Local).AddTicks(8342), new DateTime(2025, 11, 27, 14, 24, 59, 281, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 24, 59, 281, DateTimeKind.Local).AddTicks(8445), new DateTime(2025, 11, 27, 14, 24, 59, 281, DateTimeKind.Local).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 24, 59, 281, DateTimeKind.Local).AddTicks(8448), new DateTime(2025, 11, 27, 14, 24, 59, 281, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 24, 59, 281, DateTimeKind.Local).AddTicks(8450), new DateTime(2025, 11, 27, 14, 24, 59, 281, DateTimeKind.Local).AddTicks(8451) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 24, 59, 281, DateTimeKind.Local).AddTicks(8453), new DateTime(2025, 11, 27, 14, 24, 59, 281, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 30, 33, 742, DateTimeKind.Local).AddTicks(8018), new DateTime(2025, 11, 27, 13, 30, 33, 742, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 30, 33, 742, DateTimeKind.Local).AddTicks(8033), new DateTime(2025, 11, 27, 13, 30, 33, 742, DateTimeKind.Local).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 30, 33, 742, DateTimeKind.Local).AddTicks(8249), new DateTime(2025, 11, 27, 13, 30, 33, 742, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 30, 33, 742, DateTimeKind.Local).AddTicks(8253), new DateTime(2025, 11, 27, 13, 30, 33, 742, DateTimeKind.Local).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 30, 33, 742, DateTimeKind.Local).AddTicks(8345), new DateTime(2025, 11, 27, 13, 30, 33, 742, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 30, 33, 742, DateTimeKind.Local).AddTicks(8348), new DateTime(2025, 11, 27, 13, 30, 33, 742, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 30, 33, 742, DateTimeKind.Local).AddTicks(8351), new DateTime(2025, 11, 27, 13, 30, 33, 742, DateTimeKind.Local).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 30, 33, 742, DateTimeKind.Local).AddTicks(8354), new DateTime(2025, 11, 27, 13, 30, 33, 742, DateTimeKind.Local).AddTicks(8354) });
        }
    }
}
