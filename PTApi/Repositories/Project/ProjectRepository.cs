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


        public IEnumerable<myProjects> GetAllProjectsandthoseIamFollowing(string id, string companyId)
        {
            return ApplicationDbContext.Projects
                .Where(p => p.CompanyId == companyId)
                .Join(ApplicationDbContext.ProjectsIamFollowing.Where(p => p.CompanyId == companyId && p.UserId == id),
                pp => pp.ProjectId,
                pf => pf.ProjectId,
                (allowed, following) =>
                new myProjects
                {
                    ProjectId = allowed.ProjectId,
                    Project = allowed,
                    CanEdit = true,
                    Following = following.Following,
                })
                .ToList();
        }

        public IEnumerable<myProjects> GetAllProjectsIamPermittedandFollowing(string id, string companyId)
        {
            return ApplicationDbContext.ProjectsIamPermitted
                .Where(p => p.CompanyId == companyId && p.UserId == id)
                .Join(ApplicationDbContext.ProjectsIamFollowing.Where(p => p.CompanyId == companyId && p.UserId == id),
                pp => pp.ProjectId,
                pf => pf.ProjectId,
                (allowed, following) =>
                new myProjects
                {
                    ProjectId = allowed.ProjectId,
                    Project = allowed.Project,
                    CanEdit = allowed.CanEdit,
                    Following = following.Following,
                })
                .ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
