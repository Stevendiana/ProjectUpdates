using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class AssumptionRepository : Repository<Assumption>, IAssumptionRepository
    {
        public AssumptionRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public Assumption GetOneAssumption(string id, string companyId)
        {
            return ApplicationDbContext.Assumptions.SingleOrDefault(d => d.AssumptionId == id && d.CompanyId == companyId);
        }

        public IEnumerable<Assumption> GetAllAssumptionsOnly(string id, string companyId)
        {
            return ApplicationDbContext.Assumptions
                .Where(r => r.AssumptionId == id && r.CompanyId == companyId)
                .OrderByDescending(d => d.Year).ThenBy(r => r.LatestupdateDate).ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
