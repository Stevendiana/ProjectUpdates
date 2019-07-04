using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using PTApi.Data.Repositories;
using PTApi.Methods;
using PTApi.Models;
using PTApi.Persistence.Blob;
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
    public class IssuesController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IForecastService _forecastService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;


        public IssuesController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, IGetIdsWithPartIdsMethod getIdsWithPartIds,
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
            var IssueDb = _unitOfWork.Issues.SingleOrDefault(b => (b.CompanyId == companyId) && (b.IssueId == id));

            if (IssueDb == null)
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

            var allIssue = _unitOfWork.Issues.GetAllIssuesOnly(projectId, comp);

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

            var project = _unitOfWork.Projects.GetOneProject(IssueData.ProjectId, comp);

            if (project==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var companyId = comp;
            var Issue = _unitOfWork.Issues.GetOneIssue(IssueData.IssueId, comp);


            if (Issue == null)
                return NotFound();

            _mapper.Map<EditIssueData, Issue>(IssueData, Issue);

            Issue.CompanyId = comp;
            Issue.IssueCode = "ISSUE" + "-" + CreateNewId(Issue.IssueId).ToUpper();


            _unitOfWork.Complete();

            Issue = _unitOfWork.Issues.GetOneIssue(IssueData.IssueId, comp);

            var result = _mapper.Map<Issue, IssueViewModel>(Issue);

            return Ok(result);

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

            var project = _unitOfWork.Projects.GetOneProject(IssueData.ProjectId, comp);

            if (project==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var id = Guid.NewGuid().ToString();

            var Issue = _mapper.Map<EditIssueData, Issue>(IssueData);
            Issue.CompanyId = comp;
            Issue.IssueId = id;

            Issue.IssueCode = "ISSUE" + "-" + CreateNewId(Issue.IssueId).ToUpper();

            _unitOfWork.Issues.Add(Issue);
            _unitOfWork.Complete();

            Issue = _unitOfWork.Issues.GetOneIssue(id, comp);

            var results = _mapper.Map<Issue, IssueViewModel>(Issue);

            return Ok(results);
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
            var Issue = _unitOfWork.Issues.GetOneIssue(id, comp);

            if (Issue == null)
            return BadRequest("You are not authorised to perform this action.");

            _unitOfWork.Issues.Remove(Issue);
            _unitOfWork.Complete();

            return Json("Success");
        }

    }

}