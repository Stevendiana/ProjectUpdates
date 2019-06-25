using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IPlatformRepository : IRepository<Platform>
    {
        Platform GetOnePlatform(string id, string companyId);
        Platform GetOnePlatformWithPortfolios(string id, string companyId);
        IEnumerable<Platform> GetAllPlatformsOnly(string companyId);
        IEnumerable<Platform> GetAllPlatformsWithResources(string companyId);
        
    }
}
