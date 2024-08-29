using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FFP.Migrations
{
    /// <inheritdoc />
    public partial class ChangeAttributeNameInAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoPath",
                table: "Admins",
                newName: "PersonalPhotoPath");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonalPhotoPath",
                table: "Admins",
                newName: "PhotoPath");
        }
    }
}
