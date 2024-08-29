using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FFP.Migrations
{
    /// <inheritdoc />
    public partial class SeedAddressTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AppartmentNo", "City", "Country", "State", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, 50, "Riyadh", "Saudi Arabia", null, "Tahlia Street", null },
                    { 2, 30, "Riyadh", "Saudi Arabia", null, "Al Sahafa Street", null },
                    { 3, 25, "Jeddah", "Saudi Arabia", null, "Hira Street", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
