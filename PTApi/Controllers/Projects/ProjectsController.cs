using System;
using System.Collections.Generic;
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
using ProjectCentreBackend.Core.Interfaces;

namespace ProjectCentreBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProjectsController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly ProjectCentreDbContext _appDbContext;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;


        public ProjectsController(UserManager<AppUser> userManager, IUserService userService, ProjectCentreDbContext appDbContext, IMapper mapper)
        {
            _userService = userService;
            _userManager = userManager;
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        private static string CreateNewId(string id)
        {
            GeneratePublicId generatePublicId = new GeneratePublicId();
            return generatePublicId.PartId(id, 8);
        }


        public class EditProjectData
        {

            public string ProjectId { get; set; }
            public string CompanyId { get; set; }
            public string ProjectName { get; set; }
            public string ProjectRef { get; set; }
            public string ProgrammeId { get; set; }
            public string PortfolioId { get; set; }
            public string BusinessUnitId { get; set; }
            public string BusinessCustomerId { get; set; }
            public string AccountingCode { get; set; }
            public string CurrentStageGateStatus { get; set; }
            public string ProjectLifecycleStage { get; set; }
            public string ProjectStatus { get; set; }
            public string RfqNumber { get; set; }
            public string ProjectBudget { get; set; }
            public string ProjectObjective { get; set; }
            public string FinancialStatus { get; set; }
            public string ProjectPrioritisation { get; set; }
            public string Sponsor { get; set; }
            public string ProjectCustomer { get; set; }
            public string ProjectManagerUserId { get; set; }
            public string ProjectSeniorManagerUserId { get; set; }
            public string ProjectPrimaryContactUserId { get; set; }
            public string ProjectFinanceContactUserId { get; set; }
            public string ProjectOwnerUserId { get; set; }
            public string ProjectStrategy { get; set; }
            public string BusinessStrategy { get; set; }
            public string ProjectAlignment { get; set; }
            public string BusinessAlignment { get; set; }
            public DateTime? ProjectStartDate { get; set; }
            public DateTime? ProjectEndDate { get; set; }
            public string ProjectCurrentBudgetTrackerId  { get; set; }
            // [ForeignKey("ProjectCurrentBudgetTrackerId")]
            public ProjectBudgetTracker ProjectBudgetTracker  { get; set; }
            public string BudgetCurrentStatus  { get; set; }

            // Draft, Approved, Rejected, Revised
            public int? CurrentBudgetBadgeVersion  { get; set; }

            public int? BenefitsStartYear { get; set; }
            public int? BenefitsDurationInYears { get; set; }
            public decimal? GrandTotalOpexImpact { get; set; }
            public decimal? GrandTotalBenefitsForecast { get; set; }
            public decimal? GrandTotalBenefitsAchieved { get; set; }
            public decimal? GrandTotalBenefitsExpected { get; set; }
            public decimal? PlanGrandTotalCapex { get; set; }
            public decimal? PlanGrandTotalRevex { get; set; }
            public decimal? PlanGrandTotalOpex { get; set; }
            public decimal? GrandTotalBudgetSubmitted { get; set; }
            public decimal? GrandTotalBudgetApproved { get; set; }

        }


        [Authorize]
        [HttpGet("{companyId}/{id}")]
        public ActionResult Get(string companyId, string id) {

            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            var projectDb = _appDbContext.Projects.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.ProjectId == id));

            if(projectDb == null)
            return NotFound("Portfolio not found");

            var projectData = _mapper.Map<Project, ProjectViewModel>(projectDb);

            return Ok(projectData);
        }


        [HttpGet("{companyId}")]
        [Authorize(Policy="Admin_Group")]
        public async Task<IEnumerable<ProjectViewModel>> GetProjects(string companyId)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (roleGroup=="Admin_Group")
            {
                if ( companyId == comp)
                {
                    var allProjects = await _appDbContext.Projects.Where(p => p.CompanyId == companyId).ToListAsync();

                    return allProjects.Select(Mapper.Map<Project, ProjectViewModel>);
                }
                return await Task.FromResult<IEnumerable<ProjectViewModel>>(null);
            }
            return  await Task.FromResult<IEnumerable<ProjectViewModel>>(null);
        }



        [HttpPost("project")]
        [Authorize(Policy="Admin_Group")]
        public ActionResult Post([FromBody] EditProjectData projectData)
        {

            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (projectData.CompanyId != comp)
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
                var project = Getproject(companyId, projectData.ProjectId);

                if (project == null)
                    return NotFound();

                _mapper.Map<EditProjectData, Project>(projectData, project);

                project.CompanyId = comp;

                project.AccountingCode = projectData.AccountingCode ?? project.AccountingCode;
                project.BenefitsDurationInYears = projectData.BenefitsDurationInYears ?? project.BenefitsDurationInYears;
                project.BenefitsStartYear = projectData.BenefitsStartYear ?? project.BenefitsStartYear;
                project.BusinessAlignment = projectData.BusinessAlignment ?? project.BusinessAlignment;
                project.BusinessCustomerId = projectData.BusinessCustomerId ?? project.BusinessCustomerId;
                project.BusinessStrategy = projectData.BusinessStrategy ?? project.BusinessStrategy;
                project.CurrentStageGateStatus = projectData.CurrentStageGateStatus ?? project.CurrentStageGateStatus;
                project.FinancialStatus = projectData.FinancialStatus ?? project.FinancialStatus;
                project.ProgrammeId = projectData.ProgrammeId ?? project.ProgrammeId;
                project.PortfolioId = projectData.PortfolioId ?? project.PortfolioId;
                project.PortfolioId = projectData.PortfolioId ?? project.PortfolioId;
                project.BusinessUnitId = projectData.BusinessUnitId ?? project.BusinessUnitId;
                project.ParentId = projectData.ProgrammeId ?? project.ParentId;
                // project.ProjectBudget = projectData.ProjectBudget ?? project.ProjectBudget;
                project.ProjectCustomer = projectData.ProjectCustomer ?? project.ProjectCustomer;
                // project.ProjectEndDate = projectData.ProjectEndDate ?? project.ProjectEndDate;
                project.ProjectManagementRankId = project.ProjectManagementRankId;
                project.ProjectLifecycleStage = projectData.ProjectLifecycleStage ?? project.ProjectLifecycleStage;
                project.ProjectAlignment = projectData.ProjectAlignment ?? project.ProjectAlignment;

                project.ProjectName = projectData.ProjectName ?? project.ProjectName;
                project.CurrentBudgetBadgeVersion = projectData.CurrentBudgetBadgeVersion ?? project.CurrentBudgetBadgeVersion;
                project.BudgetCurrentStatus = projectData.BudgetCurrentStatus ?? project.BudgetCurrentStatus;

                project.ProjectObjective = projectData.ProjectObjective ?? project.ProjectObjective;


                project.ProjectPrioritisation = projectData.ProjectPrioritisation ?? project.ProjectPrioritisation;
                project.RfqNumber = projectData.RfqNumber ?? project.RfqNumber;
                project.Sponsor = projectData.Sponsor ?? project.Sponsor;

                project.RevexCostCode =  "30" + "-"+ CreateNewId(project.ProjectId).ToString().ToUpper();
                project.CapexCostCode =  "40"+ "-" + CreateNewId(project.ProjectId).ToString().ToUpper();
                project.OpexCostCode =  "50" + "-"+ CreateNewId(project.ProjectId).ToString().ToUpper();
               // project.ResourceCostCentreId = projectData.ResourceCostCentreId ?? project.ResourceCostCentreId;
                project.ProjectStrategy = projectData.ProjectStrategy ?? project.ProjectStrategy;
                // project.ProjectStartDate = projectData.ProjectStartDate ?? project.ProjectStartDate;


                project.ProjectCode = "PRJ" + "-" + CreateNewId(project.ProjectId).ToUpper();

                project.UpdateProjectInfo();

                if ( project.ProjectManagementRank.ProjectManagerUserId != projectData.ProjectManagerUserId  ||
                project.ProjectManagementRank.ProjectSeniorManagerUserId != projectData.ProjectSeniorManagerUserId  ||
                project.ProjectManagementRank.ProjectFinanceContactUserId != projectData.ProjectPrimaryContactUserId  ||
                project.ProjectManagementRank.ProjectPrimaryContactUserId != projectData.ProjectFinanceContactUserId  ||
                project.ProjectManagementRank.ProjectOwnerUserId != projectData.ProjectOwnerUserId)
                {
                    project.ProjectManagementRank.ProjectManagerUserId = projectData.ProjectManagerUserId ?? project.ProjectManagementRank.ProjectManagerUserId;
                    project.ProjectManagementRank.ProjectSeniorManagerUserId = projectData.ProjectSeniorManagerUserId ?? project.ProjectManagementRank.ProjectSeniorManagerUserId;
                    project.ProjectManagementRank.ProjectFinanceContactUserId = projectData.ProjectFinanceContactUserId ?? project.ProjectManagementRank.ProjectFinanceContactUserId;
                    project.ProjectManagementRank.ProjectPrimaryContactUserId = projectData.ProjectPrimaryContactUserId ?? project.ProjectManagementRank.ProjectPrimaryContactUserId;
                    project.ProjectManagementRank.ProjectOwnerUserId = projectData.ProjectOwnerUserId ?? project.ProjectManagementRank.ProjectOwnerUserId;

                    project.ProjectManagementRank.UpdateProjectManagementRank(projectData.ProjectManagerUserId,projectData.ProjectSeniorManagerUserId,
                    projectData.ProjectFinanceContactUserId,projectData.ProjectPrimaryContactUserId,projectData.ProjectOwnerUserId);

                }

                _appDbContext.SaveChanges();

                project = Getproject(comp, project.ProjectId);

                var result = _mapper.Map<Project, ProjectViewModel>(project);

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



        Project Getproject(string companyId, string id)
        {
            var projectDb =  _appDbContext.Projects.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.ProjectId == id));
            return projectDb;
        }


        [HttpPost]
        [Authorize(Policy="Admin_Group")]
        public IActionResult PostProject( [FromBody] EditProjectData projectData)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();
            var currentuser = _userService.GetSecureUserId();
            var loggedInResourceId = _userService.GetSecureResource();

            if (projectData.CompanyId != comp)
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

                var project = _mapper.Map<EditProjectData, Project>(projectData);
                project.CompanyId = comp;
                project.ProjectId = id;
                project.CurrentBudgetBadgeVersion = 0;
                project.BudgetCurrentStatus = "Draft";
                project.ProjectCode = "PRJ" + "-" + CreateNewId(id).ToUpper();

                var newproject = _appDbContext.Projects.Add(project).Entity;

                project.CreateProject(currentuser,loggedInResourceId);

                _appDbContext.SaveChanges();

                project = Getproject(comp, id);

                var results = _mapper.Map<Project, EditProjectData>(project);


                return Ok(results);
            }
            return BadRequest("You are not authorised to perform this action.");
        }


        [HttpDelete("{companyId}/{id}")]
        [Authorize(Policy="Admin_Group")]
        public IActionResult DeleteProject(string companyId, string id)
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
                var project = Getproject(company, id);

                if (project == null)
                return BadRequest("You are not authorised to perform this action.");

                project.Cancel();

                _appDbContext.Remove(project);
                _appDbContext.SaveChanges();

                return Json("Success");
            }
            return BadRequest("You are not authorised to perform this action.");
        }

    }
}






//         [HttpGet]
//         public IEnumerable<Project> Get()
//         {
//            return _appDbContext.Projects;
//         }


//         // //[Authorize]
//         // [HttpGet("{companyId}/{id}")]
//         //  public ActionResult Get(string companyId, string id) {
//         //       var projectDb = _appDbContext.Projects.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.ProjectId == id));
//         //        if(projectDb == null)
//         //        return NotFound("Project not found");

//         //       return Ok(projectDb);
//         // }

//         [HttpGet("{companyId}/{id}")]
//         public async Task<IEnumerable<ProjectViewModel>> GetProjects(string companyId, string id)
//         {
//                     var allProjects = await _appDbContext.Projects
//                                                 .Where(p => p.CompanyId == companyId && p.Id == id).ToListAsync();
//             // return allProjects.ToList().Select(Mapper.Map<Project, ProjectViewModel>);
//              return Mapper.Map<List<Project>, List<ProjectViewModel>>(allProjects);
//         }


//         //[Authorize]
//         [HttpPost("project")]
//         public ActionResult Post([FromBody] EditProjectData projectData)
//         {

//             var project = Getproject(projectData.CompanyId, projectData.ProjectId);

//                 project.AccountingCode = projectData.AccountingCode ?? project.AccountingCode;
//                 project.BenefitsDurationInYears = projectData.BenefitsDurationInYears ?? project.BenefitsDurationInYears;
//                 project.BenefitsStartYear = projectData.BenefitsStartYear ?? project.BenefitsStartYear;
//                 project.BusinessAlignment = projectData.BusinessAlignment ?? project.BusinessAlignment;
//                 project.BusinessCustomerId = projectData.BusinessCustomerId ?? project.BusinessCustomerId;
//                 project.BusinessStrategy = projectData.BusinessStrategy ?? project.BusinessStrategy;
//                 project.CurrentStageGateStatus = projectData.CurrentStageGateStatus ?? project.CurrentStageGateStatus;
//                 project.FinancialStatus = projectData.FinancialStatus ?? project.FinancialStatus;
//                 //project.PortfolioId = projectData.PortfolioId ?? project.PortfolioId;
//                 project.ParentId = projectData.ProgrammeId ?? project.ParentId;
//                 project.ProjectBudget = projectData.ProjectBudget ?? project.ProjectBudget;
//                 project.ProjectCustomer = projectData.ProjectCustomer ?? project.ProjectCustomer;
//                 project.ProjectEndDate = projectData.ProjectEndDate ?? project.ProjectEndDate;
//                 project.ProjectFinanceContactUsername = projectData.ProjectFinanceContactUsername ?? project.ProjectFinanceContactUsername;
//                 project.ProjectLifecycleStage = projectData.ProjectLifecycleStage ?? project.ProjectLifecycleStage;
//                 project.ProjectAlignment = projectData.ProjectAlignment ?? project.ProjectAlignment;

//                 project.ProjectManagerUserId = projectData.ProjectManagerUserId ?? project.ProjectManagerUserId;
//                 project.ProjectManagerUserName = projectData.ProjectManagerUserName ?? project.ProjectManagerUserName;
//                 project.ProjectName = projectData.ProjectName ?? project.ProjectName;
//                 project.ProjectObjective = projectData.ProjectObjective ?? project.ProjectObjective;
//                 project.ProjectOwnerUserName = projectData.ProjectOwnerUserName ?? project.ProjectOwnerUserName;

//                 project.ProjectPrimaryContactUsername = projectData.ProjectPrimaryContactUsername ?? project.ProjectPrimaryContactUsername;
//                 project.ProjectPrioritisation = projectData.ProjectPrioritisation ?? project.ProjectPrioritisation;
//                 project.RfqNumber = projectData.RfqNumber ?? project.RfqNumber;
//                 project.Sponsor = projectData.Sponsor ?? project.Sponsor;
//                 project.RevexCostCode =  "30" + "-"+ CreateNewId(project.Id, 7).ToString().ToUpper();
//                 project.CapexCostCode =  "40"+ "-" + CreateNewId(project.Id, 7).ToString().ToUpper();
//                 project.OpexCostCode =  "50" + "-"+ CreateNewId(project.Id, 7).ToString().ToUpper();
//                // project.ResourceCostCentreId = projectData.ResourceCostCentreId ?? project.ResourceCostCentreId;
//                 project.ProjectStrategy = projectData.ProjectStrategy ?? project.ProjectStrategy;
//                 project.ProjectStartDate = projectData.ProjectStartDate ?? project.ProjectStartDate;
//                 project.ProjectReportedToUserName = projectData.ProjectReportedToUserName ?? project.ProjectReportedToUserName;

//             _appDbContext.SaveChanges();

//             return Ok(project);
//         }



//         AppUser GetSecureUser()
//         {
//             //var id = HttpContext.User.Claims.First().Value;
//             var id = HttpContext.User.Claims.Single(c=>c.Type=="id").Value;
//             return _appDbContext.Users.SingleOrDefault(u => u.Id == id);
//         }

//         Company GetSecureUserCompany()
//         {

//             var id = HttpContext.User.Claims.Single(c => c.Type == "id").Value;
//             var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;

//             return _appDbContext.Companies.SingleOrDefault(c => c.CompanyId == comp);
//         }


//         [HttpGet("{companyId}")]
//         public async Task<IEnumerable<ProjectViewModel>> GetProjects(string companyId)
//         {
//             var allProjects = await _appDbContext.Projects
//                                          .Where(p => p.CompanyId == companyId).ToListAsync();

//             return allProjects.Select(Mapper.Map<Project, ProjectViewModel>);
//         }

//         Project Getproject(string companyId, string projectId)
//         {
//             var projectDb = _appDbContext.Projects.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.Id == projectId));
//             return projectDb;
//         }


//         [HttpPost]
//         public Project PostProject([FromBody] Project project)
//         {

//             var newProject = _appDbContext.Projects.Add(project).Entity;
//             _appDbContext.SaveChanges();
//             return newProject;
//         }


//     }
// }