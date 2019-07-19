using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class ManagerForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
               name: "FK_Resources_Suppliers_SupplierId",
               table: "Resources",
               column: "SupplierId",
               principalTable: "Suppliers",
               principalColumn: "SupplierId",
               onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Resources_CompanyId_ResourceManagerId",
                table: "Resources",
                columns: new[] { "CompanyId", "ResourceManagerId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
               name: "FK_Resources_Suppliers_SupplierId",
               table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Resources_CompanyId_ResourceManagerId",
                table: "Resources");

        }
    }
}
