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

  
        public IEnumerable<ProjectBudget> GetAllProjectBudgetByBatch(string id, string companyId)
        {
            return ApplicationDbContext.ProjectBudgets
                .Include(d => d.ReconciledActuals)
                .Include(d => d.Supplier)
                .Include(d => d.Resource)
                .Include(d => d.ForecastTaskId).Where(d => d.ProjectBudgetTrackerId == id && d.CompanyId == companyId).ToList();
        }

       

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
