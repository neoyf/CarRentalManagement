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

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 42, 37, 237, DateTimeKind.Local).AddTicks(5374), new DateTime(2024, 11, 19, 23, 42, 37, 237, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 42, 37, 237, DateTimeKind.Local).AddTicks(5388), new DateTime(2024, 11, 19, 23, 42, 37, 237, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 42, 37, 237, DateTimeKind.Local).AddTicks(5568), new DateTime(2024, 11, 19, 23, 42, 37, 237, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 42, 37, 237, DateTimeKind.Local).AddTicks(5570), new DateTime(2024, 11, 19, 23, 42, 37, 237, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 42, 37, 237, DateTimeKind.Local).AddTicks(5632), new DateTime(2024, 11, 19, 23, 42, 37, 237, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 42, 37, 237, DateTimeKind.Local).AddTicks(5634), new DateTime(2024, 11, 19, 23, 42, 37, 237, DateTimeKind.Local).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 42, 37, 237, DateTimeKind.Local).AddTicks(5636), new DateTime(2024, 11, 19, 23, 42, 37, 237, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 42, 37, 237, DateTimeKind.Local).AddTicks(5637), new DateTime(2024, 11, 19, 23, 42, 37, 237, DateTimeKind.Local).AddTicks(5638) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "2c2e4860-b6b2-41f4-a1af-2b4279e79eb4", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAECLZMcffdhFUPINp3DT2//06rvcXJvFDCp2uvHK08FE2UPMk+DOibuwCrqJLdc2fxA==", null, false, "3de18bcd-3243-4e4e-83d5-304e763ef235", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 35, 13, 706, DateTimeKind.Local).AddTicks(4705), new DateTime(2024, 11, 19, 23, 35, 13, 706, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 35, 13, 706, DateTimeKind.Local).AddTicks(4718), new DateTime(2024, 11, 19, 23, 35, 13, 706, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 35, 13, 706, DateTimeKind.Local).AddTicks(4858), new DateTime(2024, 11, 19, 23, 35, 13, 706, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 35, 13, 706, DateTimeKind.Local).AddTicks(4860), new DateTime(2024, 11, 19, 23, 35, 13, 706, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 35, 13, 706, DateTimeKind.Local).AddTicks(4921), new DateTime(2024, 11, 19, 23, 35, 13, 706, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 35, 13, 706, DateTimeKind.Local).AddTicks(4923), new DateTime(2024, 11, 19, 23, 35, 13, 706, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 35, 13, 706, DateTimeKind.Local).AddTicks(4925), new DateTime(2024, 11, 19, 23, 35, 13, 706, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 35, 13, 706, DateTimeKind.Local).AddTicks(4926), new DateTime(2024, 11, 19, 23, 35, 13, 706, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }
    }
}
