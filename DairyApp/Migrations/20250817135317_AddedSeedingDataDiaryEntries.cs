 using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DairyApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 8, 17, 19, 23, 15, 320, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2025, 8, 17, 19, 23, 15, 320, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2025, 8, 17, 19, 23, 15, 320, DateTimeKind.Local).AddTicks(9496));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 8, 17, 18, 49, 0, 217, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2025, 8, 17, 18, 49, 0, 217, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2025, 8, 17, 18, 49, 0, 217, DateTimeKind.Local).AddTicks(8569));
        }
    }
}
