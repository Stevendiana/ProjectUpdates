using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class projectClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ActualEndDate",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ActualStartDate",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectActualCompletion",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectCPI",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectEAC",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectEarnedValue",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProjectEndDate",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectEstimateAtCompletion",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectEstimateToComplete",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ProjectPlannedCompletion",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectSPI",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProjectStartDate",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectVarianceAtComplete",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalActual",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalLifeTimeForecast",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPlannedValue",
                table: "Projects",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActualEndDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ActualStartDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectActualCompletion",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectCPI",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectEAC",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectEarnedValue",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectEndDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectEstimateAtCompletion",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectEstimateToComplete",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectPlannedCompletion",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectSPI",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectStartDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectVarianceAtComplete",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TotalActual",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TotalLifeTimeForecast",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TotalPlannedValue",
                table: "Projects");
        }
    }
}
