using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Linq;

namespace PTApi.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public Company Getcompany(string companyId)
        {
            return ApplicationDbContext.Companies.Include(c=>c.CompanyCurrency).SingleOrDefault(b => b.CompanyId == companyId);
        }

     

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
