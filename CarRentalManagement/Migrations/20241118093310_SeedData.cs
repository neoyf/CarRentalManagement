﻿using System;
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
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 33, 9, 441, DateTimeKind.Local).AddTicks(2591), new DateTime(2024, 11, 18, 17, 33, 9, 441, DateTimeKind.Local).AddTicks(2601), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 33, 9, 441, DateTimeKind.Local).AddTicks(2603), new DateTime(2024, 11, 18, 17, 33, 9, 441, DateTimeKind.Local).AddTicks(2604), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 33, 9, 441, DateTimeKind.Local).AddTicks(2777), new DateTime(2024, 11, 18, 17, 33, 9, 441, DateTimeKind.Local).AddTicks(2777), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 33, 9, 441, DateTimeKind.Local).AddTicks(2779), new DateTime(2024, 11, 18, 17, 33, 9, 441, DateTimeKind.Local).AddTicks(2779), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 33, 9, 441, DateTimeKind.Local).AddTicks(2841), new DateTime(2024, 11, 18, 17, 33, 9, 441, DateTimeKind.Local).AddTicks(2842), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 33, 9, 441, DateTimeKind.Local).AddTicks(2843), new DateTime(2024, 11, 18, 17, 33, 9, 441, DateTimeKind.Local).AddTicks(2844), "x5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 17, 33, 9, 441, DateTimeKind.Local).AddTicks(2845), new DateTime(2024, 11, 18, 17, 33, 9, 441, DateTimeKind.Local).AddTicks(2845), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 17, 33, 9, 441, DateTimeKind.Local).AddTicks(2846), new DateTime(2024, 11, 18, 17, 33, 9, 441, DateTimeKind.Local).AddTicks(2847), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
