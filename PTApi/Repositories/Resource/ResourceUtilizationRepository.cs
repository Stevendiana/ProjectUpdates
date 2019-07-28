using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class ResourceUtilizationRepository : Repository<ResourceUtilizationSummary>, IResourceUtilizationRepository
    {
        public ResourceUtilizationRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public ResourceUtilizationSummary GetOneResourceUtilizationOneyear(string id, int year)
        {
            return ApplicationDbContext.ResourceUtilizationSummaries.SingleOrDefault(d => d.ResourceUtilizationSummaryId == id && d.Year == year);
        }

        public IEnumerable<ResourceUtilizationSummary> GetAllResourcesUtilization( string companyId)
        {
            return ApplicationDbContext.ResourceUtilizationSummaries.Where(d => d.CompanyId == companyId);
        }

        public ResourceUtilizationSummary GetOneAllResourceUtilization(string id, string companyId)
        {
            return ApplicationDbContext.ResourceUtilizationSummaries.SingleOrDefault(d => d.ResourceUtilizationSummaryId == id && d.CompanyId == companyId);
        }


        public IEnumerable<ResourceUtilizationSummary> GetAllResourceUtilization(string id, string companyId)
        {
            return ApplicationDbContext.ResourceUtilizationSummaries
                .Where(r => r.CompanyId == companyId && r.ResourceId == id)
                .OrderByDescending(d => d.Year).ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
