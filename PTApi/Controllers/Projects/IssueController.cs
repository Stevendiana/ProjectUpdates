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
    [Route("api/Issues")]
    //[Authorize(Policy = "ApiUser")]
    public class IssueController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly ProjectCentreDbContext _appDbContext;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;


        public IssueController(UserManager<AppUser> userManager, IUserService userService, IProjectService projectService, ProjectCentreDbContext appDbContext, IMapper mapper)
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



        public class EditIssueData
        {
            public string IssueId { get; set; }
            public string IssueCode { get; set; }
            public string ProjectId { get; set; }
            public string CompanyId { get; set; }
            public int Year { get; set; }
            public DateTime? DateRaised { get; set; }
            public string Description { get; set; }
            public string Impact { get; set; }
            public string Severity { get; set; }
            public string Priority { get; set; }
            public string Mitigationplan { get; set; }
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
            var IssueDb = _appDbContext.Issues.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.IssueId == id));

            if(IssueDb == null)
            return NotFound("Issue not found");

            var IssueData = _mapper.Map<Issue, IssueViewModel>(IssueDb);

            return Ok(IssueData);
        }


        [HttpGet("getissues/{companyId}/{projectId}")]
        [Authorize]
        public async Task<IEnumerable<IssueViewModel>> GetIssues(string companyId, string projectId)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return  await Task.FromResult<IEnumerable<IssueViewModel>>(null);

            }

            var allIssue = await _appDbContext.Issues.Where(p => (p.CompanyId == companyId) && (p.ProjectId == projectId)).ToListAsync();

            return allIssue.Select(Mapper.Map<Issue, IssueViewModel>);
        }



        [HttpPost("issue")]
        [Authorize]
        public ActionResult Post([FromBody] EditIssueData IssueData)
        {

            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (IssueData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var project = Getproject(comp, IssueData.ProjectId);

            if (project==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var companyId = comp;
            var Issue = GetIssue(companyId, IssueData.IssueId);

            if (Issue == null)
                return NotFound();

            _mapper.Map<EditIssueData, Issue>(IssueData, Issue);

            Issue.CompanyId = comp;
            Issue.IssueCode = "ASSUMP" + "-" + CreateNewId(Issue.IssueId).ToUpper();


            _appDbContext.SaveChanges();

            Issue = GetIssue(comp, Issue.IssueId);

            var result = _mapper.Map<Issue, IssueViewModel>(Issue);

            return Ok(result);

        }


        Company GetSecureUserCompany()
        {
            var id = HttpContext.User.Claims.Single(c => c.Type == "id").Value;
            var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;

            return _appDbContext.Companies.SingleOrDefault(c => c.CompanyId == comp);
        }



        Issue GetIssue(string companyId, string id)
        {
            var IssueDb =  _appDbContext.Issues.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.IssueId == id));
            return IssueDb;
        }


        [HttpPost]
        [Authorize]
        public IActionResult PostIssue( [FromBody] EditIssueData IssueData)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (IssueData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (IssueData.ProjectId==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var project = Getproject(comp, IssueData.ProjectId);

            if (project==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var id = Guid.NewGuid().ToString();

            var Issue = _mapper.Map<EditIssueData, Issue>(IssueData);
            Issue.CompanyId = comp;
            Issue.IssueId = id;

            Issue.IssueCode = "ISSUE" + "-" + CreateNewId(Issue.IssueId).ToUpper();

            var newIssue = _appDbContext.Issues.Add(Issue).Entity;
            _appDbContext.SaveChanges();

            Issue = GetIssue(comp, id);

            var results = _mapper.Map<Issue, IssueViewModel>(Issue);

            return Ok(results);
        }

        Project Getproject(string companyId, string projectId)
        {
            var projectDb = _appDbContext.Projects.SingleOrDefault(r => (r.CompanyId == companyId)&& (r.ProjectId == projectId));
            return projectDb;
        }



        [HttpDelete("{companyId}/{id}")]
        [Authorize]
        public IActionResult DeleteIssue(string companyId, string id)
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
            var Issue = GetIssue(company, id);

            if (Issue == null)
            return BadRequest("You are not authorised to perform this action.");

            _appDbContext.Remove(Issue);
            _appDbContext.SaveChanges();

            return Json("Success");
        }

    }

}