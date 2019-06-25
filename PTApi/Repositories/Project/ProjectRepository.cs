using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public Project GetOneProject(string id, string companyId)
        {
            return ApplicationDbContext.Projects.SingleOrDefault(d => d.ProjectId == id && d.CompanyId == companyId);
        }

        public IEnumerable<Project> GetAllProjects(string companyId)
        {
            return ApplicationDbContext.Projects
                .Where(r => r.CompanyId == companyId)
                .OrderByDescending(d => d.ProjectStartDate).ThenBy(r => r.ProjectStatus).ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
