using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTApi.Controllers
{
    [Produces("application/json")]
    [Route("api/risks")]
    //[Authorize(Policy = "ApiUser")]
    public class RiskController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly ProjectCentreDbContext _appDbContext;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;


        public RiskController(UserManager<AppUser> userManager, IUserService userService, IProjectService projectService, ProjectCentreDbContext appDbContext, IMapper mapper)
        {
            _userService = userService;
            _projectService = projectService;
            _userManager = userManager;
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        private static string CreateNewId(string id)
        {
            GeneratePublicId generatePublicId = new GeneratePublicId();
            return generatePublicId.PartId(id, 8);
        }

        public static string WriteMonthInWords(int period){

           ConvertPeriodNumbersToWords convertPeriodNumbersToWords = new ConvertPeriodNumbersToWords();
           return convertPeriodNumbersToWords.ConvertMonthNumbersToWords(period);
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
            var RiskDb = _appDbContext.Risks.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.RiskId == id));

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

            var allRisk = await _appDbContext.Risks.Where(p => (p.CompanyId == companyId) && (p.ProjectId == projectId)).ToListAsync();

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

            var project = Getproject(comp, RiskData.ProjectId);

            if (project==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var companyId = comp;
            var Risk = GetRisk(companyId, RiskData.RiskId);

            if (Risk == null)
                return NotFound();

            _mapper.Map<EditRiskData, Risk>(RiskData, Risk);

            Risk.CompanyId = comp;
            Risk.RiskCode = "RISK" + "-" + CreateNewId(Risk.RiskId).ToUpper();


            _appDbContext.SaveChanges();

            Risk = GetRisk(comp, Risk.RiskId);

            var result = _mapper.Map<Risk, RiskViewModel>(Risk);

            return Ok(result);

        }


        Company GetSecureUserCompany()
        {
            var id = HttpContext.User.Claims.Single(c => c.Type == "id").Value;
            var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;

            return _appDbContext.Companies.SingleOrDefault(c => c.CompanyId == comp);
        }



        Risk GetRisk(string companyId, string id)
        {
            var RiskDb =  _appDbContext.Risks.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.RiskId == id));
            return RiskDb;
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

            var project = Getproject(comp, RiskData.ProjectId);

            if (project==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var id = Guid.NewGuid().ToString();

            var Risk = _mapper.Map<EditRiskData, Risk>(RiskData);
            Risk.CompanyId = comp;
            Risk.RiskId = id;

            Risk.RiskCode = "Risk" + "-" + CreateNewId(Risk.RiskId).ToUpper();

            var newRisk = _appDbContext.Risks.Add(Risk).Entity;
            _appDbContext.SaveChanges();

            Risk = GetRisk(comp, id);

            var results = _mapper.Map<Risk, RiskViewModel>(Risk);

            return Ok(results);
        }

        Project Getproject(string companyId, string projectId)
        {
            var projectDb = _appDbContext.Projects.SingleOrDefault(r => (r.CompanyId == companyId)&& (r.ProjectId == projectId));
            return projectDb;
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
            var Risk = GetRisk(company, id);

            if (Risk == null)
            return BadRequest("You are not authorised to perform this action.");

            _appDbContext.Remove(Risk);
            _appDbContext.SaveChanges();

            return Json("Success");
        }

    }

}