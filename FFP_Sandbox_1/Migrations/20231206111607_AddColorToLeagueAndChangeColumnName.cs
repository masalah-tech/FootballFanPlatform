using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FFP.Migrations
{
    /// <inheritdoc />
    public partial class AddColorToLeagueAndChangeColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Leagues",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Leagues",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 1,
                column: "Color",
                value: "rgb(57 94 172)");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 2,
                column: "Color",
                value: "rgb(107 50 147)");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 3,
                column: "Color",
                value: "rgb(0 158 161)");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 4,
                column: "Color",
                value: "rgb(0 158 161)");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 5,
                column: "Color",
                value: "rgb(65 181 70)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Leagues");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Leagues",
                newName: "Title");

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Title" },
                values: new object[] { 6, "World Cup" });
        }
    }
}
