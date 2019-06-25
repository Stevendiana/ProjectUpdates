using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface ICompanyMethodologyStageRepository : IRepository<CompanyMethodologyStage>
    {
        CompanyMethodologyStage GetOneCompanyMethodologyStage(string id, string companyId);
        CompanyMethodologyStage GetOneCompanyMethodologyStageWithCompanyMethodology(string id, string companyId);
        IEnumerable<CompanyMethodologyStage> GetAllCompanyMethodologyStagesOnly(string companyId);
        

    }
}
