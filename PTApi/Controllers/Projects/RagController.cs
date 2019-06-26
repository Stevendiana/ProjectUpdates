using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTApi.Controllers
{
    [Produces("application/json")]
    [Route("api/rags")]
    //[Authorize(Policy = "ApiUser")]
    public class RagController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly ProjectCentreDbContext _appDbContext;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;


        public RagController(UserManager<AppUser> userManager, IUserService userService, IProjectService projectService, ProjectCentreDbContext appDbContext, IMapper mapper)
        {
            _userService = userService;
            _projectService = projectService;
            _userManager = userManager;
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        private static string CreateNewId(string businessUnitId)
        {
            GeneratePublicId generatePublicId = new GeneratePublicId();
            return generatePublicId.PartId(businessUnitId, 8);
        }

        public static string WriteMonthInWords(int period){

           ConvertPeriodNumbersToWords convertPeriodNumbersToWords = new ConvertPeriodNumbersToWords();
           return convertPeriodNumbersToWords.ConvertMonthNumbersToWords(period);
        }



        public class EditRagData
        {
            public string ProjectRagStatusId { get; set; }
            [Required]
            public string ProjectId { get; set; }
            [Required]
            public string CompanyId { get; set; }
            public int Year { get; set; }
            public byte ReportingPeriodNumbers { get; set; }
            // [NotMapped]
            public string ReportingPeriodWords { get; set; }
            // public string ReportingPeriodWords { get{return WriteMonthInWords(ReportingPeriodNumbers);} }

            public string PortfolioMiReportingPeriod { get; set; }

            [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
            public string HighlightsThisPeriod { get; set; }
            [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
            public string ActivitiesPlannedNextPeriod { get; set; }
            public string RagStatusSummary { get; set; }
            [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
            public string RagNarrativeSummary { get; set; }
            public string RagStatusGovernanceBusinessChange { get; set; }
            [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
            public string RagNarrativeGovernanceBusinessChange { get; set; }
            public string RagStatusScope { get; set; }
            [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
            public string RagNarrativeScope { get; set; }
            public string RagStatusQuality { get; set; }
            [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
            public string RagNarrativeQuality { get; set; }
            public string RagStatusSchedule { get; set; }
            [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
            public string RagNarrativeSchedule { get; set; }
            public string RagStatusFinances { get; set; }
            [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
            public string RagNarrativeFinances { get; set; }
            public string RagStatusResourcing { get; set; }
            [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
            public string RagNarrativeResourcing { get; set; }
            public string RagStatusCustomerSatisfaction { get; set; }
            [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
            public string RagNarrativeCustomerSatisfaction { get; set; }

            // public Project Project { get; set; }
            // public Company Company { get; set; }
        }



        [Authorize]
        [HttpGet("{companyId}/{id}")]
        public ActionResult Get(string companyId, string id) {

            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            var ragDb = _appDbContext.ProjectRagStatus.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.ProjectRagStatusId == id));

            if(ragDb == null)
            return NotFound("Rag not found");

            var ragData = _mapper.Map<ProjectRagStatus, RagViewModel>(ragDb);

            return Ok(ragData);
        }


        [HttpGet("getrags/{companyId}/{projectId}")]
        [Authorize]
        public async Task<IEnumerable<RagViewModel>> GetRags(string companyId, string projectId)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return  await Task.FromResult<IEnumerable<RagViewModel>>(null);

            }

            var allRags = await _appDbContext.ProjectRagStatus.Where(p => (p.CompanyId == companyId) && (p.ProjectId == projectId)).ToListAsync();

            return allRags.Select(Mapper.Map<ProjectRagStatus, RagViewModel>);
        }



        [HttpPost("rag")]
        [Authorize]
        public ActionResult Post([FromBody] EditRagData ragData)
        {

            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (ragData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var project = Getproject(comp, ragData.ProjectId);

            if (project==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var companyId = comp;
            var rag = Getrag(companyId, ragData.ProjectRagStatusId);

            if (rag == null)
                return NotFound();

            _mapper.Map<EditRagData, ProjectRagStatus>(ragData, rag);

            rag.CompanyId = comp;
            rag.ProjectRagStatusId = rag.ProjectRagStatusId;
            rag.ReportingPeriodNumbers = Convert.ToByte(_projectService.ConvertMonthWordsToNumbers(_userService.GetSecureUserCompanyReportingPeriod()));
            rag.ReportingPeriodWords = _userService.GetSecureUserCompanyReportingPeriod();

            project.RagStatus = rag.RagStatusSummary;
            project.RagStatusSummary = rag.RagNarrativeSummary;
            project.Activitythisperiod = rag.HighlightsThisPeriod;

            _appDbContext.SaveChanges();

            rag = Getrag(comp, rag.ProjectRagStatusId);

            var result = _mapper.Map<ProjectRagStatus, RagViewModel>(rag);

            return Ok(result);

        }


        Company GetSecureUserCompany()
        {
            var id = HttpContext.User.Claims.Single(c => c.Type == "id").Value;
            var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;

            return _appDbContext.Companies.SingleOrDefault(c => c.CompanyId == comp);
        }



        ProjectRagStatus Getrag(string companyId, string id)
        {
            var ragDb =  _appDbContext.ProjectRagStatus.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.ProjectRagStatusId == id));
            return ragDb;
        }


        [HttpPost]
        [Authorize]
        public IActionResult PostRag( [FromBody] EditRagData ragData)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (ragData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (ragData.ProjectId==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var project = Getproject(comp, ragData.ProjectId);

            if (project==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var id = Guid.NewGuid().ToString();

            var rag = _mapper.Map<EditRagData, ProjectRagStatus>(ragData);
            rag.CompanyId = comp;
            rag.ProjectRagStatusId = id;
            rag.ReportingPeriodNumbers = Convert.ToByte(_projectService.ConvertMonthWordsToNumbers(_userService.GetSecureUserCompanyReportingPeriod()));
            rag.ReportingPeriodWords = _userService.GetSecureUserCompanyReportingPeriod();

            project.RagStatus = rag.RagStatusSummary;
            project.RagStatusSummary = rag.RagNarrativeSummary;
            project.Activitythisperiod = rag.HighlightsThisPeriod;

            var newRag = _appDbContext.ProjectRagStatus.Add(rag).Entity;
            _appDbContext.SaveChanges();

            rag = Getrag(comp, id);

            var results = _mapper.Map<ProjectRagStatus, RagViewModel>(rag);

            return Ok(results);
        }

        Project Getproject(string companyId, string projectId)
        {
            var projectDb = _appDbContext.Projects.SingleOrDefault(r => (r.CompanyId == companyId)&& (r.ProjectId == projectId));
            return projectDb;
        }



        [HttpDelete("{companyId}/{id}")]
        [Authorize]
        public IActionResult DeleteRag(string companyId, string id)
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
            var rag = Getrag(company, id);

            if (rag == null)
            return BadRequest("You are not authorised to perform this action.");

            _appDbContext.Remove(rag);
            _appDbContext.SaveChanges();

            return Json("Success");
        }

    }

}