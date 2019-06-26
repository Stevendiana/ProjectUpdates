using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IProjectBudgetTrackerRepository : IRepository<ProjectBudgetTracker>
    {
        ProjectBudgetTracker GetOneTracker(string id, string companyId);
        ProjectBudgetTracker GetLastApprovedBudget(string id, string companyId);
        IEnumerable<ProjectBudgetTracker> GetAllProjectBudgetBatches(string id, string companyId);
        IEnumerable<ProjectBudgetTracker> GetAllProjectBudgetByBatchId(string id, string companyId);
    }
}






