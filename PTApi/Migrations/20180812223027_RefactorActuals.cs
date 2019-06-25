using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class RefactorActuals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Actuals",
                newName: "TransactionAmount");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionCurrency",
                table: "Actuals",
                nullable: false);

            migrationBuilder.AddColumn<decimal>(
                name: "ReportingAmount",
                table: "Actuals",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ReportingCurrency",
                table: "Actuals",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReportingAmount",
                table: "Actuals");

            migrationBuilder.DropColumn(
                name: "ReportingCurrency",
                table: "Actuals");

            migrationBuilder.RenameColumn(
                name: "TransactionAmount",
                table: "Actuals",
                newName: "Amount");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionCurrency",
                table: "Actuals",
                nullable: true);
        }
    }
}
