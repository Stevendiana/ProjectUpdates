using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IResourceUtilizationRepository : IRepository<ResourceUtilizationSummary>
    {
        ResourceUtilizationSummary GetOneResourceUtilization(string id, string companyId);
        IEnumerable<ResourceUtilizationSummary> GetAllResourcesUtilization(string id, string companyId);
    }
}






