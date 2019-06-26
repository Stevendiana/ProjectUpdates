
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PTApi.Data.Repositories;
using PTApi.Helpers;
using PTApi.Methods;
using PTApi.Models;
using PTApi.Services;
using PTApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectCentreBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class BudgetController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;


        public BudgetController(UserManager<ApplicationUser> userManager, IUserService userService, IProjectService projectService, IMapper mapper)
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

        public string WriteMonthInWords(int period)
        {

            return _getpublicId.ConvertMonthNumbersToWords(period);
        }

        public class EditProjectBudgetTracker
        {
            public string ProjectBudgetTrackerId { get; set; }
            public string ProjectBudgetTrackerCode { get; set; }
            public string BudgetBadgetStatus { get; set; }
            public int? BudgetBadgetVersion { get; set; }
            public string CompanyId { get; set; }
            public string ProjectId { get; set; }
            public DateTime? BudgetStartDate { get; set; }
            public DateTime? BudgetEndDate { get; set; }


        }

        public class ForecastObject
        {
            public ForecastTask ForecastTasks { get; set; }
            public Actual Actuals { get; set; }
            public string AssociatedActualForecast { get; set; }
            public string ForecastTaskId { get; set; }
            public string ActualId { get; set; }
            public decimal? AllocatedAmount { get; set; }
            public DateTime ActualDateFrom { get; set; }
            public DateTime ActualDateTo { get; set; }

        }


        [Authorize]
        [HttpGet("trackbudgethistory/{companyId}/{projectId}/{id}")]
        public ActionResult GetBudgetbytrackerId(string companyId, string projectId, string id)
        {
            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            var allbudget = _unitOfWork.ProjectBudgets.GetAllProjectBudgetByBatch(id, comp);

            if (allbudget == null)
                return null;

            var allbudgetData = _mapper.Map<IEnumerable<ProjectBudget>, IEnumerable<ProjectBudgetViewModel>>(allbudget);

            return Ok(allbudgetData);
        }


        [Authorize]
        [HttpPost("baselineforecast/{companyId}/{projectId}")]
        public ActionResult BaselineForecast(string companyId, string projectId)
        {

            var comp = _userService.GetSecureUserCompany();
            var userreportingperiod = _userService.GetSecureUserCompanyReportingPeriod();
            var userreportingyear = _userService.GetSecureUserCompanyReportingYear();

            if(companyId != comp){
                return null;
            }
            var projectDb = _unitOfWork.Projects.Get(projectId,comp);
            if(projectDb == null){
                return null;
            }
           
            var lifetimeforecast = _unitOfWork.LifetimeForecast.GetLifeTimeForecast(comp, projectId, userreportingperiod, userreportingyear);

            var id = Guid.NewGuid().ToString();

            var budgetTracker =
            new ProjectBudgetTracker
            {
                ProjectBudgetTrackerId = id,
                ProjectBudgetTrackerCode = "BUDGET" + "-" + CreateNewId(id).ToUpper() + "-" + "TRACK",
                BudgetBadgetVersion = projectDb.LastBatchCount+1,
                CompanyId = comp,
                ProjectId = projectDb.ProjectId,
                BudgetBadgetStatus = Constants.Strings.StatusTypes.PendingApproval,
            };

             _unitOfWork.BudgetTracker.Add(budgetTracker);

            List<ProjectBudget> projectBudget = new List<ProjectBudget>();
            if (lifetimeforecast != null)
            {
                foreach (var item in lifetimeforecast.ToList())
                {
                    var budget = _mapper.Map<ForecastTaskEAC, ProjectBudget>(item);

                    budget.ProjectBudgetTrackerId = id;
                    budget.ProjectBudgetId = Guid.NewGuid().ToString();
                    budget.BudgetCode =  "BUD" + "-" + CreateNewId(budget.ProjectBudgetId).ToUpper();

                    projectBudget.Add(budget);
                    continue;
                }
            }

            
            foreach (var item in projectBudget)
            {
                _unitOfWork.ProjectBudgets.Add(item);
                continue;
            }

            DateTime? minBudgetDate = projectBudget.Select(ra => ra.TaskEarliestStartDate)?.Min();
            DateTime? maxBudgetDate = projectBudget.Select(ra => ra.TaskLatestndEDate)?.Max();

            projectDb.ProjectBudgetTracker.BudgetStartDate = minBudgetDate;
            projectDb.ProjectBudgetTracker.BudgetEndDate = maxBudgetDate;

            projectDb.ProjectBudgetTracker.TotalLifeTimeBudget = projectBudget.Select(b=> b.TotalAmount).Sum();

            _unitOfWork.Complete();

            var allbudgetitems = _unitOfWork.BudgetTracker.GetAllProjectBudgetByBatchId(id,comp);


            var results =  allbudgetitems.Select(Mapper.Map<ProjectBudgetTracker, ProjectBudgetTrackerViewModel>);

           return Ok(results);

        }

        [HttpPost("updatebudgetstatus")]
        [Authorize]
        public ActionResult UpdateBudgetStatus([FromBody] EditProjectBudgetTracker tracker)
        {

            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (tracker.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var project = _unitOfWork.Projects.GetOneProject(tracker.ProjectId, comp);

            if (project == null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var companyId = comp;
            var budget = _unitOfWork.BudgetTracker.GetOneTracker(tracker.ProjectBudgetTrackerId, comp);

            if (budget == null)
                return NotFound();

            var newbudget = _mapper.Map(tracker, budget);
            //var newbudget = _mapper.Map<EditProjectBudgetTracker, ProjectBudgetTracker>(tracker, budget);

            newbudget.CompanyId = comp;
            newbudget.ProjectBudgetTrackerCode = "ASSUMP" + "-" + CreateNewId(budget.ProjectBudgetTrackerId).ToUpper();

            project.ProjectCurrentBudgetTrackerId = _unitOfWork.BudgetTracker.GetLastApprovedBudget(project.ProjectId, comp).ProjectBudgetTrackerId;


            _unitOfWork.Complete();

            newbudget = _unitOfWork.BudgetTracker.GetOneTracker(tracker.ProjectBudgetTrackerId, comp);

            var result = _mapper.Map<ProjectBudgetTracker, ProjectBudgetTrackerViewModel>(newbudget);

            return Ok(result);

        }

    }
}