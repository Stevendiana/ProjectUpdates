using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class ForecastAndResourceRefactoring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CostSubCategory",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialQuantityApr",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialQuantityAug",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialQuantityDec",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialQuantityFeb",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialQuantityJan",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialQuantityJul",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialQuantityJun",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialQuantityMar",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialQuantityMay",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialQuantityNov",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialQuantityOct",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialQuantitySep",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialUnitCostApr",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialUnitCostAug",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialUnitCostDec",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialUnitCostFeb",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialUnitCostJan",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialUnitCostJul",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialUnitCostJun",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialUnitCostMar",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialUnitCostMay",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialUnitCostNov",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialUnitCostOct",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialUnitCostSep",
                table: "ForecastTasks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostSubCategory",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialQuantityApr",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialQuantityAug",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialQuantityDec",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialQuantityFeb",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialQuantityJan",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialQuantityJul",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialQuantityJun",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialQuantityMar",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialQuantityMay",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialQuantityNov",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialQuantityOct",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialQuantitySep",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialUnitCostApr",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialUnitCostAug",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialUnitCostDec",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialUnitCostFeb",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialUnitCostJan",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialUnitCostJul",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialUnitCostJun",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialUnitCostMar",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialUnitCostMay",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialUnitCostNov",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialUnitCostOct",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MaterialUnitCostSep",
                table: "ForecastTasks");
        }
    }
}
