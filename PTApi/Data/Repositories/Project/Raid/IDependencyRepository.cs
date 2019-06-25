using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IDependencyRepository : IRepository<Dependency>
    {
        Dependency GetOneDependency(string id, string companyId);

        IEnumerable<Dependency> GetAllDependenciesOnly(string id, string companyId);


    }
}






