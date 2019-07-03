using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class DomainRepository : Repository<Domain>, IDomainRepository
    {
        public DomainRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public Domain GetOneDomain(string id, string companyId)
        {
            return ApplicationDbContext.Domains.SingleOrDefault(d => d.Id == id && d.CompanyId == companyId );
        }

        public Domain GetOneDomainWithBusinessUnit(string id, string companyId)
        {
            return ApplicationDbContext.Domains.SingleOrDefault(d => d.Id == id && d.CompanyId == companyId );
        }

        public Domain GetOneDomainWithPortfolios(string id, string companyId)
        {
            return ApplicationDbContext.Domains.Include(d => d.Portfolios).SingleOrDefault(d => d.Id == id && d.CompanyId == companyId);
        }

        public Domain GetOneDomainWithPortfoliosAndBusinessUnit(string id, string companyId)
        {
            return ApplicationDbContext.Domains.Include(d => d.Portfolios).Include(d => d.Businessunits)
                .SingleOrDefault(d => d.Id == id && d.CompanyId == companyId);
        }

        public IEnumerable<Domain> GetAllDomainsOnly(string companyId)
        {
            return ApplicationDbContext.Domains.OrderByDescending(d => d.DomainName).ToList();
        }

        public IEnumerable<Domain> GetAllDomainsWithPortfoliosAndBusinessUnit(string companyId)
        {
            return ApplicationDbContext.Domains
                .Include(d => d.Portfolios).Include(d => d.Businessunits)
                .OrderBy(d => d.DomainName)
                .ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
