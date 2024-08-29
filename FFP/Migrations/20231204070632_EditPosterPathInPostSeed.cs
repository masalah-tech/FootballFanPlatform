using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FFP.Migrations
{
    /// <inheritdoc />
    public partial class EditPosterPathInPostSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PosterPath",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PosterPath",
                value: "path");
        }
    }
}
