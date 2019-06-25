using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class AddImageUrlToBaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "ProjectStageGate",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "ProjectStageGate",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "ProjectRagStatus",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "ProjectRagStatus",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "ProjectPlanBudgetBenefits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "ProjectPlanBudgetBenefits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "ProjectsPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "ProjectsPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "ProjectManagementRanks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "ProjectManagementRanks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "ProjectBudgetTracker",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "ProjectBudgetTracker",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "ProjectBudget",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "ProjectBudget",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "ProgrammesPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "ProgrammesPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "Programmes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "Programmes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "PortfoliosPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "PortfoliosPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "Portfolios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "Portfolios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "Platforms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "Platforms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "DomainsPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "DomainsPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "Domains",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "Domains",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "CompanyRateCards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "CompanyRateCards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "CompanyMethodologyStages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "CompanyMethodologyStages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "CompanyMethodologies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "CompanyMethodologies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "BusinessUnitsPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "BusinessUnitsPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "BusinessUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "BusinessUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "BusinessCustomers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "BusinessCustomers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "Actuals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "Actuals",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "ProjectStageGate");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "ProjectStageGate");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "ProjectRagStatus");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "ProjectRagStatus");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "ProjectPlanBudgetBenefits");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "ProjectPlanBudgetBenefits");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "ProjectsPermitted");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "ProjectsPermitted");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "ProjectManagementRanks");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "ProjectManagementRanks");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "ProjectBudgetTracker");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "ProjectBudgetTracker");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "ProgrammesPermitted");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "ProgrammesPermitted");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "Programmes");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "Programmes");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "PortfoliosPermitted");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "PortfoliosPermitted");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "DomainsPermitted");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "DomainsPermitted");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "Domains");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "Domains");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "CompanyRateCards");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "CompanyRateCards");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "CompanyMethodologyStages");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "CompanyMethodologyStages");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "CompanyMethodologies");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "CompanyMethodologies");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "BusinessUnitsPermitted");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "BusinessUnitsPermitted");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "BusinessUnits");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "BusinessUnits");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "BusinessCustomers");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "BusinessCustomers");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "Actuals");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "Actuals");
        }
    }
}
