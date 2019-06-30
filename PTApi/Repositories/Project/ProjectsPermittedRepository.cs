
using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class ProjectsPermittedRepository : Repository<ProjectsPermitted>, IProjectsPermittedRepository
    {
        public ProjectsPermittedRepository(ApplicationDbContext context)
            : base(context)
        {
        }

       
        public ProjectsPermitted GetOneUserPermitted(string projectId, string resourceId, string companyId)
        {
            return ApplicationDbContext.ProjectsIamPermitted.SingleOrDefault(d => d.ProjectId == projectId && d.ResourceId == resourceId && d.CompanyId == companyId);
        }


        public IEnumerable<ProjectsPermitted> GetAllUsersPermitted(string companyId, string id)
        {
            return ApplicationDbContext.ProjectsIamPermitted.Include(r => r.Resource)
                .Where(r => r.CompanyId == companyId && r.ProjectId == id)
                .OrderByDescending(d => d.Resource.FirstName).ThenBy(r => r.Resource.LastName).ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
