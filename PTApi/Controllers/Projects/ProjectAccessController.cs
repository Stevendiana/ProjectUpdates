using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PTApi.Data.Repositories;
using PTApi.Methods;
using PTApi.Models;
using PTApi.Services;
using PTApi.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProjectAccessController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IForecastService _forecastService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;


        public ProjectAccessController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, IGetIdsWithPartIdsMethod getIdsWithPartIds,
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

        public class EditProjectsPermittedData
        {

            [Required]
            public string UserId { get; set; }
            [Required]
            public string ResourceId { get; set; }
            [Required]
            public string CompanyId { get; set; }
            [Required]
            public string ProjectId { get; set; }
            public bool CanEdit { get; set; }
            //public Project Project { get; set; }
        }

        public class EditProjectsFollowingData
        {

            [Required]
            public string UserId { get; set; }
            [Required]
            public string ResourceId { get; set; }
            [Required]
            public string CompanyId { get; set; }
            [Required]
            public string ProjectId { get; set; }
            public bool Following { get; set; }
            //public Project Project { get; set; }
        }

        // Permission

        [Authorize]
        [HttpGet("permission/{projectId}/{resourceId}/{companyId}")]
        public ActionResult GetPermitted(string projectId, string resourceId, string companyId)
        {

            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            var UserDb = _unitOfWork.Permissions.GetOneUserPermitted(projectId, resourceId, comp);

            if (UserDb == null)
                return BadRequest();

            var PermissionData = _mapper.Map<ProjectsPermitted, ProjectsPermittedViewModel>(UserDb);

            return Ok(PermissionData);
        }

        [HttpGet("userspermitted/{projectId}/{companyId}")]
        [Authorize]
        public async Task<IEnumerable<ProjectsPermittedViewModel>> GetPermittedUsersForProject(string projectId, string companyId)
        {
            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return await Task.FromResult<IEnumerable<ProjectsPermittedViewModel>>(null);

            }

            var allUsers = _unitOfWork.Permissions.GetAllUsersPermitted(comp, projectId);

            return allUsers.Select(Mapper.Map<ProjectsPermitted, ProjectsPermittedViewModel>);
        }
       
        [Authorize]
        [HttpPost("editpermission")]
        public ActionResult EditPermission([FromBody] EditProjectsPermittedData model)
        {

            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (model.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
           
            var Permission = _unitOfWork.Permissions.GetOneUserPermitted(model.ProjectId, model.ResourceId, comp);


            if (Permission == null)
                return NotFound();

            var usertoadd = _unitOfWork.Users.GetOneUser(model.UserId, comp);

            _mapper.Map(model, Permission);

            Permission.CompanyId = comp;
            Permission.UserId = usertoadd.Id;
            Permission.ResourceId = usertoadd.ResourceId;
            Permission.ProjectId = model.ProjectId;
            Permission.CanEdit = model.CanEdit;

            _unitOfWork.Complete();

            Permission = _unitOfWork.Permissions.GetOneUserPermitted(model.ProjectId, model.ResourceId, comp);

            var result = _mapper.Map<ProjectsPermitted, ProjectsPermittedViewModel>(Permission);

            return Ok(result);

        }

        [Authorize]
        [HttpPost("createpermission")]
        public IActionResult CreatePermission([FromBody] EditProjectsPermittedData model)
        {
            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (model.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var usertoadd = _unitOfWork.Users.GetOneUser(model.UserId, comp);

            var id = Guid.NewGuid().ToString();

            var Permission = _mapper.Map<EditProjectsPermittedData, ProjectsPermitted>(model);

            Permission.CompanyId = comp;
            Permission.UserId = usertoadd.Id;
            Permission.ResourceId = usertoadd.ResourceId;
            Permission.ProjectId = model.ProjectId;
            Permission.CanEdit = model.CanEdit;

            _unitOfWork.Permissions.Add(Permission);
            _unitOfWork.Complete();

            Permission = _unitOfWork.Permissions.GetOneUserPermitted(model.ProjectId, usertoadd.ResourceId, comp);

            var results = _mapper.Map<ProjectsPermitted, ProjectsPermittedViewModel>(Permission);

            return Ok(results);
        }

        [Authorize]
        [HttpDelete("permission/{companyId}/{id}")]
        public IActionResult DeletePermission(string projectId, string resourceId, string companyId)
        {
            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();
            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            // var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;
            var Permission = _unitOfWork.Permissions.GetOneUserPermitted(projectId, resourceId, comp);
            var Following = _unitOfWork.Following.GetOneUserFollowing(projectId, resourceId, comp);

            if (Permission == null)
                return BadRequest("You are not authorised to perform this action.");

            _unitOfWork.Permissions.Remove(Permission);

            if (Following != null)
            {
               _unitOfWork.Following.Remove(Following);

            }

            _unitOfWork.Complete();

            return Json("Success");
        }

        // Following

        [Authorize]
        [HttpGet("following/{projectId}/{resourceId}/{companyId}")]
        public ActionResult GetFollower(string projectId, string resourceId, string companyId)
        {

            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            var UserDb = _unitOfWork.Following.GetOneUserFollowing(projectId, resourceId, comp);

            if (UserDb == null)
                return BadRequest();

            var FollowerData = _mapper.Map<ProjectsFollowing, ProjectsFollowingViewModel>(UserDb);

            return Ok(FollowerData);
        }

        [HttpGet("usersfollowing/{projectId}/{companyId}")]
        [Authorize]
        public async Task<IEnumerable<ProjectsFollowingViewModel>> GetFollowingUsersForProject(string projectId, string companyId)
        {
            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return await Task.FromResult<IEnumerable<ProjectsFollowingViewModel>>(null);

            }

            var allUsers = _unitOfWork.Following.GetAllUsersFollowing(comp, projectId);

            return allUsers.Select(Mapper.Map<ProjectsFollowing, ProjectsFollowingViewModel>);
        }
       
        [Authorize]
        [HttpPost("editfollowing")]
        public ActionResult EditFollowing([FromBody] EditProjectsFollowingData model)
        {

            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (model.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
           
            var Follower = _unitOfWork.Following.GetOneUserFollowing(model.ProjectId, model.ResourceId, comp);


            if (Follower == null)
                return NotFound();

            var usertoadd = _unitOfWork.Users.GetOneUser(model.UserId, comp);

            _mapper.Map(model, Follower);

            Follower.CompanyId = comp;
            Follower.UserId = usertoadd.Id;
            Follower.ResourceId = usertoadd.ResourceId;
            Follower.ProjectId = model.ProjectId;
            Follower.Following = model.Following;

            _unitOfWork.Complete();

            Follower = _unitOfWork.Following.GetOneUserFollowing(model.ProjectId, model.ResourceId, comp);

            var result = _mapper.Map<ProjectsFollowing, ProjectsFollowingViewModel>(Follower);

            return Ok(result);

        }

        [Authorize]
        [HttpPost("createfollowing")]
        public IActionResult CreateFollowing([FromBody] EditProjectsFollowingData model)
        {
            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (model.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var usertoadd = _unitOfWork.Users.GetOneUser(model.UserId, comp);

            var id = Guid.NewGuid().ToString();

            var Follower = _mapper.Map<EditProjectsFollowingData, ProjectsFollowing>(model);

            Follower.CompanyId = comp;
            Follower.UserId = usertoadd.Id;
            Follower.ResourceId = usertoadd.ResourceId;
            Follower.ProjectId = model.ProjectId;
            Follower.Following = true;

            _unitOfWork.Following.Add(Follower);
            _unitOfWork.Complete();

            Follower = _unitOfWork.Following.GetOneUserFollowing(model.ProjectId, usertoadd.ResourceId, comp);

            var results = _mapper.Map<ProjectsFollowing, ProjectsFollowingViewModel>(Follower);

            return Ok(results);
        }

        [Authorize]
        [HttpDelete("following/{companyId}/{id}")]
        public IActionResult DeleteFollowing(string projectId, string resourceId, string companyId)
        {
            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();
            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            // var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;
            var Follower = _unitOfWork.Following.GetOneUserFollowing(projectId, resourceId, comp);

            if (Follower == null)
                return BadRequest("You are not authorised to perform this action.");

            _unitOfWork.Following.Remove(Follower);
            _unitOfWork.Complete();

            return Json("Success");
        }
    }
}
