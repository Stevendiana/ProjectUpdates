using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PTApi.Migrations
{
    public partial class ChangeLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "ProjectStageGate",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "ProjectStageGate",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "ProjectStageGate",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "ProjectStageGate",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "ProjectPlanBudgetBenefits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "ProjectPlanBudgetBenefits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "ProjectPlanBudgetBenefits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "ProjectPlanBudgetBenefits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "ProjectsPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "ProjectsPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "ProjectsPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "ProjectsPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "ProjectManagementRanks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "ProjectManagementRanks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "ProjectManagementRanks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "ProjectManagementRanks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "ProgrammesPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "ProgrammesPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "ProgrammesPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "ProgrammesPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "Programmes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "Programmes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "Programmes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "Programmes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "PortfoliosPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "PortfoliosPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "PortfoliosPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "PortfoliosPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "Portfolios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "Portfolios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "Portfolios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "Portfolios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "Platforms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "Platforms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "Platforms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "Platforms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "DomainsPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "DomainsPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "DomainsPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "DomainsPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "Domains",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "Domains",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "Domains",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "Domains",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "CompanyRateCards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "CompanyRateCards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "CompanyRateCards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "CompanyRateCards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "CompanyMethodologyStages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "CompanyMethodologyStages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "CompanyMethodologyStages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "CompanyMethodologyStages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "CompanyMethodologies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "CompanyMethodologies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "CompanyMethodologies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "CompanyMethodologies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "BusinessUnitsPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "BusinessUnitsPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "BusinessUnitsPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "BusinessUnitsPermitted",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "BusinessUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "BusinessUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "BusinessUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "BusinessUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "BusinessCustomers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "BusinessCustomers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "BusinessCustomers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "BusinessCustomers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "Actuals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "Actuals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "Actuals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "Actuals",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ChangeLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateChanged = table.Column<DateTime>(nullable: false),
                    EntityName = table.Column<string>(nullable: true),
                    NewValue = table.Column<string>(nullable: true),
                    OldValue = table.Column<string>(nullable: true),
                    PrimaryKeyValue = table.Column<string>(nullable: true),
                    UserCompanyId = table.Column<string>(nullable: true),
                    UserFirstName = table.Column<string>(nullable: true),
                    UserLastName = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectRagStatus",
                columns: table => new
                {
                    CompanyId = table.Column<string>(nullable: false),
                    ProjectId = table.Column<string>(nullable: false),
                    ActivitiesPlannedNextPeriod = table.Column<string>(maxLength: 2500, nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    HighlightsThisPeriod = table.Column<string>(maxLength: 2500, nullable: true),
                    PortfolioMiReportingPeriod = table.Column<string>(nullable: true),
                    ProjectRagStatusId = table.Column<string>(nullable: false),
                    RagNarrativeCustomerSatisfaction = table.Column<string>(maxLength: 2500, nullable: true),
                    RagNarrativeFinances = table.Column<string>(maxLength: 2500, nullable: true),
                    RagNarrativeGovernanceBusinessChange = table.Column<string>(maxLength: 2500, nullable: true),
                    RagNarrativeQuality = table.Column<string>(maxLength: 2500, nullable: true),
                    RagNarrativeResourcing = table.Column<string>(maxLength: 2500, nullable: true),
                    RagNarrativeSchedule = table.Column<string>(maxLength: 2500, nullable: true),
                    RagNarrativeScope = table.Column<string>(maxLength: 2500, nullable: true),
                    RagNarrativeSummary = table.Column<string>(maxLength: 2500, nullable: true),
                    RagStatusCustomerSatisfaction = table.Column<string>(nullable: true),
                    RagStatusFinances = table.Column<string>(nullable: true),
                    RagStatusGovernanceBusinessChange = table.Column<string>(nullable: true),
                    RagStatusQuality = table.Column<string>(nullable: true),
                    RagStatusResourcing = table.Column<string>(nullable: true),
                    RagStatusSchedule = table.Column<string>(nullable: true),
                    RagStatusScope = table.Column<string>(nullable: true),
                    RagStatusSummary = table.Column<string>(nullable: true),
                    ReportingPeriodNumbers = table.Column<byte>(nullable: false),
                    ReportingPeriodWords = table.Column<string>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedFirstName = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedLastName = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedFirstName = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedLastName = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectRagStatus", x => new { x.CompanyId, x.ProjectId });
                    table.UniqueConstraint("AK_ProjectRagStatus_ProjectRagStatusId", x => x.ProjectRagStatusId);
                    table.ForeignKey(
                        name: "FK_ProjectRagStatus_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectRagStatus_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectRagStatus_ProjectId",
                table: "ProjectRagStatus",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChangeLogs");

            migrationBuilder.DropTable(
                name: "ProjectRagStatus");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "ProjectStageGate");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "ProjectStageGate");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "ProjectStageGate");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "ProjectStageGate");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "ProjectPlanBudgetBenefits");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "ProjectPlanBudgetBenefits");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "ProjectPlanBudgetBenefits");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "ProjectPlanBudgetBenefits");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "ProjectsPermitted");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "ProjectsPermitted");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "ProjectsPermitted");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "ProjectsPermitted");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "ProjectManagementRanks");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "ProjectManagementRanks");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "ProjectManagementRanks");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "ProjectManagementRanks");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "ProgrammesPermitted");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "ProgrammesPermitted");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "ProgrammesPermitted");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "ProgrammesPermitted");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "Programmes");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "Programmes");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "Programmes");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "Programmes");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "PortfoliosPermitted");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "PortfoliosPermitted");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "PortfoliosPermitted");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "PortfoliosPermitted");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "DomainsPermitted");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "DomainsPermitted");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "DomainsPermitted");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "DomainsPermitted");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "Domains");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "Domains");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "Domains");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "Domains");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "CompanyRateCards");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "CompanyRateCards");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "CompanyRateCards");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "CompanyRateCards");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "CompanyMethodologyStages");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "CompanyMethodologyStages");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "CompanyMethodologyStages");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "CompanyMethodologyStages");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "CompanyMethodologies");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "CompanyMethodologies");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "CompanyMethodologies");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "CompanyMethodologies");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "BusinessUnitsPermitted");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "BusinessUnitsPermitted");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "BusinessUnitsPermitted");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "BusinessUnitsPermitted");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "BusinessUnits");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "BusinessUnits");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "BusinessUnits");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "BusinessUnits");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "BusinessCustomers");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "BusinessCustomers");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "BusinessCustomers");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "BusinessCustomers");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "Actuals");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "Actuals");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "Actuals");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "Actuals");
        }
    }
}
