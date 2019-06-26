using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProjectPermissionController: Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ProjectCentreDbContext _appDbContext;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public ProjectPermissionController(UserManager<AppUser> userManager, IMapper mapper,ProjectCentreDbContext appDbContext, IUserService userService )
        {
            _userManager = userManager;
            _userManager = userManager;
            _mapper=mapper;
            _userService=userService;
            _appDbContext = appDbContext ;
        }



         //Get All resources' projects permitted.
        [Authorize]
        [HttpGet("projectspermitted/{companyId}/{resourceId}")]
        public async Task<IEnumerable<ProjectPermittedViewModel>> GetAllProjectsPermitted(string companyId, string resourceId)
        {
            if (!string.IsNullOrEmpty(companyId) && !string.IsNullOrEmpty(resourceId))
            {
                if (_userService.UserRoleGroup() == "Admin_Group")
                {
                    var allProjectsPermittedAdmin = await _appDbContext.Projects.Where(b => (b.CompanyId == companyId)).Include(b => b.Company).ToListAsync();
                    return Mapper.Map<List<Project>, List<ProjectPermittedViewModel>>(allProjectsPermittedAdmin);
                }

                var allProjectsPermittedNon_Admin = await _appDbContext.ProjectPermitted
                            .Where(b => (b.CompanyId == companyId) && (b.ResourceId == resourceId)).Include(b => b.Project).Include(b => b.Company).ToListAsync();

                return Mapper.Map<List<ProjectPermitted>, List<ProjectPermittedViewModel>>(allProjectsPermittedNon_Admin);

            }
            return await Task.FromResult<IEnumerable<ProjectPermittedViewModel>>(null);
        }
    }
}