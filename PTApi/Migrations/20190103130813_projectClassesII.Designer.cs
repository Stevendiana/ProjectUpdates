using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PTApi.Data;
using System;

namespace PTApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190103130813_projectClassesII")]
    partial class projectClassesII
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Actual", b =>
                {
                    b.Property<string>("ActualId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountingCode");

                    b.Property<string>("ActualCode");

                    b.Property<string>("ActualCostCategory");

                    b.Property<byte>("ActualMonth");

                    b.Property<string>("ActualProjectCode")
                        .IsRequired();

                    b.Property<string>("ActualResourceName");

                    b.Property<long>("ActualYear");

                    b.Property<string>("CompanyCode");

                    b.Property<string>("CompanyId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Description");

                    b.Property<string>("DocumentDate");

                    b.Property<string>("ExpenditureClass");

                    b.Property<string>("ExpenditureType");

                    b.Property<string>("ExternalVendorNumber");

                    b.Property<string>("InvoiceNumber");

                    b.Property<string>("JournalComments");

                    b.Property<string>("MiAccountDescription");

                    b.Property<string>("ProjectCostCode");

                    b.Property<string>("ProjectId");

                    b.Property<string>("ProjectName");

                    b.Property<string>("PurchaseOrderDetail");

                    b.Property<decimal?>("ReportingAmount")
                        .IsRequired();

                    b.Property<string>("ReportingCurrency");

                    b.Property<string>("Source");

                    b.Property<decimal?>("TransactionAmount")
                        .IsRequired();

                    b.Property<string>("TransactionCurrency")
                        .IsRequired();

                    b.Property<DateTime?>("TransactionDate");

                    b.Property<string>("UploadBatchNumber");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.Property<string>("VendorName");

                    b.HasKey("ActualId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Actuals");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.BusinessCustomer", b =>
                {
                    b.Property<string>("BusinessCustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BusinessCustomerAddressI");

                    b.Property<string>("BusinessCustomerAddressII");

                    b.Property<string>("BusinessCustomerAddressIII");

                    b.Property<string>("BusinessCustomerAddressIV");

                    b.Property<string>("BusinessCustomerName");

                    b.Property<string>("BusinessCustomerReg");

                    b.Property<string>("CompanyId")
                        .IsRequired();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Industry");

                    b.Property<string>("Sector");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("BusinessCustomerId");

                    b.HasIndex("CompanyId");

                    b.ToTable("BusinessCustomers");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.BusinessUnit", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BusinessUnitCode");

                    b.Property<string>("BusinessUnitName");

                    b.Property<string>("CompanyId")
                        .IsRequired();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("HeadOfBusinessUnit");

                    b.Property<string>("NodeId");

                    b.Property<string>("ResourceCompanyId");

                    b.Property<string>("ResourceId");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ResourceCompanyId", "ResourceId");

                    b.ToTable("BusinessUnits");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.BusinessUnitPermitted", b =>
                {
                    b.Property<string>("ResourceId");

                    b.Property<string>("CompanyId");

                    b.Property<string>("BusinessUnitId");

                    b.Property<string>("AppUserId");

                    b.Property<string>("BusinessUnitPermittedBusinessUnitId");

                    b.Property<string>("BusinessUnitPermittedCompanyId");

                    b.Property<string>("BusinessUnitPermittedResourceId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("NodeId");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("ResourceId", "CompanyId", "BusinessUnitId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("BusinessUnitId");

                    b.HasIndex("CompanyId", "ResourceId");

                    b.HasIndex("BusinessUnitPermittedResourceId", "BusinessUnitPermittedCompanyId", "BusinessUnitPermittedBusinessUnitId");

                    b.ToTable("BusinessUnitsPermitted");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ChangeLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChangeId");

                    b.Property<DateTime>("DateChanged");

                    b.Property<string>("EntityName");

                    b.Property<string>("NewValue");

                    b.Property<string>("OldValue");

                    b.Property<string>("PrimaryKeyValue");

                    b.Property<string>("UserCompanyId");

                    b.Property<string>("UserFirstName");

                    b.Property<string>("UserLastName");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("Id");

                    b.ToTable("ChangeLogs");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Company", b =>
                {
                    b.Property<string>("CompanyId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AllowReconciliation");

                    b.Property<string>("CompanyAccountName");

                    b.Property<string>("CompanyAddress");

                    b.Property<string>("CompanyContactEmail");

                    b.Property<int?>("CompanyCurrencyId");

                    b.Property<string>("CompanyCurrentLongName");

                    b.Property<string>("CompanyCurrentShortName");

                    b.Property<byte[]>("CompanyLogo");

                    b.Property<string>("CompanyRef");

                    b.Property<string>("CompanyReg");

                    b.Property<string>("Country");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<bool>("DoEmployeesWorkWeekends");

                    b.Property<string>("FinanceReportingPeriod");

                    b.Property<int>("FinanceReportingYear");

                    b.Property<bool>("FreezeForecast");

                    b.Property<string>("Industry");

                    b.Property<string>("LogoId");

                    b.Property<string>("LogoName");

                    b.Property<string>("LogoUrl");

                    b.Property<int>("RecurringReportingDay");

                    b.Property<string>("ReportingCurrency");

                    b.Property<string>("Sector");

                    b.Property<byte?>("StandardDailyHours");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.Property<string>("VatReg");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.CompanyMethodology", b =>
                {
                    b.Property<string>("CompanyMethodologyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyId")
                        .IsRequired();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("MethodologyName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("MethodologyNotes");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("CompanyMethodologyId");

                    b.HasIndex("CompanyId");

                    b.ToTable("CompanyMethodologies");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.CompanyMethodologyStage", b =>
                {
                    b.Property<string>("CompanyMethodologyStageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyId")
                        .IsRequired();

                    b.Property<string>("CompanyMethodologyId")
                        .IsRequired();

                    b.Property<string>("CompanyMethodologyStageName")
                        .IsRequired();

                    b.Property<string>("CompanyMethodologyStageNumber")
                        .IsRequired();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("MethodologyStageNotes");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("CompanyMethodologyStageId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CompanyMethodologyId");

                    b.ToTable("CompanyMethodologyStages");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.CompanyRateCard", b =>
                {
                    b.Property<string>("CompanyRateCardId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyId")
                        .IsRequired();

                    b.Property<string>("CompanyRateCardCode");

                    b.Property<decimal>("DailyRate");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("EmployeeJobTitleOrGradeOrBand")
                        .IsRequired();

                    b.Property<bool>("IsContractor");

                    b.Property<string>("LocationForGradeOnshoreOffShore")
                        .IsRequired();

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("CompanyRateCardId");

                    b.HasIndex("CompanyId");

                    b.ToTable("CompanyRateCards");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.CurrencySymbol", b =>
                {
                    b.Property<int>("CurrencySymbolId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyCurrencyLongName");

                    b.Property<string>("CompanyCurrencyShortName");

                    b.Property<string>("CompanyCurrencySymbol");

                    b.HasKey("CurrencySymbolId");

                    b.ToTable("CurrencySymbols");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Domain", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BusinessUnitId");

                    b.Property<string>("BusinessUnitPermittedBusinessUnitId");

                    b.Property<string>("BusinessUnitPermittedCompanyId");

                    b.Property<string>("BusinessUnitPermittedResourceId");

                    b.Property<string>("CompanyId")
                        .IsRequired();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("DivisionOrDomainName");

                    b.Property<string>("DomainCode");

                    b.Property<string>("HeadOfDomain");

                    b.Property<string>("NodeId");

                    b.Property<string>("ResourceCompanyId");

                    b.Property<string>("ResourceId");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("Id");

                    b.HasIndex("BusinessUnitId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ResourceCompanyId", "ResourceId");

                    b.HasIndex("BusinessUnitPermittedResourceId", "BusinessUnitPermittedCompanyId", "BusinessUnitPermittedBusinessUnitId");

                    b.ToTable("Domains");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.DomainPermitted", b =>
                {
                    b.Property<string>("ResourceId");

                    b.Property<string>("CompanyId");

                    b.Property<string>("DomainId");

                    b.Property<string>("AppUserId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("NodeId");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("ResourceId", "CompanyId", "DomainId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("DomainId");

                    b.HasIndex("CompanyId", "ResourceId");

                    b.ToTable("DomainsPermitted");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("CompanyId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("HasConfirmEmail");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ResourceId");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("CompanyId", "ResourceId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ForecastTask", b =>
                {
                    b.Property<string>("ForecastTaskId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("AprActualsReconciled");

                    b.Property<DateTime?>("AprEndDate");

                    b.Property<decimal?>("AprForecastAmount");

                    b.Property<decimal?>("AprForecastPreciseDuration");

                    b.Property<DateTime?>("AprStartDate");

                    b.Property<decimal?>("AugActualsReconciled");

                    b.Property<DateTime?>("AugEndDate");

                    b.Property<decimal?>("AugForecastAmount");

                    b.Property<decimal?>("AugForecastPreciseDuration");

                    b.Property<DateTime?>("AugStartDate");

                    b.Property<int?>("BaselinePeriod");

                    b.Property<string>("CompanyId");

                    b.Property<string>("CostCat");

                    b.Property<string>("CostSubCategory");

                    b.Property<string>("CostType");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<decimal?>("DecActualsReconciled");

                    b.Property<DateTime?>("DecEndDate");

                    b.Property<decimal?>("DecForecastAmount");

                    b.Property<decimal?>("DecForecastPreciseDuration");

                    b.Property<DateTime?>("DecStartDate");

                    b.Property<decimal?>("FebActualsReconciled");

                    b.Property<DateTime?>("FebEndDate");

                    b.Property<decimal?>("FebForecastAmount");

                    b.Property<decimal?>("FebForecastPreciseDuration");

                    b.Property<DateTime?>("FebStartDate");

                    b.Property<string>("ForecastCode");

                    b.Property<byte?>("ForecastPeriodType");

                    b.Property<decimal?>("JanActualsReconciled");

                    b.Property<DateTime?>("JanEndDate");

                    b.Property<decimal?>("JanForecastAmount");

                    b.Property<decimal?>("JanForecastPreciseDuration");

                    b.Property<DateTime?>("JanStartDate");

                    b.Property<decimal?>("JulActualsReconciled");

                    b.Property<DateTime?>("JulEndDate");

                    b.Property<decimal?>("JulForecastAmount");

                    b.Property<decimal?>("JulForecastPreciseDuration");

                    b.Property<DateTime?>("JulStartDate");

                    b.Property<decimal?>("JunActualsReconciled");

                    b.Property<DateTime?>("JunEndDate");

                    b.Property<decimal?>("JunForecastAmount");

                    b.Property<decimal?>("JunForecastPreciseDuration");

                    b.Property<DateTime?>("JunStartDate");

                    b.Property<decimal?>("MarActualsReconciled");

                    b.Property<DateTime?>("MarEndDate");

                    b.Property<decimal?>("MarForecastAmount");

                    b.Property<decimal?>("MarForecastPreciseDuration");

                    b.Property<DateTime?>("MarStartDate");

                    b.Property<decimal?>("MaterialQuantityApr");

                    b.Property<decimal?>("MaterialQuantityAug");

                    b.Property<decimal?>("MaterialQuantityDec");

                    b.Property<decimal?>("MaterialQuantityFeb");

                    b.Property<decimal?>("MaterialQuantityJan");

                    b.Property<decimal?>("MaterialQuantityJul");

                    b.Property<decimal?>("MaterialQuantityJun");

                    b.Property<decimal?>("MaterialQuantityMar");

                    b.Property<decimal?>("MaterialQuantityMay");

                    b.Property<decimal?>("MaterialQuantityNov");

                    b.Property<decimal?>("MaterialQuantityOct");

                    b.Property<decimal?>("MaterialQuantitySep");

                    b.Property<decimal?>("MaterialUnitCostApr");

                    b.Property<decimal?>("MaterialUnitCostAug");

                    b.Property<decimal?>("MaterialUnitCostDec");

                    b.Property<decimal?>("MaterialUnitCostFeb");

                    b.Property<decimal?>("MaterialUnitCostJan");

                    b.Property<decimal?>("MaterialUnitCostJul");

                    b.Property<decimal?>("MaterialUnitCostJun");

                    b.Property<decimal?>("MaterialUnitCostMar");

                    b.Property<decimal?>("MaterialUnitCostMay");

                    b.Property<decimal?>("MaterialUnitCostNov");

                    b.Property<decimal?>("MaterialUnitCostOct");

                    b.Property<decimal?>("MaterialUnitCostSep");

                    b.Property<decimal?>("MayActualsReconciled");

                    b.Property<DateTime?>("MayEndDate");

                    b.Property<decimal?>("MayForecastAmount");

                    b.Property<decimal?>("MayForecastPreciseDuration");

                    b.Property<DateTime?>("MayStartDate");

                    b.Property<byte?>("Month");

                    b.Property<decimal?>("NovActualsReconciled");

                    b.Property<DateTime?>("NovEndDate");

                    b.Property<decimal?>("NovForecastAmount");

                    b.Property<decimal?>("NovForecastPreciseDuration");

                    b.Property<DateTime?>("NovStartDate");

                    b.Property<decimal?>("OctActualsReconciled");

                    b.Property<DateTime?>("OctEndDate");

                    b.Property<decimal?>("OctForecastAmount");

                    b.Property<decimal?>("OctForecastPreciseDuration");

                    b.Property<DateTime?>("OctStartDate");

                    b.Property<bool>("Open");

                    b.Property<int?>("Order");

                    b.Property<string>("OrderNumber");

                    b.Property<string>("Parent");

                    b.Property<decimal>("Progress");

                    b.Property<string>("ProjectId");

                    b.Property<string>("ProjectStage");

                    b.Property<string>("ProjectStageRefid");

                    b.Property<string>("ResourceId");

                    b.Property<string>("ResourceName");

                    b.Property<decimal?>("ResourceRateApr");

                    b.Property<decimal?>("ResourceRateAug");

                    b.Property<decimal?>("ResourceRateDec");

                    b.Property<decimal?>("ResourceRateFeb");

                    b.Property<decimal?>("ResourceRateJan");

                    b.Property<decimal?>("ResourceRateJul");

                    b.Property<decimal?>("ResourceRateJun");

                    b.Property<decimal?>("ResourceRateMar");

                    b.Property<decimal?>("ResourceRateMay");

                    b.Property<decimal?>("ResourceRateNov");

                    b.Property<decimal?>("ResourceRateOct");

                    b.Property<decimal?>("ResourceRateSep");

                    b.Property<decimal?>("SepActualsReconciled");

                    b.Property<DateTime?>("SepEndDate");

                    b.Property<decimal?>("SepForecastAmount");

                    b.Property<decimal?>("SepForecastPreciseDuration");

                    b.Property<DateTime?>("SepStartDate");

                    b.Property<string>("SupplierId");

                    b.Property<DateTime?>("TaskEarliestStartDate");

                    b.Property<DateTime?>("TaskLatestndEDate");

                    b.Property<string>("TextTaskCostDescription");

                    b.Property<int?>("TimesheetCalendarId");

                    b.Property<decimal?>("TotalForecastAmount");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.Property<string>("VendorId");

                    b.Property<int?>("Year");

                    b.HasKey("ForecastTaskId");

                    b.HasIndex("SupplierId");

                    b.HasIndex("TimesheetCalendarId");

                    b.HasIndex("CompanyId", "ResourceId");

                    b.ToTable("ForecastTasks");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Owner");

                    b.Property<string>("Text");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ActionDateTime");

                    b.Property<DateTime?>("LastDateTimeModified");

                    b.Property<string>("LastResourceModifiedId");

                    b.Property<string>("LastUserModifiedId");

                    b.Property<string>("NewUpdate");

                    b.Property<string>("OldUpdate");

                    b.Property<DateTime?>("OriginalDateTimeCreated");

                    b.Property<string>("OriginalResourceCreatedId");

                    b.Property<string>("OriginalUserCreatedId");

                    b.Property<string>("ProjectId")
                        .IsRequired();

                    b.Property<string>("Status");

                    b.Property<int>("Type");

                    b.Property<string>("UpdatedByResourceId")
                        .IsRequired();

                    b.Property<string>("UpdatedByUserCompanyId")
                        .IsRequired();

                    b.Property<string>("UpdatedByUserId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UpdatedByUserCompanyId", "LastResourceModifiedId");

                    b.HasIndex("UpdatedByUserCompanyId", "OriginalResourceCreatedId");

                    b.HasIndex("UpdatedByUserCompanyId", "UpdatedByResourceId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Platform", b =>
                {
                    b.Property<string>("PlatformId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyId")
                        .IsRequired();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("HeadOfPlatform");

                    b.Property<string>("PlatformCode");

                    b.Property<string>("PlatformName")
                        .IsRequired();

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("PlatformId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Platforms");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Portfolio", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyId")
                        .IsRequired();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("DomainId");

                    b.Property<string>("DomainPermittedCompanyId");

                    b.Property<string>("DomainPermittedDomainId");

                    b.Property<string>("DomainPermittedResourceId");

                    b.Property<string>("HeadOfPortfolio");

                    b.Property<string>("NodeId");

                    b.Property<string>("PortfolioCode");

                    b.Property<string>("PortfolioName");

                    b.Property<string>("ResourceCompanyId");

                    b.Property<string>("ResourceId");

                    b.Property<string>("UniquePortfolioRef");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("DomainId");

                    b.HasIndex("ResourceCompanyId", "ResourceId");

                    b.HasIndex("DomainPermittedResourceId", "DomainPermittedCompanyId", "DomainPermittedDomainId");

                    b.ToTable("Portfolios");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.PortfolioPermitted", b =>
                {
                    b.Property<string>("ResourceId");

                    b.Property<string>("CompanyId");

                    b.Property<string>("PortfolioId");

                    b.Property<string>("AppUserId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("NodeId");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("ResourceId", "CompanyId", "PortfolioId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("PortfolioId");

                    b.HasIndex("CompanyId", "ResourceId");

                    b.ToTable("PortfoliosPermitted");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Programme", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AuthorisedYesOrNo");

                    b.Property<string>("CompanyId")
                        .IsRequired();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("DeliveryDirector");

                    b.Property<string>("DeliveryManager");

                    b.Property<string>("NextYearIndicator");

                    b.Property<string>("NodeId");

                    b.Property<string>("PortfolioId");

                    b.Property<string>("PortfolioPermittedCompanyId");

                    b.Property<string>("PortfolioPermittedPortfolioId");

                    b.Property<string>("PortfolioPermittedResourceId");

                    b.Property<DateTime?>("ProgramEndDate");

                    b.Property<DateTime?>("ProgramStartDate");

                    b.Property<string>("ProgrammeCode");

                    b.Property<string>("ProgrammeLead");

                    b.Property<string>("ProgrammeManager");

                    b.Property<string>("ProgrammeName");

                    b.Property<string>("ResourceCompanyId");

                    b.Property<string>("ResourceId");

                    b.Property<string>("Sponsor");

                    b.Property<string>("UniqueProgrammeRef");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("PortfolioId");

                    b.HasIndex("ResourceCompanyId", "ResourceId");

                    b.HasIndex("PortfolioPermittedResourceId", "PortfolioPermittedCompanyId", "PortfolioPermittedPortfolioId");

                    b.ToTable("Programmes");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ProgrammePermitted", b =>
                {
                    b.Property<string>("ResourceId");

                    b.Property<string>("CompanyId");

                    b.Property<string>("ProgrammeId");

                    b.Property<string>("AppUserId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NodeId");

                    b.Property<string>("ProgrammePermittedCompanyId");

                    b.Property<string>("ProgrammePermittedProgrammeId");

                    b.Property<string>("ProgrammePermittedResourceId");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("ResourceId", "CompanyId", "ProgrammeId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("ProgrammeId");

                    b.HasIndex("CompanyId", "ResourceId");

                    b.HasIndex("ProgrammePermittedResourceId", "ProgrammePermittedCompanyId", "ProgrammePermittedProgrammeId");

                    b.ToTable("ProgrammesPermitted");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Project", b =>
                {
                    b.Property<string>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountingCode");

                    b.Property<DateTime?>("ActualEndDate");

                    b.Property<DateTime?>("ActualStartDate");

                    b.Property<int?>("BenefitsDurationInYears");

                    b.Property<int?>("BenefitsStartYear");

                    b.Property<string>("BudgetCurrentStatus");

                    b.Property<string>("BusinessAlignment");

                    b.Property<string>("BusinessCustomerId");

                    b.Property<string>("BusinessStrategy");

                    b.Property<string>("BusinessUnitId");

                    b.Property<string>("CapexCostCode");

                    b.Property<string>("CompanyId");

                    b.Property<int?>("CurrentBudgetBadgeVersion");

                    b.Property<string>("CurrentStageGateStatus");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("DomainId");

                    b.Property<string>("FinancialStatus");

                    b.Property<decimal?>("GrandTotalBenefitsAchieved");

                    b.Property<decimal?>("GrandTotalBenefitsExpected");

                    b.Property<decimal?>("GrandTotalBenefitsForecast");

                    b.Property<decimal?>("GrandTotalOpexImpact");

                    b.Property<bool>("IsCanceled");

                    b.Property<string>("NodeId");

                    b.Property<string>("OpexCostCode");

                    b.Property<string>("ParentId");

                    b.Property<decimal?>("PlanGrandTotalCapex");

                    b.Property<decimal?>("PlanGrandTotalOpex");

                    b.Property<decimal?>("PlanGrandTotalRevex");

                    b.Property<string>("PortfolioId");

                    b.Property<string>("PortfolioPermittedCompanyId");

                    b.Property<string>("PortfolioPermittedPortfolioId");

                    b.Property<string>("PortfolioPermittedResourceId");

                    b.Property<string>("ProgrammeId");

                    b.Property<decimal?>("ProjectActualCompletion");

                    b.Property<string>("ProjectAlignment");

                    b.Property<decimal?>("ProjectCPI");

                    b.Property<string>("ProjectCode");

                    b.Property<string>("ProjectCurrentBudgetTrackerId");

                    b.Property<string>("ProjectCustomer");

                    b.Property<decimal?>("ProjectEAC");

                    b.Property<decimal?>("ProjectEarnedValue");

                    b.Property<DateTime?>("ProjectEndDate");

                    b.Property<decimal?>("ProjectEstimateAtCompletion");

                    b.Property<decimal?>("ProjectEstimateToComplete");

                    b.Property<string>("ProjectFinanceContactDisplayName");

                    b.Property<string>("ProjectLifecycleStage");

                    b.Property<string>("ProjectLifecycleStageId");

                    b.Property<string>("ProjectManagementRankId");

                    b.Property<string>("ProjectManagerDisplayName");

                    b.Property<string>("ProjectManagerUserName");

                    b.Property<string>("ProjectName")
                        .IsRequired();

                    b.Property<string>("ProjectObjective");

                    b.Property<string>("ProjectOwnerDisplayName");

                    b.Property<double?>("ProjectPlannedCompletion");

                    b.Property<string>("ProjectPrimaryContactDisplayName");

                    b.Property<string>("ProjectPrioritisation");

                    b.Property<string>("ProjectRef");

                    b.Property<string>("ProjectReportedToDisplayname");

                    b.Property<decimal?>("ProjectSPI");

                    b.Property<DateTime?>("ProjectStartDate");

                    b.Property<string>("ProjectStatus");

                    b.Property<string>("ProjectStrategy");

                    b.Property<decimal?>("ProjectVarianceAtComplete");

                    b.Property<string>("Projectlignment");

                    b.Property<string>("ResourceCompanyId");

                    b.Property<string>("ResourceId");

                    b.Property<string>("RevexCostCode");

                    b.Property<string>("RfqNumber");

                    b.Property<string>("Sponsor");

                    b.Property<decimal?>("TotalActual");

                    b.Property<decimal?>("TotalLifeTimeForecast");

                    b.Property<decimal?>("TotalPlannedValue");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("ProjectId");

                    b.HasIndex("BusinessCustomerId");

                    b.HasIndex("BusinessUnitId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("DomainId");

                    b.HasIndex("PortfolioId");

                    b.HasIndex("ProgrammeId");

                    b.HasIndex("ProjectCurrentBudgetTrackerId");

                    b.HasIndex("ResourceCompanyId", "ResourceId");

                    b.HasIndex("PortfolioPermittedResourceId", "PortfolioPermittedCompanyId", "PortfolioPermittedPortfolioId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ProjectBudget", b =>
                {
                    b.Property<string>("ProjectBudgetId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("AprAmount");

                    b.Property<DateTime?>("AprEndDate");

                    b.Property<decimal?>("AprForecastPreciseDuration");

                    b.Property<DateTime?>("AprStartDate");

                    b.Property<decimal?>("AugAmount");

                    b.Property<DateTime?>("AugEndDate");

                    b.Property<decimal?>("AugForecastPreciseDuration");

                    b.Property<DateTime?>("AugStartDate");

                    b.Property<int?>("BaselinePeriod");

                    b.Property<string>("BudgetCode");

                    b.Property<string>("CompanyId");

                    b.Property<string>("CostCat");

                    b.Property<string>("CostSubCategory");

                    b.Property<string>("CostType");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<decimal?>("DecAmount");

                    b.Property<DateTime?>("DecEndDate");

                    b.Property<decimal?>("DecForecastPreciseDuration");

                    b.Property<DateTime?>("DecStartDate");

                    b.Property<decimal?>("FebAmount");

                    b.Property<DateTime?>("FebEndDate");

                    b.Property<decimal?>("FebForecastPreciseDuration");

                    b.Property<DateTime?>("FebStartDate");

                    b.Property<string>("ForecastCode");

                    b.Property<byte?>("ForecastPeriodType");

                    b.Property<string>("ForecastTaskId");

                    b.Property<decimal?>("JanAmount");

                    b.Property<DateTime?>("JanEndDate");

                    b.Property<decimal?>("JanForecastPreciseDuration");

                    b.Property<DateTime?>("JanStartDate");

                    b.Property<decimal?>("JulAmount");

                    b.Property<DateTime?>("JulEndDate");

                    b.Property<decimal?>("JulForecastPreciseDuration");

                    b.Property<DateTime?>("JulStartDate");

                    b.Property<decimal?>("JunAmount");

                    b.Property<DateTime?>("JunEndDate");

                    b.Property<decimal?>("JunForecastPreciseDuration");

                    b.Property<DateTime?>("JunStartDate");

                    b.Property<decimal?>("MarAmount");

                    b.Property<DateTime?>("MarEndDate");

                    b.Property<decimal?>("MarForecastPreciseDuration");

                    b.Property<DateTime?>("MarStartDate");

                    b.Property<decimal?>("MaterialQuantityApr");

                    b.Property<decimal?>("MaterialQuantityAug");

                    b.Property<decimal?>("MaterialQuantityDec");

                    b.Property<decimal?>("MaterialQuantityFeb");

                    b.Property<decimal?>("MaterialQuantityJan");

                    b.Property<decimal?>("MaterialQuantityJul");

                    b.Property<decimal?>("MaterialQuantityJun");

                    b.Property<decimal?>("MaterialQuantityMar");

                    b.Property<decimal?>("MaterialQuantityMay");

                    b.Property<decimal?>("MaterialQuantityNov");

                    b.Property<decimal?>("MaterialQuantityOct");

                    b.Property<decimal?>("MaterialQuantitySep");

                    b.Property<decimal?>("MaterialUnitCostApr");

                    b.Property<decimal?>("MaterialUnitCostAug");

                    b.Property<decimal?>("MaterialUnitCostDec");

                    b.Property<decimal?>("MaterialUnitCostFeb");

                    b.Property<decimal?>("MaterialUnitCostJan");

                    b.Property<decimal?>("MaterialUnitCostJul");

                    b.Property<decimal?>("MaterialUnitCostJun");

                    b.Property<decimal?>("MaterialUnitCostMar");

                    b.Property<decimal?>("MaterialUnitCostMay");

                    b.Property<decimal?>("MaterialUnitCostNov");

                    b.Property<decimal?>("MaterialUnitCostOct");

                    b.Property<decimal?>("MaterialUnitCostSep");

                    b.Property<decimal?>("MayAmount");

                    b.Property<DateTime?>("MayEndDate");

                    b.Property<decimal?>("MayForecastPreciseDuration");

                    b.Property<DateTime?>("MayStartDate");

                    b.Property<byte?>("Month");

                    b.Property<decimal?>("NovAmount");

                    b.Property<DateTime?>("NovEndDate");

                    b.Property<decimal?>("NovForecastPreciseDuration");

                    b.Property<DateTime?>("NovStartDate");

                    b.Property<decimal?>("OctAmount");

                    b.Property<DateTime?>("OctEndDate");

                    b.Property<decimal?>("OctForecastPreciseDuration");

                    b.Property<DateTime?>("OctStartDate");

                    b.Property<bool>("Open");

                    b.Property<int?>("Order");

                    b.Property<string>("OrderNumber");

                    b.Property<string>("Parent");

                    b.Property<decimal>("Progress");

                    b.Property<string>("ProjectBudgetTrackerId");

                    b.Property<string>("ProjectId");

                    b.Property<string>("ProjectStage");

                    b.Property<string>("ProjectStageRefid");

                    b.Property<string>("ResourceId");

                    b.Property<string>("ResourceName");

                    b.Property<string>("ResourcePerCost");

                    b.Property<decimal?>("ResourceRateApr");

                    b.Property<decimal?>("ResourceRateAug");

                    b.Property<decimal?>("ResourceRateDec");

                    b.Property<decimal?>("ResourceRateFeb");

                    b.Property<decimal?>("ResourceRateJan");

                    b.Property<decimal?>("ResourceRateJul");

                    b.Property<decimal?>("ResourceRateJun");

                    b.Property<decimal?>("ResourceRateMar");

                    b.Property<decimal?>("ResourceRateMay");

                    b.Property<decimal?>("ResourceRateNov");

                    b.Property<decimal?>("ResourceRateOct");

                    b.Property<decimal?>("ResourceRateSep");

                    b.Property<decimal?>("SepAmount");

                    b.Property<DateTime?>("SepEndDate");

                    b.Property<decimal?>("SepForecastPreciseDuration");

                    b.Property<DateTime?>("SepStartDate");

                    b.Property<string>("SupplierId");

                    b.Property<DateTime?>("TaskEarliestStartDate");

                    b.Property<DateTime?>("TaskLatestndEDate");

                    b.Property<string>("TextTaskCostDescription");

                    b.Property<decimal?>("TotalAmount");

                    b.Property<decimal?>("TotalForecastPreciseDuration");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.Property<string>("VendorId");

                    b.Property<int?>("Year");

                    b.HasKey("ProjectBudgetId");

                    b.HasIndex("ProjectBudgetTrackerId");

                    b.HasIndex("SupplierId");

                    b.HasIndex("CompanyId", "ResourceId");

                    b.ToTable("ProjectBudget");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ProjectBudgetTracker", b =>
                {
                    b.Property<string>("ProjectBudgetTrackerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BudgetBadgetStatus");

                    b.Property<int?>("BudgetBadgetVersion");

                    b.Property<DateTime?>("BudgetEndDate");

                    b.Property<DateTime?>("BudgetStartDate");

                    b.Property<string>("CompanyId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("ProjectBudgetTrackerCode");

                    b.Property<string>("ProjectId");

                    b.Property<decimal?>("TotalLifeTimeBudget");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("ProjectBudgetTrackerId");

                    b.ToTable("ProjectBudgetTracker");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ProjectManagementRank", b =>
                {
                    b.Property<string>("ProjectManagementRankId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("ProjectFinanceContactUserId");

                    b.Property<string>("ProjectId")
                        .IsRequired();

                    b.Property<string>("ProjectManagerUserId")
                        .IsRequired();

                    b.Property<string>("ProjectOwnerUserId");

                    b.Property<string>("ProjectPrimaryContactUserId");

                    b.Property<string>("ProjectSeniorManagerUserId");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("ProjectManagementRankId");

                    b.HasIndex("ProjectFinanceContactUserId");

                    b.HasIndex("ProjectManagerUserId");

                    b.HasIndex("ProjectOwnerUserId");

                    b.HasIndex("ProjectPrimaryContactUserId");

                    b.HasIndex("ProjectSeniorManagerUserId");

                    b.ToTable("ProjectManagementRanks");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ProjectPermitted", b =>
                {
                    b.Property<string>("ResourceId");

                    b.Property<string>("ProjectId");

                    b.Property<string>("CompanyId");

                    b.Property<string>("UserId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NodeId");

                    b.Property<string>("ProjectPermittedCompanyId");

                    b.Property<string>("ProjectPermittedProjectId");

                    b.Property<string>("ProjectPermittedResourceId");

                    b.Property<string>("ProjectPermittedUserId");

                    b.Property<bool>("ReadWritePermission");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("ResourceId", "ProjectId", "CompanyId", "UserId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.HasIndex("CompanyId", "ResourceId");

                    b.HasIndex("ProjectPermittedResourceId", "ProjectPermittedProjectId", "ProjectPermittedCompanyId", "ProjectPermittedUserId");

                    b.ToTable("ProjectsPermitted");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ProjectPlanBudgetBenefit", b =>
                {
                    b.Property<int>("Year");

                    b.Property<string>("ProjectId");

                    b.Property<string>("CompanyId");

                    b.Property<string>("CostCategory");

                    b.Property<decimal?>("AprBenefitAchieved");

                    b.Property<decimal?>("AprBenefitExpected");

                    b.Property<decimal?>("AprBenefitForecast");

                    b.Property<decimal?>("AprBudgetApproved");

                    b.Property<decimal?>("AprBudgetDemand");

                    b.Property<decimal?>("AprOpexImpact");

                    b.Property<decimal?>("AugBenefitAchieved");

                    b.Property<decimal?>("AugBenefitExpected");

                    b.Property<decimal?>("AugBenefitForecast");

                    b.Property<decimal?>("AugBudgetApproved");

                    b.Property<decimal?>("AugBudgetDemand");

                    b.Property<decimal?>("AugOpexImpact");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<decimal?>("DecBenefitAchieved");

                    b.Property<decimal?>("DecBenefitExpected");

                    b.Property<decimal?>("DecBenefitForecast");

                    b.Property<decimal?>("DecBudgetApproved");

                    b.Property<decimal?>("DecBudgetDemand");

                    b.Property<decimal?>("DecOpexImpact");

                    b.Property<decimal?>("FebBenefitAchieved");

                    b.Property<decimal?>("FebBenefitExpected");

                    b.Property<decimal?>("FebBenefitForecast");

                    b.Property<decimal?>("FebBudgetApproved");

                    b.Property<decimal?>("FebBudgetDemand");

                    b.Property<decimal?>("FebOpexImpact");

                    b.Property<decimal?>("JanBenefitAchieved");

                    b.Property<decimal?>("JanBenefitExpected");

                    b.Property<decimal?>("JanBenefitForecast");

                    b.Property<decimal?>("JanBudgetApproved");

                    b.Property<decimal?>("JanBudgetDemand");

                    b.Property<decimal?>("JanOpexImpact");

                    b.Property<decimal?>("JulBenefitAchieved");

                    b.Property<decimal?>("JulBenefitExpected");

                    b.Property<decimal?>("JulBenefitForecast");

                    b.Property<decimal?>("JulBudgetApproved");

                    b.Property<decimal?>("JulBudgetDemand");

                    b.Property<decimal?>("JulOpexImpact");

                    b.Property<decimal?>("JunBenefitAchieved");

                    b.Property<decimal?>("JunBenefitExpected");

                    b.Property<decimal?>("JunBenefitForecast");

                    b.Property<decimal?>("JunBudgetApproved");

                    b.Property<decimal?>("JunBudgetDemand");

                    b.Property<decimal?>("JunOpexImpact");

                    b.Property<decimal?>("MarBenefitAchieved");

                    b.Property<decimal?>("MarBenefitExpected");

                    b.Property<decimal?>("MarBenefitForecast");

                    b.Property<decimal?>("MarBudgetApproved");

                    b.Property<decimal?>("MarBudgetDemand");

                    b.Property<decimal?>("MarOpexImpact");

                    b.Property<decimal?>("MayBenefitAchieved");

                    b.Property<decimal?>("MayBenefitExpected");

                    b.Property<decimal?>("MayBenefitForecast");

                    b.Property<decimal?>("MayBudgetApproved");

                    b.Property<decimal?>("MayBudgetDemand");

                    b.Property<decimal?>("MayOpexImpact");

                    b.Property<decimal?>("NovBenefitAchieved");

                    b.Property<decimal?>("NovBenefitExpected");

                    b.Property<decimal?>("NovBenefitForecast");

                    b.Property<decimal?>("NovBudgetApproved");

                    b.Property<decimal?>("NovBudgetDemand");

                    b.Property<decimal?>("NovOpexImpact");

                    b.Property<decimal?>("OctBenefitAchieved");

                    b.Property<decimal?>("OctBenefitExpected");

                    b.Property<decimal?>("OctBenefitForecast");

                    b.Property<decimal?>("OctBudgetApproved");

                    b.Property<decimal?>("OctBudgetDemand");

                    b.Property<decimal?>("OctOpexImpact");

                    b.Property<decimal?>("PlanApr");

                    b.Property<decimal?>("PlanAug");

                    b.Property<decimal?>("PlanCategoryTotal");

                    b.Property<decimal?>("PlanDec");

                    b.Property<decimal?>("PlanFeb");

                    b.Property<decimal?>("PlanJan");

                    b.Property<decimal?>("PlanJul");

                    b.Property<decimal?>("PlanJun");

                    b.Property<decimal?>("PlanMar");

                    b.Property<decimal?>("PlanMay");

                    b.Property<decimal?>("PlanNov");

                    b.Property<decimal?>("PlanOct");

                    b.Property<decimal?>("PlanPerCategoryQ1");

                    b.Property<decimal?>("PlanPerCategoryQ2");

                    b.Property<decimal?>("PlanPerCategoryQ3");

                    b.Property<decimal?>("PlanPerCategoryQ4");

                    b.Property<decimal?>("PlanSep");

                    b.Property<decimal?>("Q1BenefitAchievedPerCategory");

                    b.Property<decimal?>("Q1BenefitExpectedPerCategory");

                    b.Property<decimal?>("Q1BenefitForecastPerCategory");

                    b.Property<decimal?>("Q1BudgetApprovedPerCategory");

                    b.Property<decimal?>("Q1BudgetDemandPerCategory");

                    b.Property<decimal?>("Q1OpexImpactPerCategory");

                    b.Property<decimal?>("Q2BenefitAchievedPerCategory");

                    b.Property<decimal?>("Q2BenefitExpectedPerCategory");

                    b.Property<decimal?>("Q2BenefitForecastPerCategory");

                    b.Property<decimal?>("Q2BudgetApprovedPerCategory");

                    b.Property<decimal?>("Q2BudgetDemandPerCategory");

                    b.Property<decimal?>("Q2OpexImpactPerCategory");

                    b.Property<decimal?>("Q3BenefitAchievedPerCategory");

                    b.Property<decimal?>("Q3BenefitExpectedPerCategory");

                    b.Property<decimal?>("Q3BenefitForecastPerCategory");

                    b.Property<decimal?>("Q3BudgetApprovedPerCategory");

                    b.Property<decimal?>("Q3BudgetDemandPerCategory");

                    b.Property<decimal?>("Q3OpexImpactPerCategory");

                    b.Property<decimal?>("Q4BenefitAchievedPerCategory");

                    b.Property<decimal?>("Q4BenefitExpectedPerCategory");

                    b.Property<decimal?>("Q4BenefitForecastPerCategory");

                    b.Property<decimal?>("Q4BudgetApprovedPerCategory");

                    b.Property<decimal?>("Q4BudgetDemandPerCategory");

                    b.Property<decimal?>("Q4OpexImpactPerCategory");

                    b.Property<decimal?>("SepBenefitAchieved");

                    b.Property<decimal?>("SepBenefitExpected");

                    b.Property<decimal?>("SepBenefitForecast");

                    b.Property<decimal?>("SepBudgetApproved");

                    b.Property<decimal?>("SepBudgetDemand");

                    b.Property<decimal?>("SepOpexImpact");

                    b.Property<decimal?>("TotalBenefitAchievedPerCategory");

                    b.Property<decimal?>("TotalBenefitExpected");

                    b.Property<decimal?>("TotalBenefitForecastPerCategory");

                    b.Property<decimal?>("TotalBudgetApprovedPerCategory");

                    b.Property<decimal?>("TotalCategoryBudgetDemand");

                    b.Property<decimal?>("TotalOpexImpactPerCategory");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("Year", "ProjectId", "CompanyId", "CostCategory");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectPlanBudgetBenefits");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ProjectRagStatus", b =>
                {
                    b.Property<string>("CompanyId");

                    b.Property<string>("ProjectId");

                    b.Property<string>("ActivitiesPlannedNextPeriod")
                        .HasMaxLength(2500);

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("HighlightsThisPeriod")
                        .HasMaxLength(2500);

                    b.Property<string>("PortfolioMiReportingPeriod");

                    b.Property<string>("ProjectRagStatusId")
                        .IsRequired();

                    b.Property<string>("RagNarrativeCustomerSatisfaction")
                        .HasMaxLength(2500);

                    b.Property<string>("RagNarrativeFinances")
                        .HasMaxLength(2500);

                    b.Property<string>("RagNarrativeGovernanceBusinessChange")
                        .HasMaxLength(2500);

                    b.Property<string>("RagNarrativeQuality")
                        .HasMaxLength(2500);

                    b.Property<string>("RagNarrativeResourcing")
                        .HasMaxLength(2500);

                    b.Property<string>("RagNarrativeSchedule")
                        .HasMaxLength(2500);

                    b.Property<string>("RagNarrativeScope")
                        .HasMaxLength(2500);

                    b.Property<string>("RagNarrativeSummary")
                        .HasMaxLength(2500);

                    b.Property<string>("RagStatusCustomerSatisfaction");

                    b.Property<string>("RagStatusFinances");

                    b.Property<string>("RagStatusGovernanceBusinessChange");

                    b.Property<string>("RagStatusQuality");

                    b.Property<string>("RagStatusResourcing");

                    b.Property<string>("RagStatusSchedule");

                    b.Property<string>("RagStatusScope");

                    b.Property<string>("RagStatusSummary");

                    b.Property<byte>("ReportingPeriodNumbers");

                    b.Property<string>("ReportingPeriodWords");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.Property<int>("Year");

                    b.HasKey("CompanyId", "ProjectId");

                    b.HasAlternateKey("ProjectRagStatusId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectRagStatus");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ProjectStageGate", b =>
                {
                    b.Property<string>("CompanyMethodologyStageId");

                    b.Property<string>("ProjectId");

                    b.Property<string>("CompanyId");

                    b.Property<DateTime?>("ActualEndDate");

                    b.Property<DateTime?>("ActualStartDate");

                    b.Property<string>("BriefNote");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<DateTime?>("PlannedEndDate");

                    b.Property<DateTime?>("PlannedStartDate");

                    b.Property<decimal?>("ProjectStageGateApprovedBudgetCapex");

                    b.Property<decimal?>("ProjectStageGateApprovedBudgetOpex");

                    b.Property<decimal?>("ProjectStageGateApprovedBudgetRevex");

                    b.Property<decimal?>("ProjectStageGateDurationDays");

                    b.Property<decimal?>("TotalProjectStageGateApprovedBudget");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.HasKey("CompanyMethodologyStageId", "ProjectId", "CompanyId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProjectId")
                        .IsUnique();

                    b.ToTable("ProjectStageGate");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ReconciledActual", b =>
                {
                    b.Property<string>("ActualId");

                    b.Property<string>("ProjectId");

                    b.Property<string>("CompanyId");

                    b.Property<string>("ForecastTaskId");

                    b.Property<DateTime>("ActualDateFrom");

                    b.Property<DateTime>("ActualDateTo");

                    b.Property<decimal?>("AllocatedAmount");

                    b.Property<string>("ProjectBudgetId");

                    b.HasKey("ActualId", "ProjectId", "CompanyId", "ForecastTaskId");

                    b.HasAlternateKey("ActualId", "CompanyId", "ForecastTaskId", "ProjectId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ForecastTaskId");

                    b.HasIndex("ProjectBudgetId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ReconciledActuals");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Resource", b =>
                {
                    b.Property<string>("CompanyId");

                    b.Property<string>("ResourceId");

                    b.Property<string>("AddedBy");

                    b.Property<string>("Agency");

                    b.Property<string>("AppUserRole")
                        .IsRequired();

                    b.Property<decimal?>("AprAvailabilityBeforeHolidaysInDays");

                    b.Property<decimal?>("AprResourceUtilizationInDays");

                    b.Property<decimal?>("AugAvailabilityBeforeHolidaysInDays");

                    b.Property<decimal?>("AugResourceUtilizationInDays");

                    b.Property<byte[]>("AvatarImage");

                    b.Property<bool>("Billable");

                    b.Property<decimal?>("ContractedHours");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<decimal?>("DecAvailabilityBeforeHolidaysInDays");

                    b.Property<decimal?>("DecResourceUtilizationInDays");

                    b.Property<string>("EmployeeJobTitle");

                    b.Property<string>("EmployeeRef");

                    b.Property<string>("EmployeeType");

                    b.Property<decimal?>("FebAvailabilityBeforeHolidaysInDays");

                    b.Property<decimal?>("FebResourceUtilizationInDays");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Gender");

                    b.Property<string>("IdentityId");

                    b.Property<string>("ImageCaption");

                    b.Property<string>("ImageId");

                    b.Property<string>("ImageName");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsDisabled");

                    b.Property<decimal?>("JanAvailabilityBeforeHolidaysInDays");

                    b.Property<decimal?>("JanResourceUtilizationInDays");

                    b.Property<decimal?>("JulAvailabilityBeforeHolidaysInDays");

                    b.Property<decimal?>("JulResourceUtilizationInDays");

                    b.Property<decimal?>("JunAvailabilityBeforeHolidaysInDays");

                    b.Property<decimal?>("JunResourceUtilizationInDays");

                    b.Property<string>("LastName");

                    b.Property<string>("Location");

                    b.Property<string>("LocationName");

                    b.Property<decimal?>("MarAvailabilityBeforeHolidaysInDays");

                    b.Property<decimal?>("MarResourceUtilizationInDays");

                    b.Property<decimal?>("MayAvailabilityBeforeHolidaysInDays");

                    b.Property<decimal?>("MayResourceUtilizationInDays");

                    b.Property<decimal?>("NovAvailabilityBeforeHolidaysInDays");

                    b.Property<decimal?>("NovResourceUtilizationInDays");

                    b.Property<decimal?>("OctAvailabilityBeforeHolidaysInDays");

                    b.Property<decimal?>("OctResourceUtilizationInDays");

                    b.Property<string>("PlatformId");

                    b.Property<string>("ProjectId");

                    b.Property<decimal?>("ResourceContractEffortInPercentage");

                    b.Property<string>("ResourceEmailAddress")
                        .IsRequired();

                    b.Property<DateTime?>("ResourceEndDate");

                    b.Property<string>("ResourceManagerId");

                    b.Property<string>("ResourceNumber");

                    b.Property<string>("ResourceRateCardId");

                    b.Property<DateTime?>("ResourceStartDate");

                    b.Property<string>("ResourceType");

                    b.Property<decimal?>("SepAvailabilityBeforeHolidaysInDays");

                    b.Property<decimal?>("SepResourceUtilizationInDays");

                    b.Property<decimal?>("TotalAvailabilityBeforeHolidaysInDays");

                    b.Property<decimal?>("TotalUtilizationInDays");

                    b.Property<string>("UserCreatedEmail");

                    b.Property<string>("UserCreatedFirstName");

                    b.Property<string>("UserCreatedId");

                    b.Property<string>("UserCreatedLastName");

                    b.Property<string>("UserCreatedResourceId");

                    b.Property<string>("UserModifiedEmail");

                    b.Property<string>("UserModifiedFirstName");

                    b.Property<string>("UserModifiedId");

                    b.Property<string>("UserModifiedLastName");

                    b.Property<string>("UserModifiedResourceId");

                    b.Property<string>("Vendor");

                    b.HasKey("CompanyId", "ResourceId");

                    b.HasIndex("IdentityId");

                    b.HasIndex("PlatformId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("ResourceRateCardId");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ResourceEffortSummary", b =>
                {
                    b.Property<string>("ResourceId");

                    b.Property<string>("ProjectId");

                    b.Property<string>("CompanyId");

                    b.Property<string>("ResourceEffortSummaryId")
                        .IsRequired()
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Year");

                    b.HasKey("ResourceId", "ProjectId", "CompanyId");

                    b.HasAlternateKey("ResourceEffortSummaryId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("CompanyId", "ResourceId");

                    b.ToTable("ResourceEffortSummaries");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ResourceHolidayBooked", b =>
                {
                    b.Property<string>("ResourceId");

                    b.Property<int>("TimesheetCalendarTsId");

                    b.Property<string>("CompanyId");

                    b.Property<string>("ApproverFeedBackNote");

                    b.Property<decimal?>("FridayHolidayHours");

                    b.Property<string>("HolidayBookingCode");

                    b.Property<string>("HolidayStatus");

                    b.Property<decimal?>("MondayHolidayHours");

                    b.Property<string>("ResourceFeedBackNote");

                    b.Property<string>("ResourceHolidayBookedId")
                        .IsRequired();

                    b.Property<decimal?>("SaturdayHolidayHours");

                    b.Property<decimal?>("SundayHolidayHours");

                    b.Property<decimal?>("ThursdayHolidayHours");

                    b.Property<int?>("TimesheetCalendarId");

                    b.Property<decimal?>("TotalHolidayHours");

                    b.Property<decimal?>("TuesdayHolidayHours");

                    b.Property<decimal?>("WednesdayHolidayHours");

                    b.HasKey("ResourceId", "TimesheetCalendarTsId", "CompanyId");

                    b.HasAlternateKey("ResourceHolidayBookedId");

                    b.HasIndex("TimesheetCalendarId");

                    b.HasIndex("CompanyId", "ResourceId");

                    b.ToTable("ResourceHolidaysBooked");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ResourceWorkTimesheet", b =>
                {
                    b.Property<string>("ResourceId");

                    b.Property<int>("TimesheetCalendarTsId");

                    b.Property<string>("CompanyId");

                    b.Property<string>("ProjectId");

                    b.Property<string>("ForecastTaskId");

                    b.Property<string>("ApproverFeedBackNote");

                    b.Property<decimal?>("OvertimeFridayBillableHours");

                    b.Property<decimal?>("OvertimeFridayNonBillableHours");

                    b.Property<decimal?>("OvertimeMondayBillableHours");

                    b.Property<decimal?>("OvertimeMondayNonBillableHours");

                    b.Property<decimal?>("OvertimeSaturdayBillableHours");

                    b.Property<decimal?>("OvertimeSaturdayNonBillableHours");

                    b.Property<decimal?>("OvertimeSundayBillableHours");

                    b.Property<decimal?>("OvertimeSundayNonBillableHours");

                    b.Property<decimal?>("OvertimeThursdayBillableHours");

                    b.Property<decimal?>("OvertimeThursdayNonBillableHours");

                    b.Property<decimal?>("OvertimeTuesdayBillableHours");

                    b.Property<decimal?>("OvertimeTuesdayNonBillableHours");

                    b.Property<decimal?>("OvertimeWednesdayBillableHours");

                    b.Property<decimal?>("OvertimeWednesdayNonBillableHours");

                    b.Property<string>("ResourceFeedBackNote");

                    b.Property<string>("ResourceWorkTimesheetId")
                        .IsRequired()
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("StandardDayFridayBillableHours");

                    b.Property<decimal?>("StandardDayFridayNonBillableHours");

                    b.Property<decimal?>("StandardDayMondayBillableHours");

                    b.Property<decimal?>("StandardDayMondayNonBillableHours");

                    b.Property<decimal?>("StandardDaySaturdayBillableHours");

                    b.Property<decimal?>("StandardDaySaturdayNonBillableHours");

                    b.Property<decimal?>("StandardDaySundayBillableHours");

                    b.Property<decimal?>("StandardDaySundayNonBillableHours");

                    b.Property<decimal?>("StandardDayThursdayBillableHours");

                    b.Property<decimal?>("StandardDayThursdayNonBillableHours");

                    b.Property<decimal?>("StandardDayTuesdayBillableHours");

                    b.Property<decimal?>("StandardDayTuesdayNonBillableHours");

                    b.Property<decimal?>("StandardDayWednesdayBillableHours");

                    b.Property<decimal?>("StandardDayWednesdayNonBillableHours");

                    b.Property<int?>("TimesheetCalendarId");

                    b.Property<string>("TimesheetStatus");

                    b.HasKey("ResourceId", "TimesheetCalendarTsId", "CompanyId", "ProjectId", "ForecastTaskId");

                    b.HasAlternateKey("ResourceWorkTimesheetId");

                    b.HasIndex("ForecastTaskId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TimesheetCalendarId");

                    b.HasIndex("CompanyId", "ResourceId");

                    b.ToTable("ResourceWorkTimesheets");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Supplier", b =>
                {
                    b.Property<string>("SupplierId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyId")
                        .IsRequired();

                    b.Property<string>("ContactEmail");

                    b.Property<string>("ContactTelephone");

                    b.Property<string>("ExternalVendorNumber");

                    b.Property<string>("Services");

                    b.Property<string>("SupplierName");

                    b.Property<string>("WorkOrderNumber");

                    b.Property<string>("WorkOrderOwner");

                    b.HasKey("SupplierId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.TimesheetCalendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("Friday")
                        .IsRequired();

                    b.Property<DateTime?>("Monday")
                        .IsRequired();

                    b.Property<DateTime?>("Saturday")
                        .IsRequired();

                    b.Property<int>("SaturdayPeriod");

                    b.Property<int>("SaturdayYear");

                    b.Property<DateTime?>("Sunday")
                        .IsRequired();

                    b.Property<int>("SundayPeriod");

                    b.Property<int>("SundayYear");

                    b.Property<DateTime?>("Thursday")
                        .IsRequired();

                    b.Property<string>("TsId")
                        .IsRequired();

                    b.Property<DateTime?>("Tuesday")
                        .IsRequired();

                    b.Property<DateTime?>("Wednesday")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TimesheetCalendars");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.UserNotification", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<int>("NotificationId");

                    b.Property<bool>("IsRead");

                    b.HasKey("UserId", "NotificationId");

                    b.HasAlternateKey("NotificationId", "UserId");

                    b.ToTable("UserNotifications");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Entities.AppUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Entities.AppUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.HasOne("ProjectCentreBackend.Models.Entities.AppUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Actual", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.BusinessCustomer", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.BusinessUnit", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.Resource")
                        .WithMany("BusinessUnits")
                        .HasForeignKey("ResourceCompanyId", "ResourceId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.BusinessUnitPermitted", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Entities.AppUser")
                        .WithMany("BusinessUnitsPermitted")
                        .HasForeignKey("AppUserId");

                    b.HasOne("ProjectCentreBackend.Models.BusinessUnit", "BusinessUnit")
                        .WithMany()
                        .HasForeignKey("BusinessUnitId");

                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.Resource", "Resource")
                        .WithMany("BusinessUnitsPermitted")
                        .HasForeignKey("CompanyId", "ResourceId");

                    b.HasOne("ProjectCentreBackend.Models.BusinessUnitPermitted")
                        .WithMany("MyBusinessUnitPermitted")
                        .HasForeignKey("BusinessUnitPermittedResourceId", "BusinessUnitPermittedCompanyId", "BusinessUnitPermittedBusinessUnitId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.CompanyMethodology", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.CompanyMethodologyStage", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.CompanyMethodology", "CompanyMethodology")
                        .WithMany("CompanyMethodologyStages")
                        .HasForeignKey("CompanyMethodologyId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.CompanyRateCard", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Domain", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.BusinessUnit", "BusinessUnit")
                        .WithMany("Domains")
                        .HasForeignKey("BusinessUnitId");

                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.Resource")
                        .WithMany("Domains")
                        .HasForeignKey("ResourceCompanyId", "ResourceId");

                    b.HasOne("ProjectCentreBackend.Models.BusinessUnitPermitted")
                        .WithMany("Domains")
                        .HasForeignKey("BusinessUnitPermittedResourceId", "BusinessUnitPermittedCompanyId", "BusinessUnitPermittedBusinessUnitId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.DomainPermitted", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Entities.AppUser")
                        .WithMany("DomainsPermitted")
                        .HasForeignKey("AppUserId");

                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.Domain", "Domain")
                        .WithMany()
                        .HasForeignKey("DomainId");

                    b.HasOne("ProjectCentreBackend.Models.Resource", "Resource")
                        .WithMany("DomainsPermitted")
                        .HasForeignKey("CompanyId", "ResourceId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Entities.AppUser", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.Resource", "Resource")
                        .WithMany()
                        .HasForeignKey("CompanyId", "ResourceId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ForecastTask", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId");

                    b.HasOne("ProjectCentreBackend.Models.TimesheetCalendar")
                        .WithMany("ForecastTasks")
                        .HasForeignKey("TimesheetCalendarId");

                    b.HasOne("ProjectCentreBackend.Models.Resource", "Resource")
                        .WithMany()
                        .HasForeignKey("CompanyId", "ResourceId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Notification", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.HasOne("ProjectCentreBackend.Models.Resource", "ModifiedByResource")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserCompanyId", "LastResourceModifiedId");

                    b.HasOne("ProjectCentreBackend.Models.Resource", "CreatedByResource")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserCompanyId", "OriginalResourceCreatedId");

                    b.HasOne("ProjectCentreBackend.Models.Resource", "UpdatedByResource")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserCompanyId", "UpdatedByResourceId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Platform", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Portfolio", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.Domain", "Domain")
                        .WithMany("Portfolios")
                        .HasForeignKey("DomainId");

                    b.HasOne("ProjectCentreBackend.Models.Resource")
                        .WithMany("Portfolios")
                        .HasForeignKey("ResourceCompanyId", "ResourceId");

                    b.HasOne("ProjectCentreBackend.Models.DomainPermitted")
                        .WithMany("Portfolios")
                        .HasForeignKey("DomainPermittedResourceId", "DomainPermittedCompanyId", "DomainPermittedDomainId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.PortfolioPermitted", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Entities.AppUser")
                        .WithMany("PortfoliosPermitted")
                        .HasForeignKey("AppUserId");

                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.Portfolio", "Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId");

                    b.HasOne("ProjectCentreBackend.Models.Resource", "Resource")
                        .WithMany("PortfoliosPermitted")
                        .HasForeignKey("CompanyId", "ResourceId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Programme", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.Portfolio", "Portfolio")
                        .WithMany("Programmes")
                        .HasForeignKey("PortfolioId");

                    b.HasOne("ProjectCentreBackend.Models.Resource")
                        .WithMany("Programmes")
                        .HasForeignKey("ResourceCompanyId", "ResourceId");

                    b.HasOne("ProjectCentreBackend.Models.PortfolioPermitted")
                        .WithMany("Programmes")
                        .HasForeignKey("PortfolioPermittedResourceId", "PortfolioPermittedCompanyId", "PortfolioPermittedPortfolioId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ProgrammePermitted", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Entities.AppUser")
                        .WithMany("ProgrammesPermitted")
                        .HasForeignKey("AppUserId");

                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.Programme", "Programme")
                        .WithMany()
                        .HasForeignKey("ProgrammeId");

                    b.HasOne("ProjectCentreBackend.Models.Resource", "Resource")
                        .WithMany("ProgrammesPermitted")
                        .HasForeignKey("CompanyId", "ResourceId");

                    b.HasOne("ProjectCentreBackend.Models.ProgrammePermitted")
                        .WithMany("ResourcesPermitted")
                        .HasForeignKey("ProgrammePermittedResourceId", "ProgrammePermittedCompanyId", "ProgrammePermittedProgrammeId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Project", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.BusinessCustomer", "BusinessCustomers")
                        .WithMany("Projects")
                        .HasForeignKey("BusinessCustomerId");

                    b.HasOne("ProjectCentreBackend.Models.BusinessUnit", "BusinessUnit")
                        .WithMany()
                        .HasForeignKey("BusinessUnitId");

                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.Domain", "Domain")
                        .WithMany()
                        .HasForeignKey("DomainId");

                    b.HasOne("ProjectCentreBackend.Models.Portfolio", "Portfolio")
                        .WithMany("Projects")
                        .HasForeignKey("PortfolioId");

                    b.HasOne("ProjectCentreBackend.Models.Programme", "Programme")
                        .WithMany("Projects")
                        .HasForeignKey("ProgrammeId");

                    b.HasOne("ProjectCentreBackend.Models.ProjectBudgetTracker", "ProjectBudgetTracker")
                        .WithMany()
                        .HasForeignKey("ProjectCurrentBudgetTrackerId");

                    b.HasOne("ProjectCentreBackend.Models.ProjectManagementRank", "ProjectManagementRank")
                        .WithOne("Project")
                        .HasForeignKey("ProjectCentreBackend.Models.Project", "ProjectManagementRankId");

                    b.HasOne("ProjectCentreBackend.Models.Resource")
                        .WithMany("Projects")
                        .HasForeignKey("ResourceCompanyId", "ResourceId");

                    b.HasOne("ProjectCentreBackend.Models.PortfolioPermitted")
                        .WithMany("Projects")
                        .HasForeignKey("PortfolioPermittedResourceId", "PortfolioPermittedCompanyId", "PortfolioPermittedPortfolioId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ProjectBudget", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.ProjectBudgetTracker")
                        .WithMany("ProjectBudgets")
                        .HasForeignKey("ProjectBudgetTrackerId");

                    b.HasOne("ProjectCentreBackend.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId");

                    b.HasOne("ProjectCentreBackend.Models.Resource", "Resource")
                        .WithMany()
                        .HasForeignKey("CompanyId", "ResourceId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ProjectManagementRank", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Entities.AppUser", "ProjectFinanceContact")
                        .WithMany()
                        .HasForeignKey("ProjectFinanceContactUserId");

                    b.HasOne("ProjectCentreBackend.Models.Entities.AppUser", "ProjectManager")
                        .WithMany()
                        .HasForeignKey("ProjectManagerUserId");

                    b.HasOne("ProjectCentreBackend.Models.Entities.AppUser", "ProjectOwner")
                        .WithMany()
                        .HasForeignKey("ProjectOwnerUserId");

                    b.HasOne("ProjectCentreBackend.Models.Entities.AppUser", "ProjectPrmiaryContact")
                        .WithMany()
                        .HasForeignKey("ProjectPrimaryContactUserId");

                    b.HasOne("ProjectCentreBackend.Models.Entities.AppUser", "ProjectSeniorManager")
                        .WithMany()
                        .HasForeignKey("ProjectSeniorManagerUserId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ProjectPermitted", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.Project", "Project")
                        .WithMany("PermittedUsers")
                        .HasForeignKey("ProjectId");

                    b.HasOne("ProjectCentreBackend.Models.Entities.AppUser", "User")
                        .WithMany("ProjectsPermitted")
                        .HasForeignKey("UserId");

                    b.HasOne("ProjectCentreBackend.Models.Resource")
                        .WithMany("ProjectsPermitted")
                        .HasForeignKey("CompanyId", "ResourceId");

                    b.HasOne("ProjectCentreBackend.Models.ProjectPermitted")
                        .WithMany("ResourcesPermitted")
                        .HasForeignKey("ProjectPermittedResourceId", "ProjectPermittedProjectId", "ProjectPermittedCompanyId", "ProjectPermittedUserId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ProjectPlanBudgetBenefit", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjectCentreBackend.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ProjectRagStatus", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ProjectStageGate", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.CompanyMethodologyStage", "CompanyMethodologyStage")
                        .WithMany()
                        .HasForeignKey("CompanyMethodologyStageId");

                    b.HasOne("ProjectCentreBackend.Models.Project", "Project")
                        .WithOne("ProjectStageGates")
                        .HasForeignKey("ProjectCentreBackend.Models.ProjectStageGate", "ProjectId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ReconciledActual", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Actual", "Actual")
                        .WithMany("ReconciledActuals")
                        .HasForeignKey("ActualId");

                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.ForecastTask", "ForecastTask")
                        .WithMany("ReconciledActuals")
                        .HasForeignKey("ForecastTaskId");

                    b.HasOne("ProjectCentreBackend.Models.ProjectBudget")
                        .WithMany("ReconciledActuals")
                        .HasForeignKey("ProjectBudgetId");

                    b.HasOne("ProjectCentreBackend.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Resource", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.Entities.AppUser", "Identity")
                        .WithMany()
                        .HasForeignKey("IdentityId");

                    b.HasOne("ProjectCentreBackend.Models.Platform", "Platform")
                        .WithMany()
                        .HasForeignKey("PlatformId");

                    b.HasOne("ProjectCentreBackend.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.HasOne("ProjectCentreBackend.Models.CompanyRateCard", "CompanyRateCard")
                        .WithMany()
                        .HasForeignKey("ResourceRateCardId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ResourceEffortSummary", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.HasOne("ProjectCentreBackend.Models.Resource", "Resource")
                        .WithMany()
                        .HasForeignKey("CompanyId", "ResourceId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ResourceHolidayBooked", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.TimesheetCalendar", "TimesheetCalendar")
                        .WithMany("ResourceHolidaysBooked")
                        .HasForeignKey("TimesheetCalendarId");

                    b.HasOne("ProjectCentreBackend.Models.Resource", "Resource")
                        .WithMany()
                        .HasForeignKey("CompanyId", "ResourceId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.ResourceWorkTimesheet", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("ProjectCentreBackend.Models.ForecastTask", "ForecastTask")
                        .WithMany()
                        .HasForeignKey("ForecastTaskId");

                    b.HasOne("ProjectCentreBackend.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.HasOne("ProjectCentreBackend.Models.TimesheetCalendar", "TimesheetCalendar")
                        .WithMany("ResourceWorkTimesheets")
                        .HasForeignKey("TimesheetCalendarId");

                    b.HasOne("ProjectCentreBackend.Models.Resource", "Resource")
                        .WithMany("ResourceWorkTimesheets")
                        .HasForeignKey("CompanyId", "ResourceId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.Supplier", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("ProjectCentreBackend.Models.UserNotification", b =>
                {
                    b.HasOne("ProjectCentreBackend.Models.Notification", "Notification")
                        .WithMany()
                        .HasForeignKey("NotificationId");

                    b.HasOne("ProjectCentreBackend.Models.Entities.AppUser", "User")
                        .WithMany("UserNotifications")
                        .HasForeignKey("UserId");
                });
        }
    }
}
