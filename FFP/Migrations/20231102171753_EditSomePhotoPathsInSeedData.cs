using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FFP.Migrations
{
    /// <inheritdoc />
    public partial class EditSomePhotoPathsInSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Path",
                value: "/uploads/product1_img1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Path",
                value: "/uploads/product1_img2.jpg");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "PosterPath",
                value: "/uploads/store1-poster.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Path",
                value: "uploads/product1_img1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Path",
                value: "uploads/product1_img2.jpg");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "PosterPath",
                value: "uploads/store1-poster.jpg");
        }
    }
}
