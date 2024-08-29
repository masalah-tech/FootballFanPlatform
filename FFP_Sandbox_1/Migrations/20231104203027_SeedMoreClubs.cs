using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FFP.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreClubs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "LogoPath", "Name" },
                values: new object[,]
                {
                    { 9, "/uploads/dortmund-club-logo.png", "Dortmund" },
                    { 10, "/uploads/newcastle-club-logo.png", "Newcastle" },
                    { 11, "/uploads/shakhtar-donetsk-club-logo.png", "Shakhtar Donetsk" },
                    { 12, "/uploads/", "Barcelona" },
                    { 13, "/uploads/real-madrid-club-logo.png", "Real Madrid" },
                    { 14, "/uploads/lazio-club-logo.png", "Lazio" },
                    { 15, "/uploads/feyenoord-club-logo.png", "Feyenoord" },
                    { 16, "/uploads/porto-club-logo.png", "Porto" },
                    { 17, "/uploads/antwerp-club-logo.png", "Antwerp" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}
