using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IIssueRepository : IRepository<Issue>
    {
        Issue GetOneIssue(string id, string companyId);

        IEnumerable<Issue> GetAllIssuesOnly(string id, string companyId);
    }
}






