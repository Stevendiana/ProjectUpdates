using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{

    public class PlatformRepository : Repository<Platform>, IPlatformRepository
    {
        public PlatformRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public Platform GetOnePlatform(string id, string companyId)
        {
            return ApplicationDbContext.Platforms.SingleOrDefault(d => d.PlatformId == id && d.CompanyId == companyId);
        }

        public Platform GetOnePlatformWithPortfolios(string id, string companyId)
        {
            return ApplicationDbContext.Platforms.Include(d => d.Resources).SingleOrDefault(d => d.PlatformId == id && d.CompanyId == companyId);
        }

        public IEnumerable<Platform> GetAllPlatformsOnly(string companyId)
        {
            return ApplicationDbContext.Platforms.OrderByDescending(d => d.PlatformName).ToList();
        }

        public IEnumerable<Platform> GetAllPlatformsWithResources(string companyId)
        {
            return ApplicationDbContext.Platforms
                .Include(d => d.Resources)
                .OrderBy(d => d.PlatformName)
                .ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}