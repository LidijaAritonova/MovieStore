using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieStore.Migrations
{
    public partial class Traller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Wishlists",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Traller",
                table: "Movies",
                maxLength: 350,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a564",
                column: "ConcurrencyStamp",
                value: "2dd00398-9485-45e2-9288-a4f12842ccc1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a565",
                column: "ConcurrencyStamp",
                value: "a207d9bb-12ba-411a-b92c-272214183d41");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a566",
                column: "ConcurrencyStamp",
                value: "48c038a9-a38c-4d75-99be-a7dd9f0ba456");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a564",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGH19BT8kkgGjqNqUoam6y2PhiCZ6aJSjS569CKwAUb0gPV7kqtPVZDHbpe+fwWyVA==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Wishlists");

            migrationBuilder.DropColumn(
                name: "Traller",
                table: "Movies");

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
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELm3nImHZb9iarE6zhf+83TMz3/bygUYBNsGutidg3uq0CSvpMJ7tVpY2xLOHNrb/A==");
        }
    }
}
