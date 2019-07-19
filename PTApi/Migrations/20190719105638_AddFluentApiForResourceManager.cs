using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class AddFluentApiForResourceManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

           

            migrationBuilder.AlterColumn<string>(
                name: "ResourceManagerId",
                table: "Resources",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierId",
                table: "Resources",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

           

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "ForecastTasks",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Resources_SupplierId",
                table: "Resources",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_CompanyId_ResourceManagerId",
                table: "Resources",
                columns: new[] { "CompanyId", "ResourceManagerId" });

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.DropIndex(
                name: "IX_Resources_SupplierId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_CompanyId_ResourceManagerId",
                table: "Resources");

           

          

            migrationBuilder.AlterColumn<string>(
                name: "ResourceManagerId",
                table: "Resources",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Vendor",
                table: "Resources",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

         

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "ForecastTasks",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
