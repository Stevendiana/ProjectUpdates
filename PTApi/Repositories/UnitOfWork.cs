using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Services;
using System.Threading.Tasks;

namespace PTApi.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly IForecastService _forecastService;

        public UnitOfWork(ApplicationDbContext context, IForecastService forecastService)
        {
            _context = context;
            _forecastService = forecastService;
 
            Users = new UserRepository(_context);

            Companies = new CompanyRepository(_context);
            Businessunits = new BusinessunitRepository(_context);
            Domains = new DomainRepository(_context);
            Platforms = new PlatformRepository(_context);
            Portfolios = new PortfolioRepository(_context);
            Programmes = new ProgrammeRepository(_context);

            Projects = new ProjectRepository(_context);
            Permissions = new ProjectsPermittedRepository(_context);
            Following = new ProjectsFollowingRepository(_context);

            CompanyMethodologies = new CompanyMethodologyRepository(_context);
            CompanyMethodologyStages = new CompanyMethodologyStageRepository(_context);
            CompanyRateCards = new CompanyRateCardRepository(_context);

            CurrencySymbols = new CurrencySymbolRepository(_context);
            ResourceTimesheets = new ResourceTimesheetRepository(_context);

            Resources = new ResourceRepository(_context);

            Actuals = new ActualRepository(_context);
            ProjectBudgets = new ProjectBudgetRepository(_context);
            BudgetTracker = new ProjectBudgetTrackerRepository(_context);
            LifetimeForecast = new ForecastTaskRepository(_context, _forecastService);

            Rags = new ProjectRagStatusRepository(_context);
            Assumptions = new AssumptionRepository(_context);
            Dependencies = new DependencyRepository(_context);
            Issues = new IssueRepository(_context);
            Risks = new RiskRepository(_context);


        }

        public IUserRepository Users { get; private set; }
        public ICompanyRepository Companies { get; private set; }

        public IBusinessunitRepository Businessunits{ get; private set; }
        public IDomainRepository Domains { get; private set; }
        public IPlatformRepository Platforms { get; private set; }
        public IPortfolioRepository Portfolios { get; private set; }
        public IProgrammeRepository Programmes { get; private set; }

        public IProjectRepository Projects { get; private set; }
        public IProjectsPermittedRepository Permissions { get; private set; }
        public IProjectsFollowingRepository Following { get; private set; }

        public ICompanyMethodologyRepository CompanyMethodologies { get; private set; }
        public ICompanyMethodologyStageRepository CompanyMethodologyStages { get; private set; }
        public ICompanyRateCardRepository CompanyRateCards { get; private set; }

        public ICurrencySymbolRepository CurrencySymbols { get; private set; }
        public IResourceTimesheetRepository ResourceTimesheets { get; private set; }

        public IResourceRepository Resources { get; private set; }

        public IActualRepository Actuals { get; private set; }
        public IProjectBudgetRepository ProjectBudgets { get; private set; }
        public IForecastTaskRepository LifetimeForecast { get; private set; }
        public IProjectBudgetTrackerRepository BudgetTracker { get; private set; }

        public IProjectRagStatusRepository Rags { get; private set; }
        public IAssumptionRepository Assumptions { get; private set; }
        public IDependencyRepository Dependencies { get; private set; }
        public IIssueRepository Issues { get; private set; }
        public IRiskRepository Risks { get; private set; }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public Task<int> CompleteAsync()
        {
            return _context.SaveChangesAsync();
        }


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
