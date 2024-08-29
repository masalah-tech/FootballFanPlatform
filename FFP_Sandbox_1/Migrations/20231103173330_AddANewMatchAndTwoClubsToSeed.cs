using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FFP.Migrations
{
    /// <inheritdoc />
    public partial class AddANewMatchAndTwoClubsToSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "LogoPath", "Name" },
                values: new object[,]
                {
                    { 3, "/uploads/al-shabab-club-logo.png", "Al-Shabab" },
                    { 4, "/uploads/al-ittihad-club-logo.png", "Al-Ittihad" }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Club1Goals", "Club1Id", "Club2Goals", "Club2Id", "DateTime", "LeagueId" },
                values: new object[] { 2, null, 3, null, 4, new DateTime(2030, 12, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
