using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FFP.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataToUserAndPrediction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 1,
                column: "MatchId",
                value: 2);

            migrationBuilder.InsertData(
                table: "Predictions",
                columns: new[] { "Id", "MatchId", "PredictedWinnerClub", "UserId" },
                values: new object[] { 2, 2, 1, 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "EncPassword", "FirstName", "LastName", "PhotoPath", "Status", "Username" },
                values: new object[,]
                {
                    { 3, "@#$FSAF@#", "Osama", "Sameer", null, true, "osamasameer" },
                    { 4, "sF3#$Gs%#ss", "Mohammed", "Naser", null, true, "mohammednaser" },
                    { 5, "Sfe34%#2#5%", "Khalid", "Amer", null, true, "khalidamer" },
                    { 6, "@#FsdE323#", "Mahmoud", "Mansour", null, true, "mahmoudmansour" },
                    { 7, "234SDFe3#$", "Abdullah", "Saleh", null, true, "abdullahsaleh" },
                    { 8, "SDe2#@43S", "Nazar", "Hamoud", null, true, "nazarhamoud" },
                    { 9, "SSEFE23fs@#", "Abdulaziz", "Sultan", null, true, "abdulazizsultan" },
                    { 10, "&%sdfSE323", "Hattan", "Faisal", null, true, "hattanfaisal" },
                    { 11, "@##@SDFss3", "Thunaian", "Khalid", null, true, "thunaiankhalid" },
                    { 12, "!!324sdSdfF43", "Mohammed", "Hamza", null, true, "mohammedhamza" },
                    { 13, "((^77456FDg3", "Somayah", "Omar", null, true, "somayahomar" },
                    { 14, "@@342SDfe2", "Kholod", "Ahmed", null, true, "kholodahmed" },
                    { 15, "!@#SDFdf323", "Taha", "Abdulghafour", null, true, "tahaabdulghafour" },
                    { 16, "Ssdfe@#234S", "Salma", "Adel", null, true, "salmaadel" }
                });

            migrationBuilder.InsertData(
                table: "Predictions",
                columns: new[] { "Id", "MatchId", "PredictedWinnerClub", "UserId" },
                values: new object[,]
                {
                    { 3, 2, 1, 3 },
                    { 4, 2, 1, 4 },
                    { 5, 2, 1, 5 },
                    { 6, 2, 1, 6 },
                    { 7, 2, 1, 7 },
                    { 8, 2, 1, 8 },
                    { 9, 2, 1, 9 },
                    { 10, 2, 1, 10 },
                    { 11, 3, 1, 11 },
                    { 12, 3, 2, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 1,
                column: "MatchId",
                value: 1);
        }
    }
}
