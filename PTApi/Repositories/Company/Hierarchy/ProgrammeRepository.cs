using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class ProgrammeRepository : Repository<Programme>, IProgrammeRepository
    {
        public ProgrammeRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public Programme GetOneProgramme(string id, string companyId)
        {
            return ApplicationDbContext.Programmes.SingleOrDefault(d => d.Id == id && d.CompanyId == companyId);
        }

        public Programme GetOneProgrammeWithPortfolio(string id, string companyId)
        {
            return ApplicationDbContext.Programmes.Include(d => d.Portfolio).SingleOrDefault(d => d.Id == id && d.CompanyId == companyId);
        }

        public Programme GetOneProgrammeWithProjects(string id, string companyId)
        {
            return ApplicationDbContext.Programmes.Include(d => d.Projects).SingleOrDefault(d => d.Id == id && d.CompanyId == companyId);
        }

        public Programme GetOneProgrammeWithProjectsThenPortfolios(string id, string companyId)
        {
            return ApplicationDbContext.Programmes.Include(d => d.Projects).ThenInclude(p => p.Portfolio).SingleOrDefault(d => d.Id == id && d.CompanyId == companyId);
        }

        public IEnumerable<Programme> GetAllProgrammesOnly(string companyId)
        {
            return ApplicationDbContext.Programmes.OrderByDescending(d => d.ProgrammeName).ToList();
        }

        public IEnumerable<Programme> GetAllProgrammeWithProjectsThenPortfolios(string companyId)
        {
            return ApplicationDbContext.Programmes
                .Include(d => d.Portfolio)
                .Include(d => d.Projects).ThenInclude(p => p.Portfolio)
                .OrderBy(d => d.ProgrammeName)
                //.ThenBy(d => d.Projects)
                .ToList();
        }
        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
