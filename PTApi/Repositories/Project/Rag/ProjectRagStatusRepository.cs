using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class ProjectRagStatusRepository : Repository<ProjectRagStatus>, IProjectRagStatusRepository
    {
        public ProjectRagStatusRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public ProjectRagStatus GetOneRag(string id, string companyId)
        {
            return ApplicationDbContext.ProjectRagStatus.SingleOrDefault(d => d.ProjectRagStatusId == id && d.CompanyId == companyId);
        }

        public IEnumerable<ProjectRagStatus> GetAllProjectRagStatusOnly(string id, string companyId)
        {
            return ApplicationDbContext.ProjectRagStatus
                .Where( r => r.ProjectRagStatusId == id && r.CompanyId == companyId)
                .OrderByDescending(d => d.Year).ThenBy(r => r.ReportingPeriodNumbers).ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
