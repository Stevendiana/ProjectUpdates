using System;
using System.Threading.Tasks;

namespace PTApi.Data.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        ICompanyRepository Companies { get; }

        IBusinessunitRepository Businessunits { get; }
        IDomainRepository Domains { get; }
        IPlatformRepository Platforms { get; }
        IPortfolioRepository Portfolios { get; }
        IProgrammeRepository Programmes { get; }

        IProjectRepository Projects { get; }
        IProjectsPermittedRepository Permissions { get; }
        IProjectsFollowingRepository Following { get; }

        ICompanyMethodologyRepository CompanyMethodologies { get; }
        ICompanyMethodologyStageRepository CompanyMethodologyStages { get; }
        ICompanyRateCardRepository CompanyRateCards { get; }

        ICurrencySymbolRepository CurrencySymbols { get; }
        IResourceTimesheetRepository ResourceTimesheets { get; }

        IActualRepository Actuals { get; }
        IProjectBudgetRepository ProjectBudgets { get; }
        IForecastTaskRepository LifetimeForecast { get; }
        IProjectBudgetTrackerRepository BudgetTracker { get; }

        IResourceRepository Resources { get; }
        IResourceUtilizationRepository ResourceUtilizations { get; }

        IProjectRagStatusRepository Rags { get; }
        IAssumptionRepository Assumptions { get; }
        IDependencyRepository Dependencies { get; }
        IIssueRepository Issues { get; }
        IRiskRepository Risks { get; }


        int Complete();
        Task<int> CompleteAsync();
    }
}
