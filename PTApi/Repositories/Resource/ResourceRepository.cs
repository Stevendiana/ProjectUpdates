using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class ResourceRepository : Repository<Resource>, IResourceRepository
    {
        public ResourceRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public Resource GetOneResouce(string id, string companyId)
        {
            return ApplicationDbContext.Resources.Include(d => d.CompanyRateCard).SingleOrDefault(d => d.ResourceId == id && d.CompanyId == companyId);
        }

        public decimal? GetResourceContractedEffortHours(string id, string companyId)
        {
            return GetOneResouce(id, companyId).ContractedHours;

        }

       

        public IEnumerable<Resource> GetAllResources(string companyId)
        {
            return ApplicationDbContext.Resources
                .Include(d => d.CompanyRateCard)
                .Where(r => r.CompanyId == companyId)
                .OrderByDescending(d => d.ResourceStartDate).ThenBy(r => r.LastName).ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
