using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class RemoveCompanyProjectIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_ProjectRagStatus_ProjectRagStatusId",
                table: "ProjectRagStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectRagStatus",
                table: "ProjectRagStatus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectRagStatus",
                table: "ProjectRagStatus",
                column: "ProjectRagStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectRagStatus_CompanyId",
                table: "ProjectRagStatus",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectRagStatus",
                table: "ProjectRagStatus");

            migrationBuilder.DropIndex(
                name: "IX_ProjectRagStatus_CompanyId",
                table: "ProjectRagStatus");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ProjectRagStatus_ProjectRagStatusId",
                table: "ProjectRagStatus",
                column: "ProjectRagStatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectRagStatus",
                table: "ProjectRagStatus",
                columns: new[] { "CompanyId", "ProjectId" });
        }
    }
}
