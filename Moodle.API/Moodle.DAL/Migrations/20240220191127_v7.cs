using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moodle.DAL.Migrations
{
    /// <inheritdoc />
    public partial class v7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_UserID",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "CursusUsers");

            migrationBuilder.DropIndex(
                name: "IX_Courses_UserID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Courses");

            migrationBuilder.AddColumn<byte[]>(
                name: "images",
                table: "Cursus",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserCourse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCourse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCourse_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCourse_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Cursus",
                keyColumn: "Id",
                keyValue: 1,
                column: "images",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cursus",
                keyColumn: "Id",
                keyValue: 2,
                column: "images",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cursus",
                keyColumn: "Id",
                keyValue: 3,
                column: "images",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cursus",
                keyColumn: "Id",
                keyValue: 4,
                column: "images",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cursus",
                keyColumn: "Id",
                keyValue: 5,
                column: "images",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cursus",
                keyColumn: "Id",
                keyValue: 6,
                column: "images",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_UserCourse_CourseId",
                table: "UserCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCourse_UserId",
                table: "UserCourse",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCourse");

            migrationBuilder.DropColumn(
                name: "images",
                table: "Cursus");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                column: "UserID",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_UserID",
                table: "Courses",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CursusUsers_UsersId",
                table: "CursusUsers",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_UserID",
                table: "Courses",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
