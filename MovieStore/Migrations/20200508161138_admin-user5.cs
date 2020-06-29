using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieStore.Migrations
{
    public partial class adminuser5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a564",
                column: "ConcurrencyStamp",
                value: "e5f641d8-716e-4dc1-a814-bafc82055b73");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a565",
                column: "ConcurrencyStamp",
                value: "9b1cb86d-2fea-46be-ad9d-05166fe07774");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a566",
                column: "ConcurrencyStamp",
                value: "4aca29bc-ebe6-4cde-bb6e-45a28c881fcb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a564",
                columns: new[] { "NormalizedUserName", "PasswordHash" },
                values: new object[] { "ADMIN@ONLINEMOVIESTORE.COM", "AQAAAAEAACcQAAAAELm3nImHZb9iarE6zhf+83TMz3/bygUYBNsGutidg3uq0CSvpMJ7tVpY2xLOHNrb/A==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "NormalizedUserName", "PasswordHash" },
                values: new object[] { "ADMIN", "AQAAAAEAACcQAAAAEDwaUn2ZBSt1chBaI9lWHYZtg61iMDEpVAuMIqWQQ9WAuTMCeBmI8A47GrCQe38S6Q==" });
        }
    }
}
