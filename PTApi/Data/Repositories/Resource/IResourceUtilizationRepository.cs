using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IResourceUtilizationRepository : IRepository<ResourceUtilizationSummary>
    {
        ResourceUtilizationSummary GetAllResourceUtilization(string id, string companyId);
        ResourceUtilizationSummary GetOneResourceUtilization(string id, int year);
        IEnumerable<ResourceUtilizationSummary> GetAllResourcesUtilization(string id, string companyId);
    }
}






