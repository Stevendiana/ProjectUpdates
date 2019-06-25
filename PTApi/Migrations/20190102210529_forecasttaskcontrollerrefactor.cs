using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class forecasttaskcontrollerrefactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AprActualsReconciled",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AugActualsReconciled",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DecActualsReconciled",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "FebActualsReconciled",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "JanActualsReconciled",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "JulActualsReconciled",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "JunActualsReconciled",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MarActualsReconciled",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MayActualsReconciled",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "NovActualsReconciled",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "OctActualsReconciled",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SepActualsReconciled",
                table: "ForecastTasks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AprActualsReconciled",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "AugActualsReconciled",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "DecActualsReconciled",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "FebActualsReconciled",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "JanActualsReconciled",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "JulActualsReconciled",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "JunActualsReconciled",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MarActualsReconciled",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "MayActualsReconciled",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "NovActualsReconciled",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "OctActualsReconciled",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "SepActualsReconciled",
                table: "ForecastTasks");
        }
    }
}
