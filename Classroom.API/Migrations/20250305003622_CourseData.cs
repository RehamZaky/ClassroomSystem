using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Classroom.API.Migrations
{
    /// <inheritdoc />
    public partial class CourseData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassroomsCourses_Classrooms_ClassroomId",
                table: "ClassroomsCourses");

            migrationBuilder.DropColumn(
                name: "ClassroomsId",
                table: "ClassroomsCourses");

            migrationBuilder.AlterColumn<int>(
                name: "ClassroomId",
                table: "ClassroomsCourses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 0, 36, 22, 629, DateTimeKind.Utc).AddTicks(11), new DateTime(2025, 3, 5, 0, 36, 22, 629, DateTimeKind.Utc).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 2, 36, 22, 629, DateTimeKind.Local).AddTicks(185), new DateTime(2025, 3, 5, 2, 36, 22, 629, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 2, 36, 22, 629, DateTimeKind.Local).AddTicks(258), new DateTime(2025, 3, 5, 2, 36, 22, 629, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 2, 36, 22, 629, DateTimeKind.Local).AddTicks(264), new DateTime(2025, 3, 5, 2, 36, 22, 629, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "ClassroomsCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClassroomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 0, 36, 22, 629, DateTimeKind.Utc).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 5, 0, 36, 22, 631, DateTimeKind.Utc).AddTicks(2044), new DateTime(2025, 3, 10, 0, 36, 22, 631, DateTimeKind.Utc).AddTicks(2051), new DateTime(2025, 3, 5, 0, 36, 22, 631, DateTimeKind.Utc).AddTicks(2049) });

            migrationBuilder.AddForeignKey(
                name: "FK_ClassroomsCourses_Classrooms_ClassroomId",
                table: "ClassroomsCourses",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassroomsCourses_Classrooms_ClassroomId",
                table: "ClassroomsCourses");

            migrationBuilder.AlterColumn<int>(
                name: "ClassroomId",
                table: "ClassroomsCourses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ClassroomsId",
                table: "ClassroomsCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 0, 33, 1, 292, DateTimeKind.Utc).AddTicks(2907), new DateTime(2025, 3, 5, 0, 33, 1, 292, DateTimeKind.Utc).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 2, 33, 1, 292, DateTimeKind.Local).AddTicks(3018), new DateTime(2025, 3, 5, 2, 33, 1, 292, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 2, 33, 1, 292, DateTimeKind.Local).AddTicks(3073), new DateTime(2025, 3, 5, 2, 33, 1, 292, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 2, 33, 1, 292, DateTimeKind.Local).AddTicks(3076), new DateTime(2025, 3, 5, 2, 33, 1, 292, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "ClassroomsCourses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClassroomId", "ClassroomsId" },
                values: new object[] { null, 3 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 0, 33, 1, 292, DateTimeKind.Utc).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 5, 0, 33, 1, 293, DateTimeKind.Utc).AddTicks(4654), new DateTime(2025, 3, 10, 0, 33, 1, 293, DateTimeKind.Utc).AddTicks(4659), new DateTime(2025, 3, 5, 0, 33, 1, 293, DateTimeKind.Utc).AddTicks(4658) });

            migrationBuilder.AddForeignKey(
                name: "FK_ClassroomsCourses_Classrooms_ClassroomId",
                table: "ClassroomsCourses",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "Id");
        }
    }
}
