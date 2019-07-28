using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class AddUtilToResource : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResourceEffortSummaries_Companies_CompanyId",
                table: "ResourceEffortSummaries");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceEffortSummaries_Resources_ResourceCompanyId_ResourceId1",
                table: "ResourceEffortSummaries");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ResourceStartDate",
                table: "Resources",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ResourceEndDate",
                table: "Resources",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceEffortSummaries_Companies_CompanyId",
                table: "ResourceEffortSummaries",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceEffortSummaries_Resources_ResourceCompanyId_ResourceId1",
                table: "ResourceEffortSummaries",
                columns: new[] { "ResourceCompanyId", "ResourceId1" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResourceEffortSummaries_Companies_CompanyId",
                table: "ResourceEffortSummaries");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceEffortSummaries_Resources_ResourceCompanyId_ResourceId1",
                table: "ResourceEffortSummaries");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ResourceStartDate",
                table: "Resources",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ResourceEndDate",
                table: "Resources",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceEffortSummaries_Companies_CompanyId",
                table: "ResourceEffortSummaries",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceEffortSummaries_Resources_ResourceCompanyId_ResourceId1",
                table: "ResourceEffortSummaries",
                columns: new[] { "ResourceCompanyId", "ResourceId1" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
