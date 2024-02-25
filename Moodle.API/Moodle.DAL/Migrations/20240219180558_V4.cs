using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moodle.DAL.Migrations
{
    /// <inheritdoc />
    public partial class V4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cursus_CursusId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CursusId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CursusId",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "CursusUsers",
                columns: table => new
                {
                    CursusId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursusUsers", x => new { x.CursusId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_CursusUsers_Cursus_CursusId",
                        column: x => x.CursusId,
                        principalTable: "Cursus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursusUsers_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserID",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_CursusUsers_UsersId",
                table: "CursusUsers",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CursusUsers");

            migrationBuilder.AddColumn<int>(
                name: "CursusId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CursusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CursusId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CursusId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CursusId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CursusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CursusId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CursusId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CursusId",
                value: 4);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CursusId",
                table: "Users",
                column: "CursusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cursus_CursusId",
                table: "Users",
                column: "CursusId",
                principalTable: "Cursus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
