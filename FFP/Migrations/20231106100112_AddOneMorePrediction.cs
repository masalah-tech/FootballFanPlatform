using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FFP.Migrations
{
    /// <inheritdoc />
    public partial class AddOneMorePrediction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "MatchId", "PredictedWinnerClub", "UserId" },
                values: new object[] { 3, 0, 13 });

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 20,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PredictedWinnerClub", "UserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 22,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 23,
                column: "UserId",
                value: 4);

            migrationBuilder.InsertData(
                table: "Predictions",
                columns: new[] { "Id", "MatchId", "PredictedWinnerClub", "UserId" },
                values: new object[] { 24, 5, 1, 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "MatchId", "PredictedWinnerClub", "UserId" },
                values: new object[] { 5, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 20,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PredictedWinnerClub", "UserId" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 22,
                column: "UserId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 23,
                column: "UserId",
                value: 5);
        }
    }
}
