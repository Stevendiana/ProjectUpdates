using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PTApi.Migrations
{
    public partial class FreshMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<string>(nullable: false),
                    AllowReconciliation = table.Column<bool>(nullable: false),
                    CompanyAccountName = table.Column<string>(nullable: true),
                    CompanyAddress = table.Column<string>(nullable: true),
                    CompanyContactEmail = table.Column<string>(nullable: true),
                    CompanyCurrencyId = table.Column<int>(nullable: true),
                    CompanyCurrentLongName = table.Column<string>(nullable: true),
                    CompanyCurrentShortName = table.Column<string>(nullable: true),
                    CompanyLogo = table.Column<byte[]>(nullable: true),
                    CompanyRef = table.Column<string>(nullable: true),
                    CompanyReg = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    DoEmployeesWorkWeekends = table.Column<bool>(nullable: false),
                    FinanceReportingPeriod = table.Column<string>(nullable: true),
                    FinanceReportingYear = table.Column<int>(nullable: false),
                    FreezeForecast = table.Column<bool>(nullable: false),
                    Industry = table.Column<string>(nullable: true),
                    ReportingCurrency = table.Column<string>(nullable: true),
                    Sector = table.Column<string>(nullable: true),
                    StandardDailyHours = table.Column<byte>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true),
                    VatReg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "CurrencySymbols",
                columns: table => new
                {
                    CurrencySymbolId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyCurrencyLongName = table.Column<string>(nullable: true),
                    CompanyCurrencyShortName = table.Column<string>(nullable: true),
                    CompanyCurrencySymbol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencySymbols", x => x.CurrencySymbolId);
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
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimesheetCalendars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Friday = table.Column<DateTime>(nullable: false),
                    Monday = table.Column<DateTime>(nullable: false),
                    Saturday = table.Column<DateTime>(nullable: false),
                    SaturdayPeriod = table.Column<int>(nullable: false),
                    SaturdayYear = table.Column<int>(nullable: false),
                    Sunday = table.Column<DateTime>(nullable: false),
                    SundayPeriod = table.Column<int>(nullable: false),
                    SundayYear = table.Column<int>(nullable: false),
                    Thursday = table.Column<DateTime>(nullable: false),
                    TsId = table.Column<string>(nullable: false),
                    Tuesday = table.Column<DateTime>(nullable: false),
                    Wednesday = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimesheetCalendars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BusinessCustomers",
                columns: table => new
                {
                    BusinessCustomerId = table.Column<string>(nullable: false),
                    BusinessCustomerAddressI = table.Column<string>(nullable: true),
                    BusinessCustomerAddressII = table.Column<string>(nullable: true),
                    BusinessCustomerAddressIII = table.Column<string>(nullable: true),
                    BusinessCustomerAddressIV = table.Column<string>(nullable: true),
                    BusinessCustomerName = table.Column<string>(nullable: true),
                    BusinessCustomerReg = table.Column<string>(nullable: true),
                    CompanyId = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    Industry = table.Column<string>(nullable: true),
                    Sector = table.Column<string>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessCustomers", x => x.BusinessCustomerId);
                    table.ForeignKey(
                        name: "FK_BusinessCustomers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyMethodologies",
                columns: table => new
                {
                    CompanyMethodologyId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    MethodologyName = table.Column<string>(maxLength: 255, nullable: false),
                    MethodologyNotes = table.Column<string>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyMethodologies", x => x.CompanyMethodologyId);
                    table.ForeignKey(
                        name: "FK_CompanyMethodologies_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyRateCards",
                columns: table => new
                {
                    CompanyRateCardId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    CompanyRateCardCode = table.Column<string>(nullable: true),
                    DailyRate = table.Column<decimal>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    EmployeeJobTitleOrGradeOrBand = table.Column<string>(nullable: false),
                    LocationForGradeOnshoreOffShore = table.Column<string>(nullable: false),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyRateCards", x => x.CompanyRateCardId);
                    table.ForeignKey(
                        name: "FK_CompanyRateCards_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    PlatformId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    HeadOfPlatform = table.Column<string>(nullable: true),
                    PlatformName = table.Column<string>(nullable: false),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.PlatformId);
                    table.ForeignKey(
                        name: "FK_Platforms_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ForecastTasks",
                columns: table => new
                {
                    ForecastTaskId = table.Column<string>(nullable: false),
                    AprEndDate = table.Column<DateTime>(nullable: true),
                    AprForecastAmount = table.Column<decimal>(nullable: true),
                    AprForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    AprStartDate = table.Column<DateTime>(nullable: true),
                    AugEndDate = table.Column<DateTime>(nullable: true),
                    AugForecastAmount = table.Column<decimal>(nullable: true),
                    AugForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    AugStartDate = table.Column<DateTime>(nullable: true),
                    BaselinePeriod = table.Column<int>(nullable: true),
                    CompanyId = table.Column<string>(nullable: true),
                    CostCat = table.Column<string>(nullable: true),
                    CostType = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    DecEndDate = table.Column<DateTime>(nullable: true),
                    DecForecastAmount = table.Column<decimal>(nullable: true),
                    DecForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    DecStartDate = table.Column<DateTime>(nullable: true),
                    FebEndDate = table.Column<DateTime>(nullable: true),
                    FebForecastAmount = table.Column<decimal>(nullable: true),
                    FebForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    FebStartDate = table.Column<DateTime>(nullable: true),
                    ForecastCode = table.Column<string>(nullable: true),
                    ForecastPeriodType = table.Column<byte>(nullable: true),
                    JanEndDate = table.Column<DateTime>(nullable: true),
                    JanForecastAmount = table.Column<decimal>(nullable: true),
                    JanForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    JanStartDate = table.Column<DateTime>(nullable: true),
                    JulEndDate = table.Column<DateTime>(nullable: true),
                    JulForecastAmount = table.Column<decimal>(nullable: true),
                    JulForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    JulStartDate = table.Column<DateTime>(nullable: true),
                    JunEndDate = table.Column<DateTime>(nullable: true),
                    JunForecastAmount = table.Column<decimal>(nullable: true),
                    JunForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    JunStartDate = table.Column<DateTime>(nullable: true),
                    MarEndDate = table.Column<DateTime>(nullable: true),
                    MarForecastAmount = table.Column<decimal>(nullable: true),
                    MarForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    MarStartDate = table.Column<DateTime>(nullable: true),
                    MayEndDate = table.Column<DateTime>(nullable: true),
                    MayForecastAmount = table.Column<decimal>(nullable: true),
                    MayForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    MayStartDate = table.Column<DateTime>(nullable: true),
                    Month = table.Column<byte>(nullable: true),
                    NovEndDate = table.Column<DateTime>(nullable: true),
                    NovForecastAmount = table.Column<decimal>(nullable: true),
                    NovForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    NovStartDate = table.Column<DateTime>(nullable: true),
                    OctEndDate = table.Column<DateTime>(nullable: true),
                    OctForecastAmount = table.Column<decimal>(nullable: true),
                    OctForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    OctStartDate = table.Column<DateTime>(nullable: true),
                    Open = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: true),
                    OrderNumber = table.Column<string>(nullable: true),
                    Parent = table.Column<string>(nullable: true),
                    Progress = table.Column<decimal>(nullable: false),
                    ProjectId = table.Column<string>(nullable: true),
                    ProjectStage = table.Column<string>(nullable: true),
                    ProjectStageRefid = table.Column<string>(nullable: true),
                    ResourceId = table.Column<string>(nullable: true),
                    ResourceName = table.Column<string>(nullable: true),
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
                    SepEndDate = table.Column<DateTime>(nullable: true),
                    SepForecastAmount = table.Column<decimal>(nullable: true),
                    SepForecastPreciseDuration = table.Column<decimal>(nullable: true),
                    SepStartDate = table.Column<DateTime>(nullable: true),
                    TextTaskCostDescription = table.Column<string>(nullable: true),
                    TimesheetCalendarId = table.Column<int>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForecastTasks", x => x.ForecastTaskId);
                    table.ForeignKey(
                        name: "FK_ForecastTasks_TimesheetCalendars_TimesheetCalendarId",
                        column: x => x.TimesheetCalendarId,
                        principalTable: "TimesheetCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyMethodologyStages",
                columns: table => new
                {
                    CompanyMethodologyStageId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    CompanyMethodologyId = table.Column<string>(nullable: false),
                    CompanyMethodologyStageName = table.Column<string>(nullable: false),
                    CompanyMethodologyStageNumber = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    MethodologyStageNotes = table.Column<string>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyMethodologyStages", x => x.CompanyMethodologyStageId);
                    table.ForeignKey(
                        name: "FK_CompanyMethodologyStages_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyMethodologyStages_CompanyMethodologies_CompanyMethodologyId",
                        column: x => x.CompanyMethodologyId,
                        principalTable: "CompanyMethodologies",
                        principalColumn: "CompanyMethodologyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReconciledActuals",
                columns: table => new
                {
                    ActualId = table.Column<string>(nullable: false),
                    ProjectId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    ForecastTaskId = table.Column<string>(nullable: false),
                    ActualDateFrom = table.Column<DateTime>(nullable: false),
                    ActualDateTo = table.Column<DateTime>(nullable: false),
                    AllocatedAmount = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReconciledActuals", x => new { x.ActualId, x.ProjectId, x.CompanyId, x.ForecastTaskId });
                    table.UniqueConstraint("AK_ReconciledActuals_ActualId_CompanyId_ForecastTaskId_ProjectId", x => new { x.ActualId, x.CompanyId, x.ForecastTaskId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_ReconciledActuals_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReconciledActuals_ForecastTasks_ForecastTaskId",
                        column: x => x.ForecastTaskId,
                        principalTable: "ForecastTasks",
                        principalColumn: "ForecastTaskId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<string>(nullable: false),
                    AccountingCode = table.Column<string>(nullable: true),
                    BenefitsDurationInYears = table.Column<int>(nullable: true),
                    BenefitsStartYear = table.Column<int>(nullable: true),
                    BusinessAlignment = table.Column<string>(nullable: true),
                    BusinessCustomerId = table.Column<string>(nullable: true),
                    BusinessStrategy = table.Column<string>(nullable: true),
                    BusinessUnitId = table.Column<string>(nullable: true),
                    CapexCostCode = table.Column<string>(nullable: true),
                    CompanyId = table.Column<string>(nullable: true),
                    CurrentStageGateStatus = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    DomainId = table.Column<string>(nullable: true),
                    FinancialStatus = table.Column<string>(nullable: true),
                    GrandTotalBenefitsAchieved = table.Column<decimal>(nullable: true),
                    GrandTotalBenefitsExpected = table.Column<decimal>(nullable: true),
                    GrandTotalBenefitsForecast = table.Column<decimal>(nullable: true),
                    GrandTotalBudgetApproved = table.Column<decimal>(nullable: true),
                    GrandTotalBudgetSubmitted = table.Column<decimal>(nullable: true),
                    GrandTotalOpexImpact = table.Column<decimal>(nullable: true),
                    IsCanceled = table.Column<bool>(nullable: false),
                    NodeId = table.Column<string>(nullable: true),
                    OpexCostCode = table.Column<string>(nullable: true),
                    ParentId = table.Column<string>(nullable: true),
                    PlanGrandTotalCapex = table.Column<decimal>(nullable: true),
                    PlanGrandTotalOpex = table.Column<decimal>(nullable: true),
                    PlanGrandTotalRevex = table.Column<decimal>(nullable: true),
                    PortfolioId = table.Column<string>(nullable: true),
                    PortfolioPermittedCompanyId = table.Column<string>(nullable: true),
                    PortfolioPermittedPortfolioId = table.Column<string>(nullable: true),
                    PortfolioPermittedResourceId = table.Column<string>(nullable: true),
                    ProgrammeId = table.Column<string>(nullable: true),
                    ProjectAlignment = table.Column<string>(nullable: true),
                    ProjectBudget = table.Column<string>(nullable: true),
                    ProjectCode = table.Column<string>(nullable: true),
                    ProjectCustomer = table.Column<string>(nullable: true),
                    ProjectEndDate = table.Column<DateTime>(nullable: true),
                    ProjectFinanceContactDisplayName = table.Column<string>(nullable: true),
                    ProjectLifecycleStage = table.Column<string>(nullable: true),
                    ProjectLifecycleStageId = table.Column<string>(nullable: true),
                    ProjectManagementRankId = table.Column<string>(nullable: true),
                    ProjectManagerDisplayName = table.Column<string>(nullable: true),
                    ProjectManagerUserName = table.Column<string>(nullable: true),
                    ProjectName = table.Column<string>(nullable: false),
                    ProjectObjective = table.Column<string>(nullable: true),
                    ProjectOwnerDisplayName = table.Column<string>(nullable: true),
                    ProjectPrimaryContactDisplayName = table.Column<string>(nullable: true),
                    ProjectPrioritisation = table.Column<string>(nullable: true),
                    ProjectRef = table.Column<string>(nullable: true),
                    ProjectReportedToDisplayname = table.Column<string>(nullable: true),
                    ProjectStartDate = table.Column<DateTime>(nullable: true),
                    ProjectStatus = table.Column<string>(nullable: true),
                    ProjectStrategy = table.Column<string>(nullable: true),
                    Projectlignment = table.Column<string>(nullable: true),
                    ResourceCompanyId = table.Column<string>(nullable: true),
                    ResourceId = table.Column<string>(nullable: true),
                    RevexCostCode = table.Column<string>(nullable: true),
                    RfqNumber = table.Column<string>(nullable: true),
                    Sponsor = table.Column<string>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_BusinessCustomers_BusinessCustomerId",
                        column: x => x.BusinessCustomerId,
                        principalTable: "BusinessCustomers",
                        principalColumn: "BusinessCustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Actuals",
                columns: table => new
                {
                    ActualId = table.Column<string>(nullable: false),
                    AccountingCode = table.Column<string>(nullable: true),
                    ActualCode = table.Column<string>(nullable: true),
                    ActualCostCategory = table.Column<string>(nullable: true),
                    ActualMonth = table.Column<byte>(nullable: false),
                    ActualProjectCode = table.Column<string>(nullable: false),
                    ActualResourceName = table.Column<string>(nullable: true),
                    ActualYear = table.Column<long>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CompanyCode = table.Column<string>(nullable: true),
                    CompanyId = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DocumentDate = table.Column<string>(nullable: true),
                    ExpenditureClass = table.Column<string>(nullable: true),
                    ExpenditureType = table.Column<string>(nullable: true),
                    ExternalVendorNumber = table.Column<string>(nullable: true),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    JournalComments = table.Column<string>(nullable: true),
                    MiAccountDescription = table.Column<string>(nullable: true),
                    ProjectCostCode = table.Column<string>(nullable: true),
                    ProjectId = table.Column<string>(nullable: true),
                    ProjectName = table.Column<string>(nullable: true),
                    PurchaseOrderDetail = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    TransactionCurrency = table.Column<string>(nullable: true),
                    TransactionDate = table.Column<DateTime>(nullable: true),
                    UploadBatchNumber = table.Column<string>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true),
                    VendorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actuals", x => x.ActualId);
                    table.ForeignKey(
                        name: "FK_Actuals_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Actuals_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectPlanBudgetBenefits",
                columns: table => new
                {
                    Year = table.Column<int>(nullable: false),
                    ProjectId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    CostCategory = table.Column<string>(nullable: false),
                    AprBenefitAchieved = table.Column<decimal>(nullable: true),
                    AprBenefitExpected = table.Column<decimal>(nullable: true),
                    AprBenefitForecast = table.Column<decimal>(nullable: true),
                    AprBudgetApproved = table.Column<decimal>(nullable: true),
                    AprBudgetDemand = table.Column<decimal>(nullable: true),
                    AprOpexImpact = table.Column<decimal>(nullable: true),
                    AugBenefitAchieved = table.Column<decimal>(nullable: true),
                    AugBenefitExpected = table.Column<decimal>(nullable: true),
                    AugBenefitForecast = table.Column<decimal>(nullable: true),
                    AugBudgetApproved = table.Column<decimal>(nullable: true),
                    AugBudgetDemand = table.Column<decimal>(nullable: true),
                    AugOpexImpact = table.Column<decimal>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    DecBenefitAchieved = table.Column<decimal>(nullable: true),
                    DecBenefitExpected = table.Column<decimal>(nullable: true),
                    DecBenefitForecast = table.Column<decimal>(nullable: true),
                    DecBudgetApproved = table.Column<decimal>(nullable: true),
                    DecBudgetDemand = table.Column<decimal>(nullable: true),
                    DecOpexImpact = table.Column<decimal>(nullable: true),
                    FebBenefitAchieved = table.Column<decimal>(nullable: true),
                    FebBenefitExpected = table.Column<decimal>(nullable: true),
                    FebBenefitForecast = table.Column<decimal>(nullable: true),
                    FebBudgetApproved = table.Column<decimal>(nullable: true),
                    FebBudgetDemand = table.Column<decimal>(nullable: true),
                    FebOpexImpact = table.Column<decimal>(nullable: true),
                    JanBenefitAchieved = table.Column<decimal>(nullable: true),
                    JanBenefitExpected = table.Column<decimal>(nullable: true),
                    JanBenefitForecast = table.Column<decimal>(nullable: true),
                    JanBudgetApproved = table.Column<decimal>(nullable: true),
                    JanBudgetDemand = table.Column<decimal>(nullable: true),
                    JanOpexImpact = table.Column<decimal>(nullable: true),
                    JulBenefitAchieved = table.Column<decimal>(nullable: true),
                    JulBenefitExpected = table.Column<decimal>(nullable: true),
                    JulBenefitForecast = table.Column<decimal>(nullable: true),
                    JulBudgetApproved = table.Column<decimal>(nullable: true),
                    JulBudgetDemand = table.Column<decimal>(nullable: true),
                    JulOpexImpact = table.Column<decimal>(nullable: true),
                    JunBenefitAchieved = table.Column<decimal>(nullable: true),
                    JunBenefitExpected = table.Column<decimal>(nullable: true),
                    JunBenefitForecast = table.Column<decimal>(nullable: true),
                    JunBudgetApproved = table.Column<decimal>(nullable: true),
                    JunBudgetDemand = table.Column<decimal>(nullable: true),
                    JunOpexImpact = table.Column<decimal>(nullable: true),
                    MarBenefitAchieved = table.Column<decimal>(nullable: true),
                    MarBenefitExpected = table.Column<decimal>(nullable: true),
                    MarBenefitForecast = table.Column<decimal>(nullable: true),
                    MarBudgetApproved = table.Column<decimal>(nullable: true),
                    MarBudgetDemand = table.Column<decimal>(nullable: true),
                    MarOpexImpact = table.Column<decimal>(nullable: true),
                    MayBenefitAchieved = table.Column<decimal>(nullable: true),
                    MayBenefitExpected = table.Column<decimal>(nullable: true),
                    MayBenefitForecast = table.Column<decimal>(nullable: true),
                    MayBudgetApproved = table.Column<decimal>(nullable: true),
                    MayBudgetDemand = table.Column<decimal>(nullable: true),
                    MayOpexImpact = table.Column<decimal>(nullable: true),
                    NovBenefitAchieved = table.Column<decimal>(nullable: true),
                    NovBenefitExpected = table.Column<decimal>(nullable: true),
                    NovBenefitForecast = table.Column<decimal>(nullable: true),
                    NovBudgetApproved = table.Column<decimal>(nullable: true),
                    NovBudgetDemand = table.Column<decimal>(nullable: true),
                    NovOpexImpact = table.Column<decimal>(nullable: true),
                    OctBenefitAchieved = table.Column<decimal>(nullable: true),
                    OctBenefitExpected = table.Column<decimal>(nullable: true),
                    OctBenefitForecast = table.Column<decimal>(nullable: true),
                    OctBudgetApproved = table.Column<decimal>(nullable: true),
                    OctBudgetDemand = table.Column<decimal>(nullable: true),
                    OctOpexImpact = table.Column<decimal>(nullable: true),
                    PlanApr = table.Column<decimal>(nullable: true),
                    PlanAug = table.Column<decimal>(nullable: true),
                    PlanCategoryTotal = table.Column<decimal>(nullable: true),
                    PlanDec = table.Column<decimal>(nullable: true),
                    PlanFeb = table.Column<decimal>(nullable: true),
                    PlanJan = table.Column<decimal>(nullable: true),
                    PlanJul = table.Column<decimal>(nullable: true),
                    PlanJun = table.Column<decimal>(nullable: true),
                    PlanMar = table.Column<decimal>(nullable: true),
                    PlanMay = table.Column<decimal>(nullable: true),
                    PlanNov = table.Column<decimal>(nullable: true),
                    PlanOct = table.Column<decimal>(nullable: true),
                    PlanPerCategoryQ1 = table.Column<decimal>(nullable: true),
                    PlanPerCategoryQ2 = table.Column<decimal>(nullable: true),
                    PlanPerCategoryQ3 = table.Column<decimal>(nullable: true),
                    PlanPerCategoryQ4 = table.Column<decimal>(nullable: true),
                    PlanSep = table.Column<decimal>(nullable: true),
                    Q1BenefitAchievedPerCategory = table.Column<decimal>(nullable: true),
                    Q1BenefitExpectedPerCategory = table.Column<decimal>(nullable: true),
                    Q1BenefitForecastPerCategory = table.Column<decimal>(nullable: true),
                    Q1BudgetApprovedPerCategory = table.Column<decimal>(nullable: true),
                    Q1BudgetDemandPerCategory = table.Column<decimal>(nullable: true),
                    Q1OpexImpactPerCategory = table.Column<decimal>(nullable: true),
                    Q2BenefitAchievedPerCategory = table.Column<decimal>(nullable: true),
                    Q2BenefitExpectedPerCategory = table.Column<decimal>(nullable: true),
                    Q2BenefitForecastPerCategory = table.Column<decimal>(nullable: true),
                    Q2BudgetApprovedPerCategory = table.Column<decimal>(nullable: true),
                    Q2BudgetDemandPerCategory = table.Column<decimal>(nullable: true),
                    Q2OpexImpactPerCategory = table.Column<decimal>(nullable: true),
                    Q3BenefitAchievedPerCategory = table.Column<decimal>(nullable: true),
                    Q3BenefitExpectedPerCategory = table.Column<decimal>(nullable: true),
                    Q3BenefitForecastPerCategory = table.Column<decimal>(nullable: true),
                    Q3BudgetApprovedPerCategory = table.Column<decimal>(nullable: true),
                    Q3BudgetDemandPerCategory = table.Column<decimal>(nullable: true),
                    Q3OpexImpactPerCategory = table.Column<decimal>(nullable: true),
                    Q4BenefitAchievedPerCategory = table.Column<decimal>(nullable: true),
                    Q4BenefitExpectedPerCategory = table.Column<decimal>(nullable: true),
                    Q4BenefitForecastPerCategory = table.Column<decimal>(nullable: true),
                    Q4BudgetApprovedPerCategory = table.Column<decimal>(nullable: true),
                    Q4BudgetDemandPerCategory = table.Column<decimal>(nullable: true),
                    Q4OpexImpactPerCategory = table.Column<decimal>(nullable: true),
                    SepBenefitAchieved = table.Column<decimal>(nullable: true),
                    SepBenefitExpected = table.Column<decimal>(nullable: true),
                    SepBenefitForecast = table.Column<decimal>(nullable: true),
                    SepBudgetApproved = table.Column<decimal>(nullable: true),
                    SepBudgetDemand = table.Column<decimal>(nullable: true),
                    SepOpexImpact = table.Column<decimal>(nullable: true),
                    TotalBenefitAchievedPerCategory = table.Column<decimal>(nullable: true),
                    TotalBenefitExpected = table.Column<decimal>(nullable: true),
                    TotalBenefitForecastPerCategory = table.Column<decimal>(nullable: true),
                    TotalBudgetApprovedPerCategory = table.Column<decimal>(nullable: true),
                    TotalCategoryBudgetDemand = table.Column<decimal>(nullable: true),
                    TotalOpexImpactPerCategory = table.Column<decimal>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectPlanBudgetBenefits", x => new { x.Year, x.ProjectId, x.CompanyId, x.CostCategory });
                    table.ForeignKey(
                        name: "FK_ProjectPlanBudgetBenefits_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectPlanBudgetBenefits_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectStageGate",
                columns: table => new
                {
                    CompanyMethodologyStageId = table.Column<string>(nullable: false),
                    ProjectId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    ActualEndDate = table.Column<DateTime>(nullable: true),
                    ActualStartDate = table.Column<DateTime>(nullable: true),
                    BriefNote = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    PlannedEndDate = table.Column<DateTime>(nullable: true),
                    PlannedStartDate = table.Column<DateTime>(nullable: true),
                    ProjectStageGateApprovedBudgetCapex = table.Column<decimal>(nullable: true),
                    ProjectStageGateApprovedBudgetOpex = table.Column<decimal>(nullable: true),
                    ProjectStageGateApprovedBudgetRevex = table.Column<decimal>(nullable: true),
                    ProjectStageGateDurationDays = table.Column<decimal>(nullable: true),
                    TotalProjectStageGateApprovedBudget = table.Column<decimal>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStageGate", x => new { x.CompanyMethodologyStageId, x.ProjectId, x.CompanyId });
                    table.ForeignKey(
                        name: "FK_ProjectStageGate_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectStageGate_CompanyMethodologyStages_CompanyMethodologyStageId",
                        column: x => x.CompanyMethodologyStageId,
                        principalTable: "CompanyMethodologyStages",
                        principalColumn: "CompanyMethodologyStageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectStageGate_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUnitsPermitted", x => new { x.ResourceId, x.CompanyId, x.BusinessUnitId });
                    table.ForeignKey(
                        name: "FK_BusinessUnitsPermitted_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BUPermitted_BUPermitted_BUPermittedResourceId_BUPermittedCompanyId_BUPermittedBusinessUnitId",
                        columns: x => new { x.BusinessUnitPermittedResourceId, x.BusinessUnitPermittedCompanyId, x.BusinessUnitPermittedBusinessUnitId },
                        principalTable: "BusinessUnitsPermitted",
                        principalColumns: new[] { "ResourceId", "CompanyId", "BusinessUnitId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Domains",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    BusinessUnitId = table.Column<string>(nullable: true),
                    BusinessUnitPermittedBusinessUnitId = table.Column<string>(nullable: true),
                    BusinessUnitPermittedCompanyId = table.Column<string>(nullable: true),
                    BusinessUnitPermittedResourceId = table.Column<string>(nullable: true),
                    CompanyId = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    DivisionOrDomainName = table.Column<string>(nullable: true),
                    DomainCode = table.Column<string>(nullable: true),
                    HeadOfDomain = table.Column<string>(nullable: true),
                    NodeId = table.Column<string>(nullable: true),
                    ResourceCompanyId = table.Column<string>(nullable: true),
                    ResourceId = table.Column<string>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Domains_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Domains_BUPermitted_BUPermittedResourceId_BUPermittedCompanyId_BUPermittedBusinessUnitId",
                        columns: x => new { x.BusinessUnitPermittedResourceId, x.BusinessUnitPermittedCompanyId, x.BusinessUnitPermittedBusinessUnitId },
                        principalTable: "BusinessUnitsPermitted",
                        principalColumns: new[] { "ResourceId", "CompanyId", "BusinessUnitId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BusinessUnits",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    BusinessUnitCode = table.Column<string>(nullable: true),
                    BusinessUnitName = table.Column<string>(nullable: true),
                    CompanyId = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    HeadOfBusinessUnit = table.Column<string>(nullable: true),
                    NodeId = table.Column<string>(nullable: true),
                    ResourceCompanyId = table.Column<string>(nullable: true),
                    ResourceId = table.Column<string>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessUnits_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
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
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomainsPermitted", x => new { x.ResourceId, x.CompanyId, x.DomainId });
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    CompanyId = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    HasConfirmEmail = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    ResourceId = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectManagementRanks",
                columns: table => new
                {
                    ProjectManagementRankId = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    ProjectFinanceContactUserId = table.Column<string>(nullable: true),
                    ProjectId = table.Column<string>(nullable: false),
                    ProjectManagerUserId = table.Column<string>(nullable: false),
                    ProjectOwnerUserId = table.Column<string>(nullable: true),
                    ProjectPrimaryContactUserId = table.Column<string>(nullable: true),
                    ProjectSeniorManagerUserId = table.Column<string>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectManagementRanks", x => x.ProjectManagementRankId);
                    table.ForeignKey(
                        name: "FK_ProjectManagementRanks_AspNetUsers_ProjectFinanceContactUserId",
                        column: x => x.ProjectFinanceContactUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectManagementRanks_AspNetUsers_ProjectManagerUserId",
                        column: x => x.ProjectManagerUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectManagementRanks_AspNetUsers_ProjectOwnerUserId",
                        column: x => x.ProjectOwnerUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectManagementRanks_AspNetUsers_ProjectPrimaryContactUserId",
                        column: x => x.ProjectPrimaryContactUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectManagementRanks_AspNetUsers_ProjectSeniorManagerUserId",
                        column: x => x.ProjectSeniorManagerUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    CompanyId = table.Column<string>(nullable: false),
                    ResourceId = table.Column<string>(nullable: false),
                    AddedBy = table.Column<string>(nullable: true),
                    Agency = table.Column<string>(nullable: true),
                    AppUserRole = table.Column<string>(nullable: false),
                    AvatarImage = table.Column<byte[]>(nullable: true),
                    Billable = table.Column<bool>(nullable: false),
                    BusinessUnit = table.Column<string>(nullable: true),
                    ContractedHours = table.Column<decimal>(nullable: true),
                    CurrentPlatform = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    Domain = table.Column<string>(nullable: true),
                    EmployeeJobTitle = table.Column<string>(nullable: true),
                    EmployeeRef = table.Column<string>(nullable: true),
                    EmployeeType = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    IdentityId = table.Column<string>(nullable: true),
                    IsDisabled = table.Column<bool>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    LocationName = table.Column<string>(nullable: true),
                    PlatformLead = table.Column<string>(nullable: true),
                    ProjectId = table.Column<string>(nullable: true),
                    ResourceContractEffortInPercentage = table.Column<decimal>(nullable: true),
                    ResourceEmailAddress = table.Column<string>(nullable: false),
                    ResourceEndDate = table.Column<DateTime>(nullable: true),
                    ResourceManagerId = table.Column<string>(nullable: true),
                    ResourceNumber = table.Column<string>(nullable: true),
                    ResourceRateCardId = table.Column<string>(nullable: true),
                    ResourceStartDate = table.Column<DateTime>(nullable: true),
                    ResourceType = table.Column<string>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => new { x.CompanyId, x.ResourceId });
                    table.ForeignKey(
                        name: "FK_Resources_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resources_AspNetUsers_IdentityId",
                        column: x => x.IdentityId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resources_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resources_CompanyRateCards_ResourceRateCardId",
                        column: x => x.ResourceRateCardId,
                        principalTable: "CompanyRateCards",
                        principalColumn: "CompanyRateCardId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActionDateTime = table.Column<DateTime>(nullable: false),
                    LastDateTimeModified = table.Column<DateTime>(nullable: true),
                    LastResourceModifiedId = table.Column<string>(nullable: true),
                    LastUserModifiedId = table.Column<string>(nullable: true),
                    NewUpdate = table.Column<string>(nullable: true),
                    OldUpdate = table.Column<string>(nullable: true),
                    OriginalDateTimeCreated = table.Column<DateTime>(nullable: true),
                    OriginalResourceCreatedId = table.Column<string>(nullable: true),
                    OriginalUserCreatedId = table.Column<string>(nullable: true),
                    ProjectId = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    UpdatedByResourceId = table.Column<string>(nullable: false),
                    UpdatedByUserCompanyId = table.Column<string>(nullable: false),
                    UpdatedByUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifications_Resources_UpdatedByUserCompanyId_LastResourceModifiedId",
                        columns: x => new { x.UpdatedByUserCompanyId, x.LastResourceModifiedId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifications_Resources_UpdatedByUserCompanyId_OriginalResourceCreatedId",
                        columns: x => new { x.UpdatedByUserCompanyId, x.OriginalResourceCreatedId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifications_Resources_UpdatedByUserCompanyId_UpdatedByResourceId",
                        columns: x => new { x.UpdatedByUserCompanyId, x.UpdatedByResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    DomainId = table.Column<string>(nullable: true),
                    DomainPermittedCompanyId = table.Column<string>(nullable: true),
                    DomainPermittedDomainId = table.Column<string>(nullable: true),
                    DomainPermittedResourceId = table.Column<string>(nullable: true),
                    HeadOfPortfolio = table.Column<string>(nullable: true),
                    NodeId = table.Column<string>(nullable: true),
                    PortfolioCode = table.Column<string>(nullable: true),
                    PortfolioName = table.Column<string>(nullable: true),
                    ResourceCompanyId = table.Column<string>(nullable: true),
                    ResourceId = table.Column<string>(nullable: true),
                    UniquePortfolioRef = table.Column<string>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Portfolios_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Portfolios_Domains_DomainId",
                        column: x => x.DomainId,
                        principalTable: "Domains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Portfolios_Resources_ResourceCompanyId_ResourceId",
                        columns: x => new { x.ResourceCompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Portfolios_DomainsPermitted_DomainPermittedResourceId_DomainPermittedCompanyId_DomainPermittedDomainId",
                        columns: x => new { x.DomainPermittedResourceId, x.DomainPermittedCompanyId, x.DomainPermittedDomainId },
                        principalTable: "DomainsPermitted",
                        principalColumns: new[] { "ResourceId", "CompanyId", "DomainId" },
                        onDelete: ReferentialAction.Restrict);
                });

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
                    Id = table.Column<string>(nullable: true),
                    NodeId = table.Column<string>(nullable: true),
                    ProjectPermittedCompanyId = table.Column<string>(nullable: true),
                    ProjectPermittedProjectId = table.Column<string>(nullable: true),
                    ProjectPermittedResourceId = table.Column<string>(nullable: true),
                    ProjectPermittedUserId = table.Column<string>(nullable: true),
                    ReadWritePermission = table.Column<bool>(nullable: false),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsPermitted", x => new { x.ResourceId, x.ProjectId, x.CompanyId, x.UserId });
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
                        name: "FK_ProjectsPermitted_ProjectsPermitted_PPResourceId_PPProjectId_PPCompanyId_ProjectPermittedUserId",
                        columns: x => new { x.ProjectPermittedResourceId, x.ProjectPermittedProjectId, x.ProjectPermittedCompanyId, x.ProjectPermittedUserId },
                        principalTable: "ProjectsPermitted",
                        principalColumns: new[] { "ResourceId", "ProjectId", "CompanyId", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResourceEffortSummaries",
                columns: table => new
                {
                    ResourceId = table.Column<string>(nullable: false),
                    ProjectId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    ResourceEffortSummaryId = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceEffortSummaries", x => new { x.ResourceId, x.ProjectId, x.CompanyId });
                    table.UniqueConstraint("AK_ResourceEffortSummaries_ResourceEffortSummaryId", x => x.ResourceEffortSummaryId);
                    table.ForeignKey(
                        name: "FK_ResourceEffortSummaries_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResourceEffortSummaries_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResourceEffortSummaries_Resources_CompanyId_ResourceId",
                        columns: x => new { x.CompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResourceHolidaysBooked",
                columns: table => new
                {
                    ResourceId = table.Column<string>(nullable: false),
                    TimesheetCalendarTsId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    ApproverFeedBackNote = table.Column<string>(nullable: true),
                    FridayHolidayHours = table.Column<decimal>(nullable: true),
                    HolidayStatus = table.Column<string>(nullable: true),
                    MondayHolidayHours = table.Column<decimal>(nullable: true),
                    ResourceFeedBackNote = table.Column<string>(nullable: true),
                    ResourceHolidayBookedId = table.Column<string>(nullable: false),
                    SaturdayHolidayHours = table.Column<decimal>(nullable: true),
                    SundayHolidayHours = table.Column<decimal>(nullable: true),
                    ThursdayHolidayHours = table.Column<decimal>(nullable: true),
                    TimesheetCalendarId = table.Column<int>(nullable: true),
                    TuesdayHolidayHours = table.Column<decimal>(nullable: true),
                    WednesdayHolidayHours = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceHolidaysBooked", x => new { x.ResourceId, x.TimesheetCalendarTsId, x.CompanyId });
                    table.UniqueConstraint("AK_ResourceHolidaysBooked_ResourceHolidayBookedId", x => x.ResourceHolidayBookedId);
                    table.ForeignKey(
                        name: "FK_ResourceHolidaysBooked_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResourceHolidaysBooked_TimesheetCalendars_TimesheetCalendarId",
                        column: x => x.TimesheetCalendarId,
                        principalTable: "TimesheetCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResourceHolidaysBooked_Resources_CompanyId_ResourceId",
                        columns: x => new { x.CompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResourceWorkTimesheets",
                columns: table => new
                {
                    ResourceId = table.Column<string>(nullable: false),
                    TimesheetCalendarTsId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    ProjectId = table.Column<string>(nullable: false),
                    ForecastTaskId = table.Column<string>(nullable: false),
                    ApproverFeedBackNote = table.Column<string>(nullable: true),
                    OvertimeFridayBillableHours = table.Column<decimal>(nullable: true),
                    OvertimeFridayNonBillableHours = table.Column<decimal>(nullable: true),
                    OvertimeMondayBillableHours = table.Column<decimal>(nullable: true),
                    OvertimeMondayNonBillableHours = table.Column<decimal>(nullable: true),
                    OvertimeSaturdayBillableHours = table.Column<decimal>(nullable: true),
                    OvertimeSaturdayNonBillableHours = table.Column<decimal>(nullable: true),
                    OvertimeSundayBillableHours = table.Column<decimal>(nullable: true),
                    OvertimeSundayNonBillableHours = table.Column<decimal>(nullable: true),
                    OvertimeThursdayBillableHours = table.Column<decimal>(nullable: true),
                    OvertimeThursdayNonBillableHours = table.Column<decimal>(nullable: true),
                    OvertimeTuesdayBillableHours = table.Column<decimal>(nullable: true),
                    OvertimeTuesdayNonBillableHours = table.Column<decimal>(nullable: true),
                    OvertimeWednesdayBillableHours = table.Column<decimal>(nullable: true),
                    OvertimeWednesdayNonBillableHours = table.Column<decimal>(nullable: true),
                    ResourceFeedBackNote = table.Column<string>(nullable: true),
                    ResourceWorkTimesheetId = table.Column<string>(nullable: false),
                    StandardDayFridayBillableHours = table.Column<decimal>(nullable: true),
                    StandardDayFridayNonBillableHours = table.Column<decimal>(nullable: true),
                    StandardDayMondayBillableHours = table.Column<decimal>(nullable: true),
                    StandardDayMondayNonBillableHours = table.Column<decimal>(nullable: true),
                    StandardDaySaturdayBillableHours = table.Column<decimal>(nullable: true),
                    StandardDaySaturdayNonBillableHours = table.Column<decimal>(nullable: true),
                    StandardDaySundayBillableHours = table.Column<decimal>(nullable: true),
                    StandardDaySundayNonBillableHours = table.Column<decimal>(nullable: true),
                    StandardDayThursdayBillableHours = table.Column<decimal>(nullable: true),
                    StandardDayThursdayNonBillableHours = table.Column<decimal>(nullable: true),
                    StandardDayTuesdayBillableHours = table.Column<decimal>(nullable: true),
                    StandardDayTuesdayNonBillableHours = table.Column<decimal>(nullable: true),
                    StandardDayWednesdayBillableHours = table.Column<decimal>(nullable: true),
                    StandardDayWednesdayNonBillableHours = table.Column<decimal>(nullable: true),
                    TimesheetCalendarId = table.Column<int>(nullable: true),
                    TimesheetStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceWorkTimesheets", x => new { x.ResourceId, x.TimesheetCalendarTsId, x.CompanyId, x.ProjectId, x.ForecastTaskId });
                    table.UniqueConstraint("AK_ResourceWorkTimesheets_ResourceWorkTimesheetId", x => x.ResourceWorkTimesheetId);
                    table.ForeignKey(
                        name: "FK_ResourceWorkTimesheets_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResourceWorkTimesheets_ForecastTasks_ForecastTaskId",
                        column: x => x.ForecastTaskId,
                        principalTable: "ForecastTasks",
                        principalColumn: "ForecastTaskId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResourceWorkTimesheets_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResourceWorkTimesheets_TimesheetCalendars_TimesheetCalendarId",
                        column: x => x.TimesheetCalendarId,
                        principalTable: "TimesheetCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResourceWorkTimesheets_Resources_CompanyId_ResourceId",
                        columns: x => new { x.CompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserNotifications",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    NotificationId = table.Column<int>(nullable: false),
                    IsRead = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNotifications", x => new { x.UserId, x.NotificationId });
                    table.UniqueConstraint("AK_UserNotifications_NotificationId_UserId", x => new { x.NotificationId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserNotifications_Notifications_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserNotifications_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
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
                name: "Programmes",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AuthorisedYesOrNo = table.Column<bool>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    DeliveryDirector = table.Column<string>(nullable: true),
                    DeliveryManager = table.Column<string>(nullable: true),
                    NextYearIndicator = table.Column<string>(nullable: true),
                    NodeId = table.Column<string>(nullable: true),
                    PortfolioId = table.Column<string>(nullable: true),
                    PortfolioPermittedCompanyId = table.Column<string>(nullable: true),
                    PortfolioPermittedPortfolioId = table.Column<string>(nullable: true),
                    PortfolioPermittedResourceId = table.Column<string>(nullable: true),
                    ProgramEndDate = table.Column<DateTime>(nullable: true),
                    ProgramStartDate = table.Column<DateTime>(nullable: true),
                    ProgrammeCode = table.Column<string>(nullable: true),
                    ProgrammeLead = table.Column<string>(nullable: true),
                    ProgrammeManager = table.Column<string>(nullable: true),
                    ProgrammeName = table.Column<string>(nullable: true),
                    ResourceCompanyId = table.Column<string>(nullable: true),
                    ResourceId = table.Column<string>(nullable: true),
                    Sponsor = table.Column<string>(nullable: true),
                    UniqueProgrammeRef = table.Column<string>(nullable: true),
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
                    UserModifiedResourceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programmes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Programmes_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Programmes_Portfolios_PortfolioId",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Programmes_Resources_ResourceCompanyId_ResourceId",
                        columns: x => new { x.ResourceCompanyId, x.ResourceId },
                        principalTable: "Resources",
                        principalColumns: new[] { "CompanyId", "ResourceId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Programmes_PortfoliosPermitted_PortfolioPermittedResourceId_PPCompanyId_PPPortfolioId",
                        columns: x => new { x.PortfolioPermittedResourceId, x.PortfolioPermittedCompanyId, x.PortfolioPermittedPortfolioId },
                        principalTable: "PortfoliosPermitted",
                        principalColumns: new[] { "ResourceId", "CompanyId", "PortfolioId" },
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
                    UserCreatedEmail = table.Column<string>(nullable: true),
                    UserCreatedId = table.Column<string>(nullable: true),
                    UserCreatedResourceId = table.Column<string>(nullable: true),
                    UserModifiedEmail = table.Column<string>(nullable: true),
                    UserModifiedId = table.Column<string>(nullable: true),
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
                        name: "FK_ProgrammesPermitted_ProgrammesPermitted_PPResourceId_PPCompanyId_PPProgrammeId",
                        columns: x => new { x.ProgrammePermittedResourceId, x.ProgrammePermittedCompanyId, x.ProgrammePermittedProgrammeId },
                        principalTable: "ProgrammesPermitted",
                        principalColumns: new[] { "ResourceId", "CompanyId", "ProgrammeId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Actuals_CompanyId",
                table: "Actuals",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Actuals_ProjectId",
                table: "Actuals",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessCustomers_CompanyId",
                table: "BusinessCustomers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnits_CompanyId",
                table: "BusinessUnits",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnits_ResourceCompanyId_ResourceId",
                table: "BusinessUnits",
                columns: new[] { "ResourceCompanyId", "ResourceId" });

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
                name: "IX_BusinessUnitsPermitted_BUPermittedResourceId_BUPermittedCompanyId_BUPermittedBusinessUnitId",
                table: "BusinessUnitsPermitted",
                columns: new[] { "BusinessUnitPermittedResourceId", "BusinessUnitPermittedCompanyId", "BusinessUnitPermittedBusinessUnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyMethodologies_CompanyId",
                table: "CompanyMethodologies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyMethodologyStages_CompanyId",
                table: "CompanyMethodologyStages",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyMethodologyStages_CompanyMethodologyId",
                table: "CompanyMethodologyStages",
                column: "CompanyMethodologyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRateCards_CompanyId",
                table: "CompanyRateCards",
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
                name: "IX_Domains_BusinessUnitPermittedResourceId_BusinessUnitPermittedCompanyId_BusinessUnitPermittedBusinessUnitId",
                table: "Domains",
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
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId_ResourceId",
                table: "AspNetUsers",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_ForecastTasks_TimesheetCalendarId",
                table: "ForecastTasks",
                column: "TimesheetCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_ProjectId",
                table: "Notifications",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UpdatedByUserCompanyId_LastResourceModifiedId",
                table: "Notifications",
                columns: new[] { "UpdatedByUserCompanyId", "LastResourceModifiedId" });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UpdatedByUserCompanyId_OriginalResourceCreatedId",
                table: "Notifications",
                columns: new[] { "UpdatedByUserCompanyId", "OriginalResourceCreatedId" });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UpdatedByUserCompanyId_UpdatedByResourceId",
                table: "Notifications",
                columns: new[] { "UpdatedByUserCompanyId", "UpdatedByResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_Platforms_CompanyId",
                table: "Platforms",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_CompanyId",
                table: "Portfolios",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_DomainId",
                table: "Portfolios",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_ResourceCompanyId_ResourceId",
                table: "Portfolios",
                columns: new[] { "ResourceCompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_DomainPermittedResourceId_DomainPermittedCompanyId_DomainPermittedDomainId",
                table: "Portfolios",
                columns: new[] { "DomainPermittedResourceId", "DomainPermittedCompanyId", "DomainPermittedDomainId" });

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
                name: "IX_Programmes_CompanyId",
                table: "Programmes",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Programmes_PortfolioId",
                table: "Programmes",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_Programmes_ResourceCompanyId_ResourceId",
                table: "Programmes",
                columns: new[] { "ResourceCompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_Programmes_PortfolioPermittedResourceId_PortfolioPermittedCompanyId_PortfolioPermittedPortfolioId",
                table: "Programmes",
                columns: new[] { "PortfolioPermittedResourceId", "PortfolioPermittedCompanyId", "PortfolioPermittedPortfolioId" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Projects_BusinessCustomerId",
                table: "Projects",
                column: "BusinessCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_BusinessUnitId",
                table: "Projects",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CompanyId",
                table: "Projects",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DomainId",
                table: "Projects",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_PortfolioId",
                table: "Projects",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProgrammeId",
                table: "Projects",
                column: "ProgrammeId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ResourceCompanyId_ResourceId",
                table: "Projects",
                columns: new[] { "ResourceCompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_PortfolioPermittedResourceId_PortfolioPermittedCompanyId_PortfolioPermittedPortfolioId",
                table: "Projects",
                columns: new[] { "PortfolioPermittedResourceId", "PortfolioPermittedCompanyId", "PortfolioPermittedPortfolioId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectManagementRanks_ProjectFinanceContactUserId",
                table: "ProjectManagementRanks",
                column: "ProjectFinanceContactUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectManagementRanks_ProjectManagerUserId",
                table: "ProjectManagementRanks",
                column: "ProjectManagerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectManagementRanks_ProjectOwnerUserId",
                table: "ProjectManagementRanks",
                column: "ProjectOwnerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectManagementRanks_ProjectPrimaryContactUserId",
                table: "ProjectManagementRanks",
                column: "ProjectPrimaryContactUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectManagementRanks_ProjectSeniorManagerUserId",
                table: "ProjectManagementRanks",
                column: "ProjectSeniorManagerUserId");

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

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPlanBudgetBenefits_CompanyId",
                table: "ProjectPlanBudgetBenefits",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPlanBudgetBenefits_ProjectId",
                table: "ProjectPlanBudgetBenefits",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectStageGate_CompanyId",
                table: "ProjectStageGate",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectStageGate_ProjectId",
                table: "ProjectStageGate",
                column: "ProjectId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReconciledActuals_CompanyId",
                table: "ReconciledActuals",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ReconciledActuals_ForecastTaskId",
                table: "ReconciledActuals",
                column: "ForecastTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_ReconciledActuals_ProjectId",
                table: "ReconciledActuals",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_IdentityId",
                table: "Resources",
                column: "IdentityId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_ProjectId",
                table: "Resources",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_ResourceRateCardId",
                table: "Resources",
                column: "ResourceRateCardId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceEffortSummaries_ProjectId",
                table: "ResourceEffortSummaries",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceEffortSummaries_CompanyId_ResourceId",
                table: "ResourceEffortSummaries",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_ResourceHolidaysBooked_TimesheetCalendarId",
                table: "ResourceHolidaysBooked",
                column: "TimesheetCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceHolidaysBooked_CompanyId_ResourceId",
                table: "ResourceHolidaysBooked",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_ResourceWorkTimesheets_ForecastTaskId",
                table: "ResourceWorkTimesheets",
                column: "ForecastTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceWorkTimesheets_ProjectId",
                table: "ResourceWorkTimesheets",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceWorkTimesheets_TimesheetCalendarId",
                table: "ResourceWorkTimesheets",
                column: "TimesheetCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceWorkTimesheets_CompanyId_ResourceId",
                table: "ResourceWorkTimesheets",
                columns: new[] { "CompanyId", "ResourceId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReconciledActuals_Projects_ProjectId",
                table: "ReconciledActuals",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReconciledActuals_Actuals_ActualId",
                table: "ReconciledActuals",
                column: "ActualId",
                principalTable: "Actuals",
                principalColumn: "ActualId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Resources_ResourceCompanyId_ResourceId",
                table: "Projects",
                columns: new[] { "ResourceCompanyId", "ResourceId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_BusinessUnits_BusinessUnitId",
                table: "Projects",
                column: "BusinessUnitId",
                principalTable: "BusinessUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Domains_DomainId",
                table: "Projects",
                column: "DomainId",
                principalTable: "Domains",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Portfolios_PortfolioId",
                table: "Projects",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_PortfoliosPermitted_PortfolioPermittedResourceId_PortfolioPermittedCompanyId_PortfolioPermittedPortfolioId",
                table: "Projects",
                columns: new[] { "PortfolioPermittedResourceId", "PortfolioPermittedCompanyId", "PortfolioPermittedPortfolioId" },
                principalTable: "PortfoliosPermitted",
                principalColumns: new[] { "ResourceId", "CompanyId", "PortfolioId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Programmes_ProgrammeId",
                table: "Projects",
                column: "ProgrammeId",
                principalTable: "Programmes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ProjectManagementRanks_ProjectManagementRankId",
                table: "Projects",
                column: "ProjectManagementRankId",
                principalTable: "ProjectManagementRanks",
                principalColumn: "ProjectManagementRankId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessUnitsPermitted_AspNetUsers_AppUserId",
                table: "BusinessUnitsPermitted",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessUnitsPermitted_Resources_CompanyId_ResourceId",
                table: "BusinessUnitsPermitted",
                columns: new[] { "CompanyId", "ResourceId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessUnitsPermitted_BusinessUnits_BusinessUnitId",
                table: "BusinessUnitsPermitted",
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
                name: "FK_Domains_BusinessUnits_BusinessUnitId",
                table: "Domains",
                column: "BusinessUnitId",
                principalTable: "BusinessUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessUnits_Resources_ResourceCompanyId_ResourceId",
                table: "BusinessUnits",
                columns: new[] { "ResourceCompanyId", "ResourceId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DomainsPermitted_AspNetUsers_AppUserId",
                table: "DomainsPermitted",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DomainsPermitted_Resources_CompanyId_ResourceId",
                table: "DomainsPermitted",
                columns: new[] { "CompanyId", "ResourceId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Resources_CompanyId_ResourceId",
                table: "AspNetUsers",
                columns: new[] { "CompanyId", "ResourceId" },
                principalTable: "Resources",
                principalColumns: new[] { "CompanyId", "ResourceId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessUnitsPermitted_AspNetUsers_AppUserId",
                table: "BusinessUnitsPermitted");

            migrationBuilder.DropForeignKey(
                name: "FK_DomainsPermitted_AspNetUsers_AppUserId",
                table: "DomainsPermitted");

            migrationBuilder.DropForeignKey(
                name: "FK_PortfoliosPermitted_AspNetUsers_AppUserId",
                table: "PortfoliosPermitted");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectManagementRanks_AspNetUsers_ProjectFinanceContactUserId",
                table: "ProjectManagementRanks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectManagementRanks_AspNetUsers_ProjectManagerUserId",
                table: "ProjectManagementRanks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectManagementRanks_AspNetUsers_ProjectOwnerUserId",
                table: "ProjectManagementRanks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectManagementRanks_AspNetUsers_ProjectPrimaryContactUserId",
                table: "ProjectManagementRanks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectManagementRanks_AspNetUsers_ProjectSeniorManagerUserId",
                table: "ProjectManagementRanks");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_AspNetUsers_IdentityId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessCustomers_Companies_CompanyId",
                table: "BusinessCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessUnits_Companies_CompanyId",
                table: "BusinessUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessUnitsPermitted_Companies_CompanyId",
                table: "BusinessUnitsPermitted");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyRateCards_Companies_CompanyId",
                table: "CompanyRateCards");

            migrationBuilder.DropForeignKey(
                name: "FK_Domains_Companies_CompanyId",
                table: "Domains");

            migrationBuilder.DropForeignKey(
                name: "FK_DomainsPermitted_Companies_CompanyId",
                table: "DomainsPermitted");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Companies_CompanyId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_PortfoliosPermitted_Companies_CompanyId",
                table: "PortfoliosPermitted");

            migrationBuilder.DropForeignKey(
                name: "FK_Programmes_Companies_CompanyId",
                table: "Programmes");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Companies_CompanyId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Companies_CompanyId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Projects_ProjectId",
                table: "Resources");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CurrencySymbols");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "ProgrammesPermitted");

            migrationBuilder.DropTable(
                name: "ProjectsPermitted");

            migrationBuilder.DropTable(
                name: "ProjectPlanBudgetBenefits");

            migrationBuilder.DropTable(
                name: "ProjectStageGate");

            migrationBuilder.DropTable(
                name: "ReconciledActuals");

            migrationBuilder.DropTable(
                name: "ResourceEffortSummaries");

            migrationBuilder.DropTable(
                name: "ResourceHolidaysBooked");

            migrationBuilder.DropTable(
                name: "ResourceWorkTimesheets");

            migrationBuilder.DropTable(
                name: "UserNotifications");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CompanyMethodologyStages");

            migrationBuilder.DropTable(
                name: "Actuals");

            migrationBuilder.DropTable(
                name: "ForecastTasks");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "CompanyMethodologies");

            migrationBuilder.DropTable(
                name: "TimesheetCalendars");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "BusinessCustomers");

            migrationBuilder.DropTable(
                name: "Programmes");

            migrationBuilder.DropTable(
                name: "ProjectManagementRanks");

            migrationBuilder.DropTable(
                name: "PortfoliosPermitted");

            migrationBuilder.DropTable(
                name: "Portfolios");

            migrationBuilder.DropTable(
                name: "DomainsPermitted");

            migrationBuilder.DropTable(
                name: "Domains");

            migrationBuilder.DropTable(
                name: "BusinessUnitsPermitted");

            migrationBuilder.DropTable(
                name: "BusinessUnits");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "CompanyRateCards");
        }
    }
}
