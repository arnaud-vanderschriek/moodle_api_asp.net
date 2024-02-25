using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Moodle.DAL.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CursusId", "Description", "EndDate", "Name", "StartDate", "UserID" },
                values: new object[,]
                {
                    { 4, 2, "Javascript beginner", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Javascript / Cours 1", new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, 2, "Javascript advanced", new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Javascript / Cours 2", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, 2, "Javascript confirmed", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET / Cours 3", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
