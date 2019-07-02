using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        Project GetOneProject(string id, string companyId);
       
        IEnumerable<Project> GetAllProjects(string companyId);
      
        IEnumerable<string> GetAllProjectsId(string companyId);
        IEnumerable<string> GetAllDomainsPermitted(string id, string companyId);
        IEnumerable<string> GetAllBusinessunitsPermitted(string id, string companyId);
        IEnumerable<string> GetAllPortfoliosPermitted(string id, string companyId);
        IEnumerable<string> GetAllProgrammesPermitted(string id, string companyId);
        IEnumerable<string> GetAllProjectsPermitted(string id, string companyId);
        IEnumerable<myProjects> CombineAllProjectsPermitted(string id, string companyId);
        IEnumerable<myProjects> CombineAllProjectsAndProjectsFollowingForAdmin(string id, string companyId);
        

    }
}



