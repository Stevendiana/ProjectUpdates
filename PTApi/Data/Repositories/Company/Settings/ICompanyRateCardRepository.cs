using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface ICompanyRateCardRepository : IRepository<CompanyRateCard>
    {
        CompanyRateCard GetOneCompanyRateCard(string id, string companyId);
        IEnumerable<CompanyRateCard> GetAllCompanyRateCardsOnly(string companyId);
    }
}

