using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieStore.Migrations
{
    public partial class adminuser4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a564",
                column: "ConcurrencyStamp",
                value: "81dddacf-d58c-4678-a076-16624f289f2d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a565",
                column: "ConcurrencyStamp",
                value: "9d9e2939-8d04-4fca-ae0c-ea1d19c91bf9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a566",
                column: "ConcurrencyStamp",
                value: "b965deb6-5922-4b1d-859d-45c4673931ab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a564",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDwaUn2ZBSt1chBaI9lWHYZtg61iMDEpVAuMIqWQQ9WAuTMCeBmI8A47GrCQe38S6Q==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEO0v1SmsPWAC+59jiIrCo9aPX5xsB1qOleT/uokMGhg9qnjmlgXpZspnbEWxcN60DQ==");
        }
    }
}
