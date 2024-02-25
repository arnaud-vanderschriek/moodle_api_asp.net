using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Moodle.DAL.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Javascript / Cours 3");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CursusId", "Description", "EndDate", "Name", "StartDate", "UserID" },
                values: new object[,]
                {
                    { 7, 4, "React beginner", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "React / Cours 1", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, 4, "React advanced", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "React / Cours 2", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 9, 4, "React confirmed", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "React / Cours 3", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "ASP.NET / Cours 3");
        }
    }
}
