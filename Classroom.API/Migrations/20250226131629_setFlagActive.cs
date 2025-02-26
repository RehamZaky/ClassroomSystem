using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Classroom.API.Migrations
{
    /// <inheritdoc />
    public partial class setFlagActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Users");

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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 18, 10, 15, 278, DateTimeKind.Utc).AddTicks(4615), new DateTime(2025, 2, 25, 18, 10, 15, 278, DateTimeKind.Utc).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "classrooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 20, 10, 15, 278, DateTimeKind.Local).AddTicks(4736), new DateTime(2025, 2, 25, 20, 10, 15, 278, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "classrooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 20, 10, 15, 278, DateTimeKind.Local).AddTicks(4791), new DateTime(2025, 2, 25, 20, 10, 15, 278, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "classrooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 20, 10, 15, 278, DateTimeKind.Local).AddTicks(4795), new DateTime(2025, 2, 25, 20, 10, 15, 278, DateTimeKind.Local).AddTicks(4796) });
        }
    }
}
