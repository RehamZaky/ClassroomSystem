using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Classroom.API.Migrations
{
    /// <inheritdoc />
    public partial class EditFlagActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Admins");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Users",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "classrooms",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 0, 9, 34, 33, DateTimeKind.Utc).AddTicks(7569), new DateTime(2025, 2, 27, 0, 9, 34, 33, DateTimeKind.Utc).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "classrooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 2, 9, 34, 33, DateTimeKind.Local).AddTicks(7720), new DateTime(2025, 2, 27, 2, 9, 34, 33, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "classrooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 2, 9, 34, 33, DateTimeKind.Local).AddTicks(7783), new DateTime(2025, 2, 27, 2, 9, 34, 33, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "classrooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 2, 9, 34, 33, DateTimeKind.Local).AddTicks(7787), new DateTime(2025, 2, 27, 2, 9, 34, 33, DateTimeKind.Local).AddTicks(7788) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Teachers",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Parents",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "classrooms",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Admins",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 13, 16, 29, 78, DateTimeKind.Utc).AddTicks(5937), new DateTime(2025, 2, 26, 13, 16, 29, 78, DateTimeKind.Utc).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "classrooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 15, 16, 29, 78, DateTimeKind.Local).AddTicks(6041), new DateTime(2025, 2, 26, 15, 16, 29, 78, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "classrooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 15, 16, 29, 78, DateTimeKind.Local).AddTicks(6104), new DateTime(2025, 2, 26, 15, 16, 29, 78, DateTimeKind.Local).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "classrooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 15, 16, 29, 78, DateTimeKind.Local).AddTicks(6107), new DateTime(2025, 2, 26, 15, 16, 29, 78, DateTimeKind.Local).AddTicks(6108) });
        }
    }
}
