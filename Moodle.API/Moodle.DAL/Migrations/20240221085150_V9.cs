using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Moodle.DAL.Migrations
{
    /// <inheritdoc />
    public partial class V9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Module",
                columns: new[] { "Id", "CourseId", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 10, 8, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "React cours 2 / module 1", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 8, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "React cours 2 / module 2", new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Module",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Module",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
