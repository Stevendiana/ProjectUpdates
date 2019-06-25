using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class RefactorResourceDomainII : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Vendor",
                table: "ForecastTasks",
                newName: "VendorId");

            migrationBuilder.AddColumn<string>(
                name: "HolidayBookingCode",
                table: "ResourceHolidaysBooked",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalHolidayHours",
                table: "ResourceHolidaysBooked",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ResourceId",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyId",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupplierId",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    ContactEmail = table.Column<string>(nullable: true),
                    ContactTelephone = table.Column<string>(nullable: true),
                    ExternalVendorNumber = table.Column<string>(nullable: true),
                    Services = table.Column<string>(nullable: true),
                    SupplierName = table.Column<string>(nullable: true),
                    WorkOrderNumber = table.Column<string>(nullable: true),
                    WorkOrderOwner = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                    table.ForeignKey(
                        name: "FK_Suppliers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ForecastTasks_SupplierId",
                table: "ForecastTasks",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_ForecastTasks_CompanyId_ResourceId",
                table: "ForecastTasks",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_CompanyId",
                table: "Suppliers",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_ForecastTasks_Suppliers_SupplierId",
                table: "ForecastTasks",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ForecastTasks_Resources_CompanyId_ResourceId",
                table: "ForecastTasks",
                columns: new[] { "CompanyId", "ResourceId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForecastTasks_Suppliers_SupplierId",
                table: "ForecastTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_ForecastTasks_Resources_CompanyId_ResourceId",
                table: "ForecastTasks");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_ForecastTasks_SupplierId",
                table: "ForecastTasks");

            migrationBuilder.DropIndex(
                name: "IX_ForecastTasks_CompanyId_ResourceId",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "HolidayBookingCode",
                table: "ResourceHolidaysBooked");

            migrationBuilder.DropColumn(
                name: "TotalHolidayHours",
                table: "ResourceHolidaysBooked");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "ForecastTasks");

            migrationBuilder.RenameColumn(
                name: "VendorId",
                table: "ForecastTasks",
                newName: "Vendor");

            migrationBuilder.AlterColumn<string>(
                name: "ResourceId",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyId",
                table: "ForecastTasks",
                nullable: true);
        }
    }
}
