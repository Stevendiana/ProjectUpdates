using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IResourceRepository : IRepository<Resource>
    {
        Resource GetOneResouce(string id, string companyId);
        decimal? GetResourceContractedEffortHours(string id, string companyId);
        IEnumerable<Resource> GetAllResources(string companyId);

    }
}






