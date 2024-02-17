using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Moodle.DAL.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    CursusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Cursus_CursusId",
                        column: x => x.CursusId,
                        principalTable: "Cursus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CursusId = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Cursus_CursusId",
                        column: x => x.CursusId,
                        principalTable: "Cursus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Module_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assessment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assessment_Module_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssessmentResult_Assessment_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "Assessment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssessmentResult_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Cursus",
                columns: new[] { "Id", "Name", "endDate", "startDate" },
                values: new object[,]
                {
                    { 1, "ASP.NET", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Javascript", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Python", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "React", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Angular", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Designer", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "RoleName" },
                values: new object[,]
                {
                    { 1, "student", "student" },
                    { 2, "teacher", "teacher" },
                    { 3, "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CursusId", "Email", "Password", "RoleID", "UserName" },
                values: new object[,]
                {
                    { 1, 1, "arnaud.vanderschrieck@gmail.com", new byte[] { 92, 234, 25, 31, 124, 81, 82, 232, 50, 91, 109, 190, 221, 246, 14, 194, 162, 218, 185, 191, 78, 61, 115, 178, 239, 110, 107, 112, 190, 62, 0, 136, 66, 251, 54, 26, 59, 201, 29, 13, 82, 121, 144, 164, 167, 21, 87, 161, 226, 220, 81, 151, 54, 200, 64, 239, 173, 255, 145, 44, 65, 216, 233, 210 }, 1, "Arnaud" },
                    { 2, 2, "yanis.oykonomou@gmail.com", new byte[] { 33, 170, 206, 201, 183, 161, 10, 33, 64, 74, 153, 152, 63, 130, 4, 88, 93, 90, 109, 11, 87, 113, 36, 195, 74, 145, 176, 215, 13, 25, 238, 105, 96, 191, 222, 75, 241, 199, 93, 65, 192, 156, 218, 128, 160, 158, 39, 129, 248, 180, 249, 8, 146, 19, 61, 43, 6, 77, 19, 221, 181, 9, 115, 209 }, 1, "Yanis" },
                    { 3, 3, "padraig.kisembe@gmail.com", new byte[] { 144, 6, 181, 197, 11, 38, 42, 22, 231, 52, 190, 238, 109, 16, 35, 37, 101, 18, 206, 10, 38, 102, 210, 6, 240, 227, 147, 108, 159, 188, 7, 128, 233, 63, 52, 84, 142, 221, 180, 112, 76, 172, 122, 184, 89, 220, 181, 5, 173, 146, 24, 227, 254, 41, 219, 126, 230, 117, 30, 172, 175, 111, 188, 143 }, 1, "Padraig" },
                    { 4, 4, "hamza.tsebien@gmail.com", new byte[] { 18, 63, 213, 210, 27, 123, 94, 78, 223, 137, 32, 49, 147, 136, 16, 72, 215, 77, 171, 217, 175, 153, 214, 153, 219, 53, 109, 234, 36, 117, 196, 64, 185, 65, 58, 102, 204, 66, 78, 23, 248, 43, 24, 9, 155, 239, 93, 100, 19, 209, 9, 153, 166, 154, 52, 53, 190, 10, 234, 99, 84, 187, 78, 84 }, 1, "Hamza" },
                    { 5, 1, "dumb.ledore@gmail.com", new byte[] { 222, 71, 3, 88, 232, 85, 168, 45, 78, 123, 226, 124, 141, 34, 156, 40, 171, 51, 48, 235, 200, 212, 30, 4, 8, 228, 155, 69, 26, 123, 175, 163, 144, 211, 231, 73, 197, 97, 234, 17, 3, 249, 97, 100, 135, 134, 145, 222, 227, 27, 176, 31, 147, 9, 14, 205, 114, 27, 49, 27, 163, 133, 190, 222 }, 2, "Dumbledore" },
                    { 6, 2, "cloud.strife@gmail.com", new byte[] { 62, 114, 205, 183, 87, 119, 128, 147, 48, 123, 39, 159, 201, 28, 39, 82, 17, 16, 207, 65, 206, 192, 52, 101, 85, 22, 3, 192, 117, 100, 47, 254, 124, 98, 96, 99, 162, 82, 128, 35, 50, 8, 111, 111, 47, 34, 223, 247, 65, 117, 101, 119, 188, 182, 233, 97, 252, 246, 198, 98, 79, 61, 209, 166 }, 2, "Cloud" },
                    { 7, 3, "test.test@gmail.com", new byte[] { 43, 190, 12, 72, 185, 26, 125, 27, 138, 103, 83, 168, 185, 203, 225, 219, 22, 184, 67, 121, 243, 249, 31, 225, 21, 98, 18, 132, 223, 122, 72, 241, 205, 113, 233, 190, 185, 14, 166, 20, 199, 189, 146, 66, 80, 170, 158, 68, 106, 134, 103, 37, 230, 133, 166, 93, 245, 209, 57, 165, 205, 24, 13, 201 }, 2, "test" },
                    { 8, 4, "boss.imtheboss@gmail.com", new byte[] { 162, 56, 58, 63, 77, 120, 123, 145, 11, 146, 207, 19, 255, 223, 111, 122, 97, 127, 240, 123, 91, 114, 35, 52, 64, 130, 222, 131, 188, 192, 5, 60, 7, 157, 2, 10, 29, 234, 40, 31, 181, 197, 191, 192, 36, 245, 108, 58, 47, 189, 92, 119, 157, 163, 226, 150, 85, 134, 109, 88, 130, 179, 205, 241 }, 3, "Boss" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CursusId", "Description", "EndDate", "Name", "StartDate", "UserID" },
                values: new object[,]
                {
                    { 1, 1, "ASP.NET beginner", new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET / Cours 1", new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 2, 1, "ASP.NET advanced", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET / Cours 2", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 1, "ASP.NET confirmed", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET / Cours 3", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "Module",
                columns: new[] { "Id", "CourseId", "endDate", "name", "startDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET cours 1 / module 1", new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET cours 1 / module 2", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET cours 1 / module 3", new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET cours 2 / module 1", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET cours 2 / module 2", new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET cours 2 / module 3", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET cours 3 / module 1", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 3, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET cours 3 / module 2", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 3, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET cours 3 / module 3", new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_ModuleId",
                table: "Assessment",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentResult_AssessmentId",
                table: "AssessmentResult",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentResult_UserId",
                table: "AssessmentResult",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CursusId",
                table: "Courses",
                column: "CursusId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_UserID",
                table: "Courses",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Module_CourseId",
                table: "Module",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CursusId",
                table: "Users",
                column: "CursusId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                column: "RoleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssessmentResult");

            migrationBuilder.DropTable(
                name: "Assessment");

            migrationBuilder.DropTable(
                name: "Module");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cursus");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
