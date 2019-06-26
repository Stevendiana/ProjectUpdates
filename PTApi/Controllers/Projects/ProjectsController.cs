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
    public class ProjectsController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;


        public ProjectsController(UserManager<ApplicationUser> userManager, IUserService userService, IProjectService projectService, IMapper mapper)
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
            var projectDb = _unitOfWork.Projects.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.ProjectId == id));

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
                    var allProjects = _unitOfWork.Projects.GetAllProjects(comp);

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
                var project = _unitOfWork.Projects.SingleOrDefault(b => (b.CompanyId == companyId) && (b.ProjectId == projectData.ProjectId));

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
                
                project.ProjectCustomer = projectData.ProjectCustomer ?? project.ProjectCustomer;
               
                project.ProjectManagementRankId = project.ProjectManagementRankId;
                project.ProjectLifecycleStage = projectData.ProjectLifecycleStage ?? project.ProjectLifecycleStage;
                project.ProjectAlignment = projectData.ProjectAlignment ?? project.ProjectAlignment;

                project.ProjectName = projectData.ProjectName ?? project.ProjectName;
                project.ProjectCurrentBudgetTrackerId = projectData.ProjectCurrentBudgetTrackerId ?? project.ProjectCurrentBudgetTrackerId;


                project.ProjectObjective = projectData.ProjectObjective ?? project.ProjectObjective;


                project.ProjectPrioritisation = projectData.ProjectPrioritisation ?? project.ProjectPrioritisation;
                project.RfqNumber = projectData.RfqNumber ?? project.RfqNumber;
                project.Sponsor = projectData.Sponsor ?? project.Sponsor;

                project.RevexCostCode =  "30" + "-"+ CreateNewId(project.ProjectId).ToString().ToUpper();
                project.CapexCostCode =  "40"+ "-" + CreateNewId(project.ProjectId).ToString().ToUpper();
                project.OpexCostCode =  "50" + "-"+ CreateNewId(project.ProjectId).ToString().ToUpper();
               
                project.ProjectStrategy = projectData.ProjectStrategy ?? project.ProjectStrategy;
               

                project.ProjectCode = "PRJ" + "-" + CreateNewId(project.ProjectId).ToUpper();


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

                // project.ProjectStartDate = projectData.ProjectStartDate ?? project.ProjectStartDate;
                //project.BudgetCurrentStatus = projectData.BudgetCurrentStatus ?? project.BudgetCurrentStatus;
                // project.ResourceCostCentreId = projectData.ResourceCostCentreId ?? project.ResourceCostCentreId;
                // project.ProjectBudget = projectData.ProjectBudget ?? project.ProjectBudget;
                // project.ProjectEndDate = projectData.ProjectEndDate ?? project.ProjectEndDate;


                _unitOfWork.Complete();
                //project.UpdateProjectInfoNotification();
                project.UpdateProjectStatusNotification(project.CurrentStageGateStatus);


                project = _unitOfWork.Projects.GetOneProject(project.ProjectId, comp);

                var result = _mapper.Map<Project, ProjectViewModel>(project);

                return Ok(result);
            }

            return BadRequest("You are not authorised to perform this action.");
        }


       


        [HttpPost]
        [Authorize(Policy="Admin_Group")]
        public IActionResult NewProject( [FromBody] EditProjectData projectData)
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
                project.LastBudgetBatchVersion = 0;
                
                project.ProjectCode = "PRJ" + "-" + CreateNewId(id).ToUpper();

                _unitOfWork.Projects.Add(project);

                project.CreateProjectNotification(currentuser,loggedInResourceId);

                _unitOfWork.Complete();

                project = _unitOfWork.Projects.GetOneProject(id,comp);

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
                var project = _unitOfWork.Projects.GetOneProject(id, comp);

                if (project == null)
                return BadRequest("You are not authorised to perform this action.");

                project.CancelProjectNotification();

                //_unitOfWork.Projects.Remove(project);
                //_unitOfWork.Complete();

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