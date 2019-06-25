using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class CompanyMethodologyRepository : Repository<CompanyMethodology>, ICompanyMethodologyRepository
    {
        public CompanyMethodologyRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public CompanyMethodology GetCompanyMethodology(string id, string companyId)
        {
            return ApplicationDbContext.CompanyMethodologies.SingleOrDefault(b => b.CompanyMethodologyId == id && b.CompanyId == companyId);
        }

        public CompanyMethodology GetCompanyMethodologyWithCompanyMethodologyStages(string id, string companyId)
        {
            return ApplicationDbContext.CompanyMethodologies.Include(b => b.CompanyMethodologyStages).SingleOrDefault(b => b.CompanyMethodologyId == id && b.CompanyId == companyId);
        }

        public IEnumerable<CompanyMethodology> GetAllCompanyMethodologies(string companyId)
        {
            return ApplicationDbContext.CompanyMethodologies.Where(b => b.CompanyId == companyId).OrderByDescending(b => b.MethodologyName).ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
