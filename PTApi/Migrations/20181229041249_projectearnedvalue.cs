using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class projectearnedvalue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BudgetEndDate",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BudgetStartDate",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectBudgetAtComplete",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalActual",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalForecast",
                table: "Projects",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BudgetEndDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "BudgetStartDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectBudgetAtComplete",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TotalActual",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TotalForecast",
                table: "Projects");
        }
    }
}
