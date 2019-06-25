using PTApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PTApi.Data.Repositories
{
    public interface IActualRepository : IRepository<Actual>
    {
        Actual GetOneProjectActual(string id, string companyId);
        IEnumerable<Actual> GetAllCompanyActuals(string companyId);
        IEnumerable<Actual> GetAllProjectActuals(string id, string companyId);
        IEnumerable<ReconciledActual> GetAllProjectReconciledActuals(string id, string companyId);

        Task<Actual> GetActual(string id);
        Task<IEnumerable<Actual>> GetRecentlyUploadedActuals(string companyId, string id);
    }
}


