using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IDomainRepository : IRepository<Domain>
    {
        
        Domain GetOneDomain(string id, string companyId);
        Domain GetOneDomainWithBusinessUnit(string id, string companyId);
        Domain GetOneDomainWithPortfolios(string id, string companyId);
        Domain GetOneDomainWithPortfoliosAndBusinessUnit(string id, string companyId);
        IEnumerable<Domain> GetAllDomainsOnly(string companyId);
        IEnumerable<Domain> GetAllDomainsWithPortfoliosAndBusinessUnit(string companyId);
    }
}
