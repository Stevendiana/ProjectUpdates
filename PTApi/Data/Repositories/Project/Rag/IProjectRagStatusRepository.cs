using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IProjectRagStatusRepository : IRepository<ProjectRagStatus>
    {
        ProjectRagStatus GetOneRag(string id, string companyId);

        IEnumerable<ProjectRagStatus> GetAllProjectRagStatusOnly(string id, string companyId);


    }
}






