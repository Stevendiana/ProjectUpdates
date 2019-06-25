using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class BusinessunitRepository : Repository<BusinessUnit>, IBusinessunitRepository
    {
        public BusinessunitRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public BusinessUnit GetBusinessUnit(string id, string companyId)
        {
            return ApplicationDbContext.BusinessUnits.SingleOrDefault(b => b.Id == id && b.CompanyId == companyId );
        }

        public BusinessUnit GetBusinessUnitWithDomains(string id, string companyId)
        {
            return ApplicationDbContext.BusinessUnits.Include(b => b.Domains).SingleOrDefault(b => b.Id == id && b.CompanyId == companyId);
        }

        public IEnumerable<BusinessUnit> GetAllBusinessUnits(string companyId)
        {
            return ApplicationDbContext.BusinessUnits.OrderByDescending(b => b.BusinessUnitName).ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
