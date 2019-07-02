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
            return ApplicationDbContext.Projects.ToList()
                .Where(r => r.CompanyId == companyId)
                .OrderByDescending(d => d.ProjectStartDate).ThenBy(r => r.ProjectStatus);
        }

        public IEnumerable<string> GetAllProjectsId(string companyId)
        {
            return ApplicationDbContext.Projects.ToList()
                .Where(r => r.CompanyId == companyId)
                .Select(d => d.ProjectId);
        }

        public IEnumerable<string> GetAllDomainsPermitted(string id, string companyId)
        {
            return ApplicationDbContext.DomainsPermitted.ToList()
                .Where(d => d.CompanyId == companyId && d.UserId == id)
                .Select(d=>d.DomainId);

        }

        public IEnumerable<string> GetAllBusinessunitsPermitted(string id, string companyId)
        {
            return ApplicationDbContext.BusinessUnitsPermitted.ToList()
                .Where(d => d.CompanyId == companyId && d.UserId == id)
                .Select(d=>d.BusinessUnitId);

        }

        public IEnumerable<string> GetAllPortfoliosPermitted(string id, string companyId)
        {
            return ApplicationDbContext.PortfoliosPermitted.ToList()
                .Where(d => d.CompanyId == companyId && d.UserId == id)
                .Select(d=>d.PortfolioId);

        }

        public IEnumerable<string> GetAllProgrammesPermitted(string id, string companyId)
        {
            return ApplicationDbContext.ProgrammesPermitted.ToList()
                .Where(d => d.CompanyId == companyId && d.UserId == id)
                .Select(d=>d.ProgrammeId);

        }

        public IEnumerable<string> GetAllProjectsPermitted(string id, string companyId)
        {
            return ApplicationDbContext.ProjectsIamPermitted.ToList()
                .Where(d => d.CompanyId == companyId && d.UserId == id)
                .Select(d=>d.ProjectId);

        }

        public IEnumerable<myProjects> CombineAllProjectsPermitted(string id, string companyId)
        {
            var fromDomain = GetAllDomainsPermitted(id, companyId);
            var fromBusinessunit = GetAllBusinessunitsPermitted(id, companyId);
            var fromPortfolio = GetAllPortfoliosPermitted(id, companyId);
            var fromProgramme = GetAllProgrammesPermitted(id, companyId);
            var fromProjects = GetAllProjectsPermitted(id, companyId);

            var allprojects = GetAllProjects(companyId);

            List<string> domainprojects = new List<string>();
            List<string> businessunitProjects = new List<string>();
            List<string> portfolioprojects = new List<string>();
            List<string> programmeprojects = new List<string>();
            List<string> projects = new List<string>();

            projects.AddRange(fromProjects);


            foreach (var item in fromDomain) { var projectsInDomain = allprojects.Where(x => x.DomainId == item);
                foreach (var p in projectsInDomain) { domainprojects.Add(p.ProjectId); continue; } }

            foreach (var item in fromBusinessunit)
            {
                var projectsInBusinessunit = allprojects.Where(x => x.BusinessUnitId == item);
                foreach (var p in projectsInBusinessunit) { businessunitProjects.Add(p.ProjectId); continue; }
            }
            foreach (var item in fromPortfolio)
            {
                var projectsInPortfolio = allprojects.Where(x => x.PortfolioId == item);
                foreach (var p in projectsInPortfolio) { portfolioprojects.Add(p.ProjectId); continue; }
            }
            foreach (var item in fromProgramme)
            {
                var projectsInProgramme = allprojects.Where(x => x.ProgrammeId == item);
                foreach (var p in projectsInProgramme) { programmeprojects.Add(p.ProjectId); continue; }
            }


            var combined = domainprojects.Union(businessunitProjects).Union(portfolioprojects).Union(programmeprojects).Union(projects);

            return combined
                .Join(ApplicationDbContext.ProjectsIamFollowing.Where(p => p.CompanyId == companyId && p.UserId == id), 
                p => p, pf => pf.ProjectId, (pro, following) => new { pro, following })
                .Join(ApplicationDbContext.ProjectsIamPermitted.Where(p => p.CompanyId == companyId && p.UserId == id), 
                pf => pf.following.ProjectId, pp => pp.ProjectId, (following, allowed) => new { following, allowed})
                .Select( myp => new myProjects
                {
                    ProjectId = myp.following.following.ProjectId,
                    Project = myp.allowed.Project,
                    CanEdit = myp.allowed.CanEdit,
                    Following = myp.following.following.Following
                })
                .ToList();
        }

        public IEnumerable<myProjects> CombineAllProjectsAndProjectsFollowingForAdmin(string id, string companyId)
        {
            var allprojects = GetAllProjects(companyId);
            var followings = ApplicationDbContext.ProjectsIamFollowing.Where(p => p.CompanyId == companyId && p.UserId == id);

           return allprojects
                .Join(followings, 
                p => p.ProjectId, 
                pf => pf.ProjectId, 
                (pro, following) =>  new myProjects
                {
                    ProjectId = pro.ProjectId,
                    Project = pro,
                    CanEdit = true,
                    Following = following.Following
                }
                ).ToList();
        }

       

        
        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
