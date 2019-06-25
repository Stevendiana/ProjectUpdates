using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class CompanyRateCardRepository : Repository<CompanyRateCard>, ICompanyRateCardRepository
    {
        public CompanyRateCardRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public CompanyRateCard GetOneCompanyRateCard(string id, string companyId)
        {
            return ApplicationDbContext.CompanyRateCards.SingleOrDefault(d => d.CompanyRateCardId == id && d.CompanyId == companyId);
        }

        public IEnumerable<CompanyRateCard> GetAllCompanyRateCardsOnly(string companyId)
        {
            return ApplicationDbContext.CompanyRateCards.OrderByDescending(d => d.EmployeeJobTitleOrGradeOrBand).ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
