using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class projectbudgetforecast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BudgetEndDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "BudgetStartDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "GrandTotalBudgetApproved",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "GrandTotalBudgetSubmitted",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectBudgetAtComplete",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectEndDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectStartDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TotalActual",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TotalForecast",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "ProjectBudget",
                table: "Projects",
                newName: "ProjectCurrentBudgetTrackerId");

            migrationBuilder.AddColumn<string>(
                name: "ProjectBudgetId",
                table: "ReconciledActuals",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectCurrentBudgetTrackerId",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BudgetCurrentStatus",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentBudgetBadgeVersion",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TaskEarliestStartDate",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TaskLatestndEDate",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalForecastAmount",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoId",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoName",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecurringReportingDay",
                table: "Companies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProjectBudgetTracker",
                columns: table => new
                {
                    ProjectBudgetTrackerId = table.Column<string>(nullable: false),
                    BudgetBadgetStatus = table.Column<string>(nullable: true),
                    BudgetBadgetVersion = table.Column<int>(nullable: true),
                    BudgetEndDate = table.Column<DateTime>(nullable: true),
                    BudgetStartDate = table.Column<DateTime>(nullable: true),
                    CompanyId = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    ProjectBudgetTrackerCode = table.Column<string>(nullable: true),
                    ProjectId = table.Column<string>(nullable: true),
                    TotalLifeTimeBudget = table.Column<decimal>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedFirstName = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedLastName = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedFirstName = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedLastName = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectBudgetTracker", x => x.ProjectBudgetTrackerId);
                });

            migrationBuilder.CreateTable(
                name: "ProjectBudget",
                columns: table => new
                {
                    ProjectBudgetId = table.Column<string>(nullable: false),
                    AprAmount = table.Column<decimal>(nullable: true),
                    AprEndDate = table.Column<DateTime>(nullable: true),
                    AprForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    AprStartDate = table.Column<DateTime>(nullable: true),
                    AugAmount = table.Column<decimal>(nullable: true),
                    AugEndDate = table.Column<DateTime>(nullable: true),
                    AugForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    AugStartDate = table.Column<DateTime>(nullable: true),
                    BaselinePeriod = table.Column<int>(nullable: true),
                    BudgetCode = table.Column<string>(nullable: true),
                    CompanyId = table.Column<string>(nullable: true),
                    CostCat = table.Column<string>(nullable: true),
                    CostSubCategory = table.Column<string>(nullable: true),
                    CostType = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    DecAmount = table.Column<decimal>(nullable: true),
                    DecEndDate = table.Column<DateTime>(nullable: true),
                    DecForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    DecStartDate = table.Column<DateTime>(nullable: true),
                    FebAmount = table.Column<decimal>(nullable: true),
                    FebEndDate = table.Column<DateTime>(nullable: true),
                    FebForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    FebStartDate = table.Column<DateTime>(nullable: true),
                    ForecastCode = table.Column<string>(nullable: true),
                    ForecastPeriodType = table.Column<byte>(nullable: true),
                    ForecastTaskId = table.Column<string>(nullable: true),
                    JanAmount = table.Column<decimal>(nullable: true),
                    JanEndDate = table.Column<DateTime>(nullable: true),
                    JanForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    JanStartDate = table.Column<DateTime>(nullable: true),
                    JulAmount = table.Column<decimal>(nullable: true),
                    JulEndDate = table.Column<DateTime>(nullable: true),
                    JulForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    JulStartDate = table.Column<DateTime>(nullable: true),
                    JunAmount = table.Column<decimal>(nullable: true),
                    JunEndDate = table.Column<DateTime>(nullable: true),
                    JunForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    JunStartDate = table.Column<DateTime>(nullable: true),
                    MarAmount = table.Column<decimal>(nullable: true),
                    MarEndDate = table.Column<DateTime>(nullable: true),
                    MarForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    MarStartDate = table.Column<DateTime>(nullable: true),
                    MaterialQuantityApr = table.Column<decimal>(nullable: true),
                    MaterialQuantityAug = table.Column<decimal>(nullable: true),
                    MaterialQuantityDec = table.Column<decimal>(nullable: true),
                    MaterialQuantityFeb = table.Column<decimal>(nullable: true),
                    MaterialQuantityJan = table.Column<decimal>(nullable: true),
                    MaterialQuantityJul = table.Column<decimal>(nullable: true),
                    MaterialQuantityJun = table.Column<decimal>(nullable: true),
                    MaterialQuantityMar = table.Column<decimal>(nullable: true),
                    MaterialQuantityMay = table.Column<decimal>(nullable: true),
                    MaterialQuantityNov = table.Column<decimal>(nullable: true),
                    MaterialQuantityOct = table.Column<decimal>(nullable: true),
                    MaterialQuantitySep = table.Column<decimal>(nullable: true),
                    MaterialUnitCostApr = table.Column<decimal>(nullable: true),
                    MaterialUnitCostAug = table.Column<decimal>(nullable: true),
                    MaterialUnitCostDec = table.Column<decimal>(nullable: true),
                    MaterialUnitCostFeb = table.Column<decimal>(nullable: true),
                    MaterialUnitCostJan = table.Column<decimal>(nullable: true),
                    MaterialUnitCostJul = table.Column<decimal>(nullable: true),
                    MaterialUnitCostJun = table.Column<decimal>(nullable: true),
                    MaterialUnitCostMar = table.Column<decimal>(nullable: true),
                    MaterialUnitCostMay = table.Column<decimal>(nullable: true),
                    MaterialUnitCostNov = table.Column<decimal>(nullable: true),
                    MaterialUnitCostOct = table.Column<decimal>(nullable: true),
                    MaterialUnitCostSep = table.Column<decimal>(nullable: true),
                    MayAmount = table.Column<decimal>(nullable: true),
                    MayEndDate = table.Column<DateTime>(nullable: true),
                    MayForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    MayStartDate = table.Column<DateTime>(nullable: true),
                    Month = table.Column<byte>(nullable: true),
                    NovAmount = table.Column<decimal>(nullable: true),
                    NovEndDate = table.Column<DateTime>(nullable: true),
                    NovForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    NovStartDate = table.Column<DateTime>(nullable: true),
                    OctAmount = table.Column<decimal>(nullable: true),
                    OctEndDate = table.Column<DateTime>(nullable: true),
                    OctForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    OctStartDate = table.Column<DateTime>(nullable: true),
                    Open = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: true),
                    OrderNumber = table.Column<string>(nullable: true),
                    Parent = table.Column<string>(nullable: true),
                    Progress = table.Column<decimal>(nullable: false),
                    ProjectBudgetTrackerId = table.Column<string>(nullable: true),
                    ProjectId = table.Column<string>(nullable: true),
                    ProjectStage = table.Column<string>(nullable: true),
                    ProjectStageRefid = table.Column<string>(nullable: true),
                    ResourceId = table.Column<string>(nullable: true),
                    ResourceName = table.Column<string>(nullable: true),
                    ResourcePerCost = table.Column<string>(nullable: true),
                    ResourceRateApr = table.Column<decimal>(nullable: true),
                    ResourceRateAug = table.Column<decimal>(nullable: true),
                    ResourceRateDec = table.Column<decimal>(nullable: true),
                    ResourceRateFeb = table.Column<decimal>(nullable: true),
                    ResourceRateJan = table.Column<decimal>(nullable: true),
                    ResourceRateJul = table.Column<decimal>(nullable: true),
                    ResourceRateJun = table.Column<decimal>(nullable: true),
                    ResourceRateMar = table.Column<decimal>(nullable: true),
                    ResourceRateMay = table.Column<decimal>(nullable: true),
                    ResourceRateNov = table.Column<decimal>(nullable: true),
                    ResourceRateOct = table.Column<decimal>(nullable: true),
                    ResourceRateSep = table.Column<decimal>(nullable: true),
                    SepAmount = table.Column<decimal>(nullable: true),
                    SepEndDate = table.Column<DateTime>(nullable: true),
                    SepForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    SepStartDate = table.Column<DateTime>(nullable: true),
                    SupplierId = table.Column<string>(nullable: true),
                    TaskEarliestStartDate = table.Column<DateTime>(nullable: true),
                    TaskLatestndEDate = table.Column<DateTime>(nullable: true),
                    TextTaskCostDescription = table.Column<string>(nullable: true),
                    TotalAmount = table.Column<decimal>(nullable: true),
                    TotalForecastPreciseDuration = table.Column<decimal>(nullable: true),
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
                    VendorId = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectBudget", x => x.ProjectBudgetId);
                    table.ForeignKey(
                        name: "FK_ProjectBudget_ProjectBudgetTracker_ProjectBudgetTrackerId",
                        column: x => x.ProjectBudgetTrackerId,
                        principalTable: "ProjectBudgetTracker",
                        principalColumn: "ProjectBudgetTrackerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectBudget_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectBudget_Resources_CompanyId_ResourceId",
                        columns: x => new { x.CompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReconciledActuals_ProjectBudgetId",
                table: "ReconciledActuals",
                column: "ProjectBudgetId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectCurrentBudgetTrackerId",
                table: "Projects",
                column: "ProjectCurrentBudgetTrackerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBudget_ProjectBudgetTrackerId",
                table: "ProjectBudget",
                column: "ProjectBudgetTrackerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBudget_SupplierId",
                table: "ProjectBudget",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBudget_CompanyId_ResourceId",
                table: "ProjectBudget",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ProjectBudgetTracker_ProjectCurrentBudgetTrackerId",
                table: "Projects",
                column: "ProjectCurrentBudgetTrackerId",
                principalTable: "ProjectBudgetTracker",
                principalColumn: "ProjectBudgetTrackerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReconciledActuals_ProjectBudget_ProjectBudgetId",
                table: "ReconciledActuals",
                column: "ProjectBudgetId",
                principalTable: "ProjectBudget",
                principalColumn: "ProjectBudgetId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ProjectBudgetTracker_ProjectCurrentBudgetTrackerId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_ReconciledActuals_ProjectBudget_ProjectBudgetId",
                table: "ReconciledActuals");

            migrationBuilder.DropTable(
                name: "ProjectBudget");

            migrationBuilder.DropTable(
                name: "ProjectBudgetTracker");

            migrationBuilder.DropIndex(
                name: "IX_ReconciledActuals_ProjectBudgetId",
                table: "ReconciledActuals");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ProjectCurrentBudgetTrackerId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectBudgetId",
                table: "ReconciledActuals");

            migrationBuilder.DropColumn(
                name: "BudgetCurrentStatus",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CurrentBudgetBadgeVersion",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TaskEarliestStartDate",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "TaskLatestndEDate",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "TotalForecastAmount",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "LogoId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "LogoName",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "RecurringReportingDay",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "ProjectCurrentBudgetTrackerId",
                table: "Projects",
                newName: "ProjectBudget");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectBudget",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BudgetEndDate",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BudgetStartDate",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "GrandTotalBudgetApproved",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "GrandTotalBudgetSubmitted",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectBudgetAtComplete",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProjectEndDate",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProjectStartDate",
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
    }
}
