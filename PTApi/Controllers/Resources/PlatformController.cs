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
    public class PlatformsController: Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;


        public PlatformsController(UserManager<ApplicationUser> userManager, IUserService userService, IProjectService projectService, IMapper mapper)
        {
            _userService = userService;
            _projectService = projectService;
            _userManager = userManager;
            _mapper = mapper;
        }

        private string CreateNewId(string id)
        {
            return _getpublicId.PartId(id, 8);
        }


        public class EditPlatformData
        {
            public string PlatformId { get; set; }
            public string PlatformCode { get; set; }

            [Required]
            public string PlatformName { get; set; }
            [Required]
            public string CompanyId { get; set; }
            public string HeadOfPlatformId { get; set; }

        }



        [Authorize]
        [HttpGet("{companyId}/{id}")]
        public ActionResult Get(string companyId, string id) {

            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            var platformDb = _unitOfWork.Platforms.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.PlatformId == id));

            if(platformDb == null)
            return NotFound("Platform not found");

            var platformData = _mapper.Map<Platform, PlatformViewModel>(platformDb);

            return Ok(platformData);
        }


        [HttpGet("{companyId}")]
        [Authorize(Policy="Admin_Group")]
        public async Task<IEnumerable<PlatformViewModel>> GetPlatForms(string companyId)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (roleGroup=="Admin_Group")
            {
                if ( companyId == comp)
                {
                    var allPlatForms = _unitOfWork.Platforms.GetAllPlatformsWithResources(comp);

                    return allPlatForms.Select(Mapper.Map<Platform, PlatformViewModel>);
                }
                return await Task.FromResult<IEnumerable<PlatformViewModel>>(null);
            }
            return  await Task.FromResult<IEnumerable<PlatformViewModel>>(null);
        }



        [HttpPost("platform")]
        [Authorize(Policy="Admin_Group")]
        public ActionResult Post([FromBody] EditPlatformData platFormData)
        {

            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (platFormData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (roleGroup=="Admin_Group")
            {
                var companyId = comp;
                var platform = _unitOfWork.Platforms.GetOnePlatform(platFormData.PlatformId, comp);

                if (platform == null)
                    return NotFound();

                _mapper.Map<EditPlatformData, Platform>(platFormData, platform);

                platform.CompanyId = comp;
                platform.PlatformName = platFormData.PlatformName ?? platform.PlatformName;
                platform.HeadOfPlatformId = platFormData.HeadOfPlatformId ?? platform.HeadOfPlatformId;
                platform.PlatformCode =  "PLATFORM" + "-" + CreateNewId(platform.PlatformId).ToUpper();


                _unitOfWork.Complete();

                platform = _unitOfWork.Platforms.GetOnePlatform(platFormData.PlatformId, comp);

                var result = _mapper.Map<Platform, PlatformViewModel>(platform);

                return Ok(result);
            }
            return BadRequest("You are not authorised to perform this action.");

        }


       

        [HttpPost]
        [Authorize(Policy="Admin_Group")]
        public IActionResult PostPlatform( [FromBody] EditPlatformData platformData)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (platformData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (roleGroup=="Admin_Group")
            {
                var id = Guid.NewGuid().ToString();

                var platform = _mapper.Map<EditPlatformData, Platform>(platformData);
                platform.CompanyId = comp;
                platform.PlatformId = id;
                platform.PlatformCode = "PLAT" + "-" + CreateNewId(platform.PlatformId).ToUpper();

                _unitOfWork.Platforms.Add(platform);
                _unitOfWork.Complete();

                platform = _unitOfWork.Platforms.GetOnePlatform(id, comp);

                var results = _mapper.Map<Platform, EditPlatformData>(platform);


                return Ok(results);
            }
            return BadRequest("You are not authorised to perform this action.");
        }


        [HttpDelete("{companyId}/{id}")]
        [Authorize(Policy="Admin_Group")]
        public IActionResult DeletePlatform(string companyId, string id)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();
            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (roleGroup=="Admin_Group")
            {

                // var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;
                var company = comp;
                var platform = _unitOfWork.Platforms.GetOnePlatform(id, comp);

                if (platform == null)
                return BadRequest("You are not authorised to perform this action.");

                _unitOfWork.Platforms.Remove(platform);
                _unitOfWork.Complete();

                return Json("Success");
            }
            return BadRequest("You are not authorised to perform this action.");
        }

    }

}