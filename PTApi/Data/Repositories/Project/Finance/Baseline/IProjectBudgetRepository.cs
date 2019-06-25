using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IProjectBudgetRepository : IRepository<ProjectBudget>
    {
        IEnumerable<ProjectBudgetTracker> GetAllProjectBudgetBatches(string id, string companyId);
        IEnumerable<ProjectBudgetTracker> GetAllProjectBudgetByBatchId(string id, string companyId);



    }
}






