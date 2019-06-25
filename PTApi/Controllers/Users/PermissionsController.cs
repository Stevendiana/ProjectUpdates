using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCentreBackend.Helpers;
using ProjectCentreBackend.Models;
using ProjectCentreBackend.Models.Entities;
using ProjectCentreBackend.Persistence;
using ProjectCentreBackend.ViewModels;

namespace ProjectCentreBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PermissionsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ProjectCentreDbContext _appDbContext;
        private readonly IMapper _mapper;

        public PermissionsController(UserManager<AppUser> userManager, IMapper mapper,ProjectCentreDbContext appDbContext )
        {
            _userManager = userManager;
            _userManager = userManager;
            _mapper=mapper;
            _appDbContext = appDbContext ;
        }


        public string GetSecureUserRole()
        {
            var role = User.Claims.Single(c=>c.Type=="rol").Value;
            return role;
        }

        public string UserRoleGroup()
        {
            var userRole = GetSecureUserRole();

            if (userRole == Constants.Strings.JwtClaims.AccountOwner
              ||userRole == Constants.Strings.JwtClaims.Admin ||
               userRole == Constants.Strings.JwtClaims.SuperAdmin)
            {
                return "Admin_Group";
            }

            if (userRole == Constants.Strings.JwtClaims.ProjectManager
              ||userRole == Constants.Strings.JwtClaims.SeniorProjectManager ||
               userRole == Constants.Strings.JwtClaims.PortfolioAdmin)
            {
                return "Portfolio_Group";
            }

            if (userRole == Constants.Strings.JwtClaims.FinanceAdmin
              ||userRole == Constants.Strings.JwtClaims.FinanceManager)
            {
                return "Finance_Group";
            }
            else
            {
                return "Other_Group";
            }
        }



         //Get All resources' businessunits permitted.
        [Authorize]
        [HttpGet("businessunitspermitted/{companyId}/{resourceId}")]
        public async Task<IEnumerable<BusinessUnitPermittedViewModel>> GetBusinessUnitsPermitted(string companyId, string resourceId)
        {
            if (!string.IsNullOrEmpty(companyId) && !string.IsNullOrEmpty(resourceId))
            {
                if (UserRoleGroup() == "Admin_Group")
                {
                    var allBusinessUnitsPermittedAdmin = await _appDbContext.BusinessUnits.Where(b => (b.CompanyId == companyId)).ToListAsync();
                    return Mapper.Map<List<BusinessUnit>, List<BusinessUnitPermittedViewModel>>(allBusinessUnitsPermittedAdmin);

                }

                var allBusinessUnitsPermitted = await _appDbContext.BusinessUnitPermitted.Where(b => (b.CompanyId == companyId) && (b.ResourceId == resourceId)).ToListAsync();
                return Mapper.Map<List<BusinessUnitPermitted>, List<BusinessUnitPermittedViewModel>>(allBusinessUnitsPermitted);

            }
            return await Task.FromResult<IEnumerable<BusinessUnitPermittedViewModel>>(null);
        }


        //Get All resources' domains permitted.
        [Authorize]
        [HttpGet("domainspermitted/{companyId}/{resourceId}")]
        public async Task<IEnumerable<DomainPermittedViewModel>> GetDomainsPermitted(string companyId, string resourceId)
        {
            if (!string.IsNullOrEmpty(companyId) && !string.IsNullOrEmpty(resourceId))
            {
                if (UserRoleGroup() == "Admin_Group")
                {
                    var allDomainsPermittedAdmin = await _appDbContext.Domains.Where(b => (b.CompanyId == companyId)).ToListAsync();
                    return Mapper.Map<List<Domain>, List<DomainPermittedViewModel>>(allDomainsPermittedAdmin);

                }

                var allDomainsPermitted = await _appDbContext.DomainPermitted.Where(b => (b.CompanyId == companyId) && (b.ResourceId == resourceId)).ToListAsync();
                return Mapper.Map<List<DomainPermitted>, List<DomainPermittedViewModel>>(allDomainsPermitted);

            }
            return await Task.FromResult<IEnumerable<DomainPermittedViewModel>>(null);
        }

        //Get All resources' portfolios permitted.
        [Authorize]
        [HttpGet("portfoliospermitted/{companyId}/{resourceId}")]
        public async Task<IEnumerable<PortfolioPermittedViewModel>> GetPortfoliosPermitted(string companyId, string resourceId)
        {
            if (!string.IsNullOrEmpty(companyId) && !string.IsNullOrEmpty(resourceId))
            {
                if (UserRoleGroup() == "Admin_Group")
                {
                    var allPortfoliosPermittedAdmin = await _appDbContext.Portfolios.Where(b => (b.CompanyId == companyId)).ToListAsync();
                    return Mapper.Map<List<Portfolio>, List<PortfolioPermittedViewModel>>(allPortfoliosPermittedAdmin);

                }

                var allPortfoliosPermitted = await _appDbContext.PortfolioPermitted.Where(b => (b.CompanyId == companyId) && (b.ResourceId == resourceId)).ToListAsync();
                return Mapper.Map<List<PortfolioPermitted>, List<PortfolioPermittedViewModel>>(allPortfoliosPermitted);

            }
            return await Task.FromResult<IEnumerable<PortfolioPermittedViewModel>>(null);
        }


        //Get All resources' programmes permitted.
        [Authorize]
        [HttpGet("programmespermitted/{companyId}/{resourceId}")]
        public async Task<IEnumerable<ProgrammePermittedViewModel>> GetProgrammesPermitted(string companyId, string resourceId)
        {
            if (!string.IsNullOrEmpty(companyId) && !string.IsNullOrEmpty(resourceId))
            {
                if (UserRoleGroup() == "Admin_Group")
                {
                    var allProgrammesPermittedAdmin = await _appDbContext.Programmes.Where(b => (b.CompanyId == companyId)).ToListAsync();
                    return Mapper.Map<List<Programme>, List<ProgrammePermittedViewModel>>(allProgrammesPermittedAdmin);

                }

                var allProgrammesPermitted = await _appDbContext.ProgrammePermitted.Where(b => (b.CompanyId == companyId) && (b.ResourceId == resourceId)).ToListAsync();
                return Mapper.Map<List<ProgrammePermitted>, List<ProgrammePermittedViewModel>>(allProgrammesPermitted);

            }
            return await Task.FromResult<IEnumerable<ProgrammePermittedViewModel>>(null);
        }


        //Get All resources' projects permitted.
        [Authorize]
        [HttpGet("projectspermitted/{companyId}/{resourceId}")]
        public async Task<IEnumerable<ProjectPermittedViewModel>> GetProjectsPermitted(string companyId, string resourceId)
        {
            if (!string.IsNullOrEmpty(companyId) && !string.IsNullOrEmpty(resourceId))
            {
                if (UserRoleGroup() == "Admin_Group")
                {
                    var allProjectsPermittedAdmin = await _appDbContext.Projects.Where(b => (b.CompanyId == companyId)).ToListAsync();
                    return Mapper.Map<List<Project>, List<ProjectPermittedViewModel>>(allProjectsPermittedAdmin);

                }

                var allProjectsPermitted = await _appDbContext.ProjectPermitted.Where(b => (b.CompanyId == companyId) && (b.ResourceId == resourceId)).ToListAsync();
                return Mapper.Map<List<ProjectPermitted>, List<ProjectPermittedViewModel>>(allProjectsPermitted);

            }
            return await Task.FromResult<IEnumerable<ProjectPermittedViewModel>>(null);
        }

         //Get All resources' projects permitted.
        [Authorize]
        [HttpGet("allprojectspermitted/{companyId}/{resourceId}")]
        public async Task<IEnumerable<ProjectPermittedViewModel>> GetAllProjectsPermitted(string companyId, string resourceId)
        {
            if (!string.IsNullOrEmpty(companyId) && !string.IsNullOrEmpty(resourceId))
            {
                if (UserRoleGroup() != "Admin_Group")
                {
                    var allProjectsPermittedAdmin = await _appDbContext.Projects.Where(b => (b.CompanyId == companyId)).ToListAsync();
                    return Mapper.Map<List<Project>, List<ProjectPermittedViewModel>>(allProjectsPermittedAdmin);
                }

                // var projects = _appDbContext.Projects.Where(p => (p.CompanyId == companyId)).ToList();

                // var programmesPermitted = new HashSet<string>( _appDbContext.ProgrammePermitted.Where(b => (b.CompanyId == companyId)
                //                                    && b.ResourceId == resourceId).Select(p => p.ProgrammeId));
                // var programmeProjects = projects.Where(p => programmesPermitted.Contains(p.ParentId)).ToList();

                // var projectsPermitted = new HashSet<string>( _appDbContext.ProjectPermitted.Where(b => (b.CompanyId == companyId)
                //                                    && b.ResourceId == resourceId).Select(p => p.ProjectId));
                // var Projectprojects = projects.Where(p => projectsPermitted.Contains(p.Id)).ToList();

                // var dict = Projectprojects.ToDictionary(p => p.Id);
                // foreach (var project in programmeProjects)
                // {
                //         dict[project.Id] = project;
                // }
                // var allProjectsPermitted = dict.Values.ToList();

                var allProjectsPermittedNon_Admin = await _appDbContext.ProjectPermitted
                            .Where(b => (b.CompanyId == companyId) && (b.ResourceId == resourceId)).Include(b => b.Project).ToListAsync();

                return Mapper.Map<List<ProjectPermitted>, List<ProjectPermittedViewModel>>(allProjectsPermittedNon_Admin);

            }
            return await Task.FromResult<IEnumerable<ProjectPermittedViewModel>>(null);
        }

    }
}