using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTApi.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly IUserService _userSevice;
        private readonly IMapper _mapper;

        public PermissionService(ApplicationDbContext appDbContext, IMapper mapper, IUserService userSevice)
        {
            _appDbContext = appDbContext;
            _userSevice = userSevice;
             _mapper=mapper;
        }

        public PermissionService()
        {

        }

        public class ForecastHoursTotals
        {
            public int? ForecastHours { get; set; }
            public int? ReconciledForecastHours { get; set; }

        }


        public class Totals
        {
            public int? ForecastHours { get; set; }
            public int? ReconciledForecastHours { get; set; }
            public int? Projects { get; set; }
            public int? Programmes { get; set; }
            public int? Portfolios { get; set; }
            public int? Domains { get; set; }
            public int? BusinessUnits { get; set; }

        }

        public async Task <Totals> GetAllTotals( string resourceId, string companyId)
        {

            var projectList=  await _appDbContext.Projects.Where(p => p.CompanyId == companyId).Select(c=>c.ProjectId).ToListAsync();
            var projects =  projectList.Count();

            var programmeList= await _appDbContext.Programmes.Where(p => p.CompanyId == companyId).Select(c=>c.Id).ToListAsync();
            var programmes =  programmeList.Count();

            var portfolioList= await _appDbContext.Portfolios.Where(p => p.CompanyId == companyId).Select(c=>c.Id).ToListAsync();
            var portfolios =  portfolioList.Count();

            var domainList= await _appDbContext.Domains.Where(p => p.CompanyId == companyId).Select(c=>c.Id).ToListAsync();
            var domains =  domainList.Count();

            var businessUnitList= await _appDbContext.BusinessUnits.Where(p => p.CompanyId == companyId).Select(c=>c.Id).ToListAsync();
            var businessUnits =  businessUnitList.Count();


            return new Totals(){
            Projects = projects,
            Programmes = programmes,
            Portfolios  = portfolios,
            Domains  = domains,
            BusinessUnits  = businessUnits,
            };
        }

        public async Task <Totals> GetPermittedTotals( string resourceId, string companyId)
        {

            var permittedProjectList= await _appDbContext.ProjectPermitted.Where(c => (c.ResourceId == resourceId)&& c.CompanyId ==companyId).Select(c=>c.Id).ToListAsync();
            var permprojects = permittedProjectList.Count();

            //var permittedProgrammeList= await _appDbContext.ProgrammePermitted.Where(c => (c.ResourceId == resourceId)&& c.CompanyId ==companyId).Select(c=>c.Id).ToListAsync();
            //var permprogrammes = permittedProgrammeList.Count();

            //var permittedPortfolioList= await _appDbContext.PortfolioPermitted.Where(c => (c.ResourceId == resourceId)&& c.CompanyId ==companyId).Select(c=>c.PortfolioId).ToListAsync();
            //var permportfolio = permittedPortfolioList.Count();

            //var permittedDomainList= await _appDbContext.DomainPermitted.Where(c => (c.ResourceId == resourceId)&& c.CompanyId ==companyId).Select(c=>c.DomainId).ToListAsync();
            //var permdomain = permittedDomainList.Count();

            //var permittedBusinessUnitList= await _appDbContext.BusinessUnitPermitted.Where(c => (c.ResourceId == resourceId)&& c.CompanyId ==companyId).Select(c=>c.BusinessUnitId).ToListAsync();
            //var permbusinessUnit = permittedBusinessUnitList.Count();

            return new Totals(){
            Projects = permprojects,
            //Programmes = permprogrammes,
            //Portfolios  = permportfolio,
            //Domains  = permdomain,
            //BusinessUnits  = permbusinessUnit,
            };
        }

        public async Task<ICollection<Project>> GetAllProjectsPermitted(string resourceId,string companyId, string rolGroup)
        {
            if (!string.IsNullOrEmpty(companyId) && !string.IsNullOrEmpty(resourceId))
            {
                if (rolGroup == "Admin_Group")
                {
                    var allProjectsPermittedAdmin = await _appDbContext.Projects.Where(b => (b.CompanyId == companyId)).Select(c=>c).ToListAsync();
                    return allProjectsPermittedAdmin;
                }
                else
                {
                    var allProjectsPermittedNon_Admin = await _appDbContext.ProjectPermitted.Include(p=>p.Project).Where(c => (c.ResourceId == resourceId)&& c.CompanyId ==companyId).Select(c=>c.Project).ToListAsync();
                    return allProjectsPermittedNon_Admin;
                }

            }
            return await Task.FromResult<ICollection<Project>>(null);
        }


    }
}