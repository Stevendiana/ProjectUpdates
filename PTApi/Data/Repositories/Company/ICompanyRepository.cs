using PTApi.Models;

namespace PTApi.Data.Repositories
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Company Getcompany(string companyId);
    }
}



