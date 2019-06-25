using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class IssueRepository : Repository<Issue>, IIssueRepository
    {
        public IssueRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public Issue GetOneIssue(string id, string companyId)
        {
            return ApplicationDbContext.Issues.SingleOrDefault(d => d.IssueId == id && d.CompanyId == companyId);
        }

        public IEnumerable<Issue> GetAllIssuesOnly(string id, string companyId)
        {
            return ApplicationDbContext.Issues
                .Where(r => r.IssueId == id && r.CompanyId == companyId)
                .OrderByDescending(d => d.Year).ThenBy(r => r.DateRaised).ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
