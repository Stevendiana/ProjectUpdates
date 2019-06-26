using System;

namespace PTApi.Data.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICompanyRepository Companies { get; }

        IBusinessunitRepository Businessunits { get; }
        IDomainRepository Domains { get; }
        IPlatformRepository Platforms { get; }
        IPortfolioRepository Portfolios { get; }
        IProgrammeRepository Programmes { get; }
        IProjectRepository Projects { get; }

        ICompanyMethodologyRepository CompanyMethodologies { get; }
        ICompanyMethodologyStageRepository CompanyMethodologyStages { get; }
        ICompanyRateCardRepository CompanyRateCards { get; }

        ICurrencySymbolRepository CurrencySymbols { get; }
        IResourceTimesheetRepository ResourceTimesheets { get; }

        IActualRepository Actuals { get; }
        IProjectBudgetRepository ProjectBudgets { get; }
        IForecastTaskRepository LifetimeForecast { get; }
        IProjectBudgetTrackerRepository BudgetTracker { get; }



        IProjectRagStatusRepository Rags { get; }
        IAssumptionRepository Assumptions { get; }
        IDependencyRepository Dependencies { get; }
        IIssueRepository Issues { get; }
        IRiskRepository Risks { get; }


        int Complete();
    }
}
