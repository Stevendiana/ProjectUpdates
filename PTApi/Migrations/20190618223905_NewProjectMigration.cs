using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class NewProjectMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Domains_BUPermitted_BUPermittedResourceId_BUPermittedCompanyId_BUPermittedBusinessUnitId",
                table: "Domains");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_DomainsPermitted_DomainPermittedResourceId_DomainPermittedCompanyId_DomainPermittedDomainId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_Programmes_PortfoliosPermitted_PortfolioPermittedResourceId_PPCompanyId_PPPortfolioId",
                table: "Programmes");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_PortfoliosPermitted_PortfolioPermittedResourceId_PortfolioPermittedCompanyId_PortfolioPermittedPortfolioId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectsPermitted_ProjectsPermitted_PPResourceId_PPProjectId_PPCompanyId_ProjectPermittedUserId",
                table: "ProjectsPermitted");

            migrationBuilder.DropTable(
                name: "BusinessUnitsPermitted");

            migrationBuilder.DropTable(
                name: "DomainsPermitted");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "PortfoliosPermitted");

            migrationBuilder.DropTable(
                name: "ProgrammesPermitted");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_ReconciledActuals_ActualId_CompanyId_ForecastTaskId_ProjectId",
                table: "ReconciledActuals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReconciledActuals",
                table: "ReconciledActuals");

            migrationBuilder.DropIndex(
                name: "IX_Projects_PortfolioPermittedResourceId_PortfolioPermittedCompanyId_PortfolioPermittedPortfolioId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Programmes_PortfolioPermittedResourceId_PortfolioPermittedCompanyId_PortfolioPermittedPortfolioId",
                table: "Programmes");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_DomainPermittedResourceId_DomainPermittedCompanyId_DomainPermittedDomainId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Domains_BusinessUnitPermittedResourceId_BusinessUnitPermittedCompanyId_BusinessUnitPermittedBusinessUnitId",
                table: "Domains");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "PortfolioPermittedCompanyId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PortfolioPermittedPortfolioId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PortfolioPermittedResourceId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PortfolioPermittedCompanyId",
                table: "Programmes");

            migrationBuilder.DropColumn(
                name: "PortfolioPermittedPortfolioId",
                table: "Programmes");

            migrationBuilder.DropColumn(
                name: "PortfolioPermittedResourceId",
                table: "Programmes");

            migrationBuilder.DropColumn(
                name: "DomainPermittedCompanyId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "DomainPermittedDomainId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "DomainPermittedResourceId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "BaselinePeriod",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "ForecastPeriodType",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "Open",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "Parent",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "Progress",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "ProjectStage",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "ProjectStageRefid",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "TextTaskCostDescription",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "BusinessUnitPermittedBusinessUnitId",
                table: "Domains");

            migrationBuilder.DropColumn(
                name: "BusinessUnitPermittedCompanyId",
                table: "Domains");

            migrationBuilder.DropColumn(
                name: "BusinessUnitPermittedResourceId",
                table: "Domains");

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayWednesdayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayWednesdayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayTuesdayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayTuesdayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayThursdayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayThursdayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDaySundayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDaySundayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDaySaturdayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDaySaturdayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayMondayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayMondayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayFridayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayFridayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeWednesdayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeWednesdayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeTuesdayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeTuesdayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeThursdayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeThursdayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeSundayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeSundayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeSaturdayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeSaturdayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeMondayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeMondayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeFridayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeFridayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ProjectsPermitted",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectManagementRankId",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OriginalResourceCreatedId",
                table: "Notifications",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastResourceModifiedId",
                table: "Notifications",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectId",
                table: "ForecastTasks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyId",
                table: "ForecastTasks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "FebForecastIrrecoverableVat",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "FebForecastNet",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "FebForecastRecoverableVat",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "FebForecastVat",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentTaskId",
                table: "ForecastTasks",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "VAT",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Resources_ResourceId",
                table: "Resources",
                column: "ResourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReconciledActuals",
                table: "ReconciledActuals",
                columns: new[] { "ActualId", "ForecastTaskId" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ProjectsPermitted_Id_ProjectId_UserId",
                table: "ProjectsPermitted",
                columns: new[] { "Id", "ProjectId", "UserId" });

            migrationBuilder.CreateTable(
                name: "ParentTasks",
                columns: table => new
                {
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedFirstName = table.Column<string>(nullable: true),
                    UserCreatedLastName = table.Column<string>(nullable: true),
                    UserCreatedAvatar = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true),
                    UserModifiedFirstName = table.Column<string>(nullable: true),
                    UserModifiedLastName = table.Column<string>(nullable: true),
                    UserModifiedAvartar = table.Column<string>(nullable: true),
                    ParentTaskId = table.Column<string>(nullable: false),
                    ProjectId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    TextTaskCostDescription = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: true),
                    Progress = table.Column<decimal>(nullable: false),
                    Open = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentTasks", x => x.ParentTaskId);
                    table.ForeignKey(
                        name: "FK_ParentTasks_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParentTasks_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectManagementRankId",
                table: "Projects",
                column: "ProjectManagementRankId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ForecastTasks_ParentTaskId",
                table: "ForecastTasks",
                column: "ParentTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_ForecastTasks_ProjectId",
                table: "ForecastTasks",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ParentTasks_CompanyId",
                table: "ParentTasks",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentTasks_ProjectId",
                table: "ParentTasks",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ForecastTasks_Companies_CompanyId",
                table: "ForecastTasks",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ForecastTasks_ParentTasks_ParentTaskId",
                table: "ForecastTasks",
                column: "ParentTaskId",
                principalTable: "ParentTasks",
                principalColumn: "ParentTaskId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ForecastTasks_Projects_ProjectId",
                table: "ForecastTasks",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectsPermitted_ProjectsPermitted_ProjectPermittedResourceId_ProjectPermittedProjectId_ProjectPermittedCompanyId_ProjectPe~",
                table: "ProjectsPermitted",
                columns: new[] { "ProjectPermittedResourceId", "ProjectPermittedProjectId", "ProjectPermittedCompanyId", "ProjectPermittedUserId" },
                principalTable: "ProjectsPermitted",
                principalColumns: new[] { "ResourceId", "ProjectId", "CompanyId", "UserId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_ForecastTasks_Companies_CompanyId",
                table: "ForecastTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_ForecastTasks_ParentTasks_ParentTaskId",
                table: "ForecastTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_ForecastTasks_Projects_ProjectId",
                table: "ForecastTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectsPermitted_ProjectsPermitted_ProjectPermittedResourceId_ProjectPermittedProjectId_ProjectPermittedCompanyId_ProjectPe~",
                table: "ProjectsPermitted");

            migrationBuilder.DropTable(
                name: "ParentTasks");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Resources_ResourceId",
                table: "Resources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReconciledActuals",
                table: "ReconciledActuals");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_ProjectsPermitted_Id_ProjectId_UserId",
                table: "ProjectsPermitted");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ProjectManagementRankId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_ForecastTasks_ParentTaskId",
                table: "ForecastTasks");

            migrationBuilder.DropIndex(
                name: "IX_ForecastTasks_ProjectId",
                table: "ForecastTasks");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "FebForecastIrrecoverableVat",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "FebForecastNet",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "FebForecastRecoverableVat",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "FebForecastVat",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "ParentTaskId",
                table: "ForecastTasks");

            migrationBuilder.DropColumn(
                name: "VAT",
                table: "ForecastTasks");

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayWednesdayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayWednesdayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayTuesdayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayTuesdayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayThursdayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayThursdayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDaySundayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDaySundayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDaySaturdayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDaySaturdayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayMondayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayMondayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayFridayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardDayFridayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeWednesdayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeWednesdayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeTuesdayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeTuesdayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeThursdayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeThursdayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeSundayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeSundayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeSaturdayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeSaturdayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeMondayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeMondayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeFridayNonBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "OvertimeFridayBillableHours",
                table: "ResourceWorkTimesheets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ProjectsPermitted",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProjectManagementRankId",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "PortfolioPermittedCompanyId",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PortfolioPermittedPortfolioId",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PortfolioPermittedResourceId",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PortfolioPermittedCompanyId",
                table: "Programmes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PortfolioPermittedPortfolioId",
                table: "Programmes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PortfolioPermittedResourceId",
                table: "Programmes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DomainPermittedCompanyId",
                table: "Portfolios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DomainPermittedDomainId",
                table: "Portfolios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DomainPermittedResourceId",
                table: "Portfolios",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OriginalResourceCreatedId",
                table: "Notifications",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LastResourceModifiedId",
                table: "Notifications",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProjectId",
                table: "ForecastTasks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CompanyId",
                table: "ForecastTasks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "BaselinePeriod",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "ForecastPeriodType",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Month",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Open",
                table: "ForecastTasks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Parent",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Progress",
                table: "ForecastTasks",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ProjectStage",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectStageRefid",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextTaskCostDescription",
                table: "ForecastTasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessUnitPermittedBusinessUnitId",
                table: "Domains",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessUnitPermittedCompanyId",
                table: "Domains",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessUnitPermittedResourceId",
                table: "Domains",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ReconciledActuals_ActualId_CompanyId_ForecastTaskId_ProjectId",
                table: "ReconciledActuals",
                columns: new[] { "ActualId", "CompanyId", "ForecastTaskId", "ProjectId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReconciledActuals",
                table: "ReconciledActuals",
                columns: new[] { "ActualId", "ProjectId", "CompanyId", "ForecastTaskId" });

            migrationBuilder.CreateTable(
                name: "BusinessUnitsPermitted",
                columns: table => new
                {
                    ResourceId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    BusinessUnitId = table.Column<string>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true),
                    BusinessUnitPermittedBusinessUnitId = table.Column<string>(nullable: true),
                    BusinessUnitPermittedCompanyId = table.Column<string>(nullable: true),
                    BusinessUnitPermittedResourceId = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    NodeId = table.Column<string>(nullable: true),
                    UserCreatedAvatar = table.Column<string>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedFirstName = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedLastName = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedAvartar = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedFirstName = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedLastName = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUnitsPermitted", x => new { x.ResourceId, x.CompanyId, x.BusinessUnitId });
                    table.ForeignKey(
                        name: "FK_BusinessUnitsPermitted_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessUnitsPermitted_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessUnitsPermitted_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessUnitsPermitted_Resources_CompanyId_ResourceId",
                        columns: x => new { x.CompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessUnitsPermitted_BusinessUnitsPermitted_BusinessUnitPermittedResourceId_BusinessUnitPermittedCompanyId_BusinessUnitPermittedBusinessUnitId",
                        columns: x => new { x.BusinessUnitPermittedResourceId, x.BusinessUnitPermittedCompanyId, x.BusinessUnitPermittedBusinessUnitId },
                        principalTable: "BusinessUnitsPermitted",
                        principalColumns: new[] { "ResourceId", "CompanyId", "BusinessUnitId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DomainsPermitted",
                columns: table => new
                {
                    ResourceId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    DomainId = table.Column<string>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    NodeId = table.Column<string>(nullable: true),
                    UserCreatedAvatar = table.Column<string>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedFirstName = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedLastName = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedAvartar = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedFirstName = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedLastName = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomainsPermitted", x => new { x.ResourceId, x.CompanyId, x.DomainId });
                    table.ForeignKey(
                        name: "FK_DomainsPermitted_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DomainsPermitted_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DomainsPermitted_Domains_DomainId",
                        column: x => x.DomainId,
                        principalTable: "Domains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DomainsPermitted_Resources_CompanyId_ResourceId",
                        columns: x => new { x.CompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    UserCreatedAvatar = table.Column<string>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedFirstName = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedLastName = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedAvartar = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedFirstName = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedLastName = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PortfoliosPermitted",
                columns: table => new
                {
                    ResourceId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    PortfolioId = table.Column<string>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    NodeId = table.Column<string>(nullable: true),
                    UserCreatedAvatar = table.Column<string>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedFirstName = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedLastName = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedAvartar = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedFirstName = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedLastName = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfoliosPermitted", x => new { x.ResourceId, x.CompanyId, x.PortfolioId });
                    table.ForeignKey(
                        name: "FK_PortfoliosPermitted_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PortfoliosPermitted_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PortfoliosPermitted_Portfolios_PortfolioId",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PortfoliosPermitted_Resources_CompanyId_ResourceId",
                        columns: x => new { x.CompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammesPermitted",
                columns: table => new
                {
                    ResourceId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    ProgrammeId = table.Column<string>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    Id = table.Column<string>(nullable: true),
                    NodeId = table.Column<string>(nullable: true),
                    ProgrammePermittedCompanyId = table.Column<string>(nullable: true),
                    ProgrammePermittedProgrammeId = table.Column<string>(nullable: true),
                    ProgrammePermittedResourceId = table.Column<string>(nullable: true),
                    UserCreatedAvatar = table.Column<string>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedFirstName = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedLastName = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedAvartar = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedFirstName = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedLastName = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammesPermitted", x => new { x.ResourceId, x.CompanyId, x.ProgrammeId });
                    table.ForeignKey(
                        name: "FK_ProgrammesPermitted_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgrammesPermitted_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgrammesPermitted_Programmes_ProgrammeId",
                        column: x => x.ProgrammeId,
                        principalTable: "Programmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgrammesPermitted_Resources_CompanyId_ResourceId",
                        columns: x => new { x.CompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgrammesPermitted_ProgrammesPermitted_ProgrammePermittedResourceId_ProgrammePermittedCompanyId_ProgrammePermittedProgrammeId",
                        columns: x => new { x.ProgrammePermittedResourceId, x.ProgrammePermittedCompanyId, x.ProgrammePermittedProgrammeId },
                        principalTable: "ProgrammesPermitted",
                        principalColumns: new[] { "ResourceId", "CompanyId", "ProgrammeId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_PortfolioPermittedResourceId_PortfolioPermittedCompanyId_PortfolioPermittedPortfolioId",
                table: "Projects",
                columns: new[] { "PortfolioPermittedResourceId", "PortfolioPermittedCompanyId", "PortfolioPermittedPortfolioId" });

            migrationBuilder.CreateIndex(
                name: "IX_Programmes_PortfolioPermittedResourceId_PortfolioPermittedCompanyId_PortfolioPermittedPortfolioId",
                table: "Programmes",
                columns: new[] { "PortfolioPermittedResourceId", "PortfolioPermittedCompanyId", "PortfolioPermittedPortfolioId" });

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_DomainPermittedResourceId_DomainPermittedCompanyId_DomainPermittedDomainId",
                table: "Portfolios",
                columns: new[] { "DomainPermittedResourceId", "DomainPermittedCompanyId", "DomainPermittedDomainId" });

            migrationBuilder.CreateIndex(
                name: "IX_Domains_BusinessUnitPermittedResourceId_BusinessUnitPermittedCompanyId_BusinessUnitPermittedBusinessUnitId",
                table: "Domains",
                columns: new[] { "BusinessUnitPermittedResourceId", "BusinessUnitPermittedCompanyId", "BusinessUnitPermittedBusinessUnitId" });

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnitsPermitted_AppUserId",
                table: "BusinessUnitsPermitted",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnitsPermitted_BusinessUnitId",
                table: "BusinessUnitsPermitted",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnitsPermitted_CompanyId_ResourceId",
                table: "BusinessUnitsPermitted",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnitsPermitted_BusinessUnitPermittedResourceId_BusinessUnitPermittedCompanyId_BusinessUnitPermittedBusinessUnitId",
                table: "BusinessUnitsPermitted",
                columns: new[] { "BusinessUnitPermittedResourceId", "BusinessUnitPermittedCompanyId", "BusinessUnitPermittedBusinessUnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_DomainsPermitted_AppUserId",
                table: "DomainsPermitted",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DomainsPermitted_DomainId",
                table: "DomainsPermitted",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_DomainsPermitted_CompanyId_ResourceId",
                table: "DomainsPermitted",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_PortfoliosPermitted_AppUserId",
                table: "PortfoliosPermitted",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PortfoliosPermitted_PortfolioId",
                table: "PortfoliosPermitted",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_PortfoliosPermitted_CompanyId_ResourceId",
                table: "PortfoliosPermitted",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammesPermitted_AppUserId",
                table: "ProgrammesPermitted",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammesPermitted_ProgrammeId",
                table: "ProgrammesPermitted",
                column: "ProgrammeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammesPermitted_CompanyId_ResourceId",
                table: "ProgrammesPermitted",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammesPermitted_ProgrammePermittedResourceId_ProgrammePermittedCompanyId_ProgrammePermittedProgrammeId",
                table: "ProgrammesPermitted",
                columns: new[] { "ProgrammePermittedResourceId", "ProgrammePermittedCompanyId", "ProgrammePermittedProgrammeId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Domains_BUPermitted_BUPermittedResourceId_BUPermittedCompanyId_BUPermittedBusinessUnitId",
                table: "Domains",
                columns: new[] { "BusinessUnitPermittedResourceId", "BusinessUnitPermittedCompanyId", "BusinessUnitPermittedBusinessUnitId" },
                principalTable: "BusinessUnitsPermitted",
                principalColumns: new[] { "ResourceId", "CompanyId", "BusinessUnitId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_DomainsPermitted_DomainPermittedResourceId_DomainPermittedCompanyId_DomainPermittedDomainId",
                table: "Portfolios",
                columns: new[] { "DomainPermittedResourceId", "DomainPermittedCompanyId", "DomainPermittedDomainId" },
                principalTable: "DomainsPermitted",
                principalColumns: new[] { "ResourceId", "CompanyId", "DomainId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Programmes_PortfoliosPermitted_PortfolioPermittedResourceId_PPCompanyId_PPPortfolioId",
                table: "Programmes",
                columns: new[] { "PortfolioPermittedResourceId", "PortfolioPermittedCompanyId", "PortfolioPermittedPortfolioId" },
                principalTable: "PortfoliosPermitted",
                principalColumns: new[] { "ResourceId", "CompanyId", "PortfolioId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_PortfoliosPermitted_PortfolioPermittedResourceId_PortfolioPermittedCompanyId_PortfolioPermittedPortfolioId",
                table: "Projects",
                columns: new[] { "PortfolioPermittedResourceId", "PortfolioPermittedCompanyId", "PortfolioPermittedPortfolioId" },
                principalTable: "PortfoliosPermitted",
                principalColumns: new[] { "ResourceId", "CompanyId", "PortfolioId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectsPermitted_ProjectsPermitted_PPResourceId_PPProjectId_PPCompanyId_ProjectPermittedUserId",
                table: "ProjectsPermitted",
                columns: new[] { "ProjectPermittedResourceId", "ProjectPermittedProjectId", "ProjectPermittedCompanyId", "ProjectPermittedUserId" },
                principalTable: "ProjectsPermitted",
                principalColumns: new[] { "ResourceId", "ProjectId", "CompanyId", "UserId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
