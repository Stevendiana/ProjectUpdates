using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IProjectBudgetRepository : IRepository<ProjectBudget>
    {

        IEnumerable<ProjectBudget> GetAllProjectBudgetByBatch(string id, string companyId);
        


    }
}






