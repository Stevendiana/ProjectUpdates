using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class DependencyRepository : Repository<Dependency>, IDependencyRepository
    {
        public DependencyRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public Dependency GetOneDependency(string id, string companyId)
        {
            return ApplicationDbContext.Dependencies.SingleOrDefault(d => d.DependencyId == id && d.CompanyId == companyId);
        }

        public IEnumerable<Dependency> GetAllDependenciesOnly(string id, string companyId)
        {
            return ApplicationDbContext.Dependencies
                .Where(r => r.DependencyId == id && r.CompanyId == companyId)
                .OrderByDescending(d => d.Year).ThenBy(r => r.DateRaised).ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
