using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FFP.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreMatches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Club1Goals", "Club1Id", "Club2Goals", "Club2Id", "DateTime", "LeagueId" },
                values: new object[,]
                {
                    { 5, null, 9, null, 10, new DateTime(2030, 12, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6, null, 11, null, 12, new DateTime(2030, 12, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, null, 14, null, 15, new DateTime(2030, 12, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 8, null, 16, null, 17, new DateTime(2030, 12, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
