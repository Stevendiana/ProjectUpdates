using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        Project GetOneProject(string id, string companyId);
        IEnumerable<Project> GetAllProjects(string companyId);
        
    }
}


