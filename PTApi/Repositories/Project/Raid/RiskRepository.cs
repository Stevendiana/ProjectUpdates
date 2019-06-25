using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class RiskRepository : Repository<Risk>, IRiskRepository
    {
        public RiskRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public Risk GetOneRisk(string id, string companyId)
        {
            return ApplicationDbContext.Risks.SingleOrDefault(d => d.RiskId == id && d.CompanyId == companyId);
        }

        public IEnumerable<Risk> GetAllRisksOnly(string id, string companyId)
        {
            return ApplicationDbContext.Risks
                .Where(r => r.RiskId == id && r.CompanyId == companyId)
                .OrderByDescending(d => d.Year).ThenByDescending(r => r.DateRaised).ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
