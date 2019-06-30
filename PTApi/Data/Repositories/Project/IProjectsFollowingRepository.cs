using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IProjectsFollowingRepository : IRepository<ProjectsFollowing>
    {
        ProjectsFollowing GetOneUserFollowing(string projectId, string resourceId, string companyId);
        IEnumerable<ProjectsFollowing> GetAllUsersFollowing(string companyId, string id);
    }
}




