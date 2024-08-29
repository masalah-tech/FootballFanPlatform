using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FFP.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdminRoleAndAdminTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppartmentNo",
                value: 60);

            migrationBuilder.InsertData(
                table: "AdminRoles",
                columns: new[] { "Id", "Title" },
                values: new object[] { 1, "Super Admin" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AddressId", "AdminRoleId", "BirthDate", "Email", "EncPassword", "FirstName", "LastName", "Nationality", "PhoneNumber", "PhotoPath", "SecondName", "Status", "ThirdName", "Username" },
                values: new object[] { 1, 1, 1, new DateTime(2000, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "masalah.tech@gmail.com", "M@zen852", "Mazen", "Salah", "Yemeni", "00967774806897", "some path", "Ameen", true, "Hamid", "masalah-tech" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AdminRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppartmentNo",
                value: 50);
        }
    }
}
