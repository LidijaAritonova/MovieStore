using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieStore.Migrations
{
    public partial class Tarllerfinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a564",
                column: "ConcurrencyStamp",
                value: "c2d6e3f7-7797-45da-99f6-f59ef13b66a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a565",
                column: "ConcurrencyStamp",
                value: "6b0cfdaf-85a1-4f85-b361-5356c26e48b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a566",
                column: "ConcurrencyStamp",
                value: "b2549221-8b15-42f7-a736-fca93a873b37");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a564",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELiNOh53TobUnguue4tVfVRMI94PKbgkoK4ezfCy08OhY6ayVKgg2RrnYIlP00FeQA==");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Traller",
                value: "https://www.youtube.com/embed/WHXxVmeGQUc");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Traller",
                value: "https://www.youtube.com/embed/tbayiPxkUMM");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Traller",
                value: "https://www.youtube.com/embed/T7O7BtBnsG4");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Traller",
                value: "https://www.youtube.com/embed/ELeMaP8EPAA");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Traller",
                value: "https://www.youtube.com/embed/Kv6JWoVKlGY");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Traller",
                value: "https://www.youtube.com/embed/gCcx85zbxz4");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Traller",
                value: "https://www.youtube.com/embed/DqQe3OrsMKI");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Traller",
                value: "https://www.youtube.com/embed/LKFuXETZUsI");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "Traller",
                value: "https://www.youtube.com/embed/DJNT7C61NrE");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "Traller",
                value: "https://www.youtube.com/embed/edUJ3bp48u0");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "Traller",
                value: "https://www.youtube.com/embed/s7EdQ4FqbhY");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "Traller",
                value: "https://www.youtube.com/embed/KJVuqYkI2jQ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "Traller",
                value: "https://www.youtube.com/embed/xas1UyTiVUw");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a564",
                column: "ConcurrencyStamp",
                value: "0e355bc8-a9de-4013-b89f-17dbb97a52ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a565",
                column: "ConcurrencyStamp",
                value: "1584824d-e8dd-4825-a316-1551be7c44d4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a566",
                column: "ConcurrencyStamp",
                value: "48e05a2a-899f-459d-b349-1c23df7d2d26");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02ca419c-4868-4f03-9b0f-8f8a4dd4a564",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENoDPqVxTKiKJ91t1frEwx678doCF0bCbBCi+aNBm4BCWDAiBXjRjtW6Mbx5d4igkw==");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Traller",
                value: "https://www.youtube.com/watch?v=WHXxVmeGQUc");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Traller",
                value: "https://www.youtube.com/watch?v=tbayiPxkUMM");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Traller",
                value: "https://www.youtube.com/watch?v=T7O7BtBnsG4");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Traller",
                value: "https://www.youtube.com/watch?v=ELeMaP8EPAA");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Traller",
                value: "https://www.youtube.com/watch?v=Kv6JWoVKlGY");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Traller",
                value: "https://www.youtube.com/watch?v=gCcx85zbxz4");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Traller",
                value: "https://www.youtube.com/watch?v=DqQe3OrsMKI");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Traller",
                value: "https://www.youtube.com/watch?v=LKFuXETZUsI");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "Traller",
                value: "https://www.youtube.com/watch?v=DJNT7C61NrE");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "Traller",
                value: "https://www.youtube.com/watch?v=edUJ3bp48u0");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "Traller",
                value: "https://www.youtube.com/watch?v=s7EdQ4FqbhY");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "Traller",
                value: "https://www.youtube.com/watch?v=KJVuqYkI2jQ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "Traller",
                value: "https://www.youtube.com/watch?v=xas1UyTiVUw");
        }
    }
}
