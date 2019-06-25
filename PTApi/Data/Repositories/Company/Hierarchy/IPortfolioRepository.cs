using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IPortfolioRepository : IRepository<Portfolio>
    {
        Portfolio GetOnePortfolio(string id, string companyId);
        Portfolio GetOnePortfolioWithDomain(string id, string companyId);
        Portfolio GetOnePortfolioWithProgrammes(string id, string companyId);
        Portfolio GetOnePortfolioWithProjects(string id, string companyId);
        Portfolio GetOnePortfolioWithProjectsThenProgrammes(string id, string companyId);


        IEnumerable<Portfolio> GetAllPortfoliosOnly(string companyId);
        IEnumerable<Portfolio> GetAllPortfoliosWithProjectsWithProgrammeAndDomain(string companyId);
    }
}
