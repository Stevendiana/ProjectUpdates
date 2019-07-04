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
using System.Linq;
using System.Threading.Tasks;

namespace PTApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    //[Authorize(Policy = "ApiUser")]
    public class AssumptionsController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IForecastService _forecastService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;


        public AssumptionsController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, IGetIdsWithPartIdsMethod getIdsWithPartIds,
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

        public string WriteMonthInWords(int period){

           return _getpublicId.ConvertMonthNumbersToWords(period);
        }



        public class EditAssumptionData
        {
            public string AssumptionId { get; set; }
            public string AssumptionCode { get; set; }
            public string ProjectId { get; set; }
            public string CompanyId { get; set; }
            public int Year { get; set; }
            public DateTime? DateRaised { get; set; }
            public string Description { get; set; }
            public string Reason { get; set; }
            public string Actiontovalidate { get; set; }
            public string Impactifassumptionfails { get; set; }
            public string Status { get; set; }
            public string Latestupdate { get; set; }
            public DateTime? LatestupdateDate { get; set; }
            public bool Cascade { get; set; }
            public string Reviewstatus { get; set; }
        }



        [Authorize]
        [HttpGet("{companyId}/{id}")]
        public ActionResult Get(string companyId, string id) {

            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            var assumptionDb = _unitOfWork.Assumptions.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.AssumptionId == id));

            if(assumptionDb == null)
            return NotFound("assumption not found");

            var assumptionData = _mapper.Map<Assumption, AssumptionViewModel>(assumptionDb);

            return Ok(assumptionData);
        }


        [HttpGet("getassumptions/{companyId}/{projectId}")]
        [Authorize]
        public async Task<IEnumerable<AssumptionViewModel>> Getassumptions(string companyId, string projectId)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return  await Task.FromResult<IEnumerable<AssumptionViewModel>>(null);

            }

            var allassumption = _unitOfWork.Assumptions.GetAllAssumptionsOnly(projectId, comp);

            return allassumption.Select(Mapper.Map<Assumption, AssumptionViewModel>);
        }



        [HttpPost("assumption")]
        [Authorize]
        public ActionResult Post([FromBody] EditAssumptionData assumptionData)
        {

            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (assumptionData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var project = _unitOfWork.Projects.GetOneProject(assumptionData.ProjectId, comp);

            if (project==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var companyId = comp;
            var assumption = _unitOfWork.Assumptions.GetOneAssumption(assumptionData.AssumptionId, comp);

            if (assumption == null)
                return NotFound();

            _mapper.Map<EditAssumptionData, Assumption>(assumptionData, assumption);

            assumption.CompanyId = comp;
            assumption.AssumptionCode = "ASSUME" + "-" + CreateNewId(assumption.AssumptionId).ToUpper();


            _unitOfWork.Complete();

            assumption = _unitOfWork.Assumptions.GetOneAssumption(assumption.AssumptionId, comp);

            var result = _mapper.Map<Assumption, AssumptionViewModel>(assumption);

            return Ok(result);

        }


        [HttpPost]
        [Authorize]
        public IActionResult Postassumption( [FromBody] EditAssumptionData assumptionData)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (assumptionData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (assumptionData.ProjectId==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var project = _unitOfWork.Projects.GetOneProject(assumptionData.ProjectId, comp);

            if (project==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var id = Guid.NewGuid().ToString();

            var assumption = _mapper.Map<EditAssumptionData, Assumption>(assumptionData);
            assumption.CompanyId = comp;
            assumption.AssumptionId = id;

            assumption.AssumptionCode = "ASSUMP" + "-" + CreateNewId(assumption.AssumptionId).ToUpper();

            _unitOfWork.Assumptions.Add(assumption);
            _unitOfWork.Complete();

            assumption = _unitOfWork.Assumptions.GetOneAssumption(id, comp);

            var results = _mapper.Map<Assumption, AssumptionViewModel>(assumption);

            return Ok(results);
        }



        [HttpDelete("{companyId}/{id}")]
        [Authorize]
        public IActionResult Deleteassumption(string companyId, string id)
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
            // var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;
            var company = comp;
            var assumption = _unitOfWork.Assumptions.GetOneAssumption(id, comp);

            if (assumption == null)
            return BadRequest("You are not authorised to perform this action.");

            _unitOfWork.Assumptions.Remove(assumption);
            _unitOfWork.Complete();

            return Json("Success");
        }

    }

}