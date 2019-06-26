using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Helpers;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class ProjectBudgetTrackerRepository : Repository<ProjectBudgetTracker>, IProjectBudgetTrackerRepository
    {
        public ProjectBudgetTrackerRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public ProjectBudgetTracker GetOneTracker(string id, string companyId)
        {
            return ApplicationDbContext.ProjectBudgetTrackers.SingleOrDefault(d => d.ProjectBudgetTrackerId == id && d.CompanyId == companyId);
        }

        public ProjectBudgetTracker GetLastApprovedBudget(string id, string companyId)
        {
            var trackerlist = GetAllProjectBudgetBatches(id,companyId);

            ProjectBudgetTracker latest = trackerlist.Where(t => t.BudgetBadgetStatus == Constants.Strings.StatusTypes.Approved).OrderByDescending(t=>t.DateModified).SingleOrDefault();

            return latest;
        }


        public IEnumerable<ProjectBudgetTracker> GetAllProjectBudgetBatches(string id, string companyId)
        {
            return ApplicationDbContext.ProjectBudgetTrackers.Where(d => d.ProjectId == id && d.CompanyId == companyId).ToList().OrderByDescending(d => d.DateModified);
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



