using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieStore.Migrations
{
    public partial class adminuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a564",
                column: "ConcurrencyStamp",
                value: "89acf6a3-f602-4042-9c30-e9eb8d2d708c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a565",
                column: "ConcurrencyStamp",
                value: "1b01f4db-6dc5-46e5-9800-bfdc04f6ce30");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a566",
                column: "ConcurrencyStamp",
                value: "ad9dfc5b-31db-413f-927e-8747ba93daeb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a564",
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAEAACcQAAAAEO0v1SmsPWAC+59jiIrCo9aPX5xsB1qOleT/uokMGhg9qnjmlgXpZspnbEWxcN60DQ==", "admin@onlinemoviestore.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a564",
                column: "ConcurrencyStamp",
                value: "d9749efc-4535-40e6-a320-f94d4beefb5b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a565",
                column: "ConcurrencyStamp",
                value: "9f4f4630-8488-48a7-a6e1-5e9dce981561");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a566",
                column: "ConcurrencyStamp",
                value: "1e5db413-4326-40e9-990c-beeb1af0667e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a564",
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAEAACcQAAAAEI1WH45FjYiJDMHK94KRp9H1qCvUdPmOq7D7nLdp5ScYtUhzk/M0Syj5zBn8gAqjIg==", "admin" });
        }
    }
}
