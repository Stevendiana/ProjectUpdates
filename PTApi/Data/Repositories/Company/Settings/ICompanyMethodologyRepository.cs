using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface ICompanyMethodologyRepository : IRepository<CompanyMethodology>
    {
        CompanyMethodology GetCompanyMethodology(string id, string companyId);
        CompanyMethodology GetCompanyMethodologyWithCompanyMethodologyStages(string id, string companyId);
        IEnumerable<CompanyMethodology> GetAllCompanyMethodologies(string companyId);
    }
}




