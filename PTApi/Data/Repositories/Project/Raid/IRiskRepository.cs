using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IRiskRepository : IRepository<Risk>
    {
        Risk GetOneRisk(string id, string companyId);

        IEnumerable<Risk> GetAllRisksOnly(string id, string companyId);


    }
}






