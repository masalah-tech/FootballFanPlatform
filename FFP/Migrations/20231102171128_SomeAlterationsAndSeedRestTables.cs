using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FFP.Migrations
{
    /// <inheritdoc />
    public partial class SomeAlterationsAndSeedRestTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountRatio",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "NewPrice");

            migrationBuilder.AddColumn<int>(
                name: "InStock",
                table: "StoresProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "OldPrice",
                table: "Products",
                type: "float",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "LogoPath", "Name" },
                values: new object[,]
                {
                    { 1, "path", "Al Hilal" },
                    { 2, "path", "Al Ra'ed" }
                });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Title" },
                values: new object[] { 1, "Roshn Saudi League" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Date", "HTMLContent", "PosterPath", "Title", "UserId" },
                values: new object[] { 1, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "<p>What are the best football games? That question is not only guaranteed to spark plenty of debate but will also generate lots of different answers.</p>", "path", "The best football games for fans of all ages", 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "MainPosterPath", "Name", "NewPrice", "OldPrice" },
                values: new object[] { 1, "/uploads/product1.jpg", "Nike Vapor Grip3 Goalkeeper Gloves – Black & Hyper Turq with Rush Fuschia with White", 118.8, null });

            migrationBuilder.InsertData(
                table: "ReportTypes",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Spam" },
                    { 2, "Hate speach or graphic violence" },
                    { 3, "Harassment or bullying" },
                    { 4, "Misinformation" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "Name", "OwnerId", "PosterPath", "Status" },
                values: new object[] { 1, "Just High Quality Items", 1, "uploads/store1-poster.jpg", true });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "EncPassword", "FirstName", "LastName", "PhotoPath", "Status", "Username" },
                values: new object[] { 2, "23@fSF3@Fs", "Shaimaa", "Salim", "path", true, "shaimaasalim" });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Club1Goals", "Club1Id", "Club2Goals", "Club2Id", "DateTime", "LeagueId" },
                values: new object[] { 1, 3, 1, 2, 2, new DateTime(2023, 5, 31, 21, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "PostComments",
                columns: new[] { "Id", "Content", "Date", "PostId", "UserId" },
                values: new object[] { 1, "I believe it is gonna be the best season ever. I'm really excited and cannot wait to see my best team take the cup.", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 });

            migrationBuilder.InsertData(
                table: "PostLikes",
                columns: new[] { "Id", "Date", "PostId", "UserId" },
                values: new object[] { 1, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.InsertData(
                table: "PostReports",
                columns: new[] { "Id", "Date", "PostId", "ReportTypeId", "UserId" },
                values: new object[] { 1, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, 2 });

            migrationBuilder.InsertData(
                table: "PostSaves",
                columns: new[] { "Id", "Date", "PostId", "UserId" },
                values: new object[] { 1, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 });

            migrationBuilder.InsertData(
                table: "ProductPhotos",
                columns: new[] { "Id", "Path", "ProductId" },
                values: new object[,]
                {
                    { 1, "uploads/product1_img1.jpg", 1 },
                    { 2, "uploads/product1_img2.jpg", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductReviews",
                columns: new[] { "Id", "Comment", "Date", "ProductId", "UserId", "Value" },
                values: new object[] { 1, "Awesome product. I really liked it", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 5 });

            migrationBuilder.InsertData(
                table: "ProductSaves",
                columns: new[] { "Id", "Date", "ProductId", "UserId" },
                values: new object[] { 1, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 });

            migrationBuilder.InsertData(
                table: "ProductsCarts",
                columns: new[] { "Id", "CartId", "ProductId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "StoreSaves",
                columns: new[] { "Id", "Date", "StoreId", "UserId" },
                values: new object[] { 1, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 });

            migrationBuilder.InsertData(
                table: "StoresProducts",
                columns: new[] { "Id", "InStock", "ProductId", "StoreId" },
                values: new object[] { 1, 7, 1, 1 });

            migrationBuilder.InsertData(
                table: "UserSaves",
                columns: new[] { "Id", "Date", "SavedUserId", "SavingUserId" },
                values: new object[] { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.InsertData(
                table: "MatchSaves",
                columns: new[] { "Id", "Date", "MatchId", "UserId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.InsertData(
                table: "MatchesRatings",
                columns: new[] { "Id", "Comment", "Date", "MatchId", "UserId", "Value" },
                values: new object[] { 1, "Bla Bla Bla", new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 4 });

            migrationBuilder.InsertData(
                table: "PostCommentLikes",
                columns: new[] { "Id", "Date", "PostCommentId", "UserId" },
                values: new object[] { 1, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 });

            migrationBuilder.InsertData(
                table: "PostCommentReports",
                columns: new[] { "Id", "Date", "PostCommentId", "ReportTypeId", "UserId" },
                values: new object[] { 1, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, 1 });

            migrationBuilder.InsertData(
                table: "Predictions",
                columns: new[] { "Id", "MatchId", "PredictedWinnerClub", "UserId" },
                values: new object[] { 1, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "CustomerId", "Date", "StoreProductId" },
                values: new object[] { 1, 2, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "MatchRatingReports",
                columns: new[] { "Id", "Date", "MatchRatingId", "ReportTypeId", "UserId" },
                values: new object[] { 1, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MatchRatingReports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MatchSaves",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostCommentLikes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostCommentReports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostLikes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostReports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostSaves",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Predictions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductSaves",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductsCarts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReportTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReportTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReportTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StoreSaves",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserSaves",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MatchesRatings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostComments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReportTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StoresProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "InStock",
                table: "StoresProducts");

            migrationBuilder.DropColumn(
                name: "OldPrice",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "NewPrice",
                table: "Products",
                newName: "Price");

            migrationBuilder.AddColumn<double>(
                name: "DiscountRatio",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
