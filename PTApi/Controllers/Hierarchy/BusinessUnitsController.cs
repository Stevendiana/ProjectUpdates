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
    //[Authorize(Policy = "ApiUser")]
    public class BusinessUnitsController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IForecastService _forecastService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;


        public BusinessUnitsController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, IGetIdsWithPartIdsMethod getIdsWithPartIds,
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


        public string CreateNewId(string id)
        {
            return _getpublicId.PartId(id, 8);
        }


        public class EditBusinessUnitData
        {
            public string Id { get; set; }
            public string BusinessunitCode { get; set; }
            public string BusinessunitName { get; set; }
            [Required]
            public string HeadOfBusinessunitId { get; set; }
            [Required]
            public string DomainId { get; set; }
            [Required]
            public string CompanyId { get; set; }
            
        }



        [Authorize]
        [HttpGet("{companyId}/{id}")]
        public ActionResult Get(string companyId, string id) {

            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            var businessunitDb = _unitOfWork.Businessunits.Get(id, comp);

            if(businessunitDb == null)
            return NotFound("Business unit not found");

            var businessUnitData = _mapper.Map<BusinessUnit, BusinessUnitViewModel>(businessunitDb);

            return Ok(businessUnitData);
        }


        [HttpGet("{companyId}")]
        [Authorize(Policy="Admin_Group")]
        public async Task<IEnumerable<BusinessUnitViewModel>> GetBusinessUnits(string companyId)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (roleGroup=="Admin_Group")
            {
                if ( companyId == comp)
                {
                    var allBusinessUnits =  _unitOfWork.Businessunits.GetAllBusinessUnits(comp);

                    return allBusinessUnits.Select(Mapper.Map<BusinessUnit, BusinessUnitViewModel>);
                }
                return await Task.FromResult<IEnumerable<BusinessUnitViewModel>>(null);
            }
            return  await Task.FromResult<IEnumerable<BusinessUnitViewModel>>(null);
        }



        [HttpPost("businessunit")]
        [Authorize(Policy="Admin_Group")]
        public ActionResult Post([FromBody] EditBusinessUnitData businessUnitData)
        {

            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (businessUnitData.CompanyId != comp)
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
                var businessunit = _unitOfWork.Businessunits.Get(businessUnitData.Id, comp);

                if (businessunit == null)
                    return NotFound();

                _mapper.Map<EditBusinessUnitData, BusinessUnit>(businessUnitData, businessunit);

                businessunit.CompanyId = comp;


                businessunit.DomainId = businessUnitData.DomainId ?? businessunit.DomainId;
                businessunit.BusinessunitName = businessUnitData.BusinessunitName ?? businessunit.BusinessunitName;
                businessunit.HeadOfBusinessunitId = businessUnitData.HeadOfBusinessunitId ?? businessunit.HeadOfBusinessunitId;
                businessunit.BusinessunitCode = "BUU" + "-" + CreateNewId(businessunit.Id).ToUpper();

                _unitOfWork.Complete();

                businessunit = _unitOfWork.Businessunits.Get(businessunit.Id, comp);

                var result = _mapper.Map<BusinessUnit, BusinessUnitViewModel>(businessunit);

                return Ok(result);
            }
            return BadRequest("You are not authorised to perform this action.");

        }



        [HttpPost]
        [Authorize(Policy="Admin_Group")]
        public IActionResult PostBusinessUnit( [FromBody] EditBusinessUnitData businessUnitData)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (businessUnitData.CompanyId != comp)
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

                var businessUnit = _mapper.Map<EditBusinessUnitData, BusinessUnit>(businessUnitData);
                businessUnit.CompanyId = comp;
                businessUnit.Id = id;
                businessUnit.BusinessunitCode = "BUU" + "-" + CreateNewId(id).ToUpper();

                _unitOfWork.Businessunits.Add(businessUnit);
                _unitOfWork.Complete();

                businessUnit = _unitOfWork.Businessunits.Get(id, comp);

                var results = _mapper.Map<BusinessUnit, EditBusinessUnitData>(businessUnit);


                return Ok(results);
            }
            return BadRequest("You are not authorised to perform this action.");
        }


        [HttpDelete("{companyId}/{id}")]
        [Authorize(Policy="Admin_Group")]
        public IActionResult DeleteBusinessUnit(string companyId, string id)
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
                var businessunit = _unitOfWork.Businessunits.Get(id, comp);

                if (businessunit == null)
                return BadRequest("You are not authorised to perform this action.");

                _unitOfWork.Businessunits.Remove(businessunit);
                _unitOfWork.Complete();

                return Json("Success");
            }
            return BadRequest("You are not authorised to perform this action.");
        }

    }

}