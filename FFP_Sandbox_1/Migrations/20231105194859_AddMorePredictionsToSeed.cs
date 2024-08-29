using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FFP.Migrations
{
    /// <inheritdoc />
    public partial class AddMorePredictionsToSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "MatchId", "PredictedWinnerClub", "UserId" },
                values: new object[] { 2, 2, 14 });

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "MatchId", "UserId" },
                values: new object[] { 2, 15 });

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "MatchId", "UserId" },
                values: new object[] { 2, 16 });

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "MatchId", "PredictedWinnerClub", "UserId" },
                values: new object[] { 3, 1, 11 });

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "MatchId", "PredictedWinnerClub", "UserId" },
                values: new object[] { 3, 2, 12 });

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PredictedWinnerClub", "UserId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PredictedWinnerClub", "UserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "Predictions",
                columns: new[] { "Id", "MatchId", "PredictedWinnerClub", "UserId" },
                values: new object[,]
                {
                    { 21, 5, 1, 3 },
                    { 22, 5, 1, 4 },
                    { 23, 5, 1, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "MatchId", "PredictedWinnerClub", "UserId" },
                values: new object[] { 3, 1, 11 });

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "MatchId", "UserId" },
                values: new object[] { 3, 12 });

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "MatchId", "UserId" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "MatchId", "PredictedWinnerClub", "UserId" },
                values: new object[] { 5, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "MatchId", "PredictedWinnerClub", "UserId" },
                values: new object[] { 5, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PredictedWinnerClub", "UserId" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PredictedWinnerClub", "UserId" },
                values: new object[] { 1, 5 });
        }
    }
}
