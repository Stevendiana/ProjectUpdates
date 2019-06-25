using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IAssumptionRepository : IRepository<Assumption>
    {
        Assumption GetOneAssumption(string id, string companyId);

        IEnumerable<Assumption> GetAllAssumptionsOnly(string id, string companyId);


    }
}






