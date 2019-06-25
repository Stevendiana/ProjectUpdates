using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class PlatformsAndResources : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusinessUnit",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "CurrentPlatform",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "Domain",
                table: "Resources");

            migrationBuilder.RenameColumn(
                name: "PlatformLead",
                table: "Resources",
                newName: "PlatformId");

            migrationBuilder.AlterColumn<string>(
                name: "PlatformId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlatformCode",
                table: "Platforms",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Resources_PlatformId",
                table: "Resources",
                column: "PlatformId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Platforms_PlatformId",
                table: "Resources",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Platforms_PlatformId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_PlatformId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "PlatformCode",
                table: "Platforms");

            migrationBuilder.RenameColumn(
                name: "PlatformId",
                table: "Resources",
                newName: "PlatformLead");

            migrationBuilder.AlterColumn<string>(
                name: "PlatformLead",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessUnit",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentPlatform",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Domain",
                table: "Resources",
                nullable: true);
        }
    }
}
