using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class RefactoredEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessUnits_Resources_ResourceCompanyId_ResourceId",
                table: "BusinessUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_Domains_BusinessUnits_BusinessUnitId",
                table: "Domains");

            migrationBuilder.DropForeignKey(
                name: "FK_Domains_Resources_ResourceCompanyId_ResourceId",
                table: "Domains");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Resources_ResourceCompanyId_ResourceId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_Programmes_Resources_ResourceCompanyId_ResourceId",
                table: "Programmes");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Resources_ResourceCompanyId_ResourceId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceEffortSummaries_Projects_ProjectId",
                table: "ResourceEffortSummaries");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceEffortSummaries_Resources_CompanyId_ResourceId",
                table: "ResourceEffortSummaries");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Projects_ProjectId",
                table: "Resources");

            migrationBuilder.DropTable(
                name: "ProjectsPermitted");

            migrationBuilder.DropIndex(
                name: "IX_Resources_ProjectId",
                table: "Resources");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_ResourceHolidaysBooked_ResourceHolidayBookedId",
                table: "ResourceHolidaysBooked");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResourceEffortSummaries",
                table: "ResourceEffortSummaries");

            migrationBuilder.DropIndex(
                name: "IX_ResourceEffortSummaries_ProjectId",
                table: "ResourceEffortSummaries");

            migrationBuilder.DropIndex(
                name: "IX_ResourceEffortSummaries_CompanyId_ResourceId",
                table: "ResourceEffortSummaries");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ResourceCompanyId_ResourceId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Programmes_CompanyId",
                table: "Programmes");

            migrationBuilder.DropIndex(
                name: "IX_Programmes_ResourceCompanyId_ResourceId",
                table: "Programmes");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_CompanyId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_ResourceCompanyId_ResourceId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Platforms_CompanyId",
                table: "Platforms");

            migrationBuilder.DropIndex(
                name: "IX_Domains_BusinessUnitId",
                table: "Domains");

            migrationBuilder.DropIndex(
                name: "IX_Domains_CompanyId",
                table: "Domains");

            migrationBuilder.DropIndex(
                name: "IX_Domains_ResourceCompanyId_ResourceId",
                table: "Domains");

            migrationBuilder.DropIndex(
                name: "IX_BusinessUnits_CompanyId",
                table: "BusinessUnits");

            migrationBuilder.DropIndex(
                name: "IX_BusinessUnits_ResourceCompanyId_ResourceId",
                table: "BusinessUnits");

            migrationBuilder.DropColumn(
                name: "AppUserRole",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "BudgetCurrentStatus",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CurrentBudgetBadgeVersion",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "BaselinePeriod",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "ForecastPeriodType",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "Open",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "Parent",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "Progress",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "ProjectStage",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "ProjectStageRefid",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "TextTaskCostDescription",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "DeliveryDirector",
                table: "Programmes");

            migrationBuilder.DropColumn(
                name: "DeliveryManager",
                table: "Programmes");

            migrationBuilder.DropColumn(
                name: "NodeId",
                table: "Programmes");

            migrationBuilder.DropColumn(
                name: "HeadOfPortfolio",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "NodeId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "ResourceCompanyId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "BusinessUnitId",
                table: "Domains");

            migrationBuilder.DropColumn(
                name: "DivisionOrDomainName",
                table: "Domains");

            migrationBuilder.DropColumn(
                name: "HeadOfDomain",
                table: "Domains");

            migrationBuilder.DropColumn(
                name: "NodeId",
                table: "Domains");

            migrationBuilder.DropColumn(
                name: "HeadOfBusinessUnit",
                table: "BusinessUnits");

            migrationBuilder.DropColumn(
                name: "NodeId",
                table: "BusinessUnits");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Resources",
                newName: "ProjectsPermittedUserId");

            migrationBuilder.RenameColumn(
                name: "AddedBy",
                table: "Resources",
                newName: "ProjectsPermittedResourceId");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "ResourceEffortSummaries",
                newName: "ResourceId1");

            migrationBuilder.RenameColumn(
                name: "Sponsor",
                table: "Projects",
                newName: "SponsorResourceId");

            migrationBuilder.RenameColumn(
                name: "ResourceId",
                table: "Projects",
                newName: "SponsorId");

            migrationBuilder.RenameColumn(
                name: "ResourceCompanyId",
                table: "Projects",
                newName: "SponsorCompanyId");

            migrationBuilder.RenameColumn(
                name: "SepAmount",
                table: "ProjectBudget",
                newName: "VAT");

            migrationBuilder.RenameColumn(
                name: "OctAmount",
                table: "ProjectBudget",
                newName: "SepForecastAmount");

            migrationBuilder.RenameColumn(
                name: "NovAmount",
                table: "ProjectBudget",
                newName: "OctForecastAmount");

            migrationBuilder.RenameColumn(
                name: "MayAmount",
                table: "ProjectBudget",
                newName: "NovForecastAmount");

            migrationBuilder.RenameColumn(
                name: "MarAmount",
                table: "ProjectBudget",
                newName: "MayForecastAmount");

            migrationBuilder.RenameColumn(
                name: "JunAmount",
                table: "ProjectBudget",
                newName: "MarForecastAmount");

            migrationBuilder.RenameColumn(
                name: "JulAmount",
                table: "ProjectBudget",
                newName: "JunForecastAmount");

            migrationBuilder.RenameColumn(
                name: "JanAmount",
                table: "ProjectBudget",
                newName: "JulForecastAmount");

            migrationBuilder.RenameColumn(
                name: "FebAmount",
                table: "ProjectBudget",
                newName: "JanForecastAmount");

            migrationBuilder.RenameColumn(
                name: "AugAmount",
                table: "ProjectBudget",
                newName: "FebForecastVat");

            migrationBuilder.RenameColumn(
                name: "AprAmount",
                table: "ProjectBudget",
                newName: "FebForecastRecoverableVat");

            migrationBuilder.RenameColumn(
                name: "Sponsor",
                table: "Programmes",
                newName: "SponsorId");

            migrationBuilder.RenameColumn(
                name: "ResourceId",
                table: "Programmes",
                newName: "ProgrammeManagerId");

            migrationBuilder.RenameColumn(
                name: "ResourceCompanyId",
                table: "Programmes",
                newName: "DeliveryManagerId");

            migrationBuilder.RenameColumn(
                name: "ProgrammeManager",
                table: "Programmes",
                newName: "DeliveryDirectorId");

            migrationBuilder.RenameColumn(
                name: "ResourceId",
                table: "Portfolios",
                newName: "HeadOfPortfolioId");

            migrationBuilder.RenameColumn(
                name: "HeadOfPlatform",
                table: "Platforms",
                newName: "HeadOfPlatformId");

            migrationBuilder.RenameColumn(
                name: "ResourceId",
                table: "Domains",
                newName: "HeadOfDomainId");

            migrationBuilder.RenameColumn(
                name: "ResourceCompanyId",
                table: "Domains",
                newName: "DomainName");

            migrationBuilder.RenameColumn(
                name: "BusinessUnitName",
                table: "BusinessUnits",
                newName: "BusinessunitName");

            migrationBuilder.RenameColumn(
                name: "BusinessUnitCode",
                table: "BusinessUnits",
                newName: "BusinessunitCode");

            migrationBuilder.RenameColumn(
                name: "ResourceId",
                table: "BusinessUnits",
                newName: "HeadOfBusinessunitId");

            migrationBuilder.RenameColumn(
                name: "ResourceCompanyId",
                table: "BusinessUnits",
                newName: "DomainId");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectsPermittedResourceId",
                table: "Resources",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessUnitsPermittedBusinessUnitId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessUnitsPermittedCompanyId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessUnitsPermittedResourceId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessUnitsPermittedUserId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessunitsFollowingBusinessUnitId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessunitsFollowingCompanyId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessunitsFollowingResourceId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessunitsFollowingUserId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DomainsFollowingCompanyId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DomainsFollowingDomainId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DomainsFollowingResourceId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DomainsFollowingUserId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DomainsPermittedCompanyId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DomainsPermittedDomainId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DomainsPermittedResourceId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DomainsPermittedUserId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAppUser",
                table: "Resources",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PortfoliosFollowingCompanyId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PortfoliosFollowingPortfolioId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PortfoliosFollowingResourceId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PortfoliosFollowingUserId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PortfoliosPermittedCompanyId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PortfoliosPermittedPortfolioId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PortfoliosPermittedResourceId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PortfoliosPermittedUserId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgrammesFollowingCompanyId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgrammesFollowingProgrammeId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgrammesFollowingResourceId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgrammesFollowingUserId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgrammesPermittedCompanyId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgrammesPermittedProgrammeId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgrammesPermittedResourceId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgrammesPermittedUserId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectsFollowingCompanyId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectsFollowingProjectId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectsFollowingResourceId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectsFollowingUserId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectsPermittedCompanyId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectsPermittedProjectId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResourceCompanyId",
                table: "ResourceEffortSummaries",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "SponsorResourceId",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SponsorId",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastBudgetBatchVersion",
                table: "Projects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "ProjectBudgetTracker",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectId",
                table: "ProjectBudget",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ForecastTaskId",
                table: "ProjectBudget",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyId",
                table: "ProjectBudget",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AprForecastAmount",
                table: "ProjectBudget",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AugForecastAmount",
                table: "ProjectBudget",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DecForecastAmount",
                table: "ProjectBudget",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "FebForecastAmount",
                table: "ProjectBudget",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "FebForecastIrrecoverableVat",
                table: "ProjectBudget",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "FebForecastNet",
                table: "ProjectBudget",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentTaskId",
                table: "ProjectBudget",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "SponsorId",
                table: "Programmes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryDirectorId",
                table: "Programmes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessunitId",
                table: "Programmes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DomainId",
                table: "Programmes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "DomainId",
                table: "Portfolios",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessunitId",
                table: "Portfolios",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PortfolioEndDate",
                table: "Portfolios",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PortfolioStartDate",
                table: "Portfolios",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HeadOfPlatformId",
                table: "Platforms",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DomainName",
                table: "Domains",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyCurrencyId",
                table: "Companies",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "IrrecoverableVATPercentage",
                table: "Companies",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "UseRateCard",
                table: "Companies",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AppUserRole",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDisabled",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedAvatar",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedEmail",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedFirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedLastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedResourceId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedAvartar",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedEmail",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedFirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedLastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModifiedResourceId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ResourceHolidaysBooked_ResourceHolidayBookedId_ResourceId_TimesheetCalendarTsId",
                table: "ResourceHolidaysBooked",
                columns: new[] { "ResourceHolidayBookedId", "ResourceId", "TimesheetCalendarTsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResourceEffortSummaries",
                table: "ResourceEffortSummaries",
                columns: new[] { "ResourceId", "CompanyId" });

            migrationBuilder.CreateTable(
                name: "BusinessunitsIamFollowing",
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
                    UserId = table.Column<string>(nullable: false),
                    ResourceId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    BusinessUnitId = table.Column<string>(nullable: false),
                    Following = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessunitsIamFollowing", x => new { x.ResourceId, x.BusinessUnitId, x.CompanyId, x.UserId });
                    table.UniqueConstraint("AK_BusinessunitsIamFollowing_BusinessUnitId_CompanyId_ResourceId_UserId", x => new { x.BusinessUnitId, x.CompanyId, x.ResourceId, x.UserId });
                    table.ForeignKey(
                        name: "FK_BusinessunitsIamFollowing_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessunitsIamFollowing_Resources_CompanyId_ResourceId",
                        columns: x => new { x.CompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BusinessUnitsPermitted",
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
                    UserId = table.Column<string>(nullable: false),
                    ResourceId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    BusinessUnitId = table.Column<string>(nullable: false),
                    CanEdit = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUnitsPermitted", x => new { x.UserId, x.ResourceId, x.CompanyId, x.BusinessUnitId });
                    table.UniqueConstraint("AK_BusinessUnitsPermitted_BusinessUnitId_CompanyId_ResourceId_UserId", x => new { x.BusinessUnitId, x.CompanyId, x.ResourceId, x.UserId });
                    table.ForeignKey(
                        name: "FK_BusinessUnitsPermitted_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessUnitsPermitted_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessUnitsPermitted_Resources_CompanyId_ResourceId",
                        columns: x => new { x.CompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DomainsIamFollowing",
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
                    UserId = table.Column<string>(nullable: false),
                    ResourceId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    DomainId = table.Column<string>(nullable: false),
                    Following = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomainsIamFollowing", x => new { x.ResourceId, x.DomainId, x.CompanyId, x.UserId });
                    table.UniqueConstraint("AK_DomainsIamFollowing_CompanyId_DomainId_ResourceId_UserId", x => new { x.CompanyId, x.DomainId, x.ResourceId, x.UserId });
                    table.ForeignKey(
                        name: "FK_DomainsIamFollowing_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DomainsIamFollowing_Resources_CompanyId_ResourceId",
                        columns: x => new { x.CompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DomainsPermitted",
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
                    UserId = table.Column<string>(nullable: false),
                    ResourceId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    DomainId = table.Column<string>(nullable: false),
                    CanEdit = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomainsPermitted", x => new { x.UserId, x.ResourceId, x.CompanyId, x.DomainId });
                    table.UniqueConstraint("AK_DomainsPermitted_CompanyId_DomainId_ResourceId_UserId", x => new { x.CompanyId, x.DomainId, x.ResourceId, x.UserId });
                    table.ForeignKey(
                        name: "FK_DomainsPermitted_Domains_DomainId",
                        column: x => x.DomainId,
                        principalTable: "Domains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DomainsPermitted_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                name: "PortfoliosIamFollowing",
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
                    UserId = table.Column<string>(nullable: false),
                    ResourceId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    PortfolioId = table.Column<string>(nullable: false),
                    Following = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfoliosIamFollowing", x => new { x.ResourceId, x.PortfolioId, x.CompanyId, x.UserId });
                    table.UniqueConstraint("AK_PortfoliosIamFollowing_CompanyId_PortfolioId_ResourceId_UserId", x => new { x.CompanyId, x.PortfolioId, x.ResourceId, x.UserId });
                    table.ForeignKey(
                        name: "FK_PortfoliosIamFollowing_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PortfoliosIamFollowing_Resources_CompanyId_ResourceId",
                        columns: x => new { x.CompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PortfoliosPermitted",
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
                    UserId = table.Column<string>(nullable: false),
                    ResourceId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    PortfolioId = table.Column<string>(nullable: false),
                    CanEdit = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfoliosPermitted", x => new { x.UserId, x.ResourceId, x.CompanyId, x.PortfolioId });
                    table.UniqueConstraint("AK_PortfoliosPermitted_CompanyId_PortfolioId_ResourceId_UserId", x => new { x.CompanyId, x.PortfolioId, x.ResourceId, x.UserId });
                    table.ForeignKey(
                        name: "FK_PortfoliosPermitted_Portfolios_PortfolioId",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PortfoliosPermitted_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                name: "ProgrammesIamFollowing",
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
                    UserId = table.Column<string>(nullable: false),
                    ResourceId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    ProgrammeId = table.Column<string>(nullable: false),
                    Following = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammesIamFollowing", x => new { x.ResourceId, x.ProgrammeId, x.CompanyId, x.UserId });
                    table.UniqueConstraint("AK_ProgrammesIamFollowing_CompanyId_ProgrammeId_ResourceId_UserId", x => new { x.CompanyId, x.ProgrammeId, x.ResourceId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ProgrammesIamFollowing_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgrammesIamFollowing_Resources_CompanyId_ResourceId",
                        columns: x => new { x.CompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammesPermitted",
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
                    UserId = table.Column<string>(nullable: false),
                    ResourceId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    ProgrammeId = table.Column<string>(nullable: false),
                    CanEdit = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammesPermitted", x => new { x.UserId, x.ResourceId, x.CompanyId, x.ProgrammeId });
                    table.UniqueConstraint("AK_ProgrammesPermitted_CompanyId_ProgrammeId_ResourceId_UserId", x => new { x.CompanyId, x.ProgrammeId, x.ResourceId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ProgrammesPermitted_Programmes_ProgrammeId",
                        column: x => x.ProgrammeId,
                        principalTable: "Programmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgrammesPermitted_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgrammesPermitted_Resources_CompanyId_ResourceId",
                        columns: x => new { x.CompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectsIamFollowing",
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
                    UserId = table.Column<string>(nullable: false),
                    ResourceId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    ProjectId = table.Column<string>(nullable: false),
                    Following = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsIamFollowing", x => new { x.ResourceId, x.ProjectId, x.CompanyId, x.UserId });
                    table.UniqueConstraint("AK_ProjectsIamFollowing_CompanyId_ProjectId_ResourceId_UserId", x => new { x.CompanyId, x.ProjectId, x.ResourceId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ProjectsIamFollowing_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectsIamFollowing_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectsIamFollowing_Resources_CompanyId_ResourceId",
                        columns: x => new { x.CompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectsIamPermitted",
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
                    UserId = table.Column<string>(nullable: false),
                    ResourceId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    ProjectId = table.Column<string>(nullable: false),
                    CanEdit = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsIamPermitted", x => new { x.ResourceId, x.ProjectId, x.CompanyId, x.UserId });
                    table.UniqueConstraint("AK_ProjectsIamPermitted_CompanyId_ProjectId_ResourceId_UserId", x => new { x.CompanyId, x.ProjectId, x.ResourceId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ProjectsIamPermitted_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectsIamPermitted_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectsIamPermitted_Resources_CompanyId_ResourceId",
                        columns: x => new { x.CompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResourceUtilizationSummaries",
                columns: table => new
                {
                    ResourceUtilizationSummaryId = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    CompanyId = table.Column<string>(nullable: true),
                    ResourceId = table.Column<string>(nullable: true),
                    JanResourceUtilizationInDays = table.Column<decimal>(nullable: true),
                    FebResourceUtilizationInDays = table.Column<decimal>(nullable: true),
                    MarResourceUtilizationInDays = table.Column<decimal>(nullable: true),
                    AprResourceUtilizationInDays = table.Column<decimal>(nullable: true),
                    MayResourceUtilizationInDays = table.Column<decimal>(nullable: true),
                    JunResourceUtilizationInDays = table.Column<decimal>(nullable: true),
                    JulResourceUtilizationInDays = table.Column<decimal>(nullable: true),
                    AugResourceUtilizationInDays = table.Column<decimal>(nullable: true),
                    SepResourceUtilizationInDays = table.Column<decimal>(nullable: true),
                    OctResourceUtilizationInDays = table.Column<decimal>(nullable: true),
                    NovResourceUtilizationInDays = table.Column<decimal>(nullable: true),
                    DecResourceUtilizationInDays = table.Column<decimal>(nullable: true),
                    JanAvailabilityBeforeHolidaysInDays = table.Column<decimal>(nullable: true),
                    FebAvailabilityBeforeHolidaysInDays = table.Column<decimal>(nullable: true),
                    MarAvailabilityBeforeHolidaysInDays = table.Column<decimal>(nullable: true),
                    AprAvailabilityBeforeHolidaysInDays = table.Column<decimal>(nullable: true),
                    MayAvailabilityBeforeHolidaysInDays = table.Column<decimal>(nullable: true),
                    JunAvailabilityBeforeHolidaysInDays = table.Column<decimal>(nullable: true),
                    JulAvailabilityBeforeHolidaysInDays = table.Column<decimal>(nullable: true),
                    AugAvailabilityBeforeHolidaysInDays = table.Column<decimal>(nullable: true),
                    SepAvailabilityBeforeHolidaysInDays = table.Column<decimal>(nullable: true),
                    OctAvailabilityBeforeHolidaysInDays = table.Column<decimal>(nullable: true),
                    NovAvailabilityBeforeHolidaysInDays = table.Column<decimal>(nullable: true),
                    DecAvailabilityBeforeHolidaysInDays = table.Column<decimal>(nullable: true),
                    JanTotalHolidays = table.Column<decimal>(nullable: true),
                    FebTotalHolidays = table.Column<decimal>(nullable: true),
                    MarTotalHolidays = table.Column<decimal>(nullable: true),
                    AprTotalHolidays = table.Column<decimal>(nullable: true),
                    MayTotalHolidays = table.Column<decimal>(nullable: true),
                    JunTotalHolidays = table.Column<decimal>(nullable: true),
                    JulTotalHolidays = table.Column<decimal>(nullable: true),
                    AugTotalHolidays = table.Column<decimal>(nullable: true),
                    SepTotalHolidays = table.Column<decimal>(nullable: true),
                    OctTotalHolidays = table.Column<decimal>(nullable: true),
                    NovTotalHolidays = table.Column<decimal>(nullable: true),
                    DecTotalHolidays = table.Column<decimal>(nullable: true),
                    JanAvailabilityAfterHolidaysInDays = table.Column<decimal>(nullable: true),
                    FebAvailabilityAfterHolidaysInDays = table.Column<decimal>(nullable: true),
                    MarAvailabilityAfterHolidaysInDays = table.Column<decimal>(nullable: true),
                    AprAvailabilityAfterHolidaysInDays = table.Column<decimal>(nullable: true),
                    MayAvailabilityAfterHolidaysInDays = table.Column<decimal>(nullable: true),
                    JunAvailabilityAfterHolidaysInDays = table.Column<decimal>(nullable: true),
                    JulAvailabilityAfterHolidaysInDays = table.Column<decimal>(nullable: true),
                    AugAvailabilityAfterHolidaysInDays = table.Column<decimal>(nullable: true),
                    SepAvailabilityAfterHolidaysInDays = table.Column<decimal>(nullable: true),
                    OctAvailabilityAfterHolidaysInDays = table.Column<decimal>(nullable: true),
                    NovAvailabilityAfterHolidaysInDays = table.Column<decimal>(nullable: true),
                    DecAvailabilityAfterHolidaysInDays = table.Column<decimal>(nullable: true),
                    JanUtilizationPercentage = table.Column<decimal>(nullable: true),
                    FebUtilizationPercentage = table.Column<decimal>(nullable: true),
                    MarUtilizationPercentage = table.Column<decimal>(nullable: true),
                    AprUtilizationPercentage = table.Column<decimal>(nullable: true),
                    MayUtilizationPercentage = table.Column<decimal>(nullable: true),
                    JunUtilizationPercentage = table.Column<decimal>(nullable: true),
                    JulUtilizationPercentage = table.Column<decimal>(nullable: true),
                    AugUtilizationPercentage = table.Column<decimal>(nullable: true),
                    SepUtilizationPercentage = table.Column<decimal>(nullable: true),
                    OctUtilizationPercentage = table.Column<decimal>(nullable: true),
                    NovUtilizationPercentage = table.Column<decimal>(nullable: true),
                    DecUtilizationPercentage = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceUtilizationSummaries", x => x.ResourceUtilizationSummaryId);
                    table.ForeignKey(
                        name: "FK_ResourceUtilizationSummaries_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResourceUtilizationSummaries_Resources_CompanyId_ResourceId",
                        columns: x => new { x.CompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Resources_BusinessUnitsPermittedUserId_BusinessUnitsPermittedResourceId_BusinessUnitsPermittedCompanyId_BusinessUnitsPermitt~",
                table: "Resources",
                columns: new[] { "BusinessUnitsPermittedUserId", "BusinessUnitsPermittedResourceId", "BusinessUnitsPermittedCompanyId", "BusinessUnitsPermittedBusinessUnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_Resources_BusinessunitsFollowingResourceId_BusinessunitsFollowingBusinessUnitId_BusinessunitsFollowingCompanyId_Businessunit~",
                table: "Resources",
                columns: new[] { "BusinessunitsFollowingResourceId", "BusinessunitsFollowingBusinessUnitId", "BusinessunitsFollowingCompanyId", "BusinessunitsFollowingUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Resources_DomainsFollowingResourceId_DomainsFollowingDomainId_DomainsFollowingCompanyId_DomainsFollowingUserId",
                table: "Resources",
                columns: new[] { "DomainsFollowingResourceId", "DomainsFollowingDomainId", "DomainsFollowingCompanyId", "DomainsFollowingUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Resources_DomainsPermittedUserId_DomainsPermittedResourceId_DomainsPermittedCompanyId_DomainsPermittedDomainId",
                table: "Resources",
                columns: new[] { "DomainsPermittedUserId", "DomainsPermittedResourceId", "DomainsPermittedCompanyId", "DomainsPermittedDomainId" });

            migrationBuilder.CreateIndex(
                name: "IX_Resources_PortfoliosFollowingResourceId_PortfoliosFollowingPortfolioId_PortfoliosFollowingCompanyId_PortfoliosFollowingUserId",
                table: "Resources",
                columns: new[] { "PortfoliosFollowingResourceId", "PortfoliosFollowingPortfolioId", "PortfoliosFollowingCompanyId", "PortfoliosFollowingUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Resources_PortfoliosPermittedUserId_PortfoliosPermittedResourceId_PortfoliosPermittedCompanyId_PortfoliosPermittedPortfolioId",
                table: "Resources",
                columns: new[] { "PortfoliosPermittedUserId", "PortfoliosPermittedResourceId", "PortfoliosPermittedCompanyId", "PortfoliosPermittedPortfolioId" });

            migrationBuilder.CreateIndex(
                name: "IX_Resources_ProgrammesFollowingResourceId_ProgrammesFollowingProgrammeId_ProgrammesFollowingCompanyId_ProgrammesFollowingUserId",
                table: "Resources",
                columns: new[] { "ProgrammesFollowingResourceId", "ProgrammesFollowingProgrammeId", "ProgrammesFollowingCompanyId", "ProgrammesFollowingUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Resources_ProgrammesPermittedUserId_ProgrammesPermittedResourceId_ProgrammesPermittedCompanyId_ProgrammesPermittedProgrammeId",
                table: "Resources",
                columns: new[] { "ProgrammesPermittedUserId", "ProgrammesPermittedResourceId", "ProgrammesPermittedCompanyId", "ProgrammesPermittedProgrammeId" });

            migrationBuilder.CreateIndex(
                name: "IX_Resources_ProjectsFollowingResourceId_ProjectsFollowingProjectId_ProjectsFollowingCompanyId_ProjectsFollowingUserId",
                table: "Resources",
                columns: new[] { "ProjectsFollowingResourceId", "ProjectsFollowingProjectId", "ProjectsFollowingCompanyId", "ProjectsFollowingUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Resources_ProjectsPermittedResourceId_ProjectsPermittedProjectId_ProjectsPermittedCompanyId_ProjectsPermittedUserId",
                table: "Resources",
                columns: new[] { "ProjectsPermittedResourceId", "ProjectsPermittedProjectId", "ProjectsPermittedCompanyId", "ProjectsPermittedUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ResourceEffortSummaries_CompanyId",
                table: "ResourceEffortSummaries",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceEffortSummaries_ResourceCompanyId_ResourceId1",
                table: "ResourceEffortSummaries",
                columns: new[] { "ResourceCompanyId", "ResourceId1" });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_SponsorCompanyId_SponsorResourceId",
                table: "Projects",
                columns: new[] { "SponsorCompanyId", "SponsorResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBudget_ForecastTaskId",
                table: "ProjectBudget",
                column: "ForecastTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBudget_ParentTaskId",
                table: "ProjectBudget",
                column: "ParentTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBudget_ProjectId",
                table: "ProjectBudget",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Programmes_BusinessunitId",
                table: "Programmes",
                column: "BusinessunitId");

            migrationBuilder.CreateIndex(
                name: "IX_Programmes_DomainId",
                table: "Programmes",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_Programmes_CompanyId_DeliveryDirectorId",
                table: "Programmes",
                columns: new[] { "CompanyId", "DeliveryDirectorId" });

            migrationBuilder.CreateIndex(
                name: "IX_Programmes_CompanyId_DeliveryManagerId",
                table: "Programmes",
                columns: new[] { "CompanyId", "DeliveryManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_Programmes_CompanyId_ProgrammeManagerId",
                table: "Programmes",
                columns: new[] { "CompanyId", "ProgrammeManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_Programmes_CompanyId_SponsorId",
                table: "Programmes",
                columns: new[] { "CompanyId", "SponsorId" });

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_BusinessunitId",
                table: "Portfolios",
                column: "BusinessunitId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_CompanyId_HeadOfPortfolioId",
                table: "Portfolios",
                columns: new[] { "CompanyId", "HeadOfPortfolioId" });

            migrationBuilder.CreateIndex(
                name: "IX_Platforms_CompanyId_HeadOfPlatformId",
                table: "Platforms",
                columns: new[] { "CompanyId", "HeadOfPlatformId" });

            migrationBuilder.CreateIndex(
                name: "IX_Domains_CompanyId_HeadOfDomainId",
                table: "Domains",
                columns: new[] { "CompanyId", "HeadOfDomainId" });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyCurrencyId",
                table: "Companies",
                column: "CompanyCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnits_DomainId",
                table: "BusinessUnits",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnits_CompanyId_HeadOfBusinessunitId",
                table: "BusinessUnits",
                columns: new[] { "CompanyId", "HeadOfBusinessunitId" });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessunitsIamFollowing_UserId",
                table: "BusinessunitsIamFollowing",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessunitsIamFollowing_CompanyId_ResourceId",
                table: "BusinessunitsIamFollowing",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnitsPermitted_CompanyId_ResourceId",
                table: "BusinessUnitsPermitted",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_DomainsIamFollowing_UserId",
                table: "DomainsIamFollowing",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DomainsIamFollowing_CompanyId_ResourceId",
                table: "DomainsIamFollowing",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_DomainsPermitted_DomainId",
                table: "DomainsPermitted",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_DomainsPermitted_CompanyId_ResourceId",
                table: "DomainsPermitted",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_PortfoliosIamFollowing_UserId",
                table: "PortfoliosIamFollowing",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PortfoliosIamFollowing_CompanyId_ResourceId",
                table: "PortfoliosIamFollowing",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_PortfoliosPermitted_PortfolioId",
                table: "PortfoliosPermitted",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_PortfoliosPermitted_CompanyId_ResourceId",
                table: "PortfoliosPermitted",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammesIamFollowing_UserId",
                table: "ProgrammesIamFollowing",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammesIamFollowing_CompanyId_ResourceId",
                table: "ProgrammesIamFollowing",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammesPermitted_ProgrammeId",
                table: "ProgrammesPermitted",
                column: "ProgrammeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammesPermitted_CompanyId_ResourceId",
                table: "ProgrammesPermitted",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsIamFollowing_ProjectId",
                table: "ProjectsIamFollowing",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsIamFollowing_UserId",
                table: "ProjectsIamFollowing",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsIamFollowing_CompanyId_ResourceId",
                table: "ProjectsIamFollowing",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsIamPermitted_ProjectId",
                table: "ProjectsIamPermitted",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsIamPermitted_UserId",
                table: "ProjectsIamPermitted",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsIamPermitted_CompanyId_ResourceId",
                table: "ProjectsIamPermitted",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_ResourceUtilizationSummaries_CompanyId_ResourceId",
                table: "ResourceUtilizationSummaries",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessUnits_Domains_DomainId",
                table: "BusinessUnits",
                column: "DomainId",
                principalTable: "Domains",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessUnits_Resources_CompanyId_HeadOfBusinessunitId",
                table: "BusinessUnits",
                columns: new[] { "CompanyId", "HeadOfBusinessunitId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_CurrencySymbols_CompanyCurrencyId",
                table: "Companies",
                column: "CompanyCurrencyId",
                principalTable: "CurrencySymbols",
                principalColumn: "CurrencySymbolId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Domains_Resources_CompanyId_HeadOfDomainId",
                table: "Domains",
                columns: new[] { "CompanyId", "HeadOfDomainId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Platforms_Resources_CompanyId_HeadOfPlatformId",
                table: "Platforms",
                columns: new[] { "CompanyId", "HeadOfPlatformId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_BusinessUnits_BusinessunitId",
                table: "Portfolios",
                column: "BusinessunitId",
                principalTable: "BusinessUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Resources_CompanyId_HeadOfPortfolioId",
                table: "Portfolios",
                columns: new[] { "CompanyId", "HeadOfPortfolioId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Programmes_BusinessUnits_BusinessunitId",
                table: "Programmes",
                column: "BusinessunitId",
                principalTable: "BusinessUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Programmes_Domains_DomainId",
                table: "Programmes",
                column: "DomainId",
                principalTable: "Domains",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Programmes_Resources_CompanyId_DeliveryDirectorId",
                table: "Programmes",
                columns: new[] { "CompanyId", "DeliveryDirectorId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Programmes_Resources_CompanyId_DeliveryManagerId",
                table: "Programmes",
                columns: new[] { "CompanyId", "DeliveryManagerId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Programmes_Resources_CompanyId_ProgrammeManagerId",
                table: "Programmes",
                columns: new[] { "CompanyId", "ProgrammeManagerId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Programmes_Resources_CompanyId_SponsorId",
                table: "Programmes",
                columns: new[] { "CompanyId", "SponsorId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectBudget_Companies_CompanyId",
                table: "ProjectBudget",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectBudget_ForecastTasks_ForecastTaskId",
                table: "ProjectBudget",
                column: "ForecastTaskId",
                principalTable: "ForecastTasks",
                principalColumn: "ForecastTaskId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectBudget_ParentTasks_ParentTaskId",
                table: "ProjectBudget",
                column: "ParentTaskId",
                principalTable: "ParentTasks",
                principalColumn: "ParentTaskId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectBudget_Projects_ProjectId",
                table: "ProjectBudget",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Resources_SponsorCompanyId_SponsorResourceId",
                table: "Projects",
                columns: new[] { "SponsorCompanyId", "SponsorResourceId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceEffortSummaries_Resources_ResourceCompanyId_ResourceId1",
                table: "ResourceEffortSummaries",
                columns: new[] { "ResourceCompanyId", "ResourceId1" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_BusinessUnitsPermitted_BusinessUnitsPermittedUserId_BusinessUnitsPermittedResourceId_BusinessUnitsPermittedCompany~",
                table: "Resources",
                columns: new[] { "BusinessUnitsPermittedUserId", "BusinessUnitsPermittedResourceId", "BusinessUnitsPermittedCompanyId", "BusinessUnitsPermittedBusinessUnitId" },
                principalTable: "BusinessUnitsPermitted",
                principalColumns: new[] { "UserId", "ResourceId", "CompanyId", "BusinessUnitId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_BusinessunitsIamFollowing_BusinessunitsFollowingResourceId_BusinessunitsFollowingBusinessUnitId_BusinessunitsFollo~",
                table: "Resources",
                columns: new[] { "BusinessunitsFollowingResourceId", "BusinessunitsFollowingBusinessUnitId", "BusinessunitsFollowingCompanyId", "BusinessunitsFollowingUserId" },
                principalTable: "BusinessunitsIamFollowing",
                principalColumns: new[] { "ResourceId", "BusinessUnitId", "CompanyId", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_DomainsIamFollowing_DomainsFollowingResourceId_DomainsFollowingDomainId_DomainsFollowingCompanyId_DomainsFollowing~",
                table: "Resources",
                columns: new[] { "DomainsFollowingResourceId", "DomainsFollowingDomainId", "DomainsFollowingCompanyId", "DomainsFollowingUserId" },
                principalTable: "DomainsIamFollowing",
                principalColumns: new[] { "ResourceId", "DomainId", "CompanyId", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_DomainsPermitted_DomainsPermittedUserId_DomainsPermittedResourceId_DomainsPermittedCompanyId_DomainsPermittedDomai~",
                table: "Resources",
                columns: new[] { "DomainsPermittedUserId", "DomainsPermittedResourceId", "DomainsPermittedCompanyId", "DomainsPermittedDomainId" },
                principalTable: "DomainsPermitted",
                principalColumns: new[] { "UserId", "ResourceId", "CompanyId", "DomainId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_PortfoliosIamFollowing_PortfoliosFollowingResourceId_PortfoliosFollowingPortfolioId_PortfoliosFollowingCompanyId_P~",
                table: "Resources",
                columns: new[] { "PortfoliosFollowingResourceId", "PortfoliosFollowingPortfolioId", "PortfoliosFollowingCompanyId", "PortfoliosFollowingUserId" },
                principalTable: "PortfoliosIamFollowing",
                principalColumns: new[] { "ResourceId", "PortfolioId", "CompanyId", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_PortfoliosPermitted_PortfoliosPermittedUserId_PortfoliosPermittedResourceId_PortfoliosPermittedCompanyId_Portfolio~",
                table: "Resources",
                columns: new[] { "PortfoliosPermittedUserId", "PortfoliosPermittedResourceId", "PortfoliosPermittedCompanyId", "PortfoliosPermittedPortfolioId" },
                principalTable: "PortfoliosPermitted",
                principalColumns: new[] { "UserId", "ResourceId", "CompanyId", "PortfolioId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_ProgrammesIamFollowing_ProgrammesFollowingResourceId_ProgrammesFollowingProgrammeId_ProgrammesFollowingCompanyId_P~",
                table: "Resources",
                columns: new[] { "ProgrammesFollowingResourceId", "ProgrammesFollowingProgrammeId", "ProgrammesFollowingCompanyId", "ProgrammesFollowingUserId" },
                principalTable: "ProgrammesIamFollowing",
                principalColumns: new[] { "ResourceId", "ProgrammeId", "CompanyId", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_ProgrammesPermitted_ProgrammesPermittedUserId_ProgrammesPermittedResourceId_ProgrammesPermittedCompanyId_Programme~",
                table: "Resources",
                columns: new[] { "ProgrammesPermittedUserId", "ProgrammesPermittedResourceId", "ProgrammesPermittedCompanyId", "ProgrammesPermittedProgrammeId" },
                principalTable: "ProgrammesPermitted",
                principalColumns: new[] { "UserId", "ResourceId", "CompanyId", "ProgrammeId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_ProjectsIamFollowing_ProjectsFollowingResourceId_ProjectsFollowingProjectId_ProjectsFollowingCompanyId_ProjectsFol~",
                table: "Resources",
                columns: new[] { "ProjectsFollowingResourceId", "ProjectsFollowingProjectId", "ProjectsFollowingCompanyId", "ProjectsFollowingUserId" },
                principalTable: "ProjectsIamFollowing",
                principalColumns: new[] { "ResourceId", "ProjectId", "CompanyId", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_ProjectsIamPermitted_ProjectsPermittedResourceId_ProjectsPermittedProjectId_ProjectsPermittedCompanyId_ProjectsPer~",
                table: "Resources",
                columns: new[] { "ProjectsPermittedResourceId", "ProjectsPermittedProjectId", "ProjectsPermittedCompanyId", "ProjectsPermittedUserId" },
                principalTable: "ProjectsIamPermitted",
                principalColumns: new[] { "ResourceId", "ProjectId", "CompanyId", "UserId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessUnits_Domains_DomainId",
                table: "BusinessUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessUnits_Resources_CompanyId_HeadOfBusinessunitId",
                table: "BusinessUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_CurrencySymbols_CompanyCurrencyId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Domains_Resources_CompanyId_HeadOfDomainId",
                table: "Domains");

            migrationBuilder.DropForeignKey(
                name: "FK_Platforms_Resources_CompanyId_HeadOfPlatformId",
                table: "Platforms");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_BusinessUnits_BusinessunitId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Resources_CompanyId_HeadOfPortfolioId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_Programmes_BusinessUnits_BusinessunitId",
                table: "Programmes");

            migrationBuilder.DropForeignKey(
                name: "FK_Programmes_Domains_DomainId",
                table: "Programmes");

            migrationBuilder.DropForeignKey(
                name: "FK_Programmes_Resources_CompanyId_DeliveryDirectorId",
                table: "Programmes");

            migrationBuilder.DropForeignKey(
                name: "FK_Programmes_Resources_CompanyId_DeliveryManagerId",
                table: "Programmes");

            migrationBuilder.DropForeignKey(
                name: "FK_Programmes_Resources_CompanyId_ProgrammeManagerId",
                table: "Programmes");

            migrationBuilder.DropForeignKey(
                name: "FK_Programmes_Resources_CompanyId_SponsorId",
                table: "Programmes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectBudget_Companies_CompanyId",
                table: "ProjectBudget");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectBudget_ForecastTasks_ForecastTaskId",
                table: "ProjectBudget");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectBudget_ParentTasks_ParentTaskId",
                table: "ProjectBudget");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectBudget_Projects_ProjectId",
                table: "ProjectBudget");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Resources_SponsorCompanyId_SponsorResourceId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceEffortSummaries_Resources_ResourceCompanyId_ResourceId1",
                table: "ResourceEffortSummaries");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_BusinessUnitsPermitted_BusinessUnitsPermittedUserId_BusinessUnitsPermittedResourceId_BusinessUnitsPermittedCompany~",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_BusinessunitsIamFollowing_BusinessunitsFollowingResourceId_BusinessunitsFollowingBusinessUnitId_BusinessunitsFollo~",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_DomainsIamFollowing_DomainsFollowingResourceId_DomainsFollowingDomainId_DomainsFollowingCompanyId_DomainsFollowing~",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_DomainsPermitted_DomainsPermittedUserId_DomainsPermittedResourceId_DomainsPermittedCompanyId_DomainsPermittedDomai~",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_PortfoliosIamFollowing_PortfoliosFollowingResourceId_PortfoliosFollowingPortfolioId_PortfoliosFollowingCompanyId_P~",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_PortfoliosPermitted_PortfoliosPermittedUserId_PortfoliosPermittedResourceId_PortfoliosPermittedCompanyId_Portfolio~",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_ProgrammesIamFollowing_ProgrammesFollowingResourceId_ProgrammesFollowingProgrammeId_ProgrammesFollowingCompanyId_P~",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_ProgrammesPermitted_ProgrammesPermittedUserId_ProgrammesPermittedResourceId_ProgrammesPermittedCompanyId_Programme~",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_ProjectsIamFollowing_ProjectsFollowingResourceId_ProjectsFollowingProjectId_ProjectsFollowingCompanyId_ProjectsFol~",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_ProjectsIamPermitted_ProjectsPermittedResourceId_ProjectsPermittedProjectId_ProjectsPermittedCompanyId_ProjectsPer~",
                table: "Resources");

            migrationBuilder.DropTable(
                name: "BusinessunitsIamFollowing");

            migrationBuilder.DropTable(
                name: "BusinessUnitsPermitted");

            migrationBuilder.DropTable(
                name: "DomainsIamFollowing");

            migrationBuilder.DropTable(
                name: "DomainsPermitted");

            migrationBuilder.DropTable(
                name: "PortfoliosIamFollowing");

            migrationBuilder.DropTable(
                name: "PortfoliosPermitted");

            migrationBuilder.DropTable(
                name: "ProgrammesIamFollowing");

            migrationBuilder.DropTable(
                name: "ProgrammesPermitted");

            migrationBuilder.DropTable(
                name: "ProjectsIamFollowing");

            migrationBuilder.DropTable(
                name: "ProjectsIamPermitted");

            migrationBuilder.DropTable(
                name: "ResourceUtilizationSummaries");

            migrationBuilder.DropIndex(
                name: "IX_Resources_BusinessUnitsPermittedUserId_BusinessUnitsPermittedResourceId_BusinessUnitsPermittedCompanyId_BusinessUnitsPermitt~",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_BusinessunitsFollowingResourceId_BusinessunitsFollowingBusinessUnitId_BusinessunitsFollowingCompanyId_Businessunit~",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_DomainsFollowingResourceId_DomainsFollowingDomainId_DomainsFollowingCompanyId_DomainsFollowingUserId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_DomainsPermittedUserId_DomainsPermittedResourceId_DomainsPermittedCompanyId_DomainsPermittedDomainId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_PortfoliosFollowingResourceId_PortfoliosFollowingPortfolioId_PortfoliosFollowingCompanyId_PortfoliosFollowingUserId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_PortfoliosPermittedUserId_PortfoliosPermittedResourceId_PortfoliosPermittedCompanyId_PortfoliosPermittedPortfolioId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_ProgrammesFollowingResourceId_ProgrammesFollowingProgrammeId_ProgrammesFollowingCompanyId_ProgrammesFollowingUserId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_ProgrammesPermittedUserId_ProgrammesPermittedResourceId_ProgrammesPermittedCompanyId_ProgrammesPermittedProgrammeId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_ProjectsFollowingResourceId_ProjectsFollowingProjectId_ProjectsFollowingCompanyId_ProjectsFollowingUserId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_ProjectsPermittedResourceId_ProjectsPermittedProjectId_ProjectsPermittedCompanyId_ProjectsPermittedUserId",
                table: "Resources");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_ResourceHolidaysBooked_ResourceHolidayBookedId_ResourceId_TimesheetCalendarTsId",
                table: "ResourceHolidaysBooked");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResourceEffortSummaries",
                table: "ResourceEffortSummaries");

            migrationBuilder.DropIndex(
                name: "IX_ResourceEffortSummaries_CompanyId",
                table: "ResourceEffortSummaries");

            migrationBuilder.DropIndex(
                name: "IX_ResourceEffortSummaries_ResourceCompanyId_ResourceId1",
                table: "ResourceEffortSummaries");

            migrationBuilder.DropIndex(
                name: "IX_Projects_SponsorCompanyId_SponsorResourceId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_ProjectBudget_ForecastTaskId",
                table: "ProjectBudget");

            migrationBuilder.DropIndex(
                name: "IX_ProjectBudget_ParentTaskId",
                table: "ProjectBudget");

            migrationBuilder.DropIndex(
                name: "IX_ProjectBudget_ProjectId",
                table: "ProjectBudget");

            migrationBuilder.DropIndex(
                name: "IX_Programmes_BusinessunitId",
                table: "Programmes");

            migrationBuilder.DropIndex(
                name: "IX_Programmes_DomainId",
                table: "Programmes");

            migrationBuilder.DropIndex(
                name: "IX_Programmes_CompanyId_DeliveryDirectorId",
                table: "Programmes");

            migrationBuilder.DropIndex(
                name: "IX_Programmes_CompanyId_DeliveryManagerId",
                table: "Programmes");

            migrationBuilder.DropIndex(
                name: "IX_Programmes_CompanyId_ProgrammeManagerId",
                table: "Programmes");

            migrationBuilder.DropIndex(
                name: "IX_Programmes_CompanyId_SponsorId",
                table: "Programmes");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_BusinessunitId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_CompanyId_HeadOfPortfolioId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Platforms_CompanyId_HeadOfPlatformId",
                table: "Platforms");

            migrationBuilder.DropIndex(
                name: "IX_Domains_CompanyId_HeadOfDomainId",
                table: "Domains");

            migrationBuilder.DropIndex(
                name: "IX_Companies_CompanyCurrencyId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_BusinessUnits_DomainId",
                table: "BusinessUnits");

            migrationBuilder.DropIndex(
                name: "IX_BusinessUnits_CompanyId_HeadOfBusinessunitId",
                table: "BusinessUnits");

            migrationBuilder.DropColumn(
                name: "BusinessUnitsPermittedBusinessUnitId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "BusinessUnitsPermittedCompanyId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "BusinessUnitsPermittedResourceId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "BusinessUnitsPermittedUserId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "BusinessunitsFollowingBusinessUnitId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "BusinessunitsFollowingCompanyId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "BusinessunitsFollowingResourceId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "BusinessunitsFollowingUserId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "DomainsFollowingCompanyId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "DomainsFollowingDomainId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "DomainsFollowingResourceId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "DomainsFollowingUserId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "DomainsPermittedCompanyId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "DomainsPermittedDomainId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "DomainsPermittedResourceId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "DomainsPermittedUserId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "IsAppUser",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "PortfoliosFollowingCompanyId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "PortfoliosFollowingPortfolioId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "PortfoliosFollowingResourceId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "PortfoliosFollowingUserId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "PortfoliosPermittedCompanyId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "PortfoliosPermittedPortfolioId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "PortfoliosPermittedResourceId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "PortfoliosPermittedUserId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "ProgrammesFollowingCompanyId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "ProgrammesFollowingProgrammeId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "ProgrammesFollowingResourceId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "ProgrammesFollowingUserId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "ProgrammesPermittedCompanyId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "ProgrammesPermittedProgrammeId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "ProgrammesPermittedResourceId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "ProgrammesPermittedUserId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "ProjectsFollowingCompanyId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "ProjectsFollowingProjectId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "ProjectsFollowingResourceId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "ProjectsFollowingUserId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "ProjectsPermittedCompanyId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "ProjectsPermittedProjectId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "ResourceCompanyId",
                table: "ResourceEffortSummaries");

            migrationBuilder.DropColumn(
                name: "LastBudgetBatchVersion",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "ProjectBudgetTracker");

            migrationBuilder.DropColumn(
                name: "AprForecastAmount",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "AugForecastAmount",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "DecForecastAmount",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "FebForecastAmount",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "FebForecastIrrecoverableVat",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "FebForecastNet",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "ParentTaskId",
                table: "ProjectBudget");

            migrationBuilder.DropColumn(
                name: "BusinessunitId",
                table: "Programmes");

            migrationBuilder.DropColumn(
                name: "DomainId",
                table: "Programmes");

            migrationBuilder.DropColumn(
                name: "BusinessunitId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioEndDate",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioStartDate",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "IrrecoverableVATPercentage",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "UseRateCard",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "AppUserRole",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsDisabled",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserCreatedAvatar",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserCreatedEmail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserCreatedFirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserCreatedId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserCreatedLastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserCreatedResourceId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserModifiedAvartar",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserModifiedEmail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserModifiedFirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserModifiedId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserModifiedLastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserModifiedResourceId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ProjectsPermittedUserId",
                table: "Resources",
                newName: "ProjectId");

            migrationBuilder.RenameColumn(
                name: "ProjectsPermittedResourceId",
                table: "Resources",
                newName: "AddedBy");

            migrationBuilder.RenameColumn(
                name: "ResourceId1",
                table: "ResourceEffortSummaries",
                newName: "ProjectId");

            migrationBuilder.RenameColumn(
                name: "SponsorResourceId",
                table: "Projects",
                newName: "Sponsor");

            migrationBuilder.RenameColumn(
                name: "SponsorId",
                table: "Projects",
                newName: "ResourceId");

            migrationBuilder.RenameColumn(
                name: "SponsorCompanyId",
                table: "Projects",
                newName: "ResourceCompanyId");

            migrationBuilder.RenameColumn(
                name: "VAT",
                table: "ProjectBudget",
                newName: "SepAmount");

            migrationBuilder.RenameColumn(
                name: "SepForecastAmount",
                table: "ProjectBudget",
                newName: "OctAmount");

            migrationBuilder.RenameColumn(
                name: "OctForecastAmount",
                table: "ProjectBudget",
                newName: "NovAmount");

            migrationBuilder.RenameColumn(
                name: "NovForecastAmount",
                table: "ProjectBudget",
                newName: "MayAmount");

            migrationBuilder.RenameColumn(
                name: "MayForecastAmount",
                table: "ProjectBudget",
                newName: "MarAmount");

            migrationBuilder.RenameColumn(
                name: "MarForecastAmount",
                table: "ProjectBudget",
                newName: "JunAmount");

            migrationBuilder.RenameColumn(
                name: "JunForecastAmount",
                table: "ProjectBudget",
                newName: "JulAmount");

            migrationBuilder.RenameColumn(
                name: "JulForecastAmount",
                table: "ProjectBudget",
                newName: "JanAmount");

            migrationBuilder.RenameColumn(
                name: "JanForecastAmount",
                table: "ProjectBudget",
                newName: "FebAmount");

            migrationBuilder.RenameColumn(
                name: "FebForecastVat",
                table: "ProjectBudget",
                newName: "AugAmount");

            migrationBuilder.RenameColumn(
                name: "FebForecastRecoverableVat",
                table: "ProjectBudget",
                newName: "AprAmount");

            migrationBuilder.RenameColumn(
                name: "SponsorId",
                table: "Programmes",
                newName: "Sponsor");

            migrationBuilder.RenameColumn(
                name: "ProgrammeManagerId",
                table: "Programmes",
                newName: "ResourceId");

            migrationBuilder.RenameColumn(
                name: "DeliveryManagerId",
                table: "Programmes",
                newName: "ResourceCompanyId");

            migrationBuilder.RenameColumn(
                name: "DeliveryDirectorId",
                table: "Programmes",
                newName: "ProgrammeManager");

            migrationBuilder.RenameColumn(
                name: "HeadOfPortfolioId",
                table: "Portfolios",
                newName: "ResourceId");

            migrationBuilder.RenameColumn(
                name: "HeadOfPlatformId",
                table: "Platforms",
                newName: "HeadOfPlatform");

            migrationBuilder.RenameColumn(
                name: "HeadOfDomainId",
                table: "Domains",
                newName: "ResourceId");

            migrationBuilder.RenameColumn(
                name: "DomainName",
                table: "Domains",
                newName: "ResourceCompanyId");

            migrationBuilder.RenameColumn(
                name: "BusinessunitName",
                table: "BusinessUnits",
                newName: "BusinessUnitName");

            migrationBuilder.RenameColumn(
                name: "BusinessunitCode",
                table: "BusinessUnits",
                newName: "BusinessUnitCode");

            migrationBuilder.RenameColumn(
                name: "HeadOfBusinessunitId",
                table: "BusinessUnits",
                newName: "ResourceId");

            migrationBuilder.RenameColumn(
                name: "DomainId",
                table: "BusinessUnits",
                newName: "ResourceCompanyId");

            migrationBuilder.AlterColumn<string>(
                name: "AddedBy",
                table: "Resources",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserRole",
                table: "Resources",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Sponsor",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ResourceId",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BudgetCurrentStatus",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentBudgetBadgeVersion",
                table: "Projects",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectId",
                table: "ProjectBudget",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ForecastTaskId",
                table: "ProjectBudget",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyId",
                table: "ProjectBudget",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "BaselinePeriod",
                table: "ProjectBudget",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "ForecastPeriodType",
                table: "ProjectBudget",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Month",
                table: "ProjectBudget",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Open",
                table: "ProjectBudget",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "ProjectBudget",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Parent",
                table: "ProjectBudget",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Progress",
                table: "ProjectBudget",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ProjectStage",
                table: "ProjectBudget",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectStageRefid",
                table: "ProjectBudget",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextTaskCostDescription",
                table: "ProjectBudget",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sponsor",
                table: "Programmes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProgrammeManager",
                table: "Programmes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryDirector",
                table: "Programmes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryManager",
                table: "Programmes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NodeId",
                table: "Programmes",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DomainId",
                table: "Portfolios",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "HeadOfPortfolio",
                table: "Portfolios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NodeId",
                table: "Portfolios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResourceCompanyId",
                table: "Portfolios",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HeadOfPlatform",
                table: "Platforms",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ResourceCompanyId",
                table: "Domains",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessUnitId",
                table: "Domains",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DivisionOrDomainName",
                table: "Domains",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeadOfDomain",
                table: "Domains",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NodeId",
                table: "Domains",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyCurrencyId",
                table: "Companies",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "HeadOfBusinessUnit",
                table: "BusinessUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NodeId",
                table: "BusinessUnits",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ResourceHolidaysBooked_ResourceHolidayBookedId",
                table: "ResourceHolidaysBooked",
                column: "ResourceHolidayBookedId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResourceEffortSummaries",
                table: "ResourceEffortSummaries",
                columns: new[] { "ResourceId", "ProjectId", "CompanyId" });

            migrationBuilder.CreateTable(
                name: "ProjectsPermitted",
                columns: table => new
                {
                    ResourceId = table.Column<string>(nullable: false),
                    ProjectId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    Id = table.Column<string>(nullable: false),
                    NodeId = table.Column<string>(nullable: true),
                    ProjectPermittedCompanyId = table.Column<string>(nullable: true),
                    ProjectPermittedProjectId = table.Column<string>(nullable: true),
                    ProjectPermittedResourceId = table.Column<string>(nullable: true),
                    ProjectPermittedUserId = table.Column<string>(nullable: true),
                    ReadWritePermission = table.Column<bool>(nullable: false),
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
                    table.PrimaryKey("PK_ProjectsPermitted", x => new { x.ResourceId, x.ProjectId, x.CompanyId, x.UserId });
                    table.UniqueConstraint("AK_ProjectsPermitted_Id_ProjectId_UserId", x => new { x.Id, x.ProjectId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ProjectsPermitted_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectsPermitted_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectsPermitted_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectsPermitted_Resources_CompanyId_ResourceId",
                        columns: x => new { x.CompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectsPermitted_ProjectsPermitted_ProjectPermittedResourceId_ProjectPermittedProjectId_ProjectPermittedCompanyId_ProjectPe~",
                        columns: x => new { x.ProjectPermittedResourceId, x.ProjectPermittedProjectId, x.ProjectPermittedCompanyId, x.ProjectPermittedUserId },
                        principalTable: "ProjectsPermitted",
                        principalColumns: new[] { "ResourceId", "ProjectId", "CompanyId", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Resources_ProjectId",
                table: "Resources",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceEffortSummaries_ProjectId",
                table: "ResourceEffortSummaries",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceEffortSummaries_CompanyId_ResourceId",
                table: "ResourceEffortSummaries",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ResourceCompanyId_ResourceId",
                table: "Projects",
                columns: new[] { "ResourceCompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_Programmes_CompanyId",
                table: "Programmes",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Programmes_ResourceCompanyId_ResourceId",
                table: "Programmes",
                columns: new[] { "ResourceCompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_CompanyId",
                table: "Portfolios",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_ResourceCompanyId_ResourceId",
                table: "Portfolios",
                columns: new[] { "ResourceCompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_Platforms_CompanyId",
                table: "Platforms",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Domains_BusinessUnitId",
                table: "Domains",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Domains_CompanyId",
                table: "Domains",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Domains_ResourceCompanyId_ResourceId",
                table: "Domains",
                columns: new[] { "ResourceCompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnits_CompanyId",
                table: "BusinessUnits",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnits_ResourceCompanyId_ResourceId",
                table: "BusinessUnits",
                columns: new[] { "ResourceCompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsPermitted_ProjectId",
                table: "ProjectsPermitted",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsPermitted_UserId",
                table: "ProjectsPermitted",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsPermitted_CompanyId_ResourceId",
                table: "ProjectsPermitted",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsPermitted_ProjectPermittedResourceId_ProjectPermittedProjectId_ProjectPermittedCompanyId_ProjectPermittedUserId",
                table: "ProjectsPermitted",
                columns: new[] { "ProjectPermittedResourceId", "ProjectPermittedProjectId", "ProjectPermittedCompanyId", "ProjectPermittedUserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessUnits_Resources_ResourceCompanyId_ResourceId",
                table: "BusinessUnits",
                columns: new[] { "ResourceCompanyId", "ResourceId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Domains_BusinessUnits_BusinessUnitId",
                table: "Domains",
                column: "BusinessUnitId",
                principalTable: "BusinessUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Domains_Resources_ResourceCompanyId_ResourceId",
                table: "Domains",
                columns: new[] { "ResourceCompanyId", "ResourceId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Resources_ResourceCompanyId_ResourceId",
                table: "Portfolios",
                columns: new[] { "ResourceCompanyId", "ResourceId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Programmes_Resources_ResourceCompanyId_ResourceId",
                table: "Programmes",
                columns: new[] { "ResourceCompanyId", "ResourceId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Resources_ResourceCompanyId_ResourceId",
                table: "Projects",
                columns: new[] { "ResourceCompanyId", "ResourceId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceEffortSummaries_Projects_ProjectId",
                table: "ResourceEffortSummaries",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceEffortSummaries_Resources_CompanyId_ResourceId",
                table: "ResourceEffortSummaries",
                columns: new[] { "CompanyId", "ResourceId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Projects_ProjectId",
                table: "Resources",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
