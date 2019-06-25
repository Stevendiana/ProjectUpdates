
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
using ProjectCentreBackend.Core.Repositories;
using ProjectCentreBackend.Core.Interfaces;
using static ProjectCentreBackend.Core.Repositories.ProjectForecastRepository;
using System.Collections.ObjectModel;
using ProjectCentreBackend.Helpers;
using FluentValidation.Results;
using System.ComponentModel.DataAnnotations;
using static ProjectCentreBackend.CustomValidation.CustomValidation;

namespace ProjectCentreBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class BudgetController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ProjectCentreDbContext _appDbContext;
        private readonly IProjectService _projectService;
        private readonly IUserService _userService;
        private readonly IProjectForecastRepository _projectForecastRepository;
        private readonly IMapper _mapper;

        public BudgetController(UserManager<AppUser> userManager, IUserService userService, IMapper mapper,ProjectCentreDbContext appDbContext, IProjectForecastRepository projectForecastRepository, IProjectService projectService )
        {
            _projectService = projectService;
            _userManager = userManager;
             _userService = userService;
            _mapper=mapper;
            _appDbContext = appDbContext ;
            _projectForecastRepository = projectForecastRepository ;

        }

        private static string CreateNewId(string Id)
        {
            GeneratePublicId generatePublicId = new GeneratePublicId();
            return generatePublicId.PartId(Id, 8);
        }


        public class ForecastTaskEAC
        {
            // public string ForecastCode { get{return "FOR" + "-" + CreateNewId(ForecastTaskId,8).ToUpper();}}

            public string ForecastTaskId { get; set; }
            public string TextTaskCostDescription { get; set; }
            public byte? ForecastPeriodType { get; set; }
            public int? Order { get; set; }
            public decimal Progress { get; set; }
            public bool Open { get; set; }
            public string Parent { get; set; }
            public int? Year { get; set; }
            public byte? Month { get; set; }
            public int? BaselinePeriod { get; set; }
            public string ForecastCode { get; set; }
            public string ProjectStageRefid { get; set; }
            public string ProjectStage { get; set; }
            public string CostType { get; set; }
            public string CostCat { get; set; }
            public string ResourceId { get; set; }
            public string ResourceName { get; set; }
            public string VendorId { get; set; }
            public Supplier Supplier { get; set; }
            public Resource Resource { get; set; }
            public string OrderNumber { get; set; }
            public string CompanyId { get; set; }
            public string ProjectId { get; set; }
            public DateTime? JanStartDate { get; set; }
            public DateTime? JanEndDate { get; set; }
            public decimal? ResourceRateJan { get; set; }
            public decimal? JanForecastPreciseDuration { get; set; }
            public decimal? JanAmount { get; set; }
            public DateTime? FebStartDate { get; set; }
            public DateTime? FebEndDate { get; set; }
            public decimal? ResourceRateFeb { get; set; }
            public decimal? FebForecastPreciseDuration { get; set; }
            public decimal? FebAmount { get; set; }
            public DateTime? MarStartDate { get; set; }
            public DateTime? MarEndDate { get; set; }
            public decimal? ResourceRateMar { get; set; }
            public decimal? MarForecastPreciseDuration { get; set; }
            public decimal? MarAmount { get; set; }
            public DateTime? AprStartDate { get; set; }
            public DateTime? AprEndDate { get; set; }
            public decimal? ResourceRateApr { get; set; }
            public decimal? AprForecastPreciseDuration { get; set; }
            public decimal? AprAmount { get; set; }
            public DateTime? MayStartDate { get; set; }
            public DateTime? MayEndDate { get; set; }
            public decimal? ResourceRateMay { get; set; }
            public decimal? MayForecastPreciseDuration { get; set; }
            public decimal? MayAmount { get; set; }
            public DateTime? JunStartDate { get; set; }
            public DateTime? JunEndDate { get; set; }
            public decimal? ResourceRateJun { get; set; }
            public decimal? JunForecastPreciseDuration { get; set; }
            public decimal? JunAmount { get; set; }
            public DateTime? JulStartDate { get; set; }
            public DateTime? JulEndDate { get; set; }
            public decimal? ResourceRateJul { get; set; }
            public decimal? JulForecastPreciseDuration { get; set; }
            public decimal? JulAmount { get; set; }
            public DateTime? AugStartDate { get; set; }
            public DateTime? AugEndDate { get; set; }
            public decimal? ResourceRateAug { get; set; }
            public decimal? AugForecastPreciseDuration { get; set; }
            public decimal? AugAmount { get; set; }
            public DateTime? SepStartDate { get; set; }
            public DateTime? SepEndDate { get; set; }
            public decimal? ResourceRateSep { get; set; }
            public decimal? SepForecastPreciseDuration { get; set; }
            public decimal? SepAmount { get; set; }
            public DateTime? OctEndDate { get; set; }
            public DateTime? OctStartDate { get; set; }
            public decimal? ResourceRateOct { get; set; }
            public decimal? OctForecastPreciseDuration { get; set; }
            public decimal? OctAmount { get; set; }
            public DateTime? NovStartDate { get; set; }
            public DateTime? NovEndDate { get; set; }
            public decimal? ResourceRateNov { get; set; }
            public decimal? NovForecastPreciseDuration { get; set; }
            public decimal? NovAmount { get; set; }
            public DateTime? DecStartDate { get; set; }
            public DateTime? DecEndDate { get; set; }
            public decimal? ResourceRateDec { get; set; }
            public decimal? DecForecastPreciseDuration { get; set; }
            public decimal? DecAmount { get; set; }
            public decimal? TotalForecastPreciseDuration { get; set; }
            public decimal? TotalAmount { get; set; }

            public string CostSubCategory { get; set; }
            public string ResourcePerCost { get; set; }
            public decimal? MaterialQuantityJan { get; set; }
            public decimal? MaterialUnitCostJan { get; set; }

            public decimal? MaterialQuantityFeb { get; set; }
            public decimal? MaterialUnitCostFeb { get; set; }
            public decimal? MaterialQuantityMar { get; set; }
            public decimal? MaterialUnitCostMar { get; set; }
            public decimal? MaterialQuantityApr { get; set; }
            public decimal? MaterialUnitCostApr { get; set; }
            public decimal? MaterialQuantityMay { get; set; }
            public decimal? MaterialUnitCostMay { get; set; }
            public decimal? MaterialQuantityJun { get; set; }
            public decimal? MaterialUnitCostJun { get; set; }
            public decimal? MaterialQuantityJul { get; set; }
            public decimal? MaterialUnitCostJul { get; set; }
            public decimal? MaterialQuantityAug { get; set; }
            public decimal? MaterialUnitCostAug { get; set; }
            public decimal? MaterialQuantitySep { get; set; }
            public decimal? MaterialUnitCostSep { get; set; }
            public decimal? MaterialQuantityOct { get; set; }
            public decimal? MaterialUnitCostOct { get; set; }
            public decimal? MaterialQuantityNov { get; set; }
            public decimal? MaterialUnitCostNov { get; set; }
            public decimal? MaterialQuantityDec { get; set; }
            public decimal? MaterialUnitCostDec { get; set; }

            public ICollection<ReconciledActual> ReconciledActuals { get; set; }

            public ForecastTaskEAC()
            {
                ReconciledActuals = new Collection<ReconciledActual>();
            }

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
        public async Task<IEnumerable<ProjectBudgetTrackerViewModel>> GetBudgetbytrackerId(string companyId, string projectId, string id)
        {

            var allmore = await _appDbContext.ProjectBudgetTrackers
                                            .Include(b=>b.ProjectBudgets)
                                            .Where(b=>(b.ProjectId==projectId) && (b.CompanyId==companyId) && (b.ProjectBudgetTrackerId==id)).ToListAsync();


            return allmore.Select(Mapper.Map<ProjectBudgetTracker, ProjectBudgetTrackerViewModel>);
        }

        public decimal? GetTotalActualReconciled(List<ForecastTask>  forecast, string forecastId, int month)
        {

          var forecastactuals = forecast.SelectMany(f=>f.ReconciledActuals.Where(fr=>(f.ForecastTaskId==forecastId)));
          return forecastactuals?.Where(a=>(a.ActualDateTo.Month == month)&&(a.ActualDateFrom.Month == month)).Select(a=> a.AllocatedAmount).Sum();
        }

        public string GetResourcePerCost(ForecastTask  forecast)
        {

            if (forecast.CostType==Constants.Strings.CostTypes.LabourCost&&forecast.ResourceId!=null)
            {
                return forecast.ResourceId;
            }
            return forecast.VendorId;
        }



        [Authorize]
        [HttpGet("getactualforecastrec/{companyId}/{projectId}/{year}")]
        public async Task<IEnumerable<ForecastTaskViewModel>> GetOneForecastAndRec(string companyId, string projectId, int year)
        {

            var all = await _appDbContext.ForecastTasks
                                            .Include(f=>f.Resource).Include(f=>f.Supplier)
                                            .Where(f=>(f.ProjectId==projectId) && (f.CompanyId==companyId)&& (f.Year==year))
                                            .Include(f=>f.ReconciledActuals).ToListAsync();


            return all.Select(Mapper.Map<ForecastTask, ForecastTaskViewModel>);
        }
        public List<ForecastTask> GetForecast(string companyId, string projectId, string reportingyear, bool lifetime)
        {

            int? i = 0;
            string s = reportingyear;
            i =int.Parse(s);
            i = Convert.ToInt32(s);


            if (lifetime==false)
            {
                var allprojectforecast = _appDbContext.ForecastTasks
                                              .Include(f=>f.Resource).Include(f=>f.Supplier)
                                               .Where(f=>(f.ProjectId==projectId) && (f.CompanyId==companyId)&&(f.Year==i)).ToList();


                return allprojectforecast;
            }

            var allprojectforecastLifetime =  _appDbContext.ForecastTasks
                                                  .Where(f=>(f.ProjectId==projectId) && (f.CompanyId==companyId))
                                                  .Include(f=>f.Resource).Include(f=>f.Supplier)
                                                  .Include(f=>f.ReconciledActuals).ToList();

            return allprojectforecastLifetime;
        }

        public async Task<ForecastTask> GetOneForecast(string companyId, string projectId, string id, string reportingyear, bool lifetime)
        {

            int? i = 0;
            string s = reportingyear;
            i =int.Parse(s);
            i = Convert.ToInt32(s);


            if (lifetime==false)
            {
                var oneforecast = await  _appDbContext.ForecastTasks
                                         .Include(f=>f.Resource)
                                         .Include(f=>f.Supplier)
                                         .Include(f=>f.ReconciledActuals)
                                        .SingleOrDefaultAsync(f => (f.CompanyId == companyId) &&
                                               (f.ProjectId == projectId)&& (f.Year==i) &&
                                               (f.ForecastTaskId == id));
                return oneforecast;
            }

            var oneforecastLifetime = await  _appDbContext.ForecastTasks
                                         .Include(f=>f.Resource)
                                         .Include(f=>f.Supplier)
                                        .Include(b=>b.ReconciledActuals)
                                        .SingleOrDefaultAsync(f => (f.CompanyId == companyId) &&
                                               (f.ProjectId == projectId)&&
                                               (f.ForecastTaskId == id));

            return oneforecastLifetime;
        }




        [Authorize]
        [HttpPost("baselineforecast/{companyId}/{projectId}")]
        public async Task<ActionResult> BaselineForecast(string companyId, string projectId)
        {

            var comp = _userService.GetSecureUserCompany();
            var userreportingperiod = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Financerepperiod).Value;
            var userreportingyear = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Financerepyear).Value;

            int? i = 0;
            string status = "Draft";
            string s = userreportingyear;
            i =int.Parse(s);
            i = Convert.ToInt32(s);

            if(companyId != comp){
                return null;
            }
            var projectDb = _appDbContext.Projects
            .Include(p=>p.ProjectBudgetTracker).ThenInclude(pt=>pt.ProjectBudgets).SingleOrDefault(b => (b.CompanyId == companyId)&& (b.ProjectId == projectId));
            if(projectDb == null){
                return null;
            }
            if(projectDb.BudgetCurrentStatus == Constants.Strings.StatusTypes.Approved){
                ModelState.AddModelError("status", string.Format("Budget is approved. You can not amend until the last submitted budget is rejected ", projectDb.BudgetCurrentStatus));
                return BadRequest(ModelState);
            }
            if(status != Constants.Strings.StatusTypes.Draft||
               status != Constants.Strings.StatusTypes.Rejected||
               status != Constants.Strings.StatusTypes.Revised){

                ModelState.AddModelError("status", string.Format("Unknown Status ", status));
                return BadRequest(ModelState);
            }

            var previousyearsforecast = PastYearsForecast(companyId, projectId, i).Result;
            var futureyearsforecast = FutureYearsForecast(companyId, projectId, i).Result;
            var currentyear = GetCurrentYearForecast(companyId, projectId, userreportingperiod, userreportingyear);

            // List<ForecastTaskEAC> lifetimebudget = new List<ForecastTaskEAC>();

            var id = Guid.NewGuid().ToString();

            var allbudget = new List<ForecastTaskEAC>(previousyearsforecast.Count+futureyearsforecast.Count + currentyear.Count);
                            allbudget.AddRange(previousyearsforecast);
                            allbudget.AddRange(futureyearsforecast);
                            allbudget.AddRange(currentyear);

            projectDb.BudgetCurrentStatus = status;
            projectDb.CurrentBudgetBadgeVersion = projectDb.CurrentBudgetBadgeVersion+1;
            projectDb.ProjectCurrentBudgetTrackerId = id;


            var budgetTracker =
            new ProjectBudgetTracker
            {
                ProjectBudgetTrackerId = id,
                ProjectBudgetTrackerCode = "BUDGET" + "-" + CreateNewId(id).ToUpper() + "-" + "TRACK",
                BudgetBadgetVersion = projectDb.CurrentBudgetBadgeVersion+1,
                CompanyId = comp,
                ProjectId = projectDb.ProjectId,
                BudgetBadgetStatus = status,
            };

             _appDbContext.Add(budgetTracker);

            List<ProjectBudget> projectBudget = new List<ProjectBudget>();
            if (allbudget!=null)
            {
                foreach (var item in allbudget)
                {
                    var budget = _mapper.Map<ForecastTaskEAC, ProjectBudget>(item);

                    budget.ProjectBudgetTrackerId = id;
                    budget.ProjectBudgetId = Guid.NewGuid().ToString();
                    budget.BudgetCode =  "BUD" + "-" + CreateNewId(budget.ProjectBudgetId).ToUpper();

                    projectBudget.Add(budget);
                    continue;
                }

            }

            // if (futureyearsforecast!=null)
            // {
            //     foreach (var item in futureyearsforecast)
            //     {
            //         var budget = _mapper.Map<ForecastTaskEAC, ProjectBudget>(item);

            //         budget.ProjectBudgetTrackerId = id;
            //         budget.ProjectBudgetId = Guid.NewGuid().ToString();
            //         budget.BudgetCode =  "BUD" + "-" + CreateNewId(budget.ProjectBudgetId).ToUpper();

            //         projectBudget.Add(budget);
            //         continue;
            //     }

            // }
            // if (currentyear!=null)
            // {
            //     foreach (var item in currentyear)
            //     {
            //         var budget = _mapper.Map<ForecastTaskEAC, ProjectBudget>(item);

            //         budget.ProjectBudgetTrackerId = id;
            //         budget.ProjectBudgetId = Guid.NewGuid().ToString();
            //         budget.BudgetCode =  "BUD" + "-" + CreateNewId(budget.ProjectBudgetId).ToUpper();

            //         projectBudget.Add(budget);
            //         continue;
            //     }

            // }

            foreach (var item in projectBudget)
            {
                var newbudget = _appDbContext.ProjectBudgets.Add(item).Entity;
                continue;
            }

            DateTime? minBudgetDate = projectBudget.Select(ra => ra.TaskEarliestStartDate)?.Min();
            DateTime? maxBudgetDate = projectBudget.Select(ra => ra.TaskLatestndEDate)?.Max();

            projectDb.ProjectBudgetTracker.BudgetStartDate = minBudgetDate;
            projectDb.ProjectBudgetTracker.BudgetEndDate = maxBudgetDate;

            projectDb.ProjectBudgetTracker.TotalLifeTimeBudget = projectBudget.Select(b=> b.TotalAmount).Sum();

            _appDbContext.SaveChanges();

            var allbudgetitems = await _appDbContext.ProjectBudgetTrackers
                                            .Include(b=>b.ProjectBudgets)
                                            .Where(b=>(b.ProjectId==projectId) && (b.CompanyId==companyId) && (b.ProjectBudgetTrackerId==id)).ToListAsync();


            var results =  allbudgetitems.Select(Mapper.Map<ProjectBudgetTracker, ProjectBudgetTrackerViewModel>);

           return Ok(results);

        }
        public async Task<List<ForecastTaskEAC>> PastYearsForecast(string companyId, string projectId, int? i)
        {


            var allprojectforecasts = await _appDbContext.ForecastTasks.Where(f=>(f.ProjectId==projectId) &&
                                     (f.CompanyId==companyId)&& (f.Year<i)).Include(f=>f.Resource).Include(f=>f.Supplier)
                                     .Include(f=>f.ReconciledActuals.Where(fr=>f.ProjectId == fr.ProjectId)).ToListAsync();

            if(allprojectforecasts == null){
                return null;
            }


            List<ForecastTaskEAC> forecastTask = new List<ForecastTaskEAC>();

            foreach (var item in allprojectforecasts)
            {
                var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(item);

                forecast.JanAmount = GetTotalActualReconciled(allprojectforecasts, item.ForecastTaskId, 1);
                forecast.FebAmount = GetTotalActualReconciled(allprojectforecasts, item.ForecastTaskId, 2);
                forecast.MarAmount = GetTotalActualReconciled(allprojectforecasts, item.ForecastTaskId, 3);
                forecast.AprAmount = GetTotalActualReconciled(allprojectforecasts, item.ForecastTaskId, 4);
                forecast.MayAmount = GetTotalActualReconciled(allprojectforecasts, item.ForecastTaskId, 5);
                forecast.JunAmount = GetTotalActualReconciled(allprojectforecasts, item.ForecastTaskId, 6);
                forecast.JulAmount = GetTotalActualReconciled(allprojectforecasts, item.ForecastTaskId, 7);
                forecast.AugAmount = GetTotalActualReconciled(allprojectforecasts, item.ForecastTaskId, 8);
                forecast.SepAmount = GetTotalActualReconciled(allprojectforecasts, item.ForecastTaskId, 9);
                forecast.OctAmount = GetTotalActualReconciled(allprojectforecasts, item.ForecastTaskId, 10);
                forecast.NovAmount = GetTotalActualReconciled(allprojectforecasts, item.ForecastTaskId, 11);
                forecast.DecAmount = GetTotalActualReconciled(allprojectforecasts, item.ForecastTaskId, 12);
                forecast.ResourcePerCost = GetResourcePerCost(item);

                forecastTask.Add(forecast);
                continue;
            }
            return forecastTask;

        }



        // [Authorize]
        // [HttpGet("futureyearsprojectforecast/{companyId}/{projectId}/{reportingyear}")]
        public async Task<List<ForecastTaskEAC>> FutureYearsForecast(string companyId, string projectId, int? i)
        {

            var allprojectforecasts = await _appDbContext.ForecastTasks.Where(f=>(f.ProjectId==projectId) &&
                                     (f.CompanyId==companyId)&& (f.Year>i))
                                     .Include(f=>f.ReconciledActuals.Where(fr=>f.ProjectId == fr.ProjectId)).ToListAsync();

            if(allprojectforecasts == null){
                return null;
            }


            List<ForecastTaskEAC> forecastTask = new List<ForecastTaskEAC>();

            foreach (var item in allprojectforecasts)
            {
                var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(item);

                forecast.JanAmount = item.JanForecastAmount;
                forecast.FebAmount = item.FebForecastAmount;
                forecast.MarAmount = item.MarForecastAmount;
                forecast.AprAmount = item.AprForecastAmount;
                forecast.MayAmount = item.MayForecastAmount;
                forecast.JunAmount = item.JunForecastAmount;
                forecast.JulAmount = item.JulForecastAmount;
                forecast.AugAmount = item.AugForecastAmount;
                forecast.SepAmount = item.SepForecastAmount;
                forecast.OctAmount = item.OctForecastAmount;
                forecast.NovAmount = item.NovForecastAmount;
                forecast.DecAmount = item.DecForecastAmount;
                forecast.ResourcePerCost = GetResourcePerCost(item);

                forecastTask.Add(forecast);
                continue;
            }
            return forecastTask;

        }

        public decimal? GetActualsReconciledSum(ForecastTask  forecast, string forecastId, int month)
        {

          var forecastactuals = forecast.ReconciledActuals.Where(a=>(a.ActualDateTo.Month == month)&&
                                        (a.ActualDateFrom.Month == month)&&
                                        (a.ForecastTaskId == forecastId)).Select(a=> a.AllocatedAmount).Sum();
          return forecastactuals;
        }
        public ActualSumAndDuration GetActualsReconciled(ForecastTask  forecast, string forecastId, int month)
        {

          var forecastactuals = forecast.ReconciledActuals.Where(a=>(a.ActualDateTo.Month == month)&&
                                        (a.ActualDateFrom.Month == month)&&
                                        (a.ForecastTaskId == forecastId)).ToList();


            decimal? amountSum = forecastactuals.Select(a=> a.AllocatedAmount).Sum();
            decimal? timeDuration = forecastactuals.Select(a=> a.ActualDurationInDaysWorkingDays).Sum();

            var forecastObj = new ActualSumAndDuration()
            {
                AmountSum = amountSum,
                TimeDuration = timeDuration
            };

            return forecastObj;
        }

        public class ActualSumAndDuration
        {
            public decimal? AmountSum { get; set; }
            public decimal? TimeDuration { get; set; }
        }



        [Authorize]
        [HttpGet("currentprojectforecast/{companyId}/{projectId}/{id}/{reportingperiod}/{reportingyear}")]
        public IActionResult GetCurrentYearOneForecast(string companyId, string projectId, string id, string reportingperiod, string reportingyear) {

            var comp = _userService.GetSecureUserCompany();
            var userreportingperiod = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Financerepperiod).Value;
            var userreportingyear = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Financerepyear).Value;

            if(companyId != comp){
                return BadRequest();
            }

            var forecastTaskDb = GetOneForecast( companyId, projectId, id, userreportingyear, false).Result;

            if(forecastTaskDb == null)
            return NotFound("Forecast not found");

            List<ForecastTaskEAC> forecastTask = new List<ForecastTaskEAC>();
            // var forecastEac =  Mapper.Map<List<ForecastTask>, List<ForecastTaskEAC>>(allprojectforecast);

            if (reportingperiod == Constants.Strings.ReportingPeriods.January)
            {
               var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(forecastTaskDb);

                forecast.JanAmount = forecastTaskDb.JanForecastAmount;
                forecast.FebAmount = forecastTaskDb.FebForecastAmount;
                forecast.MarAmount = forecastTaskDb.MarForecastAmount;
                forecast.AprAmount = forecastTaskDb.AprForecastAmount;
                forecast.MayAmount = forecastTaskDb.MayForecastAmount;
                forecast.JunAmount = forecastTaskDb.JunForecastAmount;
                forecast.JulAmount = forecastTaskDb.JulForecastAmount;
                forecast.AugAmount = forecastTaskDb.AugForecastAmount;
                forecast.SepAmount = forecastTaskDb.SepForecastAmount;
                forecast.OctAmount = forecastTaskDb.OctForecastAmount;
                forecast.NovAmount = forecastTaskDb.NovForecastAmount;
                forecast.DecAmount = forecastTaskDb.DecForecastAmount;
                forecast.ResourcePerCost = GetResourcePerCost(forecastTaskDb);
               return Ok(forecastTask);
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.February)
            {
               var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(forecastTaskDb);

                forecast.JanForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).TimeDuration;
                forecast.JanAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).AmountSum;
                forecast.FebAmount = forecastTaskDb.FebForecastAmount;
                forecast.MarAmount = forecastTaskDb.MarForecastAmount;
                forecast.AprAmount = forecastTaskDb.AprForecastAmount;
                forecast.MayAmount = forecastTaskDb.MayForecastAmount;
                forecast.JunAmount = forecastTaskDb.JunForecastAmount;
                forecast.JulAmount = forecastTaskDb.JulForecastAmount;
                forecast.AugAmount = forecastTaskDb.AugForecastAmount;
                forecast.SepAmount = forecastTaskDb.SepForecastAmount;
                forecast.OctAmount = forecastTaskDb.OctForecastAmount;
                forecast.NovAmount = forecastTaskDb.NovForecastAmount;
                forecast.DecAmount = forecastTaskDb.DecForecastAmount;
                forecast.ResourcePerCost = GetResourcePerCost(forecastTaskDb);
                forecastTask.Add(forecast);
               return Ok(forecastTask);
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.March)
            {
               var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(forecastTaskDb);

                forecast.JanForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).TimeDuration;
                forecast.FebForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).TimeDuration;
                forecast.JanAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).AmountSum;
                forecast.FebAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).AmountSum;
                forecast.MarAmount = forecastTaskDb.MarForecastAmount;
                forecast.AprAmount = forecastTaskDb.AprForecastAmount;
                forecast.MayAmount = forecastTaskDb.MayForecastAmount;
                forecast.JunAmount = forecastTaskDb.JunForecastAmount;
                forecast.JulAmount = forecastTaskDb.JulForecastAmount;
                forecast.AugAmount = forecastTaskDb.AugForecastAmount;
                forecast.SepAmount = forecastTaskDb.SepForecastAmount;
                forecast.OctAmount = forecastTaskDb.OctForecastAmount;
                forecast.NovAmount = forecastTaskDb.NovForecastAmount;
                forecast.DecAmount = forecastTaskDb.DecForecastAmount;
                forecast.ResourcePerCost = GetResourcePerCost(forecastTaskDb);
                forecastTask.Add(forecast);
               return Ok(forecastTask);
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.April)
            {
               var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(forecastTaskDb);

                forecast.JanForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).TimeDuration;
                forecast.FebForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).TimeDuration;
                forecast.MarForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 3).TimeDuration;
                forecast.JanAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).AmountSum;
                forecast.FebAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).AmountSum;
                forecast.MarAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 3).AmountSum;
                forecast.AprAmount = forecastTaskDb.AprForecastAmount;
                forecast.MayAmount = forecastTaskDb.MayForecastAmount;
                forecast.JunAmount = forecastTaskDb.JunForecastAmount;
                forecast.JulAmount = forecastTaskDb.JulForecastAmount;
                forecast.AugAmount = forecastTaskDb.AugForecastAmount;
                forecast.SepAmount = forecastTaskDb.SepForecastAmount;
                forecast.OctAmount = forecastTaskDb.OctForecastAmount;
                forecast.NovAmount = forecastTaskDb.NovForecastAmount;
                forecast.DecAmount = forecastTaskDb.DecForecastAmount;
                forecast.ResourcePerCost = GetResourcePerCost(forecastTaskDb);
                forecastTask.Add(forecast);
               return Ok(forecastTask);
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.May)
            {
               var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(forecastTaskDb);

                forecast.JanForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).TimeDuration;
                forecast.FebForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).TimeDuration;
                forecast.MarForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 3).TimeDuration;
                forecast.AprForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 4).TimeDuration;
                forecast.JanAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).AmountSum;
                forecast.FebAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).AmountSum;
                forecast.MarAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 3).AmountSum;
                forecast.AprAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 4).AmountSum;
                forecast.MayAmount = forecastTaskDb.MayForecastAmount;
                forecast.JunAmount = forecastTaskDb.JunForecastAmount;
                forecast.JulAmount = forecastTaskDb.JulForecastAmount;
                forecast.AugAmount = forecastTaskDb.AugForecastAmount;
                forecast.SepAmount = forecastTaskDb.SepForecastAmount;
                forecast.OctAmount = forecastTaskDb.OctForecastAmount;
                forecast.NovAmount = forecastTaskDb.NovForecastAmount;
                forecast.DecAmount = forecastTaskDb.DecForecastAmount;
                forecast.ResourcePerCost = GetResourcePerCost(forecastTaskDb);
                forecastTask.Add(forecast);
               return Ok(forecastTask);
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.June)
            {
               var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(forecastTaskDb);

                forecast.JanForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).TimeDuration;
                forecast.FebForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).TimeDuration;
                forecast.MarForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 3).TimeDuration;
                forecast.AprForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 4).TimeDuration;
                forecast.MayForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 5).TimeDuration;

                forecast.JanAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).AmountSum;
                forecast.FebAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).AmountSum;
                forecast.MarAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 3).AmountSum;
                forecast.AprAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 4).AmountSum;
                forecast.MayAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 5).AmountSum;

                forecast.JunAmount = forecastTaskDb.JunForecastAmount;
                forecast.JulAmount = forecastTaskDb.JulForecastAmount;
                forecast.AugAmount = forecastTaskDb.AugForecastAmount;
                forecast.SepAmount = forecastTaskDb.SepForecastAmount;
                forecast.OctAmount = forecastTaskDb.OctForecastAmount;
                forecast.NovAmount = forecastTaskDb.NovForecastAmount;
                forecast.DecAmount = forecastTaskDb.DecForecastAmount;
                forecast.ResourcePerCost = GetResourcePerCost(forecastTaskDb);
                forecastTask.Add(forecast);
               return Ok(forecastTask);
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.July)
            {
               var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(forecastTaskDb);

                forecast.JanForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).TimeDuration;
                forecast.FebForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).TimeDuration;
                forecast.MarForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 3).TimeDuration;
                forecast.AprForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 4).TimeDuration;
                forecast.MayForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 5).TimeDuration;
                forecast.JunForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 6).TimeDuration;
                forecast.JanAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).AmountSum;
                forecast.FebAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).AmountSum;
                forecast.MarAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 3).AmountSum;
                forecast.AprAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 4).AmountSum;
                forecast.MayAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 5).AmountSum;
                forecast.JunAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 6).AmountSum;
                forecast.JulAmount = forecastTaskDb.JulForecastAmount;
                forecast.AugAmount = forecastTaskDb.AugForecastAmount;
                forecast.SepAmount = forecastTaskDb.SepForecastAmount;
                forecast.OctAmount = forecastTaskDb.OctForecastAmount;
                forecast.NovAmount = forecastTaskDb.NovForecastAmount;
                forecast.DecAmount = forecastTaskDb.DecForecastAmount;
                forecast.ResourcePerCost = GetResourcePerCost(forecastTaskDb);
                forecastTask.Add(forecast);
               return Ok(forecastTask);
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.August)
            {
               var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(forecastTaskDb);

                forecast.JanForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).TimeDuration;
                forecast.FebForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).TimeDuration;
                forecast.MarForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 3).TimeDuration;
                forecast.AprForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 4).TimeDuration;
                forecast.MayForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 5).TimeDuration;
                forecast.JunForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 6).TimeDuration;
                forecast.JulForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 7).TimeDuration;
                forecast.JanAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).AmountSum;
                forecast.FebAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).AmountSum;
                forecast.MarAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 3).AmountSum;
                forecast.AprAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 4).AmountSum;
                forecast.MayAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 5).AmountSum;
                forecast.JunAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 6).AmountSum;
                forecast.JulAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 7).AmountSum;
                forecast.AugAmount = forecastTaskDb.AugForecastAmount;
                forecast.SepAmount = forecastTaskDb.SepForecastAmount;
                forecast.OctAmount = forecastTaskDb.OctForecastAmount;
                forecast.NovAmount = forecastTaskDb.NovForecastAmount;
                forecast.DecAmount = forecastTaskDb.DecForecastAmount;
                forecast.ResourcePerCost = GetResourcePerCost(forecastTaskDb);
                forecastTask.Add(forecast);
               return Ok(forecastTask);
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.September)
            {
               var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(forecastTaskDb);

                forecast.JanForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).TimeDuration;
                forecast.FebForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).TimeDuration;
                forecast.MarForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 3).TimeDuration;
                forecast.AprForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 4).TimeDuration;
                forecast.MayForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 5).TimeDuration;
                forecast.JunForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 6).TimeDuration;
                forecast.JulForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 7).TimeDuration;
                forecast.AugForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 8).TimeDuration;
                forecast.JanAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).AmountSum;
                forecast.FebAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).AmountSum;
                forecast.MarAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 3).AmountSum;
                forecast.AprAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 4).AmountSum;
                forecast.MayAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 5).AmountSum;
                forecast.JunAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 6).AmountSum;
                forecast.JulAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 7).AmountSum;
                forecast.AugAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 8).AmountSum;
                forecast.SepAmount = forecastTaskDb.SepForecastAmount;
                forecast.OctAmount = forecastTaskDb.OctForecastAmount;
                forecast.NovAmount = forecastTaskDb.NovForecastAmount;
                forecast.DecAmount = forecastTaskDb.DecForecastAmount;
                forecast.ResourcePerCost = GetResourcePerCost(forecastTaskDb);
                forecastTask.Add(forecast);
               return Ok(forecastTask);
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.October)
            {
               var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(forecastTaskDb);

                forecast.JanForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).TimeDuration;
                forecast.FebForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).TimeDuration;
                forecast.MarForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 3).TimeDuration;
                forecast.AprForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 4).TimeDuration;
                forecast.MayForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 5).TimeDuration;
                forecast.JunForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 6).TimeDuration;
                forecast.JulForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 7).TimeDuration;
                forecast.AugForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 8).TimeDuration;
                forecast.SepForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 9).TimeDuration;
                forecast.JanAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).AmountSum;
                forecast.FebAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).AmountSum;
                forecast.MarAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 3).AmountSum;
                forecast.AprAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 4).AmountSum;
                forecast.MayAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 5).AmountSum;
                forecast.JunAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 6).AmountSum;
                forecast.JulAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 7).AmountSum;
                forecast.AugAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 8).AmountSum;
                forecast.SepAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 9).AmountSum;
                forecast.OctAmount = forecastTaskDb.OctForecastAmount;
                forecast.NovAmount = forecastTaskDb.NovForecastAmount;
                forecast.DecAmount = forecastTaskDb.DecForecastAmount;
                forecast.ResourcePerCost = GetResourcePerCost(forecastTaskDb);
                forecastTask.Add(forecast);
               return Ok(forecastTask);
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.November)
            {
               var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(forecastTaskDb);

                forecast.JanForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).TimeDuration;
                forecast.FebForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).TimeDuration;
                forecast.MarForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 3).TimeDuration;
                forecast.AprForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 4).TimeDuration;
                forecast.MayForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 5).TimeDuration;
                forecast.JunForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 6).TimeDuration;
                forecast.JulForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 7).TimeDuration;
                forecast.AugForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 8).TimeDuration;
                forecast.SepForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 9).TimeDuration;
                forecast.OctForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 10).TimeDuration;
                forecast.JanAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).AmountSum;
                forecast.FebAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).AmountSum;
                forecast.MarAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 3).AmountSum;
                forecast.AprAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 4).AmountSum;
                forecast.MayAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 5).AmountSum;
                forecast.JunAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 6).AmountSum;
                forecast.JulAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 7).AmountSum;
                forecast.AugAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 8).AmountSum;
                forecast.SepAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 9).AmountSum;
                forecast.OctAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 10).AmountSum;
                forecast.NovAmount = forecastTaskDb.NovForecastAmount;
                forecast.DecAmount = forecastTaskDb.DecForecastAmount;
                forecast.ResourcePerCost = GetResourcePerCost(forecastTaskDb);
                forecastTask.Add(forecast);
               return Ok(forecastTask);
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.December)
            {
               var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(forecastTaskDb);

                forecast.JanForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).TimeDuration;
                forecast.FebForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).TimeDuration;
                forecast.MarForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 3).TimeDuration;
                forecast.AprForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 4).TimeDuration;
                forecast.MayForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 5).TimeDuration;
                forecast.JunForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 6).TimeDuration;
                forecast.JulForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 7).TimeDuration;
                forecast.AugForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 8).TimeDuration;
                forecast.SepForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 9).TimeDuration;
                forecast.OctForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 10).TimeDuration;
                forecast.NovForecastPreciseDuration = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 11).TimeDuration;
                forecast.JanAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 1).AmountSum;
                forecast.FebAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 2).AmountSum;
                forecast.MarAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 3).AmountSum;
                forecast.AprAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 4).AmountSum;
                forecast.MayAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 5).AmountSum;
                forecast.JunAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 6).AmountSum;
                forecast.JulAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 7).AmountSum;
                forecast.AugAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 8).AmountSum;
                forecast.SepAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 9).AmountSum;
                forecast.OctAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 10).AmountSum;
                forecast.NovAmount = GetActualsReconciled(forecastTaskDb, forecastTaskDb.ForecastTaskId, 11).AmountSum;
                forecast.DecAmount = forecastTaskDb.DecForecastAmount;
                forecast.ResourcePerCost = GetResourcePerCost(forecastTaskDb);
                forecastTask.Add(forecast);
               return Ok(forecastTask);
            }

            return BadRequest();
        }


        public decimal? Getforecastitemtotal(ForecastTaskEAC  forecast)
        {
            var total = forecast.JanAmount + forecast.FebAmount +
                        forecast.MarAmount + forecast.AprAmount +
                        forecast.MayAmount + forecast.JunAmount +
                        forecast.JulAmount + forecast.AugAmount +
                        forecast.SepAmount + forecast.OctAmount +
                        forecast.NovAmount + forecast.DecAmount;

            return total;
        }


        // [Authorize]
        // [HttpGet("currentprojectforecast/{companyId}/{projectId}/{reportingperiod}/{reportingyear}")]
        public  List<ForecastTaskEAC> GetCurrentYearForecast(string companyId, string projectId, string reportingperiod, string reportingyear) {


            var allprojectforecast = GetForecast( companyId, projectId, reportingyear, false);

            if(allprojectforecast == null){
                return null;
            }

            List<ForecastTaskEAC> forecastTask = new List<ForecastTaskEAC>();
            // var forecastEac =  Mapper.Map<List<ForecastTask>, List<ForecastTaskEAC>>(allprojectforecast);

            if (reportingperiod == Constants.Strings.ReportingPeriods.January)
            {
               foreach (var item in allprojectforecast)
               {
                   var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(item);

                   forecast.JanAmount = item.JanForecastAmount??0;
                   forecast.FebAmount = item.FebForecastAmount??0;
                   forecast.MarAmount = item.MarForecastAmount??0;
                   forecast.AprAmount = item.AprForecastAmount??0;
                   forecast.MayAmount = item.MayForecastAmount??0;
                   forecast.JunAmount = item.JunForecastAmount??0;
                   forecast.JulAmount = item.JulForecastAmount??0;
                   forecast.AugAmount = item.AugForecastAmount??0;
                   forecast.SepAmount = item.SepForecastAmount??0;
                   forecast.OctAmount = item.OctForecastAmount??0;
                   forecast.NovAmount = item.NovForecastAmount??0;
                   forecast.DecAmount = item.DecForecastAmount??0;
                   forecast.TotalAmount = forecast.JanAmount + forecast.FebAmount + forecast.MarAmount + forecast.AprAmount + forecast.MayAmount +
                   forecast.JunAmount + forecast.JulAmount + forecast.AugAmount + forecast.SepAmount + forecast.OctAmount + forecast.NovAmount + forecast.DecAmount;
                   forecast.ResourcePerCost = GetResourcePerCost(item);

                    forecastTask.Add(forecast);
                    continue;
               }
               return forecastTask;
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.February)
            {
               foreach (var item in allprojectforecast)
               {
                   var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(item);

                   forecast.JanAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 1);
                   forecast.FebAmount = item.FebForecastAmount??0;
                   forecast.MarAmount = item.MarForecastAmount??0;
                   forecast.AprAmount = item.AprForecastAmount??0;
                   forecast.MayAmount = item.MayForecastAmount??0;
                   forecast.JunAmount = item.JunForecastAmount??0;
                   forecast.JulAmount = item.JulForecastAmount??0;
                   forecast.AugAmount = item.AugForecastAmount??0;
                   forecast.SepAmount = item.SepForecastAmount??0;
                   forecast.OctAmount = item.OctForecastAmount??0;
                   forecast.NovAmount = item.NovForecastAmount??0;
                   forecast.DecAmount = item.DecForecastAmount??0;
                   forecast.TotalAmount = forecast.JanAmount + forecast.FebAmount + forecast.MarAmount + forecast.AprAmount + forecast.MayAmount +
                   forecast.JunAmount + forecast.JulAmount + forecast.AugAmount + forecast.SepAmount + forecast.OctAmount + forecast.NovAmount + forecast.DecAmount;
                   forecast.ResourcePerCost = GetResourcePerCost(item);
                   forecastTask.Add(forecast);
                    continue;
               }
               return forecastTask;
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.March)
            {
               foreach (var item in allprojectforecast)
               {
                   var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(item);

                   forecast.JanAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 1);
                   forecast.FebAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 2);
                   forecast.MarAmount = item.MarForecastAmount??0;
                   forecast.AprAmount = item.AprForecastAmount??0;
                   forecast.MayAmount = item.MayForecastAmount??0;
                   forecast.JunAmount = item.JunForecastAmount??0;
                   forecast.JulAmount = item.JulForecastAmount??0;
                   forecast.AugAmount = item.AugForecastAmount??0;
                   forecast.SepAmount = item.SepForecastAmount??0;
                   forecast.OctAmount = item.OctForecastAmount??0;
                   forecast.NovAmount = item.NovForecastAmount??0;
                   forecast.DecAmount = item.DecForecastAmount??0;
                   forecast.TotalAmount = forecast.JanAmount + forecast.FebAmount + forecast.MarAmount + forecast.AprAmount + forecast.MayAmount +
                   forecast.JunAmount + forecast.JulAmount + forecast.AugAmount + forecast.SepAmount + forecast.OctAmount + forecast.NovAmount + forecast.DecAmount;
                   forecast.ResourcePerCost = GetResourcePerCost(item);
                   forecastTask.Add(forecast);
                    continue;
               }
               return forecastTask;
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.April)
            {
               foreach (var item in allprojectforecast)
               {
                   var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(item);

                   forecast.JanAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 1);
                   forecast.FebAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 2);
                   forecast.MarAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 3);

                   forecast.AprAmount = item.AprForecastAmount??0;
                   forecast.MayAmount = item.MayForecastAmount??0;
                   forecast.JunAmount = item.JunForecastAmount??0;
                   forecast.JulAmount = item.JulForecastAmount??0;
                   forecast.AugAmount = item.AugForecastAmount??0;
                   forecast.SepAmount = item.SepForecastAmount??0;
                   forecast.OctAmount = item.OctForecastAmount??0;
                   forecast.NovAmount = item.NovForecastAmount??0;
                   forecast.DecAmount = item.DecForecastAmount??0;
                   forecast.TotalAmount = forecast.JanAmount + forecast.FebAmount + forecast.MarAmount + forecast.AprAmount + forecast.MayAmount +
                   forecast.JunAmount + forecast.JulAmount + forecast.AugAmount + forecast.SepAmount + forecast.OctAmount + forecast.NovAmount + forecast.DecAmount;
                   forecast.ResourcePerCost = GetResourcePerCost(item);
                   forecastTask.Add(forecast);
                    continue;
               }
               return forecastTask;
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.May)
            {
               foreach (var item in allprojectforecast)
               {
                   var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(item);

                   forecast.JanAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 1);
                   forecast.FebAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 2);
                   forecast.MarAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 3);
                   forecast.AprAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 4);
                   forecast.MayAmount = item.MayForecastAmount??0;
                   forecast.JunAmount = item.JunForecastAmount??0;
                   forecast.JulAmount = item.JulForecastAmount??0;
                   forecast.AugAmount = item.AugForecastAmount??0;
                   forecast.SepAmount = item.SepForecastAmount??0;
                   forecast.OctAmount = item.OctForecastAmount??0;
                   forecast.NovAmount = item.NovForecastAmount??0;
                   forecast.DecAmount = item.DecForecastAmount??0;
                   forecast.TotalAmount = forecast.JanAmount + forecast.FebAmount + forecast.MarAmount + forecast.AprAmount + forecast.MayAmount +
                   forecast.JunAmount + forecast.JulAmount + forecast.AugAmount + forecast.SepAmount + forecast.OctAmount + forecast.NovAmount + forecast.DecAmount;
                   forecast.ResourcePerCost = GetResourcePerCost(item);
                   forecastTask.Add(forecast);
                    continue;
               }
               return forecastTask;
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.June)
            {
               foreach (var item in allprojectforecast)
               {
                   var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(item);

                   forecast.JanAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 1);
                   forecast.FebAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 2);
                   forecast.MarAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 3);
                   forecast.AprAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 4);
                   forecast.MayAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 5);
                   forecast.JunAmount = item.JunForecastAmount??0;
                   forecast.JulAmount = item.JulForecastAmount??0;
                   forecast.AugAmount = item.AugForecastAmount??0;
                   forecast.SepAmount = item.SepForecastAmount??0;
                   forecast.OctAmount = item.OctForecastAmount??0;
                   forecast.NovAmount = item.NovForecastAmount??0;
                   forecast.DecAmount = item.DecForecastAmount??0;
                   forecast.TotalAmount = forecast.JanAmount + forecast.FebAmount + forecast.MarAmount + forecast.AprAmount + forecast.MayAmount +
                   forecast.JunAmount + forecast.JulAmount + forecast.AugAmount + forecast.SepAmount + forecast.OctAmount + forecast.NovAmount + forecast.DecAmount;
                   forecast.ResourcePerCost = GetResourcePerCost(item);
                   forecastTask.Add(forecast);
                    continue;
               }
               return forecastTask;
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.July)
            {
               foreach (var item in allprojectforecast)
               {
                   var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(item);

                   forecast.JanAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 1);
                   forecast.FebAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 2);
                   forecast.MarAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 3);
                   forecast.AprAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 4);
                   forecast.MayAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 5);
                   forecast.JunAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 6);
                   forecast.JulAmount = item.JulForecastAmount??0;
                   forecast.AugAmount = item.AugForecastAmount??0;
                   forecast.SepAmount = item.SepForecastAmount??0;
                   forecast.OctAmount = item.OctForecastAmount??0;
                   forecast.NovAmount = item.NovForecastAmount??0;
                   forecast.DecAmount = item.DecForecastAmount??0;
                   forecast.TotalAmount = forecast.JanAmount + forecast.FebAmount + forecast.MarAmount + forecast.AprAmount + forecast.MayAmount +
                   forecast.JunAmount + forecast.JulAmount + forecast.AugAmount + forecast.SepAmount + forecast.OctAmount + forecast.NovAmount + forecast.DecAmount;
                   forecast.ResourcePerCost = GetResourcePerCost(item);
                   forecastTask.Add(forecast);
                    continue;
               }
               return forecastTask;
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.August)
            {
               foreach (var item in allprojectforecast)
               {
                   var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(item);

                   forecast.JanAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 1);
                   forecast.FebAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 2);
                   forecast.MarAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 3);
                   forecast.AprAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 4);
                   forecast.MayAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 5);
                   forecast.JunAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 6);
                   forecast.JulAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 7);
                   forecast.AugAmount = item.AugForecastAmount??0;
                   forecast.SepAmount = item.SepForecastAmount??0;
                   forecast.OctAmount = item.OctForecastAmount??0;
                   forecast.NovAmount = item.NovForecastAmount??0;
                   forecast.DecAmount = item.DecForecastAmount??0;
                   forecast.TotalAmount = forecast.JanAmount + forecast.FebAmount + forecast.MarAmount + forecast.AprAmount + forecast.MayAmount +
                   forecast.JunAmount + forecast.JulAmount + forecast.AugAmount + forecast.SepAmount + forecast.OctAmount + forecast.NovAmount + forecast.DecAmount;
                   forecast.ResourcePerCost = GetResourcePerCost(item);
                   forecastTask.Add(forecast);
                    continue;
               }
               return forecastTask;
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.September)
            {
               foreach (var item in allprojectforecast)
               {
                   var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(item);

                   forecast.JanAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 1);
                   forecast.FebAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 2);
                   forecast.MarAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 3);
                   forecast.AprAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 4);
                   forecast.MayAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 5);
                   forecast.JunAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 6);
                   forecast.JulAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 7);
                   forecast.AugAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 8);

                   forecast.SepAmount = item.SepForecastAmount??0;
                   forecast.OctAmount = item.OctForecastAmount??0;
                   forecast.NovAmount = item.NovForecastAmount??0;
                   forecast.DecAmount = item.DecForecastAmount??0;
                   forecast.TotalAmount = forecast.JanAmount + forecast.FebAmount + forecast.MarAmount + forecast.AprAmount + forecast.MayAmount +
                   forecast.JunAmount + forecast.JulAmount + forecast.AugAmount + forecast.SepAmount + forecast.OctAmount + forecast.NovAmount + forecast.DecAmount;
                   forecast.ResourcePerCost = GetResourcePerCost(item);
                   forecastTask.Add(forecast);
                    continue;
               }
               return forecastTask;
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.October)
            {
               foreach (var item in allprojectforecast)
               {
                   var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(item);

                   forecast.JanAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 1);
                   forecast.FebAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 2);
                   forecast.MarAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 3);
                   forecast.AprAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 4);
                   forecast.MayAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 5);
                   forecast.JunAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 6);
                   forecast.JulAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 7);
                   forecast.AugAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 8);
                   forecast.SepAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 9);

                   forecast.OctAmount = item.OctForecastAmount??0;
                   forecast.NovAmount = item.NovForecastAmount??0;
                   forecast.DecAmount = item.DecForecastAmount??0;
                   forecast.TotalAmount = forecast.JanAmount + forecast.FebAmount + forecast.MarAmount + forecast.AprAmount + forecast.MayAmount +
                   forecast.JunAmount + forecast.JulAmount + forecast.AugAmount + forecast.SepAmount + forecast.OctAmount + forecast.NovAmount + forecast.DecAmount;
                   forecast.ResourcePerCost = GetResourcePerCost(item);
                   forecastTask.Add(forecast);
                    continue;
               }
               return forecastTask;
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.November)
            {
               foreach (var item in allprojectforecast)
               {
                   var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(item);

                   forecast.JanAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 1);
                   forecast.FebAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 2);
                   forecast.MarAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 3);
                   forecast.AprAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 4);
                   forecast.MayAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 5);
                   forecast.JunAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 6);
                   forecast.JulAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 7);
                   forecast.AugAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 8);
                   forecast.SepAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 9);
                   forecast.OctAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 10);

                   forecast.NovAmount = item.NovForecastAmount??0;
                   forecast.DecAmount = item.DecForecastAmount??0;
                   forecast.TotalAmount = forecast.JanAmount + forecast.FebAmount + forecast.MarAmount + forecast.AprAmount + forecast.MayAmount +
                   forecast.JunAmount + forecast.JulAmount + forecast.AugAmount + forecast.SepAmount + forecast.OctAmount + forecast.NovAmount + forecast.DecAmount;
                   forecast.ResourcePerCost = GetResourcePerCost(item);
                   forecastTask.Add(forecast);
                    continue;
               }
               return forecastTask;
            }
            if (reportingperiod == Constants.Strings.ReportingPeriods.December)
            {
               foreach (var item in allprojectforecast)
               {
                   var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(item);

                   forecast.JanAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 1);
                   forecast.FebAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 2);
                   forecast.MarAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 3);
                   forecast.AprAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 4);
                   forecast.MayAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 5);
                   forecast.JunAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 6);
                   forecast.JulAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 7);
                   forecast.AugAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 8);
                   forecast.SepAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 9);
                   forecast.OctAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 10);
                   forecast.NovAmount = GetTotalActualReconciled(allprojectforecast, item.ForecastTaskId, 11);
                   forecast.DecAmount = item.DecForecastAmount??0;
                   forecast.TotalAmount = forecast.JanAmount + forecast.FebAmount + forecast.MarAmount + forecast.AprAmount + forecast.MayAmount +
                   forecast.JunAmount + forecast.JulAmount + forecast.AugAmount + forecast.SepAmount + forecast.OctAmount + forecast.NovAmount + forecast.DecAmount;
                   forecast.ResourcePerCost = GetResourcePerCost(item);
                   forecastTask.Add(forecast);
                    continue;
               }
               return forecastTask;
            }

            return null;
        }

        public decimal? CalculateUtilization(decimal? oldutility, decimal? oldforecast, decimal? newforecast)
        {
            if (oldforecast==newforecast)
            {
                return oldutility;
            }
            var difference = newforecast- oldforecast;
            var newutility = difference+ oldutility;

            return newutility;
        }
        public decimal? CalculateUtilizationNewForecast(decimal? oldutility, decimal? newforecast)
        {

            var newutility =  oldutility + newforecast;

            return newutility;
        }

         public decimal? CalculateAmount(decimal? days, decimal? rate)
        {
            if (days == 0 || rate == 0)
            {
               return 0;
            }
            var amount = days * rate;
            return amount;
        }


        AppUser GetSecureUser()
        {
            //var id = HttpContext.User.Claims.First().Value;
            var id = HttpContext.User.Claims.Single(c=>c.Type=="id").Value;
            return _appDbContext.Users.SingleOrDefault(u => u.Id == id);
        }


        Resource Getresource(string companyId, string resourceId)
        {
            var resourceDb = _appDbContext.Resources.Include(r => r.CompanyRateCard).SingleOrDefault(r => (r.CompanyId == companyId)&& (r.ResourceId == resourceId));
            return resourceDb;
        }
        Project Getproject(string companyId, string projectId)
        {
            var projectDb = _appDbContext.Projects.SingleOrDefault(r => (r.CompanyId == companyId)&& (r.ProjectId == projectId));
            return projectDb;
        }

        Company GetSecureUserCompany()
        {

            var id = HttpContext.User.Claims.Single(c => c.Type == "id").Value;
            var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;

            return _appDbContext.Companies.SingleOrDefault(c => c.CompanyId == comp);
        }


        [HttpGet("{companyId}/{projectId}")]
        public async Task<IEnumerable<ForecastTaskViewModel>> GetProjectForecastTasks(string companyId, string projectId)
        {
            var allProjectForecastTasks = await _appDbContext.ForecastTasks
                                         .Where(f => (f.CompanyId == companyId)
                                         && (f.ProjectId == projectId)).ToListAsync();

            return allProjectForecastTasks.Select(Mapper.Map<ForecastTask, ForecastTaskViewModel>);
        }

        ForecastTask GetforecastTask(string companyId, string forecastTaskId)
        {
            var forecastTaskDb = _appDbContext.ForecastTasks.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.ForecastTaskId == forecastTaskId));
            return forecastTaskDb;
        }

        public decimal NewResourceRate(decimal duration, decimal rate)
        {
            if (duration == 0 || rate == 0)
            {
                return 0;
            }
            return rate;
        }





    }
}