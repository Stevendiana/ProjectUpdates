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
    public class RisksController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;


        public RisksController(UserManager<ApplicationUser> userManager, IUserService userService, IProjectService projectService, IMapper mapper)
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


        public class EditRiskData
        {
            public string RiskId { get; set; }
            public string RiskCode { get; set; }
            public string ProjectId { get; set; }
            public string CompanyId { get; set; }
            public int Year { get; set; }
            public DateTime? DateRaised { get; set; }
            public string Description { get; set; }
            public string Impact { get; set; }
            public string Severity { get; set; }
            public string Likelihood { get; set; }
            public string Owner { get; set; }
            public string Status { get; set; }
            public DateTime? Dateclosed { get; set; }
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
            var RiskDb = _unitOfWork.Risks.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.RiskId == id));

            if(RiskDb == null)
            return NotFound("Risk not found");

            var RiskData = _mapper.Map<Risk, RiskViewModel>(RiskDb);

            return Ok(RiskData);
        }


        [HttpGet("getrisks/{companyId}/{projectId}")]
        [Authorize]
        public async Task<IEnumerable<RiskViewModel>> GetRisks(string companyId, string projectId)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
              return  await Task.FromResult<IEnumerable<RiskViewModel>>(null);
            }

            var allRisk = _unitOfWork.Risks.GetAllRisksOnly(projectId, comp);

            return allRisk.Select(Mapper.Map<Risk, RiskViewModel>);
        }



        [HttpPost("risk")]
            [Authorize]
        public ActionResult Post([FromBody] EditRiskData RiskData)
        {

            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (RiskData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var project = _unitOfWork.Projects.GetOneProject(RiskData.ProjectId, comp);

            if (project==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var companyId = comp;
            var Risk = _unitOfWork.Risks.GetOneRisk(RiskData.RiskId, comp);

            if (Risk == null)
                return NotFound();

            _mapper.Map<EditRiskData, Risk>(RiskData, Risk);

            Risk.CompanyId = comp;
            Risk.RiskCode = "RISK" + "-" + CreateNewId(Risk.RiskId).ToUpper();


            _unitOfWork.Complete();

            Risk = _unitOfWork.Risks.GetOneRisk(RiskData.RiskId, comp);

            var result = _mapper.Map<Risk, RiskViewModel>(Risk);

            return Ok(result);

        }



        [HttpPost]
        [Authorize]
        public IActionResult PostRisk( [FromBody] EditRiskData RiskData)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (RiskData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (RiskData.ProjectId==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var project = _unitOfWork.Projects.GetOneProject(RiskData.ProjectId, comp);

            if (project==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var id = Guid.NewGuid().ToString();

            var Risk = _mapper.Map<EditRiskData, Risk>(RiskData);
            Risk.CompanyId = comp;
            Risk.RiskId = id;

            Risk.RiskCode = "Risk" + "-" + CreateNewId(Risk.RiskId).ToUpper();

            _unitOfWork.Risks.Add(Risk);
            _unitOfWork.Complete();

            Risk = _unitOfWork.Risks.GetOneRisk(id, comp);

            var results = _mapper.Map<Risk, RiskViewModel>(Risk);

            return Ok(results);
        }

       

        [HttpDelete("{companyId}/{id}")]
        [Authorize]
        public IActionResult DeleteRisk(string companyId, string id)
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
            var Risk = _unitOfWork.Risks.GetOneRisk(id, comp);

            if (Risk == null)
            return BadRequest("You are not authorised to perform this action.");

            _unitOfWork.Risks.Remove(Risk);
            _unitOfWork.Complete();

            return Json("Success");
        }

    }

}