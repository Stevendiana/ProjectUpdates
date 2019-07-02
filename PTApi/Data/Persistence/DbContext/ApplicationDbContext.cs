using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PTApi.Models;
using PTApi.Services;
using System.Linq;


namespace PTApi.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IUserService _userService;

        public ApplicationDbContext(DbContextOptions options, IUserService userService)
        : base(options)
        {
            _userService = userService;


        }


        //public ApplicationDbContext()
        //{
        //}

        //public static ApplicationDbContext Create()
        //{
        //    return new ApplicationDbContext();
        //}



      
        public DbSet<ParentTask> ParentTasks { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<BusinessUnit> BusinessUnits { get; set; }
        public DbSet<Domain> Domains { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Programme> Programmes { get; set; }
        public DbSet<CurrencySymbol> CurrencySymbols { get; set; }
        public DbSet<CompanyMethodologyStage> CompanyMethodologyStages { get; set; }
        public DbSet<CompanyRateCard> CompanyRateCards { get; set; }
        public DbSet<CompanyMethodology> CompanyMethodologies { get; set; }

        public DbSet<Resource> Resources { get; set; }
        public DbSet<TimesheetCalendar> TimesheetCalendars { get; set; }
  
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectBudget> ProjectBudgets { get; set; }
        public DbSet<ProjectBudgetTracker> ProjectBudgetTrackers { get; set; }
        public DbSet<ProjectStageGate> ProjectStageGates { get; set; }
        public DbSet<ProjectRagStatus> ProjectRagStatus { get; set; }

        public DbSet<ReconciledActual> ReconciledActuals { get; set; }
        public DbSet<Actual> Actuals { get; set; }
        public DbSet<ForecastTask> ForecastTasks { get; set; }

        public DbSet<ResourceEffortSummary> ResourceEffortSummaries { get; set; }
        public DbSet<ResourceHolidayBooked> ResourceHolidays { get; set; }
        public DbSet<ResourceWorkTimesheet> ResourceWorkTimesheets { get; set; }
        
        public DbSet<BusinessCustomer> BusinessCustomers { get; set; }
       
        public DbSet<ProjectsPermitted> ProjectsIamPermitted { get; set; }
        public DbSet<ProjectsFollowing> ProjectsIamFollowing { get; set; }
        public DbSet<ProgrammesFollowing> ProgrammesIamFollowing { get; set; }
        public DbSet<PortfoliosFollowing> PortfoliosIamFollowing { get; set; }
        public DbSet<BusinessunitsFollowing> BusinessunitsIamFollowing { get; set; }
        public DbSet<DomainsFollowing> DomainsIamFollowing { get; set; }
        

        public DbSet<ProgrammesPermitted> ProgrammesPermitted { get; set; }
        public DbSet<PortfoliosPermitted> PortfoliosPermitted { get; set; }
        public DbSet<DomainsPermitted> DomainsPermitted { get; set; }
        public DbSet<BusinessUnitsPermitted> BusinessUnitsPermitted { get; set; }

        public DbSet<Notification> Notifications { get; set; }
        public DbSet<UserNotification> UserNotifications { get; set; }

        public DbSet<ChangeLog> ChangeLogs { get; set; }

        public DbSet<Risk> Risks { get; set; }
        public DbSet<Assumption> Assumptions { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Dependency> Dependencies { get; set; }

        // public DbSet<ResourceCostCentre> ResourceCostCentres { get; set; }
        // public DbSet<ResourceCentre> ResourceCentres { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            // modelBuilder.Entity<Company>().HasKey(c => c.CompanyId);
            // modelBuilder.Entity<AppUser>().HasOne(u => u.ResourceCentre).WithOne(c => c.Identity);
            // modelBuilder.Entity<Resource>().HasKey(r => r.ResourceCentreId);
            // modelBuilder.Entity<Resource>().HasKey(r => new { r.ResourceId, r.ResourceCentreId});
            // modelBuilder.Entity<ProjectRagStatus>().HasKey(prs => new { prs.CompanyId, prs.ProjectId });

            modelBuilder.Entity<ApplicationUser>().HasOne(u => u.Company);

            //modelBuilder.Entity<ProjectsPermitted>().HasMany(p => p.ResourcesPermitted);

            //modelBuilder.Entity<ParentTask>().HasKey(f => new { f.ParentTaskId, f.ProjectId, f.CompanyId });

            modelBuilder.Entity<ForecastTask>().HasKey(f => new { f.ForecastTaskId });
            //modelBuilder.Entity<ForecastTask>().HasOne(f => f.ParentTaskId);

            modelBuilder.Entity<ReconciledActual>().HasKey(ra => new { ra.ActualId,  ra.ForecastTaskId });

            modelBuilder.Entity<ProjectStageGate>().HasKey(pmst => new { pmst.CompanyMethodologyStageId, pmst.ProjectId, pmst.CompanyId });

            modelBuilder.Entity<ProjectPlanBudgetBenefit>().HasKey(ppbb => new { ppbb.Year, ppbb.ProjectId, ppbb.CompanyId, ppbb.CostCategory });


            modelBuilder.Entity<BusinessUnitsPermitted>().HasKey(bup => new { bup.UserId, bup.ResourceId, bup.CompanyId, bup.BusinessUnitId });

            modelBuilder.Entity<DomainsPermitted>().HasKey(dp => new { dp.UserId, dp.ResourceId, dp.CompanyId, dp.DomainId });

            modelBuilder.Entity<PortfoliosPermitted>().HasKey(pfp => new { pfp.UserId, pfp.ResourceId, pfp.CompanyId, pfp.PortfolioId });

            modelBuilder.Entity<ProgrammesPermitted>().HasKey(pgp => new { pgp.UserId, pgp.ResourceId, pgp.CompanyId, pgp.ProgrammeId });


            modelBuilder.Entity<ProjectsPermitted>().HasKey(pjp => new { pjp.ResourceId, pjp.ProjectId, pjp.CompanyId, pjp.UserId });

            modelBuilder.Entity<Resource>().HasKey(res => new { res.CompanyId, res.ResourceId });

            modelBuilder.Entity<ProjectManagementRank>().HasOne(pm => pm.Project);

            modelBuilder.Entity<Project>().HasOne(pm => pm.ProjectManagementRank).WithOne(c => c.Project);

            modelBuilder.Entity<UserNotification>().HasKey(un => new { un.UserId, un.NotificationId });

            modelBuilder.Entity<ResourceEffortSummary>().HasKey(res => new { res.ResourceId, res.ProjectId, res.CompanyId });

            modelBuilder.Entity<ResourceHolidayBooked>().HasKey(rhb => new { rhb.ResourceId, rhb.TimesheetCalendarTsId, rhb.CompanyId });

            modelBuilder.Entity<ResourceWorkTimesheet>().HasKey(rwt => new { rwt.ResourceId, rwt.TimesheetCalendarTsId, rwt.CompanyId, rwt.ProjectId, rwt.ForecastTaskId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
