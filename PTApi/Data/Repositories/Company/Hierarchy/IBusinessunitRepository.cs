using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IBusinessunitRepository : IRepository<BusinessUnit>
    {
        BusinessUnit GetBusinessUnitWithDomains(string id, string companyId);
        IEnumerable<BusinessUnit> GetAllBusinessUnits(string companyId);
    }
}
