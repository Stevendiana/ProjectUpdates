using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class CompanyMethodologyStageRepository : Repository<CompanyMethodologyStage>, ICompanyMethodologyStageRepository
    {
        public CompanyMethodologyStageRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public CompanyMethodologyStage GetOneCompanyMethodologyStage(string id, string companyId)
        {
            return ApplicationDbContext.CompanyMethodologyStages.SingleOrDefault(d => d.CompanyMethodologyStageId == id && d.CompanyId == companyId);
        }

        public CompanyMethodologyStage GetOneCompanyMethodologyStageWithCompanyMethodology(string id, string companyId)
        {
            return ApplicationDbContext.CompanyMethodologyStages.Include(d => d.CompanyMethodology).SingleOrDefault(d => d.CompanyMethodologyStageId == id && d.CompanyId == companyId);
        }

        public IEnumerable<CompanyMethodologyStage> GetAllCompanyMethodologyStagesOnly(string companyId)
        {
            return ApplicationDbContext.CompanyMethodologyStages.OrderByDescending(d => d.CompanyMethodologyStageName).ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
