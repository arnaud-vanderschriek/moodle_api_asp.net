using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moodle.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedersV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_UserID",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "CourseName",
                table: "Courses",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2024, 2, 13, 22, 18, 17, 607, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_UserID",
                table: "Courses",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_UserID",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Courses",
                newName: "CourseName");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2024, 2, 13, 21, 53, 21, 440, DateTimeKind.Local).AddTicks(5980));

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
