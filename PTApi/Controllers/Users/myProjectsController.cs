using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PTApi.Data.Repositories;
using PTApi.Methods;
using PTApi.Models;
using PTApi.Services;
using PTApi.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PTApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class MyProjectsController: Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IForecastService _forecastService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;


        public MyProjectsController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, IGetIdsWithPartIdsMethod getIdsWithPartIds,
            IGeneratePublicIdMethod getpublicId, IForecastService forecastService, IUserService userService, IProjectService projectService, IMapper mapper)
        {
            _userService = userService;
            _projectService = projectService;
            _forecastService = forecastService;
            _unitOfWork = unitOfWork;
            _getIdsWithPartIds = getIdsWithPartIds;
            _getpublicId = getpublicId;
            _userManager = userManager;
            _mapper = mapper;
        }

        private string CreateNewId(string id)
        {
            return _getpublicId.PartId(id, 8);
        }


        //Get All resources' projects permitted.
        [Authorize]
        [HttpGet("myprojects/{companyId}")]
        public async Task<IEnumerable<myProjectsViewModel>> GetAllMyProjects(string companyId)
        {
            var user = _userService.GetSecureUserId();
            var comp = _userService.GetSecureUserCompany();

            if (!string.IsNullOrEmpty(comp) && !string.IsNullOrEmpty(user))
            {
                if (_userService.UserRoleGroup() == "Admin_Group")
                {
                    var allProjectsPermittedAdmin = _unitOfWork.Projects.CombineAllProjectsAndProjectsFollowingForAdmin(user, comp);
                    return Mapper.Map<IEnumerable<myProjects>, IEnumerable<myProjectsViewModel>>(allProjectsPermittedAdmin);
                }

                var allProjectsPermittedNon_Admin = _unitOfWork.Projects.CombineAllProjectsPermitted(user, comp);

                return Mapper.Map<IEnumerable<myProjects>, IEnumerable < myProjectsViewModel>>(allProjectsPermittedNon_Admin);

            }
            return await Task.FromResult<IEnumerable<myProjectsViewModel>>(null);
        }
    }
}