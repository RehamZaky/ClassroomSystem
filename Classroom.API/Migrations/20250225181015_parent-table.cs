using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Classroom.API.Migrations
{
    /// <inheritdoc />
    public partial class parenttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 12, 4, 1, 288, DateTimeKind.Utc).AddTicks(5931), new DateTime(2025, 2, 25, 12, 4, 1, 288, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "classrooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 4, 1, 288, DateTimeKind.Local).AddTicks(6036), new DateTime(2025, 2, 25, 14, 4, 1, 288, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "classrooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 4, 1, 288, DateTimeKind.Local).AddTicks(6087), new DateTime(2025, 2, 25, 14, 4, 1, 288, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "classrooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 4, 1, 288, DateTimeKind.Local).AddTicks(6090), new DateTime(2025, 2, 25, 14, 4, 1, 288, DateTimeKind.Local).AddTicks(6092) });
        }
    }
}
