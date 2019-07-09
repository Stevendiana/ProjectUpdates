using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class PopulateAccountOnwerRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.UpdateData(
            table: "AspNetUsers",
            keyColumn: "Id",
            keyValue: "1b060f05-f5ff-4512-83a4-f92370192ca9",
            column: "AppUserRole",
            value: "AccountOwner");migrationBuilder.UpdateData(
            table: "AspNetUsers",
            keyColumn: "Id",
            keyValue: "3eca44b1-bcad-45b5-a2a3-50b0412094a6",
            column: "AppUserRole",
            value: "AccountOwner");migrationBuilder.UpdateData(
            table: "AspNetUsers",
            keyColumn: "Id",
            keyValue: "42b6985a-f154-4dc8-87ed-08a091472b99",
            column: "AppUserRole",
            value: "AccountOwner");migrationBuilder.UpdateData(
            table: "AspNetUsers",
            keyColumn: "Id",
            keyValue: "a51f3ec7-7121-4caf-aea7-c646adf78170",
            column: "AppUserRole",
            value: "AccountOwner");migrationBuilder.UpdateData(
            table: "AspNetUsers",
            keyColumn: "Id",
            keyValue: "d92b5b5b-26f1-4fa5-a2b0-070294840bd0",
            column: "AppUserRole",
            value: "AccountOwner");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
