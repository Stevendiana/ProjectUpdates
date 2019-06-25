using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjectCentreBackend.Models;
using ProjectCentreBackend.Models.Entities;
using ProjectCentreBackend.Models.Methods;
using ProjectCentreBackend.Persistence;
using ProjectCentreBackend.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using ProjectCentreBackend.Core.Interfaces;


namespace ProjectCentreBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/platforms")]
    public class PlatformController: Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly ProjectCentreDbContext _appDbContext;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;


        public PlatformController(UserManager<AppUser> userManager, IUserService userService, ProjectCentreDbContext appDbContext, IMapper mapper)
        {
            _userService = userService;
            _userManager = userManager;
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        private static string CreateNewId(string businessUnitId)
        {
            GeneratePublicId generatePublicId = new GeneratePublicId();
            return generatePublicId.PartId(businessUnitId, 8);
        }


        public class EditPlatformData
        {
            public string PlatformId { get; set; }
            public string PlatformCode { get; set; }

            [Required]
            public string PlatformName { get; set; }
            [Required]
            public string CompanyId { get; set; }
            public string HeadOfPlatform { get; set; }

        }



        [Authorize]
        [HttpGet("{companyId}/{id}")]
        public ActionResult Get(string companyId, string id) {

            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            var platformDb = _appDbContext.Platforms.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.PlatformId == id));

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
                    var allPlatForms = await _appDbContext.Platforms.Where(p => p.CompanyId == companyId).ToListAsync();

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
                var platform = Getplatform(companyId, platFormData.PlatformId);

                if (platform == null)
                    return NotFound();

                _mapper.Map<EditPlatformData, Platform>(platFormData, platform);

                platform.CompanyId = comp;
                platform.PlatformName = platFormData.PlatformName ?? platform.PlatformName;
                platform.HeadOfPlatform = platFormData.HeadOfPlatform ?? platform.HeadOfPlatform;
                platform.PlatformCode =  "PLAT" + "-" + CreateNewId(platform.PlatformId).ToUpper();


                _appDbContext.SaveChanges();

                platform = Getplatform(comp, platform.PlatformId);

                var result = _mapper.Map<Platform, PlatformViewModel>(platform);

                return Ok(result);
            }
            return BadRequest("You are not authorised to perform this action.");

        }


        Company GetSecureUserCompany()
        {
            var id = HttpContext.User.Claims.Single(c => c.Type == "id").Value;
            var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;

            return _appDbContext.Companies.SingleOrDefault(c => c.CompanyId == comp);
        }



        Platform Getplatform(string companyId, string platformId)
        {
            var platformDb =  _appDbContext.Platforms.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.PlatformId == platformId));
            return platformDb;
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

                var newPlatform = _appDbContext.Platforms.Add(platform).Entity;
                _appDbContext.SaveChanges();

                platform = Getplatform(comp, id);

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
                var platform = Getplatform(company, id);

                if (platform == null)
                return BadRequest("You are not authorised to perform this action.");

                _appDbContext.Remove(platform);
                _appDbContext.SaveChanges();

                return Json("Success");
            }
            return BadRequest("You are not authorised to perform this action.");
        }

    }

}