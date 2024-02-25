using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moodle.DAL.Migrations
{
    /// <inheritdoc />
    public partial class V3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "startDate",
                table: "Module",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Module",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "endDate",
                table: "Module",
                newName: "EndDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Module",
                newName: "startDate");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Module",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Module",
                newName: "endDate");
        }
    }
}
