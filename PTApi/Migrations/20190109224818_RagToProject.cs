using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class RagToProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Activitythisperiod",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RagStatus",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RagStatusSummary",
                table: "Projects",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activitythisperiod",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "RagStatus",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "RagStatusSummary",
                table: "Projects");
        }
    }
}
