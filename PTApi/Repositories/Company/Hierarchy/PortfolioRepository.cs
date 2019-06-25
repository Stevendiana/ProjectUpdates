using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class PortfolioRepository : Repository<Portfolio>, IPortfolioRepository
    {
        public PortfolioRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public Portfolio GetOnePortfolio(string id, string companyId)
        {
            return ApplicationDbContext.Portfolios.SingleOrDefault(d => d.Id == id && d.CompanyId == companyId);
        }

        public Portfolio GetOnePortfolioWithDomain(string id, string companyId)
        {
            return ApplicationDbContext.Portfolios.Include(d => d.Domain).SingleOrDefault(d => d.Id == id && d.CompanyId == companyId);
        }

        public Portfolio GetOnePortfolioWithProgrammes(string id, string companyId)
        {
            return ApplicationDbContext.Portfolios.Include(d => d.Programmes).SingleOrDefault(d => d.Id == id && d.CompanyId == companyId);
        }

        public Portfolio GetOnePortfolioWithProjects(string id, string companyId)
        {
            return ApplicationDbContext.Portfolios.Include(d => d.Projects).SingleOrDefault(d => d.Id == id && d.CompanyId == companyId);
        }

        public Portfolio GetOnePortfolioWithProjectsThenProgrammes(string id, string companyId)
        {
            return ApplicationDbContext.Portfolios.Include(d => d.Projects).ThenInclude(p => p.Programme).SingleOrDefault(d => d.Id == id && d.CompanyId == companyId);
        }

        public IEnumerable<Portfolio> GetAllPortfoliosOnly(string companyId)
        {
            return ApplicationDbContext.Portfolios.OrderByDescending(d => d.PortfolioName).ToList();
        }

        public IEnumerable<Portfolio> GetAllPortfoliosWithProjectsWithProgrammeAndDomain(string companyId)
        {
            return ApplicationDbContext.Portfolios
                .Include(d => d.Domain)
                .Include(d => d.Projects).ThenInclude(p => p.Programme)
                .OrderBy(d => d.PortfolioName)
                //.ThenBy(d => d.Projects)
                .ToList();
        }
        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
