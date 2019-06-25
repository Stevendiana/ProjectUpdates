using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class ProjectBudgetRepository : Repository<ProjectBudget>, IProjectBudgetRepository
    {
        public ProjectBudgetRepository(ApplicationDbContext context)
            : base(context)
        {
        }

  
        public IEnumerable<ProjectBudgetTracker> GetAllProjectBudgetBatches(string id, string companyId)
        {
            return ApplicationDbContext.ProjectBudgetTrackers.Where(d => d.ProjectId == id && d.CompanyId == companyId).ToList().OrderByDescending(d => d.BudgetBadgetVersion);
        }

        public IEnumerable<ProjectBudgetTracker> GetAllProjectBudgetByBatchId(string id, string companyId)
        {
            return ApplicationDbContext.ProjectBudgetTrackers
                .Include(d => d.ProjectBudgets)
                .Where(d => d.ProjectBudgetTrackerId == id && d.CompanyId == companyId).ToList()
                .OrderByDescending(d => d.BudgetBadgetVersion);
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
