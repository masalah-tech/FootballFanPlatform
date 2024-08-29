using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FFP.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreClubsAndMatchesToSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "LogoPath", "Name" },
                values: new object[,]
                {
                    { 5, "/uploads/al-ettifaq-club-logo.png", "Al-Ettifaq" },
                    { 6, "/uploads/al-raed-club-logo.png", "Al-Raed" },
                    { 7, "/uploads/al-nassr-club-logo.png", "Al-Nassr" },
                    { 8, "/uploads/al-khaleej-club-logo.png", "Al-Khaleej" }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Club1Goals", "Club1Id", "Club2Goals", "Club2Id", "DateTime", "LeagueId" },
                values: new object[,]
                {
                    { 3, null, 5, null, 6, new DateTime(2030, 12, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, null, 7, null, 8, new DateTime(2030, 12, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
