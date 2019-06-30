using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IProjectsPermittedRepository : IRepository<ProjectsPermitted>
    {
        
        ProjectsPermitted GetOneUserPermitted(string projectId, string resourceId, string companyId);
        IEnumerable<ProjectsPermitted> GetAllUsersPermitted(string companyId, string id);

       
    }
}




