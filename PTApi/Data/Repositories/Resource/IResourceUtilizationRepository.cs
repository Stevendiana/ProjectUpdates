using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IResourceUtilizationRepository : IRepository<ResourceUtilizationSummary>
    {
        IEnumerable<ResourceUtilizationSummary> GetAllResourcesUtilization( string companyId);
        ResourceUtilizationSummary GetOneAllResourceUtilization(string id, string companyId);
        ResourceUtilizationSummary GetOneResourceUtilizationOneyear(string id, int year);
        IEnumerable<ResourceUtilizationSummary> GetAllResourceUtilization(string id, string companyId);
    }
}






