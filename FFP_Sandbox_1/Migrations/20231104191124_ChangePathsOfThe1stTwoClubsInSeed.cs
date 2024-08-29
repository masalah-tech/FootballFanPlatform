using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FFP.Migrations
{
    /// <inheritdoc />
    public partial class ChangePathsOfThe1stTwoClubsInSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LogoPath", "Name" },
                values: new object[] { "al-hilal-club-logo.png", "Al-Hilal" });

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LogoPath", "Name" },
                values: new object[] { "/uploads/al-raed-club-logo.png", "Al-Ra'ed" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LogoPath", "Name" },
                values: new object[] { "path", "Al Hilal" });

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LogoPath", "Name" },
                values: new object[] { "path", "Al Ra'ed" });
        }
    }
}
