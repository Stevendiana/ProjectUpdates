
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
    public class ForecastTasksController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ProjectCentreDbContext _appDbContext;
        private readonly IProjectService _projectService;
        private readonly IUserService _userService;
        private readonly IProjectForecastRepository _projectForecastRepository;
        private readonly IMapper _mapper;
        GetForecastAndActualMinAndMaxDates _summaries;
        int p;
        // string projectId;


        public ForecastTasksController(UserManager<AppUser> userManager, IUserService userService, IMapper mapper,ProjectCentreDbContext appDbContext, IProjectForecastRepository projectForecastRepository, IProjectService projectService )
        {
            _projectService = projectService;
            _userManager = userManager;
             _userService = userService;
            _mapper=mapper;
            _appDbContext = appDbContext ;
            _projectForecastRepository = projectForecastRepository ;
            p = _projectService.ConvertMonthWordsToNumbers(_userService.GetSecureUserCompanyReportingPeriod());


        }

        private static string CreateNewId(string Id)
        {
            GeneratePublicId generatePublicId = new GeneratePublicId();
            return generatePublicId.PartId(Id, 8);
        }

        public class EditForecastTaskData
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
            [Required]
            public string CostType { get; set; }
            [Required]
            public string CostCat { get; set; }
            public string ResourceId { get; set; }
            public string ResourceName { get; set; }
            public string VendorId { get; set; }
            public Supplier Supplier { get; set; }
            public Resource Resource { get; set; }
            public string OrderNumber { get; set; }
            [Required]
            public string CompanyId { get; set; }
            [Required]
            public string ProjectId { get; set; }

            [ValidStartAndEndDate("Year", "1" , "JanEndDate")]
            [DataType(DataType.Date)]
            public DateTime? JanStartDate { get; set; }
            [DataType(DataType.Date)]
            public DateTime? JanEndDate { get; set; }
            public decimal? ResourceRateJan { get; set; }
            public decimal? JanForecastPreciseDuration { get; set; }
            public decimal? JanForecastAmount { get; set; }

            [ValidStartAndEndDate("Year", "2" , "FebEndDate")]
            [DataType(DataType.Date)]
            public DateTime? FebStartDate { get; set; }
            [DataType(DataType.Date)]
            public DateTime? FebEndDate { get; set; }
            public decimal? ResourceRateFeb { get; set; }
            public decimal? FebForecastPreciseDuration { get; set; }
            public decimal? FebForecastAmount { get; set; }

            [ValidStartAndEndDate("Year", "3" , "MarEndDate")]
            [DataType(DataType.Date)]
            public DateTime? MarStartDate { get; set; }
            [DataType(DataType.Date)]
            public DateTime? MarEndDate { get; set; }
            public decimal? ResourceRateMar { get; set; }
            public decimal? MarForecastPreciseDuration { get; set; }
            public decimal? MarForecastAmount { get; set; }

            [ValidStartAndEndDate("Year", "4" , "AprEndDate")]
            [DataType(DataType.Date)]
            public DateTime? AprStartDate { get; set; }
            [DataType(DataType.Date)]
            public DateTime? AprEndDate { get; set; }
            public decimal? ResourceRateApr { get; set; }
            public decimal? AprForecastPreciseDuration { get; set; }
            public decimal? AprForecastAmount { get; set; }

            [ValidStartAndEndDate("Year", "5" , "MayEndDate")]
            [DataType(DataType.Date)]
            public DateTime? MayStartDate { get; set; }
            [DataType(DataType.Date)]
            public DateTime? MayEndDate { get; set; }
            public decimal? ResourceRateMay { get; set; }
            public decimal? MayForecastPreciseDuration { get; set; }
            public decimal? MayForecastAmount { get; set; }

            [ValidStartAndEndDate("Year", "6" , "JunEndDate")]
            [DataType(DataType.Date)]
            public DateTime? JunStartDate { get; set; }
            [DataType(DataType.Date)]
            public DateTime? JunEndDate { get; set; }
            public decimal? ResourceRateJun { get; set; }
            public decimal? JunForecastPreciseDuration { get; set; }
            public decimal? JunForecastAmount { get; set; }

            [ValidStartAndEndDate("Year", "7" , "JulEndDate")]
            [DataType(DataType.Date)]
            public DateTime? JulStartDate { get; set; }
            [DataType(DataType.Date)]
            public DateTime? JulEndDate { get; set; }
            public decimal? ResourceRateJul { get; set; }
            public decimal? JulForecastPreciseDuration { get; set; }
            public decimal? JulForecastAmount { get; set; }

            [ValidStartAndEndDate("Year", "8" , "AugEndDate")]
            [DataType(DataType.Date)]
            public DateTime? AugStartDate { get; set; }
            [DataType(DataType.Date)]
            public DateTime? AugEndDate { get; set; }
            public decimal? ResourceRateAug { get; set; }
            public decimal? AugForecastPreciseDuration { get; set; }
            public decimal? AugForecastAmount { get; set; }

            [ValidStartAndEndDate("Year", "9" , "SepEndDate")]
            [DataType(DataType.Date)]
            public DateTime? SepStartDate { get; set; }
            [DataType(DataType.Date)]
            public DateTime? SepEndDate { get; set; }
            public decimal? ResourceRateSep { get; set; }
            public decimal? SepForecastPreciseDuration { get; set; }
            public decimal? SepForecastAmount { get; set; }

            [ValidStartAndEndDate("Year", "10" , "OctEndDate")]
            [DataType(DataType.Date)]
            public DateTime? OctEndDate { get; set; }
            [DataType(DataType.Date)]
            public DateTime? OctStartDate { get; set; }
            public decimal? ResourceRateOct { get; set; }
            public decimal? OctForecastPreciseDuration { get; set; }
            public decimal? OctForecastAmount { get; set; }

            [ValidStartAndEndDate("Year", "11" , "NovEndDate")]
            [DataType(DataType.Date)]
            public DateTime? NovStartDate { get; set; }
            [DataType(DataType.Date)]
            public DateTime? NovEndDate { get; set; }
            public decimal? ResourceRateNov { get; set; }
            public decimal? NovForecastPreciseDuration { get; set; }
            public decimal? NovForecastAmount { get; set; }

            [ValidStartAndEndDate("Year", "12" , "DecEndDate")]
            [DataType(DataType.Date)]
            public DateTime? DecStartDate { get; set; }
            [DataType(DataType.Date)]
            public DateTime? DecEndDate { get; set; }
            public decimal? ResourceRateDec { get; set; }
            public decimal? DecForecastPreciseDuration { get; set; }
            public decimal? DecForecastAmount { get; set; }

            public string CostSubCategory { get; set; }
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

        }

        public class MinMaxDates
        {
            public DateTime? MinStartDate { get; set; }
            public DateTime? MaxEndDate { get; set; }
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

            public decimal? QoneForecastAmount { get; set; }
            public decimal? QtwoForecastAmount { get; set; }
            public decimal? QthreeForecastAmount { get; set; }
            public decimal? QfourForecastAmount { get; set; }

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


        [HttpGet]
        [Authorize]
        public IEnumerable<ForecastTask> Get()
        {
           return _appDbContext.ForecastTasks;
        }


        [Authorize]
        [HttpGet("{companyId}/{id}")]
        public ActionResult Get(string companyId, string id) {
            var forecastTaskDb = _appDbContext.ForecastTasks.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.ForecastTaskId == id));

            if(forecastTaskDb == null)
            return NotFound("Forecast not found");

            return Ok(forecastTaskDb);
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
        [HttpGet("pastyearsprojectspend/{companyId}/{projectId}/{reportingyear}")]
        public async Task<ActionResult> PastYearsForecast(string companyId, string projectId, string reportingyear)
        {

            var comp = _userService.GetSecureUserCompany();
            var userreportingperiod = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Financerepperiod).Value;
            var userreportingyear = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Financerepyear).Value;

            int? i = 0;
            string s = userreportingyear;
            i =int.Parse(s);
            i = Convert.ToInt32(s);

            if(companyId != comp  || reportingyear != userreportingyear){
                return BadRequest();
            }

            var projectDb = _appDbContext.Projects.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.ProjectId == projectId));
            if(projectDb == null){
                return BadRequest();
            }


            var allprojectforecasts = await _appDbContext.ForecastTasks.Where(f=>(f.ProjectId==projectDb.ProjectId) &&
                                     (f.CompanyId==projectDb.CompanyId)&& (f.Year<i)).Include(f=>f.Resource).Include(f=>f.Supplier)
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
            return Ok(forecastTask);

        }



        [Authorize]
        [HttpGet("futureyearsprojectforecast/{companyId}/{projectId}/{reportingyear}")]
        public async Task<ActionResult> FutureYearsForecast(string companyId, string projectId, string reportingyear)
        {

            var comp = _userService.GetSecureUserCompany();
            var userreportingperiod = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Financerepperiod).Value;
            var userreportingyear = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Financerepyear).Value;

            int? i = 0;
            string s = userreportingyear;
            i =int.Parse(s);
            i = Convert.ToInt32(s);

            if(companyId != comp  || reportingyear != userreportingyear){
                return BadRequest();
            }

            var projectDb = _appDbContext.Projects.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.ProjectId == projectId));
            if(projectDb == null){
                return BadRequest();
            }


            var allprojectforecasts = await _appDbContext.ForecastTasks.Where(f=>(f.ProjectId==projectDb.ProjectId) &&
                                     (f.CompanyId==projectDb.CompanyId)&& (f.Year>i))
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
            return Ok(forecastTask);

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
        public IActionResult GetCurrentYearOneForecast(string companyId, string projectId, string id, string reportingperiod, string reportingyear)
        {

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
        public Project UpdateProjectSummaries(Project project, GetForecastAndActualMinAndMaxDates _summaries)
        {
            // _summaries =_projectService.GetForecastAndActual(project.ProjectId, _userService.GetSecureUserCompany(), p);
            GetForecastAndActualMinAndMaxDates summaries = _projectService.GetSumForecastAndActual(_summaries);
            if (project!=null)
            {
                if (_summaries.Lifetimeforecast.Count()!=0)
                {
                    DateTime? minForecastDate = _summaries.Lifetimeforecast.Where(f=>f.TaskEarliestStartDate.HasValue).Min(f=>f.TaskEarliestStartDate);
                    DateTime? maxForecastDate = _summaries.Lifetimeforecast.Where(f=>f.TaskLatestndEDate.HasValue).Max(f=>f.TaskLatestndEDate);

                    project.ProjectStartDate = minForecastDate;
                    project.ProjectEndDate = maxForecastDate;

                }
                if (_summaries.PastyearActualsToCurrentFullYearActual.Count()!=0)
                {
                    DateTime? minActualDate = _summaries.PastyearActualsToCurrentFullYearActual?.Select(ra => ra.ActualDateFrom)?.Min();
                    DateTime? maxActualDate = _summaries.PastyearActualsToCurrentFullYearActual?.Select(ra => ra.ActualDateTo)?.Max();

                    project.ActualStartDate = minActualDate;
                    project.ActualStartDate = maxActualDate;

                }

                project.TotalActual = _summaries.SumpastyearActualsToCurrentFullYearActual;

                if (p==1)
                {
                    project.TotalLifeTimeForecast = summaries.Projectlifetimetotalforjanrec;
                }
                if (p==2)
                {
                    project.TotalLifeTimeForecast = summaries.Projectlifetimetotalforfebrec;

                } if (p==3)
                {
                    project.TotalLifeTimeForecast = summaries.Projectlifetimetotalformarrec;

                } if (p==4)
                {
                    project.TotalLifeTimeForecast = summaries.Projectlifetimetotalforaprrec;

                } if (p==5)
                {
                    project.TotalLifeTimeForecast = summaries.Projectlifetimetotalformayrec;

                } if (p==6)
                {
                    project.TotalLifeTimeForecast = summaries.Projectlifetimetotalforjunrec;

                } if (p==7)
                {
                    project.TotalLifeTimeForecast = summaries.Projectlifetimetotalforjulrec;

                } if (p==8)
                {
                    project.TotalLifeTimeForecast = summaries.Projectlifetimetotalforaugrec;

                } if (p==9)
                {
                    project.TotalLifeTimeForecast = summaries.Projectlifetimetotalforseprec;

                } if (p==10)
                {
                    project.TotalLifeTimeForecast = summaries.Projectlifetimetotalforoctrec;

                } if (p==11)
                {
                    project.TotalLifeTimeForecast = summaries.Projectlifetimetotalfornovrec;

                } if (p==12)
                {
                    project.TotalLifeTimeForecast = summaries.Projectlifetimetotalfordecrec;
                }
                if (project.ProjectBudgetTracker!=null)
                {
                    project.ProjectPlannedCompletion = ((
                    new DateTime(
                        Convert.ToInt32( _userService.GetSecureUserCompanyReportingYear()),
                        _projectService.ConvertMonthWordsToNumbers(_userService.GetSecureUserCompanyReportingPeriod()),
                        Convert.ToInt32(_userService.GetSecureUserCompanyReportingDay()))).Date-project.ProjectBudgetTracker.BudgetStartDate.Value).TotalDays
                        /(project.ProjectBudgetTracker.BudgetEndDate.Value-project.ProjectBudgetTracker.BudgetStartDate.Value).TotalDays;

                    project.ProjectActualCompletion = (project.TotalActual/project.TotalLifeTimeForecast);
                    project.TotalPlannedValue = (Convert.ToDecimal(project.ProjectPlannedCompletion) * project.ProjectBudgetTracker.TotalLifeTimeBudget);
                    project.ProjectEarnedValue = (project.ProjectActualCompletion * project.ProjectBudgetTracker.TotalLifeTimeBudget);
                    project.ProjectEstimateAtCompletion = (project.TotalActual + (project.ProjectBudgetTracker.TotalLifeTimeBudget - project.ProjectEarnedValue));
                    project.ProjectEstimateToComplete =((project.TotalActual + (project.ProjectBudgetTracker.TotalLifeTimeBudget - project.ProjectEarnedValue)) - project.ProjectEarnedValue);
                    project.ProjectVarianceAtComplete = (project.ProjectBudgetTracker.TotalLifeTimeBudget - project.ProjectEarnedValue);
                    project.ProjectSPI =(project.ProjectEarnedValue / project.TotalPlannedValue);
                    project.ProjectCPI =(project.ProjectEarnedValue / project.TotalActual);
                    project.ProjectEAC = (project.TotalActual + (project.ProjectBudgetTracker.TotalLifeTimeBudget - project.ProjectEarnedValue));

                }
                if (project.ProjectBudgetTracker==null)
                {
                    project.ProjectPlannedCompletion = 0;
                    project.TotalPlannedValue = 0;
                    project.ProjectEarnedValue = 0;
                    project.ProjectEstimateAtCompletion = project.TotalLifeTimeForecast;
                    project.ProjectEstimateToComplete = project.TotalLifeTimeForecast - project.TotalActual;
                    project.ProjectVarianceAtComplete = project.TotalLifeTimeForecast - project.TotalActual;
                    project.ProjectSPI =0;
                    project.ProjectCPI =0;
                    project.ProjectEAC = 0;

                }
                if (project.TotalActual==null|| project.TotalLifeTimeForecast==null)
                {
                    project.ProjectActualCompletion = 0;
                }

                return project;

            }
            return null;
        }


        [Authorize]
        [HttpGet("currentprojectforecast/{companyId}/{projectId}/{reportingperiod}/{reportingyear}")]
        public IActionResult GetCurrentYearForecast(string companyId, string projectId, string reportingperiod, string reportingyear) {

            var comp = _userService.GetSecureUserCompany();
            var userreportingperiod = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Financerepperiod).Value;
            var userreportingyear = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Financerepyear).Value;


            if(companyId != comp  || reportingperiod != userreportingperiod || reportingyear != userreportingyear){
                return BadRequest();
            }

            var allprojectforecast = GetForecast( companyId, projectId, userreportingyear, false);

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
               return Ok(forecastTask);
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
               return Ok(forecastTask);
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
               return Ok(forecastTask);
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
               return Ok(forecastTask);
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
               return Ok(forecastTask);
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
               return Ok(forecastTask);
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
               return Ok(forecastTask);
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
               return Ok(forecastTask);
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
               return Ok(forecastTask);
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
               return Ok(forecastTask);
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
               return Ok(forecastTask);
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
               return Ok(forecastTask);
            }

            return BadRequest();
        }





        [HttpPost("forecasttask/{companyId}/{reportingperiod}")]
        [Authorize]
        // [Authorize(Policy = "Admin_Group, Portfolio_Group, Finance_Group")]
        public ActionResult EditForecast([FromBody] EditForecastTaskData forecasttaskData, string companyId, string reportingperiod)
        {

            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();
            var systemreportingperiod = HttpContext.User.Claims.Single(c => c.Type == "financerepperiod").Value;
            var systemreportingyear = HttpContext.User.Claims.Single(c => c.Type == "financerepyear").Value;

            int? y = 0;
            string s = systemreportingyear;
            y =int.Parse(s);
            y = Convert.ToInt32(s);

            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (roleGroup != "Admin_Group" ||  roleGroup != "Portfolio_Group" || roleGroup != "Finance_Group")
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (reportingperiod != systemreportingperiod || companyId != comp )
            {
              return BadRequest();
            }

            // var oldforecasttask = GetforecastTask(forecasttaskData.CompanyId, forecasttaskData.ForecastTaskId);
            var oldforecasttask = GetOneForecast(forecasttaskData.CompanyId, forecasttaskData.ProjectId, forecasttaskData.ForecastTaskId, systemreportingyear, false).Result;
            var resource = Getresource(forecasttaskData.CompanyId, forecasttaskData.ResourceId);
            var project = Getproject(forecasttaskData.CompanyId, forecasttaskData.ProjectId);

            oldforecasttask.CostType = oldforecasttask.CostType ?? forecasttaskData.CostType;
            if (oldforecasttask == null)
            {
                return BadRequest();
            }

            if (forecasttaskData.ResourceId == null || forecasttaskData.VendorId == null)
            {
                return BadRequest();
            }

            var forecasttask = _mapper.Map<EditForecastTaskData, ForecastTask>(forecasttaskData);


            if (reportingperiod==Constants.Strings.ReportingPeriods.January)
            {
                forecasttask.JanEndDate = forecasttaskData.JanEndDate ?? forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttaskData.JanStartDate ?? forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = resource.CompanyRateCard.DailyRate;
                forecasttask.JanForecastPreciseDuration = forecasttaskData.JanForecastPreciseDuration ?? forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttaskData.FebEndDate ?? forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttaskData.FebStartDate ?? forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = resource.CompanyRateCard.DailyRate;
                forecasttask.FebForecastPreciseDuration = forecasttaskData.FebForecastPreciseDuration ?? forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttaskData.MarEndDate ?? forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttaskData.MarStartDate ?? forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = resource.CompanyRateCard.DailyRate;
                forecasttask.MarForecastPreciseDuration = forecasttaskData.MarForecastPreciseDuration ?? forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttaskData.AprEndDate ?? forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttaskData.AprStartDate ?? forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = resource.CompanyRateCard.DailyRate;
                forecasttask.AprForecastPreciseDuration = forecasttaskData.AprForecastPreciseDuration ?? forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttaskData.MayEndDate ?? forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttaskData.MayStartDate ?? forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = resource.CompanyRateCard.DailyRate;
                forecasttask.MayForecastPreciseDuration = forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttaskData.JunEndDate ?? forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttaskData.JunStartDate ?? forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = resource.CompanyRateCard.DailyRate;
                forecasttask.JunForecastPreciseDuration = forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttaskData.JulEndDate ?? forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttaskData.JulStartDate ?? forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = resource.CompanyRateCard.DailyRate;
                forecasttask.JulForecastPreciseDuration = forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttaskData.AugEndDate ?? forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttaskData.AugStartDate ?? forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = resource.CompanyRateCard.DailyRate;
                forecasttask.AugForecastPreciseDuration = forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttaskData.SepEndDate ?? forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttaskData.SepStartDate ?? forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = resource.CompanyRateCard.DailyRate;
                forecasttask.SepForecastPreciseDuration = forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttaskData.JanForecastPreciseDuration ?? forecasttask.JanForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttaskData.FebForecastPreciseDuration ?? forecasttask.FebForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttaskData.MarForecastPreciseDuration ?? forecasttask.MarForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttaskData.AprForecastPreciseDuration ?? forecasttask.AprForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJan ?? forecasttask.MaterialUnitCostJan, forecasttaskData.MaterialQuantityJan ?? forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostFeb ?? forecasttask.MaterialUnitCostFeb, forecasttaskData.MaterialQuantityFeb ?? forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostMar ?? forecasttask.MaterialUnitCostMar, forecasttaskData.MaterialQuantityMar ?? forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostApr ?? forecasttask.MaterialUnitCostApr, forecasttaskData.MaterialQuantityApr ?? forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostMay ?? forecasttask.MaterialUnitCostMay, forecasttaskData.MaterialQuantityMay ?? forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJul ?? forecasttask.MaterialUnitCostJul, forecasttaskData.MaterialQuantityJul ?? forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJun ?? forecasttask.MaterialUnitCostJun, forecasttaskData.MaterialQuantityJun ?? forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostAug ?? forecasttask.MaterialUnitCostAug, forecasttaskData.MaterialQuantityAug ?? forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostSep ?? forecasttask.MaterialUnitCostSep, forecasttaskData.MaterialQuantitySep ?? forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }

            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.February)
            {

                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttaskData.FebEndDate ?? forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttaskData.FebStartDate ?? forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = resource.CompanyRateCard.DailyRate;
                forecasttask.FebForecastPreciseDuration = forecasttaskData.FebForecastPreciseDuration ?? forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttaskData.MarEndDate ?? forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttaskData.MarStartDate ?? forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = resource.CompanyRateCard.DailyRate;
                forecasttask.MarForecastPreciseDuration = forecasttaskData.MarForecastPreciseDuration ?? forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttaskData.AprEndDate ?? forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttaskData.AprStartDate ?? forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = resource.CompanyRateCard.DailyRate;
                forecasttask.AprForecastPreciseDuration = forecasttaskData.AprForecastPreciseDuration ?? forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttaskData.MayEndDate ?? forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttaskData.MayStartDate ?? forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = resource.CompanyRateCard.DailyRate;
                forecasttask.MayForecastPreciseDuration = forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttaskData.JunEndDate ?? forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttaskData.JunStartDate ?? forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = resource.CompanyRateCard.DailyRate;
                forecasttask.JunForecastPreciseDuration = forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttaskData.JulEndDate ?? forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttaskData.JulStartDate ?? forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = resource.CompanyRateCard.DailyRate;
                forecasttask.JulForecastPreciseDuration = forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttaskData.AugEndDate ?? forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttaskData.AugStartDate ?? forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = resource.CompanyRateCard.DailyRate;
                forecasttask.AugForecastPreciseDuration = forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttaskData.SepEndDate ?? forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttaskData.SepStartDate ?? forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = resource.CompanyRateCard.DailyRate;
                forecasttask.SepForecastPreciseDuration = forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttaskData.FebForecastPreciseDuration ?? forecasttask.FebForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttaskData.MarForecastPreciseDuration ?? forecasttask.MarForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttaskData.AprForecastPreciseDuration ?? forecasttask.AprForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostFeb ?? forecasttask.MaterialUnitCostFeb, forecasttaskData.MaterialQuantityFeb ?? forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostMar ?? forecasttask.MaterialUnitCostMar, forecasttaskData.MaterialQuantityMar ?? forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostApr ?? forecasttask.MaterialUnitCostApr, forecasttaskData.MaterialQuantityApr ?? forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostMay ?? forecasttask.MaterialUnitCostMay, forecasttaskData.MaterialQuantityMay ?? forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJul ?? forecasttask.MaterialUnitCostJul, forecasttaskData.MaterialQuantityJul ?? forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJun ?? forecasttask.MaterialUnitCostJun, forecasttaskData.MaterialQuantityJun ?? forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostAug ?? forecasttask.MaterialUnitCostAug, forecasttaskData.MaterialQuantityAug ?? forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostSep ?? forecasttask.MaterialUnitCostSep, forecasttaskData.MaterialQuantitySep ?? forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }

            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.March)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttaskData.MarEndDate ?? forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttaskData.MarStartDate ?? forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = resource.CompanyRateCard.DailyRate;
                forecasttask.MarForecastPreciseDuration = forecasttaskData.MarForecastPreciseDuration ?? forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttaskData.AprEndDate ?? forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttaskData.AprStartDate ?? forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = resource.CompanyRateCard.DailyRate;
                forecasttask.AprForecastPreciseDuration = forecasttaskData.AprForecastPreciseDuration ?? forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttaskData.MayEndDate ?? forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttaskData.MayStartDate ?? forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = resource.CompanyRateCard.DailyRate;
                forecasttask.MayForecastPreciseDuration = forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttaskData.JunEndDate ?? forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttaskData.JunStartDate ?? forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = resource.CompanyRateCard.DailyRate;
                forecasttask.JunForecastPreciseDuration = forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttaskData.JulEndDate ?? forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttaskData.JulStartDate ?? forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = resource.CompanyRateCard.DailyRate;
                forecasttask.JulForecastPreciseDuration = forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttaskData.AugEndDate ?? forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttaskData.AugStartDate ?? forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = resource.CompanyRateCard.DailyRate;
                forecasttask.AugForecastPreciseDuration = forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttaskData.SepEndDate ?? forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttaskData.SepStartDate ?? forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = resource.CompanyRateCard.DailyRate;
                forecasttask.SepForecastPreciseDuration = forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttaskData.MarForecastPreciseDuration ?? forecasttask.MarForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttaskData.AprForecastPreciseDuration ?? forecasttask.AprForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostMar ?? forecasttask.MaterialUnitCostMar, forecasttaskData.MaterialQuantityMar ?? forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostApr ?? forecasttask.MaterialUnitCostApr, forecasttaskData.MaterialQuantityApr ?? forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostMay ?? forecasttask.MaterialUnitCostMay, forecasttaskData.MaterialQuantityMay ?? forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJul ?? forecasttask.MaterialUnitCostJul, forecasttaskData.MaterialQuantityJul ?? forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJun ?? forecasttask.MaterialUnitCostJun, forecasttaskData.MaterialQuantityJun ?? forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostAug ?? forecasttask.MaterialUnitCostAug, forecasttaskData.MaterialQuantityAug ?? forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostSep ?? forecasttask.MaterialUnitCostSep, forecasttaskData.MaterialQuantitySep ?? forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }

            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.April)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = forecasttask.ResourceRateMar;
                forecasttask.MarForecastPreciseDuration = forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttaskData.AprEndDate ?? forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttaskData.AprStartDate ?? forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = resource.CompanyRateCard.DailyRate;
                forecasttask.AprForecastPreciseDuration = forecasttaskData.AprForecastPreciseDuration ?? forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttaskData.MayEndDate ?? forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttaskData.MayStartDate ?? forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = resource.CompanyRateCard.DailyRate;
                forecasttask.MayForecastPreciseDuration = forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttaskData.JunEndDate ?? forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttaskData.JunStartDate ?? forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = resource.CompanyRateCard.DailyRate;
                forecasttask.JunForecastPreciseDuration = forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttaskData.JulEndDate ?? forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttaskData.JulStartDate ?? forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = resource.CompanyRateCard.DailyRate;
                forecasttask.JulForecastPreciseDuration = forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttaskData.AugEndDate ?? forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttaskData.AugStartDate ?? forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = resource.CompanyRateCard.DailyRate;
                forecasttask.AugForecastPreciseDuration = forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttaskData.SepEndDate ?? forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttaskData.SepStartDate ?? forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = resource.CompanyRateCard.DailyRate;
                forecasttask.SepForecastPreciseDuration = forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MarForecastPreciseDuration, forecasttask.ResourceRateMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttaskData.AprForecastPreciseDuration ?? forecasttask.AprForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMar, forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostApr ?? forecasttask.MaterialUnitCostApr, forecasttaskData.MaterialQuantityApr ?? forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostMay ?? forecasttask.MaterialUnitCostMay, forecasttaskData.MaterialQuantityMay ?? forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJul ?? forecasttask.MaterialUnitCostJul, forecasttaskData.MaterialQuantityJul ?? forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJun ?? forecasttask.MaterialUnitCostJun, forecasttaskData.MaterialQuantityJun ?? forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostAug ?? forecasttask.MaterialUnitCostAug, forecasttaskData.MaterialQuantityAug ?? forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostSep ?? forecasttask.MaterialUnitCostSep, forecasttaskData.MaterialQuantitySep ?? forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }
            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.May)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = forecasttask.ResourceRateMar;
                forecasttask.MarForecastPreciseDuration = forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = forecasttask.ResourceRateApr;
                forecasttask.AprForecastPreciseDuration = forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttaskData.MayEndDate ?? forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttaskData.MayStartDate ?? forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = resource.CompanyRateCard.DailyRate;
                forecasttask.MayForecastPreciseDuration = forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttaskData.JunEndDate ?? forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttaskData.JunStartDate ?? forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = resource.CompanyRateCard.DailyRate;
                forecasttask.JunForecastPreciseDuration = forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttaskData.JulEndDate ?? forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttaskData.JulStartDate ?? forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = resource.CompanyRateCard.DailyRate;
                forecasttask.JulForecastPreciseDuration = forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttaskData.AugEndDate ?? forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttaskData.AugStartDate ?? forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = resource.CompanyRateCard.DailyRate;
                forecasttask.AugForecastPreciseDuration = forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttaskData.SepEndDate ?? forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttaskData.SepStartDate ?? forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = resource.CompanyRateCard.DailyRate;
                forecasttask.SepForecastPreciseDuration = forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MarForecastPreciseDuration, forecasttask.ResourceRateMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.AprForecastPreciseDuration, forecasttask.ResourceRateApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMar, forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostApr, forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostMay ?? forecasttask.MaterialUnitCostMay, forecasttaskData.MaterialQuantityMay ?? forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJul ?? forecasttask.MaterialUnitCostJul, forecasttaskData.MaterialQuantityJul ?? forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJun ?? forecasttask.MaterialUnitCostJun, forecasttaskData.MaterialQuantityJun ?? forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostAug ?? forecasttask.MaterialUnitCostAug, forecasttaskData.MaterialQuantityAug ?? forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostSep ?? forecasttask.MaterialUnitCostSep, forecasttaskData.MaterialQuantitySep ?? forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }

            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.June)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = forecasttask.ResourceRateMar;
                forecasttask.MarForecastPreciseDuration = forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = forecasttask.ResourceRateApr;
                forecasttask.AprForecastPreciseDuration = forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = forecasttask.ResourceRateMay;
                forecasttask.MayForecastPreciseDuration = forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttaskData.JunEndDate ?? forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttaskData.JunStartDate ?? forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = resource.CompanyRateCard.DailyRate;
                forecasttask.JunForecastPreciseDuration = forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttaskData.JulEndDate ?? forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttaskData.JulStartDate ?? forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = resource.CompanyRateCard.DailyRate;
                forecasttask.JulForecastPreciseDuration = forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttaskData.AugEndDate ?? forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttaskData.AugStartDate ?? forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = resource.CompanyRateCard.DailyRate;
                forecasttask.AugForecastPreciseDuration = forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttaskData.SepEndDate ?? forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttaskData.SepStartDate ?? forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = resource.CompanyRateCard.DailyRate;
                forecasttask.SepForecastPreciseDuration = forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MarForecastPreciseDuration, forecasttask.ResourceRateMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.AprForecastPreciseDuration, forecasttask.ResourceRateApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MayForecastPreciseDuration, forecasttask.ResourceRateMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMar, forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostApr, forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMay, forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJul ?? forecasttask.MaterialUnitCostJul, forecasttaskData.MaterialQuantityJul ?? forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJun ?? forecasttask.MaterialUnitCostJun, forecasttaskData.MaterialQuantityJun ?? forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostAug ?? forecasttask.MaterialUnitCostAug, forecasttaskData.MaterialQuantityAug ?? forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostSep ?? forecasttask.MaterialUnitCostSep, forecasttaskData.MaterialQuantitySep ?? forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }
            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.July)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = forecasttask.ResourceRateMar;
                forecasttask.MarForecastPreciseDuration = forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = forecasttask.ResourceRateApr;
                forecasttask.AprForecastPreciseDuration = forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = forecasttask.ResourceRateMay;
                forecasttask.MayForecastPreciseDuration = forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = forecasttask.ResourceRateJun;
                forecasttask.JunForecastPreciseDuration = forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttaskData.JulEndDate ?? forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttaskData.JulStartDate ?? forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = resource.CompanyRateCard.DailyRate;
                forecasttask.JulForecastPreciseDuration = forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttaskData.AugEndDate ?? forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttaskData.AugStartDate ?? forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = resource.CompanyRateCard.DailyRate;
                forecasttask.AugForecastPreciseDuration = forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttaskData.SepEndDate ?? forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttaskData.SepStartDate ?? forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = resource.CompanyRateCard.DailyRate;
                forecasttask.SepForecastPreciseDuration = forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MarForecastPreciseDuration, forecasttask.ResourceRateMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.AprForecastPreciseDuration, forecasttask.ResourceRateApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MayForecastPreciseDuration, forecasttask.ResourceRateMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.JunForecastPreciseDuration, forecasttask.ResourceRateJun);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMar, forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostApr, forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMay, forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJul, forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJun ?? forecasttask.MaterialUnitCostJun, forecasttaskData.MaterialQuantityJun ?? forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostAug ?? forecasttask.MaterialUnitCostAug, forecasttaskData.MaterialQuantityAug ?? forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostSep ?? forecasttask.MaterialUnitCostSep, forecasttaskData.MaterialQuantitySep ?? forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }
            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.August)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = forecasttask.ResourceRateMar;
                forecasttask.MarForecastPreciseDuration = forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = forecasttask.ResourceRateApr;
                forecasttask.AprForecastPreciseDuration = forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = forecasttask.ResourceRateMay;
                forecasttask.MayForecastPreciseDuration = forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = forecasttask.ResourceRateJun;
                forecasttask.JunForecastPreciseDuration = forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = forecasttask.ResourceRateJul;
                forecasttask.JulForecastPreciseDuration = forecasttask.JulForecastPreciseDuration;

               forecasttask.AugEndDate = forecasttaskData.AugEndDate ?? forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttaskData.AugStartDate ?? forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = resource.CompanyRateCard.DailyRate;
                forecasttask.AugForecastPreciseDuration = forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttaskData.SepEndDate ?? forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttaskData.SepStartDate ?? forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = resource.CompanyRateCard.DailyRate;
                forecasttask.SepForecastPreciseDuration = forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MarForecastPreciseDuration, forecasttask.ResourceRateMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.AprForecastPreciseDuration, forecasttask.ResourceRateApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MayForecastPreciseDuration, forecasttask.ResourceRateMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.JunForecastPreciseDuration, forecasttask.ResourceRateJun);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.JulForecastPreciseDuration, forecasttask.ResourceRateJul);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMar, forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostApr, forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMay, forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJul, forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJun, forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostAug ?? forecasttask.MaterialUnitCostAug, forecasttaskData.MaterialQuantityAug ?? forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostSep ?? forecasttask.MaterialUnitCostSep, forecasttaskData.MaterialQuantitySep ?? forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }

            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.September)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = forecasttask.ResourceRateMar;
                forecasttask.MarForecastPreciseDuration = forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = forecasttask.ResourceRateApr;
                forecasttask.AprForecastPreciseDuration = forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = forecasttask.ResourceRateMay;
                forecasttask.MayForecastPreciseDuration = forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = forecasttask.ResourceRateJun;
                forecasttask.JunForecastPreciseDuration = forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = forecasttask.ResourceRateJul;
                forecasttask.JulForecastPreciseDuration = forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = forecasttask.ResourceRateAug;
                forecasttask.AugForecastPreciseDuration = forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttaskData.SepEndDate ?? forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttaskData.SepStartDate ?? forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = resource.CompanyRateCard.DailyRate;
                forecasttask.SepForecastPreciseDuration = forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MarForecastPreciseDuration, forecasttask.ResourceRateMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.AprForecastPreciseDuration, forecasttask.ResourceRateApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MayForecastPreciseDuration, forecasttask.ResourceRateMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.JunForecastPreciseDuration, forecasttask.ResourceRateJun);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.JulForecastPreciseDuration, forecasttask.ResourceRateJul);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttask.AugForecastPreciseDuration, forecasttask.ResourceRateAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMar, forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostApr, forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMay, forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJul, forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJun, forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostAug, forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostSep ?? forecasttask.MaterialUnitCostSep, forecasttaskData.MaterialQuantitySep ?? forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }


            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.October)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = forecasttask.ResourceRateMar;
                forecasttask.MarForecastPreciseDuration = forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = forecasttask.ResourceRateApr;
                forecasttask.AprForecastPreciseDuration = forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = forecasttask.ResourceRateMay;
                forecasttask.MayForecastPreciseDuration = forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = forecasttask.ResourceRateJun;
                forecasttask.JunForecastPreciseDuration = forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = forecasttask.ResourceRateJul;
                forecasttask.JulForecastPreciseDuration = forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = forecasttask.ResourceRateAug;
                forecasttask.AugForecastPreciseDuration = forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = forecasttask.ResourceRateSep;
                forecasttask.SepForecastPreciseDuration = forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MarForecastPreciseDuration, forecasttask.ResourceRateMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.AprForecastPreciseDuration, forecasttask.ResourceRateApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MayForecastPreciseDuration, forecasttask.ResourceRateMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.JunForecastPreciseDuration, forecasttask.ResourceRateJun);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.JulForecastPreciseDuration, forecasttask.ResourceRateJul);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttask.AugForecastPreciseDuration, forecasttask.ResourceRateAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttask.SepForecastPreciseDuration, forecasttask.ResourceRateSep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMar, forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostApr, forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMay, forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJul, forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJun, forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostAug, forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostSep, forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }

            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.November)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = forecasttask.ResourceRateMar;
                forecasttask.MarForecastPreciseDuration = forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = forecasttask.ResourceRateApr;
                forecasttask.AprForecastPreciseDuration = forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = forecasttask.ResourceRateMay;
                forecasttask.MayForecastPreciseDuration = forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = forecasttask.ResourceRateJun;
                forecasttask.JunForecastPreciseDuration = forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = forecasttask.ResourceRateJul;
                forecasttask.JulForecastPreciseDuration = forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = forecasttask.ResourceRateAug;
                forecasttask.AugForecastPreciseDuration = forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = forecasttask.ResourceRateSep;
                forecasttask.SepForecastPreciseDuration = forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = forecasttask.ResourceRateOct;
                forecasttask.OctForecastPreciseDuration = forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MarForecastPreciseDuration, forecasttask.ResourceRateMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.AprForecastPreciseDuration, forecasttask.ResourceRateApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MayForecastPreciseDuration, forecasttask.ResourceRateMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.JunForecastPreciseDuration, forecasttask.ResourceRateJun);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.JulForecastPreciseDuration, forecasttask.ResourceRateJul);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttask.AugForecastPreciseDuration, forecasttask.ResourceRateAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttask.SepForecastPreciseDuration, forecasttask.ResourceRateSep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttask.OctForecastPreciseDuration, forecasttask.ResourceRateOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMar, forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostApr, forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMay, forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJul, forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJun, forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostAug, forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostSep, forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostOct, forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }

            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.December)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = forecasttask.ResourceRateMar;
                forecasttask.MarForecastPreciseDuration = forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = forecasttask.ResourceRateApr;
                forecasttask.AprForecastPreciseDuration = forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = forecasttask.ResourceRateMay;
                forecasttask.MayForecastPreciseDuration = forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = forecasttask.ResourceRateJun;
                forecasttask.JunForecastPreciseDuration = forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = forecasttask.ResourceRateJul;
                forecasttask.JulForecastPreciseDuration = forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = forecasttask.ResourceRateAug;
                forecasttask.AugForecastPreciseDuration = forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = forecasttask.ResourceRateSep;
                forecasttask.SepForecastPreciseDuration = forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = forecasttask.ResourceRateOct;
                forecasttask.OctForecastPreciseDuration = forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = forecasttask.ResourceRateNov;
                forecasttask.NovForecastPreciseDuration = forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MarForecastPreciseDuration, forecasttask.ResourceRateMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.AprForecastPreciseDuration, forecasttask.ResourceRateApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MayForecastPreciseDuration, forecasttask.ResourceRateMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.JunForecastPreciseDuration, forecasttask.ResourceRateJun);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.JulForecastPreciseDuration, forecasttask.ResourceRateJul);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttask.AugForecastPreciseDuration, forecasttask.ResourceRateAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttask.SepForecastPreciseDuration, forecasttask.ResourceRateSep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttask.OctForecastPreciseDuration, forecasttask.ResourceRateOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttask.NovForecastPreciseDuration, forecasttask.ResourceRateNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMar, forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostApr, forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMay, forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJul, forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJun, forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostAug, forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostSep, forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostOct, forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostNov, forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }

            }

            var newtasktotal = (forecasttask.JanForecastAmount +
                    forecasttask.FebForecastAmount +
                    forecasttask.MarForecastAmount+
                    forecasttask.AprForecastAmount +
                    forecasttask.MayForecastAmount +
                    forecasttask.JulForecastAmount +
                    forecasttask.JunForecastAmount +
                    forecasttask.AugForecastAmount +
                    forecasttask.SepForecastAmount +
                    forecasttask.OctForecastAmount +
                    forecasttask.NovForecastAmount +
                    forecasttask.DecForecastAmount);

            var oldtasktotal =  ( oldforecasttask.JanForecastAmount +
                    oldforecasttask.FebForecastAmount +
                    oldforecasttask.MarForecastAmount +
                    oldforecasttask.AprForecastAmount +
                    oldforecasttask.MayForecastAmount +
                    oldforecasttask.JulForecastAmount +
                    oldforecasttask.JunForecastAmount +
                    oldforecasttask.AugForecastAmount +
                    oldforecasttask.SepForecastAmount +
                    oldforecasttask.OctForecastAmount +
                    oldforecasttask.NovForecastAmount +
                    oldforecasttask.DecForecastAmount );

            forecasttask.TotalForecastAmount = newtasktotal;

            // project.Yearminus5 = y-5;
            // project.Yearminus4 = y-4;
            // project.Yearminus3 = y-3;
            // project.Yearminus2 = y-2;
            // project.Yearminus1 = y-1;
            // project.CurrentYear = y;
            // project.Yearplus1 = y+1;
            // project.Yearplus2 = y+2;
            // project.Yearplus3 = y+3;
            // project.Yearplus4 = y+4;
            // project.Yearplus5 = y+5;




            forecasttask.TextTaskCostDescription = forecasttaskData.TextTaskCostDescription ?? forecasttask.TextTaskCostDescription;
            forecasttask.VendorId = forecasttaskData.VendorId ?? forecasttask.VendorId;
            forecasttask.Year = forecasttaskData.Year ?? forecasttask.Year;
            forecasttask.Month = forecasttaskData.Month ?? forecasttask.Month;
            forecasttask.ForecastPeriodType = forecasttaskData.ForecastPeriodType ?? forecasttask.ForecastPeriodType;

            forecasttask.BaselinePeriod = forecasttaskData.BaselinePeriod ?? forecasttask.BaselinePeriod;
            forecasttask.CostCat = forecasttaskData.CostCat ?? forecasttask.CostCat;
            forecasttask.CostSubCategory = forecasttaskData.CostSubCategory ?? forecasttask.CostSubCategory;

            forecasttask.Open = forecasttaskData.Open;
            forecasttask.Order = forecasttaskData.Order ?? forecasttask.Order;
            forecasttask.OrderNumber = forecasttaskData.OrderNumber ?? forecasttask.OrderNumber;
            forecasttask.Parent = forecasttaskData.Parent ?? forecasttask.Parent;
            forecasttask.Progress = forecasttaskData.Progress;
            forecasttask.ProjectStage = forecasttaskData.ProjectStage ?? forecasttask.ProjectStage;
            forecasttask.ProjectStageRefid = forecasttaskData.ProjectStageRefid ?? forecasttask.ProjectStageRefid;
            forecasttask.ResourceId = forecasttaskData.ResourceId ?? forecasttask.ResourceId;
            forecasttask.ResourceName = forecasttaskData.ResourceName ?? forecasttask.ResourceName;


            MinMaxDates dates =  FindEarliestActivityDay(
            forecasttask.JanForecastAmount,forecasttask.FebForecastAmount,forecasttask.MarForecastAmount,forecasttask.AprForecastAmount,forecasttask.MayForecastAmount,forecasttask.JunForecastAmount,forecasttask.JulForecastAmount,
            forecasttask.AugForecastAmount,forecasttask.SepForecastAmount,forecasttask.OctForecastAmount,forecasttask.NovForecastAmount,forecasttask.DecForecastAmount,forecasttask.JanEndDate,forecasttask.JanStartDate,
            forecasttask.FebEndDate,forecasttask.FebStartDate,forecasttask.MarEndDate,forecasttask.MarStartDate,forecasttask.AprEndDate,forecasttask.AprStartDate,forecasttask.MayEndDate,forecasttask.MayStartDate,
            forecasttask.JunEndDate,forecasttask.JunStartDate,forecasttask.JulEndDate,forecasttask.JulStartDate,forecasttask.AugEndDate,forecasttask.AugStartDate,forecasttask.SepEndDate,forecasttask.SepStartDate,
            forecasttask.OctEndDate,forecasttask.OctStartDate,forecasttask.NovEndDate,forecasttask.NovStartDate,forecasttask.DecEndDate,forecasttask.DecStartDate
            );

            forecasttask.TaskEarliestStartDate = dates.MinStartDate;
            forecasttask.TaskLatestndEDate= dates.MaxEndDate;

            forecasttask.JanActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 1);
            forecasttask.FebActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 2);;
            forecasttask.MarActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 3);
            forecasttask.AprActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 4);
            forecasttask.MayActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 5);
            forecasttask.JunActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 6);
            forecasttask.JulActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 7);
            forecasttask.AugActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 8);
            forecasttask.SepActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 9);
            forecasttask.OctActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 10);
            forecasttask.NovActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 11);
            forecasttask.DecActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 12);

            forecasttask.ForecastTaskId = oldforecasttask.ForecastTaskId;

            resource.JanResourceUtilizationInDays = CalculateUtilization(resource.JanResourceUtilizationInDays, forecasttask.JanForecastPreciseDuration, forecasttaskData.JanForecastPreciseDuration);
            resource.FebResourceUtilizationInDays = CalculateUtilization(resource.FebResourceUtilizationInDays, forecasttask.FebForecastPreciseDuration, forecasttaskData.FebForecastPreciseDuration);
            resource.MarResourceUtilizationInDays = CalculateUtilization(resource.MarResourceUtilizationInDays, forecasttask.MarForecastPreciseDuration, forecasttaskData.MarForecastPreciseDuration);
            resource.AprResourceUtilizationInDays = CalculateUtilization(resource.AprResourceUtilizationInDays, forecasttask.AprForecastPreciseDuration, forecasttaskData.AprForecastPreciseDuration);
            resource.MayResourceUtilizationInDays = CalculateUtilization(resource.MayResourceUtilizationInDays, forecasttask.MayForecastPreciseDuration, forecasttaskData.MayForecastPreciseDuration);
            resource.JunResourceUtilizationInDays = CalculateUtilization(resource.JunResourceUtilizationInDays, forecasttask.JunForecastPreciseDuration, forecasttaskData.JunForecastPreciseDuration);
            resource.JulResourceUtilizationInDays = CalculateUtilization(resource.JulResourceUtilizationInDays, forecasttask.JulForecastPreciseDuration, forecasttaskData.JulForecastPreciseDuration);
            resource.AugResourceUtilizationInDays = CalculateUtilization(resource.AugResourceUtilizationInDays, forecasttask.AugForecastPreciseDuration, forecasttaskData.AugForecastPreciseDuration);
            resource.SepResourceUtilizationInDays = CalculateUtilization(resource.SepResourceUtilizationInDays, forecasttask.SepForecastPreciseDuration, forecasttaskData.SepForecastPreciseDuration);
            resource.OctResourceUtilizationInDays = CalculateUtilization(resource.OctResourceUtilizationInDays, forecasttask.OctForecastPreciseDuration, forecasttaskData.OctForecastPreciseDuration);
            resource.NovResourceUtilizationInDays = CalculateUtilization(resource.NovResourceUtilizationInDays, forecasttask.NovForecastPreciseDuration, forecasttaskData.NovForecastPreciseDuration);
            resource.DecResourceUtilizationInDays = CalculateUtilization(resource.DecResourceUtilizationInDays, forecasttask.DecForecastPreciseDuration, forecasttaskData.DecForecastPreciseDuration);

            resource.TotalUtilizationInDays = resource.JanResourceUtilizationInDays + resource.FebResourceUtilizationInDays + resource.MarResourceUtilizationInDays + resource.AprResourceUtilizationInDays
                     + resource.MayResourceUtilizationInDays + resource.JunResourceUtilizationInDays +  resource.JulResourceUtilizationInDays + resource.AugResourceUtilizationInDays
                     + resource.SepResourceUtilizationInDays + resource.OctResourceUtilizationInDays +  resource.NovResourceUtilizationInDays + resource.DecResourceUtilizationInDays;




             _appDbContext.ForecastTasks.Update(forecasttask);
           _summaries =_projectService.GetForecastAndActual(project.ProjectId, _userService.GetSecureUserCompany(), p);
           _summaries.Lifetimeforecast.Add(forecasttask);

           project = UpdateProjectSummaries(project, _summaries);
           _appDbContext.Projects.Update(project);

           _appDbContext.SaveChanges();
            forecasttask = GetforecastTask(comp, oldforecasttask.ForecastTaskId);

            var result = _mapper.Map<ForecastTask, EditForecastTaskData>(forecasttask);
            return Ok(result);
        }

        [HttpPost("editforecasttask/{companyId}/{reportingperiod}")]
        [Authorize]
        // [Authorize(Policy = "Admin_Group, Portfolio_Group, Finance_Group")]
        public ActionResult EditOneForecast([FromBody] ForecastTaskEAC forecasttaskData, string companyId, string reportingperiod)
        {

            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();
            var systemreportingperiod = HttpContext.User.Claims.Single(c => c.Type == "financerepperiod").Value;

            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (roleGroup != "Admin_Group" ||  roleGroup != "Portfolio_Group" || roleGroup != "Finance_Group")
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (reportingperiod != systemreportingperiod || companyId != comp )
            {
              return BadRequest();
            }

            var oldforecasttask = GetforecastTask(forecasttaskData.CompanyId, forecasttaskData.ForecastTaskId);
            var resource = Getresource(forecasttaskData.CompanyId, forecasttaskData.ResourceId);
            var project = Getproject(forecasttaskData.CompanyId, forecasttaskData.ProjectId);

            oldforecasttask.CostType = oldforecasttask.CostType ?? forecasttaskData.CostType;
            if (oldforecasttask == null)
            {
                return BadRequest();
            }

            if (resource == null || forecasttaskData.VendorId == null)
            {
                return BadRequest();
            }

            var forecasttask = _mapper.Map<ForecastTaskEAC, ForecastTask>(forecasttaskData);


            if (reportingperiod==Constants.Strings.ReportingPeriods.January)
            {
                forecasttask.JanEndDate = forecasttaskData.JanEndDate ?? forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttaskData.JanStartDate ?? forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = resource.CompanyRateCard.DailyRate;
                forecasttask.JanForecastPreciseDuration = forecasttaskData.JanForecastPreciseDuration ?? forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttaskData.FebEndDate ?? forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttaskData.FebStartDate ?? forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = resource.CompanyRateCard.DailyRate;
                forecasttask.FebForecastPreciseDuration = forecasttaskData.FebForecastPreciseDuration ?? forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttaskData.MarEndDate ?? forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttaskData.MarStartDate ?? forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = resource.CompanyRateCard.DailyRate;
                forecasttask.MarForecastPreciseDuration = forecasttaskData.MarForecastPreciseDuration ?? forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttaskData.AprEndDate ?? forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttaskData.AprStartDate ?? forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = resource.CompanyRateCard.DailyRate;
                forecasttask.AprForecastPreciseDuration = forecasttaskData.AprForecastPreciseDuration ?? forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttaskData.MayEndDate ?? forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttaskData.MayStartDate ?? forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = resource.CompanyRateCard.DailyRate;
                forecasttask.MayForecastPreciseDuration = forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttaskData.JunEndDate ?? forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttaskData.JunStartDate ?? forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = resource.CompanyRateCard.DailyRate;
                forecasttask.JunForecastPreciseDuration = forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttaskData.JulEndDate ?? forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttaskData.JulStartDate ?? forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = resource.CompanyRateCard.DailyRate;
                forecasttask.JulForecastPreciseDuration = forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttaskData.AugEndDate ?? forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttaskData.AugStartDate ?? forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = resource.CompanyRateCard.DailyRate;
                forecasttask.AugForecastPreciseDuration = forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttaskData.SepEndDate ?? forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttaskData.SepStartDate ?? forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = resource.CompanyRateCard.DailyRate;
                forecasttask.SepForecastPreciseDuration = forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttaskData.JanForecastPreciseDuration ?? forecasttask.JanForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttaskData.FebForecastPreciseDuration ?? forecasttask.FebForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttaskData.MarForecastPreciseDuration ?? forecasttask.MarForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttaskData.AprForecastPreciseDuration ?? forecasttask.AprForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJan ?? forecasttask.MaterialUnitCostJan, forecasttaskData.MaterialQuantityJan ?? forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostFeb ?? forecasttask.MaterialUnitCostFeb, forecasttaskData.MaterialQuantityFeb ?? forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostMar ?? forecasttask.MaterialUnitCostMar, forecasttaskData.MaterialQuantityMar ?? forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostApr ?? forecasttask.MaterialUnitCostApr, forecasttaskData.MaterialQuantityApr ?? forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostMay ?? forecasttask.MaterialUnitCostMay, forecasttaskData.MaterialQuantityMay ?? forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJul ?? forecasttask.MaterialUnitCostJul, forecasttaskData.MaterialQuantityJul ?? forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJun ?? forecasttask.MaterialUnitCostJun, forecasttaskData.MaterialQuantityJun ?? forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostAug ?? forecasttask.MaterialUnitCostAug, forecasttaskData.MaterialQuantityAug ?? forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostSep ?? forecasttask.MaterialUnitCostSep, forecasttaskData.MaterialQuantitySep ?? forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }

            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.February)
            {

                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttaskData.FebEndDate ?? forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttaskData.FebStartDate ?? forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = resource.CompanyRateCard.DailyRate;
                forecasttask.FebForecastPreciseDuration = forecasttaskData.FebForecastPreciseDuration ?? forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttaskData.MarEndDate ?? forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttaskData.MarStartDate ?? forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = resource.CompanyRateCard.DailyRate;
                forecasttask.MarForecastPreciseDuration = forecasttaskData.MarForecastPreciseDuration ?? forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttaskData.AprEndDate ?? forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttaskData.AprStartDate ?? forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = resource.CompanyRateCard.DailyRate;
                forecasttask.AprForecastPreciseDuration = forecasttaskData.AprForecastPreciseDuration ?? forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttaskData.MayEndDate ?? forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttaskData.MayStartDate ?? forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = resource.CompanyRateCard.DailyRate;
                forecasttask.MayForecastPreciseDuration = forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttaskData.JunEndDate ?? forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttaskData.JunStartDate ?? forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = resource.CompanyRateCard.DailyRate;
                forecasttask.JunForecastPreciseDuration = forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttaskData.JulEndDate ?? forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttaskData.JulStartDate ?? forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = resource.CompanyRateCard.DailyRate;
                forecasttask.JulForecastPreciseDuration = forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttaskData.AugEndDate ?? forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttaskData.AugStartDate ?? forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = resource.CompanyRateCard.DailyRate;
                forecasttask.AugForecastPreciseDuration = forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttaskData.SepEndDate ?? forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttaskData.SepStartDate ?? forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = resource.CompanyRateCard.DailyRate;
                forecasttask.SepForecastPreciseDuration = forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttaskData.FebForecastPreciseDuration ?? forecasttask.FebForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttaskData.MarForecastPreciseDuration ?? forecasttask.MarForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttaskData.AprForecastPreciseDuration ?? forecasttask.AprForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostFeb ?? forecasttask.MaterialUnitCostFeb, forecasttaskData.MaterialQuantityFeb ?? forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostMar ?? forecasttask.MaterialUnitCostMar, forecasttaskData.MaterialQuantityMar ?? forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostApr ?? forecasttask.MaterialUnitCostApr, forecasttaskData.MaterialQuantityApr ?? forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostMay ?? forecasttask.MaterialUnitCostMay, forecasttaskData.MaterialQuantityMay ?? forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJul ?? forecasttask.MaterialUnitCostJul, forecasttaskData.MaterialQuantityJul ?? forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJun ?? forecasttask.MaterialUnitCostJun, forecasttaskData.MaterialQuantityJun ?? forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostAug ?? forecasttask.MaterialUnitCostAug, forecasttaskData.MaterialQuantityAug ?? forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostSep ?? forecasttask.MaterialUnitCostSep, forecasttaskData.MaterialQuantitySep ?? forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }

            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.March)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttaskData.MarEndDate ?? forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttaskData.MarStartDate ?? forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = resource.CompanyRateCard.DailyRate;
                forecasttask.MarForecastPreciseDuration = forecasttaskData.MarForecastPreciseDuration ?? forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttaskData.AprEndDate ?? forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttaskData.AprStartDate ?? forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = resource.CompanyRateCard.DailyRate;
                forecasttask.AprForecastPreciseDuration = forecasttaskData.AprForecastPreciseDuration ?? forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttaskData.MayEndDate ?? forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttaskData.MayStartDate ?? forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = resource.CompanyRateCard.DailyRate;
                forecasttask.MayForecastPreciseDuration = forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttaskData.JunEndDate ?? forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttaskData.JunStartDate ?? forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = resource.CompanyRateCard.DailyRate;
                forecasttask.JunForecastPreciseDuration = forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttaskData.JulEndDate ?? forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttaskData.JulStartDate ?? forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = resource.CompanyRateCard.DailyRate;
                forecasttask.JulForecastPreciseDuration = forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttaskData.AugEndDate ?? forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttaskData.AugStartDate ?? forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = resource.CompanyRateCard.DailyRate;
                forecasttask.AugForecastPreciseDuration = forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttaskData.SepEndDate ?? forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttaskData.SepStartDate ?? forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = resource.CompanyRateCard.DailyRate;
                forecasttask.SepForecastPreciseDuration = forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttaskData.MarForecastPreciseDuration ?? forecasttask.MarForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttaskData.AprForecastPreciseDuration ?? forecasttask.AprForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostMar ?? forecasttask.MaterialUnitCostMar, forecasttaskData.MaterialQuantityMar ?? forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostApr ?? forecasttask.MaterialUnitCostApr, forecasttaskData.MaterialQuantityApr ?? forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostMay ?? forecasttask.MaterialUnitCostMay, forecasttaskData.MaterialQuantityMay ?? forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJul ?? forecasttask.MaterialUnitCostJul, forecasttaskData.MaterialQuantityJul ?? forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJun ?? forecasttask.MaterialUnitCostJun, forecasttaskData.MaterialQuantityJun ?? forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostAug ?? forecasttask.MaterialUnitCostAug, forecasttaskData.MaterialQuantityAug ?? forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostSep ?? forecasttask.MaterialUnitCostSep, forecasttaskData.MaterialQuantitySep ?? forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }

            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.April)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = forecasttask.ResourceRateMar;
                forecasttask.MarForecastPreciseDuration = forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttaskData.AprEndDate ?? forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttaskData.AprStartDate ?? forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = resource.CompanyRateCard.DailyRate;
                forecasttask.AprForecastPreciseDuration = forecasttaskData.AprForecastPreciseDuration ?? forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttaskData.MayEndDate ?? forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttaskData.MayStartDate ?? forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = resource.CompanyRateCard.DailyRate;
                forecasttask.MayForecastPreciseDuration = forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttaskData.JunEndDate ?? forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttaskData.JunStartDate ?? forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = resource.CompanyRateCard.DailyRate;
                forecasttask.JunForecastPreciseDuration = forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttaskData.JulEndDate ?? forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttaskData.JulStartDate ?? forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = resource.CompanyRateCard.DailyRate;
                forecasttask.JulForecastPreciseDuration = forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttaskData.AugEndDate ?? forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttaskData.AugStartDate ?? forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = resource.CompanyRateCard.DailyRate;
                forecasttask.AugForecastPreciseDuration = forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttaskData.SepEndDate ?? forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttaskData.SepStartDate ?? forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = resource.CompanyRateCard.DailyRate;
                forecasttask.SepForecastPreciseDuration = forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MarForecastPreciseDuration, forecasttask.ResourceRateMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttaskData.AprForecastPreciseDuration ?? forecasttask.AprForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMar, forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostApr ?? forecasttask.MaterialUnitCostApr, forecasttaskData.MaterialQuantityApr ?? forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostMay ?? forecasttask.MaterialUnitCostMay, forecasttaskData.MaterialQuantityMay ?? forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJul ?? forecasttask.MaterialUnitCostJul, forecasttaskData.MaterialQuantityJul ?? forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJun ?? forecasttask.MaterialUnitCostJun, forecasttaskData.MaterialQuantityJun ?? forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostAug ?? forecasttask.MaterialUnitCostAug, forecasttaskData.MaterialQuantityAug ?? forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostSep ?? forecasttask.MaterialUnitCostSep, forecasttaskData.MaterialQuantitySep ?? forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }
            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.May)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = forecasttask.ResourceRateMar;
                forecasttask.MarForecastPreciseDuration = forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = forecasttask.ResourceRateApr;
                forecasttask.AprForecastPreciseDuration = forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttaskData.MayEndDate ?? forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttaskData.MayStartDate ?? forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = resource.CompanyRateCard.DailyRate;
                forecasttask.MayForecastPreciseDuration = forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttaskData.JunEndDate ?? forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttaskData.JunStartDate ?? forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = resource.CompanyRateCard.DailyRate;
                forecasttask.JunForecastPreciseDuration = forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttaskData.JulEndDate ?? forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttaskData.JulStartDate ?? forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = resource.CompanyRateCard.DailyRate;
                forecasttask.JulForecastPreciseDuration = forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttaskData.AugEndDate ?? forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttaskData.AugStartDate ?? forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = resource.CompanyRateCard.DailyRate;
                forecasttask.AugForecastPreciseDuration = forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttaskData.SepEndDate ?? forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttaskData.SepStartDate ?? forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = resource.CompanyRateCard.DailyRate;
                forecasttask.SepForecastPreciseDuration = forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MarForecastPreciseDuration, forecasttask.ResourceRateMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.AprForecastPreciseDuration, forecasttask.ResourceRateApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MayForecastPreciseDuration ?? forecasttask.MayForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMar, forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostApr, forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostMay ?? forecasttask.MaterialUnitCostMay, forecasttaskData.MaterialQuantityMay ?? forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJul ?? forecasttask.MaterialUnitCostJul, forecasttaskData.MaterialQuantityJul ?? forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJun ?? forecasttask.MaterialUnitCostJun, forecasttaskData.MaterialQuantityJun ?? forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostAug ?? forecasttask.MaterialUnitCostAug, forecasttaskData.MaterialQuantityAug ?? forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostSep ?? forecasttask.MaterialUnitCostSep, forecasttaskData.MaterialQuantitySep ?? forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }

            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.June)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = forecasttask.ResourceRateMar;
                forecasttask.MarForecastPreciseDuration = forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = forecasttask.ResourceRateApr;
                forecasttask.AprForecastPreciseDuration = forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = forecasttask.ResourceRateMay;
                forecasttask.MayForecastPreciseDuration = forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttaskData.JunEndDate ?? forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttaskData.JunStartDate ?? forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = resource.CompanyRateCard.DailyRate;
                forecasttask.JunForecastPreciseDuration = forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttaskData.JulEndDate ?? forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttaskData.JulStartDate ?? forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = resource.CompanyRateCard.DailyRate;
                forecasttask.JulForecastPreciseDuration = forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttaskData.AugEndDate ?? forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttaskData.AugStartDate ?? forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = resource.CompanyRateCard.DailyRate;
                forecasttask.AugForecastPreciseDuration = forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttaskData.SepEndDate ?? forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttaskData.SepStartDate ?? forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = resource.CompanyRateCard.DailyRate;
                forecasttask.SepForecastPreciseDuration = forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MarForecastPreciseDuration, forecasttask.ResourceRateMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.AprForecastPreciseDuration, forecasttask.ResourceRateApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MayForecastPreciseDuration, forecasttask.ResourceRateMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMar, forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostApr, forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMay, forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJul ?? forecasttask.MaterialUnitCostJul, forecasttaskData.MaterialQuantityJul ?? forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJun ?? forecasttask.MaterialUnitCostJun, forecasttaskData.MaterialQuantityJun ?? forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostAug ?? forecasttask.MaterialUnitCostAug, forecasttaskData.MaterialQuantityAug ?? forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostSep ?? forecasttask.MaterialUnitCostSep, forecasttaskData.MaterialQuantitySep ?? forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }
            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.July)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = forecasttask.ResourceRateMar;
                forecasttask.MarForecastPreciseDuration = forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = forecasttask.ResourceRateApr;
                forecasttask.AprForecastPreciseDuration = forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = forecasttask.ResourceRateMay;
                forecasttask.MayForecastPreciseDuration = forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = forecasttask.ResourceRateJun;
                forecasttask.JunForecastPreciseDuration = forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttaskData.JulEndDate ?? forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttaskData.JulStartDate ?? forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = resource.CompanyRateCard.DailyRate;
                forecasttask.JulForecastPreciseDuration = forecasttaskData.JulForecastPreciseDuration ?? forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttaskData.AugEndDate ?? forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttaskData.AugStartDate ?? forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = resource.CompanyRateCard.DailyRate;
                forecasttask.AugForecastPreciseDuration = forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttaskData.SepEndDate ?? forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttaskData.SepStartDate ?? forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = resource.CompanyRateCard.DailyRate;
                forecasttask.SepForecastPreciseDuration = forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MarForecastPreciseDuration, forecasttask.ResourceRateMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.AprForecastPreciseDuration, forecasttask.ResourceRateApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MayForecastPreciseDuration, forecasttask.ResourceRateMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.JunForecastPreciseDuration, forecasttask.ResourceRateJun);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.JunForecastPreciseDuration ?? forecasttask.JunForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMar, forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostApr, forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMay, forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJul, forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostJun ?? forecasttask.MaterialUnitCostJun, forecasttaskData.MaterialQuantityJun ?? forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostAug ?? forecasttask.MaterialUnitCostAug, forecasttaskData.MaterialQuantityAug ?? forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostSep ?? forecasttask.MaterialUnitCostSep, forecasttaskData.MaterialQuantitySep ?? forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }
            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.August)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = forecasttask.ResourceRateMar;
                forecasttask.MarForecastPreciseDuration = forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = forecasttask.ResourceRateApr;
                forecasttask.AprForecastPreciseDuration = forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = forecasttask.ResourceRateMay;
                forecasttask.MayForecastPreciseDuration = forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = forecasttask.ResourceRateJun;
                forecasttask.JunForecastPreciseDuration = forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = forecasttask.ResourceRateJul;
                forecasttask.JulForecastPreciseDuration = forecasttask.JulForecastPreciseDuration;

               forecasttask.AugEndDate = forecasttaskData.AugEndDate ?? forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttaskData.AugStartDate ?? forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = resource.CompanyRateCard.DailyRate;
                forecasttask.AugForecastPreciseDuration = forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttaskData.SepEndDate ?? forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttaskData.SepStartDate ?? forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = resource.CompanyRateCard.DailyRate;
                forecasttask.SepForecastPreciseDuration = forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MarForecastPreciseDuration, forecasttask.ResourceRateMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.AprForecastPreciseDuration, forecasttask.ResourceRateApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MayForecastPreciseDuration, forecasttask.ResourceRateMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.JunForecastPreciseDuration, forecasttask.ResourceRateJun);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.JulForecastPreciseDuration, forecasttask.ResourceRateJul);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.AugForecastPreciseDuration ?? forecasttask.AugForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMar, forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostApr, forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMay, forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJul, forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJun, forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostAug ?? forecasttask.MaterialUnitCostAug, forecasttaskData.MaterialQuantityAug ?? forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostSep ?? forecasttask.MaterialUnitCostSep, forecasttaskData.MaterialQuantitySep ?? forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }

            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.September)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = forecasttask.ResourceRateMar;
                forecasttask.MarForecastPreciseDuration = forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = forecasttask.ResourceRateApr;
                forecasttask.AprForecastPreciseDuration = forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = forecasttask.ResourceRateMay;
                forecasttask.MayForecastPreciseDuration = forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = forecasttask.ResourceRateJun;
                forecasttask.JunForecastPreciseDuration = forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = forecasttask.ResourceRateJul;
                forecasttask.JulForecastPreciseDuration = forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = forecasttask.ResourceRateAug;
                forecasttask.AugForecastPreciseDuration = forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttaskData.SepEndDate ?? forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttaskData.SepStartDate ?? forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = resource.CompanyRateCard.DailyRate;
                forecasttask.SepForecastPreciseDuration = forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MarForecastPreciseDuration, forecasttask.ResourceRateMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.AprForecastPreciseDuration, forecasttask.ResourceRateApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MayForecastPreciseDuration, forecasttask.ResourceRateMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.JunForecastPreciseDuration, forecasttask.ResourceRateJun);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.JulForecastPreciseDuration, forecasttask.ResourceRateJul);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttask.AugForecastPreciseDuration, forecasttask.ResourceRateAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.SepForecastPreciseDuration ?? forecasttask.SepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMar, forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostApr, forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMay, forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJul, forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJun, forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostAug, forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostSep ?? forecasttask.MaterialUnitCostSep, forecasttaskData.MaterialQuantitySep ?? forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }


            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.October)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = forecasttask.ResourceRateMar;
                forecasttask.MarForecastPreciseDuration = forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = forecasttask.ResourceRateApr;
                forecasttask.AprForecastPreciseDuration = forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = forecasttask.ResourceRateMay;
                forecasttask.MayForecastPreciseDuration = forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = forecasttask.ResourceRateJun;
                forecasttask.JunForecastPreciseDuration = forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = forecasttask.ResourceRateJul;
                forecasttask.JulForecastPreciseDuration = forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = forecasttask.ResourceRateAug;
                forecasttask.AugForecastPreciseDuration = forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = forecasttask.ResourceRateSep;
                forecasttask.SepForecastPreciseDuration = forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttaskData.OctEndDate ?? forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttaskData.OctStartDate ?? forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = resource.CompanyRateCard.DailyRate;
                forecasttask.OctForecastPreciseDuration = forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MarForecastPreciseDuration, forecasttask.ResourceRateMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.AprForecastPreciseDuration, forecasttask.ResourceRateApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MayForecastPreciseDuration, forecasttask.ResourceRateMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.JunForecastPreciseDuration, forecasttask.ResourceRateJun);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.JulForecastPreciseDuration, forecasttask.ResourceRateJul);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttask.AugForecastPreciseDuration, forecasttask.ResourceRateAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttask.SepForecastPreciseDuration, forecasttask.ResourceRateSep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.OctForecastPreciseDuration ?? forecasttask.OctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMar, forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostApr, forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMay, forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJul, forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJun, forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostAug, forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostSep, forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostOct ?? forecasttask.MaterialUnitCostOct, forecasttaskData.MaterialQuantityOct ?? forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }

            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.November)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = forecasttask.ResourceRateMar;
                forecasttask.MarForecastPreciseDuration = forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = forecasttask.ResourceRateApr;
                forecasttask.AprForecastPreciseDuration = forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = forecasttask.ResourceRateMay;
                forecasttask.MayForecastPreciseDuration = forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = forecasttask.ResourceRateJun;
                forecasttask.JunForecastPreciseDuration = forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = forecasttask.ResourceRateJul;
                forecasttask.JulForecastPreciseDuration = forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = forecasttask.ResourceRateAug;
                forecasttask.AugForecastPreciseDuration = forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = forecasttask.ResourceRateSep;
                forecasttask.SepForecastPreciseDuration = forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = forecasttask.ResourceRateOct;
                forecasttask.OctForecastPreciseDuration = forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttaskData.NovEndDate ?? forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttaskData.NovStartDate ?? forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = resource.CompanyRateCard.DailyRate;
                forecasttask.NovForecastPreciseDuration = forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MarForecastPreciseDuration, forecasttask.ResourceRateMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.AprForecastPreciseDuration, forecasttask.ResourceRateApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MayForecastPreciseDuration, forecasttask.ResourceRateMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.JunForecastPreciseDuration, forecasttask.ResourceRateJun);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.JulForecastPreciseDuration, forecasttask.ResourceRateJul);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttask.AugForecastPreciseDuration, forecasttask.ResourceRateAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttask.SepForecastPreciseDuration, forecasttask.ResourceRateSep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttask.OctForecastPreciseDuration, forecasttask.ResourceRateOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.NovForecastPreciseDuration ?? forecasttask.NovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMar, forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostApr, forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMay, forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJul, forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJun, forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostAug, forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostSep, forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostOct, forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostNov ?? forecasttask.MaterialUnitCostNov, forecasttaskData.MaterialQuantityNov ?? forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }

            }
            if (reportingperiod==Constants.Strings.ReportingPeriods.December)
            {
                forecasttask.JanEndDate = forecasttask.JanEndDate;
                forecasttask.JanStartDate = forecasttask.JanStartDate;
                forecasttask.ResourceRateJan = forecasttask.ResourceRateJan;
                forecasttask.JanForecastPreciseDuration = forecasttask.JanForecastPreciseDuration;

                forecasttask.FebEndDate = forecasttask.FebEndDate;
                forecasttask.FebStartDate = forecasttask.FebStartDate;
                forecasttask.ResourceRateFeb = forecasttask.ResourceRateFeb;
                forecasttask.FebForecastPreciseDuration = forecasttask.FebForecastPreciseDuration;

                forecasttask.MarEndDate = forecasttask.MarEndDate;
                forecasttask.MarStartDate = forecasttask.MarStartDate;
                forecasttask.ResourceRateMar = forecasttask.ResourceRateMar;
                forecasttask.MarForecastPreciseDuration = forecasttask.MarForecastPreciseDuration;

                forecasttask.AprEndDate = forecasttask.AprEndDate;
                forecasttask.AprStartDate = forecasttask.AprStartDate;
                forecasttask.ResourceRateApr = forecasttask.ResourceRateApr;
                forecasttask.AprForecastPreciseDuration = forecasttask.AprForecastPreciseDuration;

                forecasttask.MayEndDate = forecasttask.MayEndDate;
                forecasttask.MayStartDate = forecasttask.MayStartDate;
                forecasttask.ResourceRateMay = forecasttask.ResourceRateMay;
                forecasttask.MayForecastPreciseDuration = forecasttask.MayForecastPreciseDuration;

                forecasttask.JunEndDate = forecasttask.JunEndDate;
                forecasttask.JunStartDate = forecasttask.JunStartDate;
                forecasttask.ResourceRateJun = forecasttask.ResourceRateJun;
                forecasttask.JunForecastPreciseDuration = forecasttask.JunForecastPreciseDuration;

                forecasttask.JulEndDate = forecasttask.JulEndDate;
                forecasttask.JulStartDate = forecasttask.JulStartDate;
                forecasttask.ResourceRateJul = forecasttask.ResourceRateJul;
                forecasttask.JulForecastPreciseDuration = forecasttask.JulForecastPreciseDuration;

                forecasttask.AugEndDate = forecasttask.AugEndDate;
                forecasttask.AugStartDate = forecasttask.AugStartDate;
                forecasttask.ResourceRateAug = forecasttask.ResourceRateAug;
                forecasttask.AugForecastPreciseDuration = forecasttask.AugForecastPreciseDuration;

                forecasttask.SepEndDate = forecasttask.SepEndDate;
                forecasttask.SepStartDate = forecasttask.SepStartDate;
                forecasttask.ResourceRateSep = forecasttask.ResourceRateSep;
                forecasttask.SepForecastPreciseDuration = forecasttask.SepForecastPreciseDuration;

                forecasttask.OctEndDate = forecasttask.OctEndDate;
                forecasttask.OctStartDate = forecasttask.OctStartDate;
                forecasttask.ResourceRateOct = forecasttask.ResourceRateOct;
                forecasttask.OctForecastPreciseDuration = forecasttask.OctForecastPreciseDuration;

                forecasttask.NovEndDate = forecasttask.NovEndDate;
                forecasttask.NovStartDate = forecasttask.NovStartDate;
                forecasttask.ResourceRateNov = forecasttask.ResourceRateNov;
                forecasttask.NovForecastPreciseDuration = forecasttask.NovForecastPreciseDuration;

                forecasttask.DecEndDate = forecasttaskData.DecEndDate ?? forecasttask.DecEndDate;
                forecasttask.DecStartDate = forecasttaskData.DecStartDate ?? forecasttask.DecStartDate;
                forecasttask.ResourceRateDec = resource.CompanyRateCard.DailyRate;
                forecasttask.DecForecastPreciseDuration = forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration;

                if (forecasttask.CostType == "Labour_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.JanForecastPreciseDuration, forecasttask.ResourceRateJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.FebForecastPreciseDuration, forecasttask.ResourceRateFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MarForecastPreciseDuration, forecasttask.ResourceRateMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.AprForecastPreciseDuration, forecasttask.ResourceRateApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MayForecastPreciseDuration, forecasttask.ResourceRateMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.JunForecastPreciseDuration, forecasttask.ResourceRateJun);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.JulForecastPreciseDuration, forecasttask.ResourceRateJul);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttask.AugForecastPreciseDuration, forecasttask.ResourceRateAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttask.SepForecastPreciseDuration, forecasttask.ResourceRateSep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttask.OctForecastPreciseDuration, forecasttask.ResourceRateOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttask.NovForecastPreciseDuration, forecasttask.ResourceRateNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.DecForecastPreciseDuration ?? forecasttask.DecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

                }
                if (forecasttask.CostType == "Material_Cost")
                {
                    forecasttask.JanForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJan, forecasttask.MaterialQuantityJan);
                    forecasttask.FebForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostFeb, forecasttask.MaterialQuantityFeb);
                    forecasttask.MarForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMar, forecasttask.MaterialQuantityMar);
                    forecasttask.AprForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostApr, forecasttask.MaterialQuantityApr);
                    forecasttask.MayForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostMay, forecasttask.MaterialQuantityMay);
                    forecasttask.JulForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJul, forecasttask.MaterialQuantityJul);
                    forecasttask.JunForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostJun, forecasttask.MaterialQuantityJun);
                    forecasttask.AugForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostAug, forecasttask.MaterialQuantityAug);
                    forecasttask.SepForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostSep, forecasttask.MaterialQuantitySep);
                    forecasttask.OctForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostOct, forecasttask.MaterialQuantityOct);
                    forecasttask.NovForecastAmount = CalculateAmount(forecasttask.MaterialUnitCostNov, forecasttask.MaterialQuantityNov);
                    forecasttask.DecForecastAmount = CalculateAmount(forecasttaskData.MaterialUnitCostDec ?? forecasttask.MaterialUnitCostDec, forecasttaskData.MaterialQuantityDec ?? forecasttask.MaterialQuantityDec);

                }
            }

            var newtasktotal = (forecasttask.JanForecastAmount +
                    forecasttask.FebForecastAmount +
                    forecasttask.MarForecastAmount+
                    forecasttask.AprForecastAmount +
                    forecasttask.MayForecastAmount +
                    forecasttask.JulForecastAmount +
                    forecasttask.JunForecastAmount +
                    forecasttask.AugForecastAmount +
                    forecasttask.SepForecastAmount +
                    forecasttask.OctForecastAmount +
                    forecasttask.NovForecastAmount +
                    forecasttask.DecForecastAmount);


            forecasttask.TotalForecastAmount = newtasktotal;

            forecasttask.TextTaskCostDescription = forecasttaskData.TextTaskCostDescription ?? forecasttask.TextTaskCostDescription;
            forecasttask.VendorId = forecasttaskData.VendorId ?? forecasttask.VendorId;
            forecasttask.Year = forecasttaskData.Year ?? forecasttask.Year;
            forecasttask.Month = forecasttaskData.Month ?? forecasttask.Month;
            forecasttask.ForecastPeriodType = forecasttaskData.ForecastPeriodType ?? forecasttask.ForecastPeriodType;

            forecasttask.BaselinePeriod = forecasttaskData.BaselinePeriod ?? forecasttask.BaselinePeriod;
            forecasttask.CostCat = forecasttaskData.CostCat ?? forecasttask.CostCat;
            forecasttask.CostSubCategory = forecasttaskData.CostSubCategory ?? forecasttask.CostSubCategory;

            forecasttask.Open = forecasttaskData.Open;
            forecasttask.Order = forecasttaskData.Order ?? forecasttask.Order;
            forecasttask.OrderNumber = forecasttaskData.OrderNumber ?? forecasttask.OrderNumber;
            forecasttask.Parent = forecasttaskData.Parent ?? forecasttask.Parent;
            forecasttask.Progress = forecasttaskData.Progress;
            forecasttask.ProjectStage = forecasttaskData.ProjectStage ?? forecasttask.ProjectStage;
            forecasttask.ProjectStageRefid = forecasttaskData.ProjectStageRefid ?? forecasttask.ProjectStageRefid;
            forecasttask.ResourceId = forecasttaskData.ResourceId ?? forecasttask.ResourceId;
            forecasttask.ResourceName = forecasttaskData.ResourceName ?? forecasttask.ResourceName;

            MinMaxDates dates =  FindEarliestActivityDay(
            forecasttask.JanForecastAmount,forecasttask.FebForecastAmount,forecasttask.MarForecastAmount,forecasttask.AprForecastAmount,forecasttask.MayForecastAmount,forecasttask.JunForecastAmount,forecasttask.JulForecastAmount,
            forecasttask.AugForecastAmount,forecasttask.SepForecastAmount,forecasttask.OctForecastAmount,forecasttask.NovForecastAmount,forecasttask.DecForecastAmount,forecasttask.JanEndDate,forecasttask.JanStartDate,
            forecasttask.FebEndDate,forecasttask.FebStartDate,forecasttask.MarEndDate,forecasttask.MarStartDate,forecasttask.AprEndDate,forecasttask.AprStartDate,forecasttask.MayEndDate,forecasttask.MayStartDate,
            forecasttask.JunEndDate,forecasttask.JunStartDate,forecasttask.JulEndDate,forecasttask.JulStartDate,forecasttask.AugEndDate,forecasttask.AugStartDate,forecasttask.SepEndDate,forecasttask.SepStartDate,
            forecasttask.OctEndDate,forecasttask.OctStartDate,forecasttask.NovEndDate,forecasttask.NovStartDate,forecasttask.DecEndDate,forecasttask.DecStartDate
            );

            forecasttask.TaskEarliestStartDate = dates.MinStartDate;
            forecasttask.TaskLatestndEDate= dates.MaxEndDate;
            forecasttask.JanActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 1);
            forecasttask.FebActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 2);;
            forecasttask.MarActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 3);
            forecasttask.AprActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 4);
            forecasttask.MayActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 5);
            forecasttask.JunActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 6);
            forecasttask.JulActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 7);
            forecasttask.AugActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 8);
            forecasttask.SepActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 9);
            forecasttask.OctActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 10);
            forecasttask.NovActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 11);
            forecasttask.DecActualsReconciled= SumReconciledActualsByForecast(forecasttask.CompanyId,forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 12);


            forecasttask.ForecastTaskId = oldforecasttask.ForecastTaskId;

            resource.JanResourceUtilizationInDays = CalculateUtilization(resource.JanResourceUtilizationInDays, forecasttask.JanForecastPreciseDuration, forecasttaskData.JanForecastPreciseDuration);
            resource.FebResourceUtilizationInDays = CalculateUtilization(resource.FebResourceUtilizationInDays, forecasttask.FebForecastPreciseDuration, forecasttaskData.FebForecastPreciseDuration);
            resource.MarResourceUtilizationInDays = CalculateUtilization(resource.MarResourceUtilizationInDays, forecasttask.MarForecastPreciseDuration, forecasttaskData.MarForecastPreciseDuration);
            resource.AprResourceUtilizationInDays = CalculateUtilization(resource.AprResourceUtilizationInDays, forecasttask.AprForecastPreciseDuration, forecasttaskData.AprForecastPreciseDuration);
            resource.MayResourceUtilizationInDays = CalculateUtilization(resource.MayResourceUtilizationInDays, forecasttask.MayForecastPreciseDuration, forecasttaskData.MayForecastPreciseDuration);
            resource.JunResourceUtilizationInDays = CalculateUtilization(resource.JunResourceUtilizationInDays, forecasttask.JunForecastPreciseDuration, forecasttaskData.JunForecastPreciseDuration);
            resource.JulResourceUtilizationInDays = CalculateUtilization(resource.JulResourceUtilizationInDays, forecasttask.JulForecastPreciseDuration, forecasttaskData.JulForecastPreciseDuration);
            resource.AugResourceUtilizationInDays = CalculateUtilization(resource.AugResourceUtilizationInDays, forecasttask.AugForecastPreciseDuration, forecasttaskData.AugForecastPreciseDuration);
            resource.SepResourceUtilizationInDays = CalculateUtilization(resource.SepResourceUtilizationInDays, forecasttask.SepForecastPreciseDuration, forecasttaskData.SepForecastPreciseDuration);
            resource.OctResourceUtilizationInDays = CalculateUtilization(resource.OctResourceUtilizationInDays, forecasttask.OctForecastPreciseDuration, forecasttaskData.OctForecastPreciseDuration);
            resource.NovResourceUtilizationInDays = CalculateUtilization(resource.NovResourceUtilizationInDays, forecasttask.NovForecastPreciseDuration, forecasttaskData.NovForecastPreciseDuration);
            resource.DecResourceUtilizationInDays = CalculateUtilization(resource.DecResourceUtilizationInDays, forecasttask.DecForecastPreciseDuration, forecasttaskData.DecForecastPreciseDuration);

            resource.TotalUtilizationInDays = resource.JanResourceUtilizationInDays + resource.FebResourceUtilizationInDays + resource.MarResourceUtilizationInDays + resource.AprResourceUtilizationInDays
                     + resource.MayResourceUtilizationInDays + resource.JunResourceUtilizationInDays +  resource.JulResourceUtilizationInDays + resource.AugResourceUtilizationInDays
                     + resource.SepResourceUtilizationInDays + resource.OctResourceUtilizationInDays +  resource.NovResourceUtilizationInDays + resource.DecResourceUtilizationInDays;



           _appDbContext.ForecastTasks.Update(forecasttask);
           _summaries =_projectService.GetForecastAndActual(project.ProjectId, _userService.GetSecureUserCompany(), p);
           _summaries.Lifetimeforecast.Add(forecasttask);

           project = UpdateProjectSummaries(project, _summaries);
           _appDbContext.Projects.Update(project);

            _appDbContext.SaveChanges();
            forecasttask = GetforecastTask(comp, oldforecasttask.ForecastTaskId);

            var result = _mapper.Map<ForecastTask, EditForecastTaskData>(forecasttask);
            return Ok(result);
        }

        public static decimal? SumReconciledActualsByForecast(string CompanyId, string ProjectId, string ForecastTaskId, int? Year, int? Month){

           TimesheetTotals timesheetTotals = new TimesheetTotals();
           return timesheetTotals.GetTotalAllocatedAmountFromReconcileActual(CompanyId, ProjectId, ForecastTaskId, Year, Month).GetForecastActualReconcileActual;
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
            var projectDb = _appDbContext.Projects.Include(r => r.ProjectBudgetTracker).SingleOrDefault(r => (r.CompanyId == companyId)&& (r.ProjectId == projectId));
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


        [HttpPost("newforecasttask/{companyId}/{reportingperiod}")]
        [Authorize]
        // [Authorize(Policy = "Admin_Group, Portfolio_Group, Finance_Group")]
        public async Task<IActionResult> CreateForecast([FromBody] ForecastTaskEAC forecasttaskData, string companyId, string reportingperiod)
        {

            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();
            var systemreportingperiod = HttpContext.User.Claims.Single(c => c.Type == "financerepperiod").Value;

            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            // if (roleGroup != "Admin_Group" ||  roleGroup != "Portfolio_Group" || roleGroup != "Finance_Group")
            // {
            //     return BadRequest("You are not authorised to perform this action.");

            // }
            if (roleGroup != "Admin_Group")
            {
                if (roleGroup != "Portfolio_Group")
                {
                    if (roleGroup != "Finance_Group")
                    {
                        return BadRequest("You are not authorised to perform this action.");
                    }
                }
            }
            if (reportingperiod != systemreportingperiod || companyId != comp )
            {
              return BadRequest();
            }

            var resource = Getresource(forecasttaskData.CompanyId, forecasttaskData.ResourceId);
            var project = Getproject(forecasttaskData.CompanyId, forecasttaskData.ProjectId);
            if (forecasttaskData.VendorId == null && forecasttaskData.CostType == Constants.Strings.CostTypes.LabourCost)
            {
                if (resource == null)
                {
                    return BadRequest();
                }
            }

            // if (resource == null || forecasttaskData.VendorId == null  )
            // {
            //     return BadRequest();
            // }

            var newforecast = _mapper.Map<ForecastTaskEAC, ForecastTask>(forecasttaskData);

            // var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;

            var id = Guid.NewGuid().ToString();
            newforecast.ForecastTaskId = id;
            newforecast.CompanyId = comp;
            newforecast.ForecastCode = "FOR" + "-" + CreateNewId(id).ToUpper();

            var newJanEndDate = newforecast.JanEndDate?? new DateTime(newforecast.Year.Value, 1, 1);
            var newJanStartDate = newforecast.JanStartDate?? new DateTime(newforecast.Year.Value, 1, 1);
            var newJanForecastPreciseDuration = newforecast.JanForecastPreciseDuration ??0;
            var newResourceRateJan = NewResourceRate(newJanForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.JanEndDate = newJanEndDate;
            newforecast.JanStartDate = newJanStartDate;
            newforecast.ResourceRateJan = newResourceRateJan;
            newforecast.JanForecastPreciseDuration = newJanForecastPreciseDuration;

            var newFebEndDate = newforecast.FebEndDate?? new DateTime(newforecast.Year.Value, 2, 1);
            var newFebStartDate = newforecast.FebStartDate?? new DateTime(newforecast.Year.Value, 2, 1);
            var newFebForecastPreciseDuration = newforecast.FebForecastPreciseDuration ??0;
            var newResourceRateFeb = NewResourceRate(newFebForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.FebEndDate = newFebEndDate;
            newforecast.FebStartDate = newFebStartDate;
            newforecast.ResourceRateFeb = newResourceRateFeb;
            newforecast.FebForecastPreciseDuration = newFebForecastPreciseDuration;

            var newMarEndDate = newforecast.MarEndDate?? new DateTime(newforecast.Year.Value, 3, 1);
            var newMarStartDate = newforecast.MarStartDate?? new DateTime(newforecast.Year.Value, 3, 1);
            var newMarForecastPreciseDuration = newforecast.MarForecastPreciseDuration ??0;
            var newResourceRateMar = NewResourceRate(newMarForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.MarEndDate = newMarEndDate;
            newforecast.MarStartDate = newMarStartDate;
            newforecast.ResourceRateMar = newResourceRateMar;
            newforecast.MarForecastPreciseDuration = newMarForecastPreciseDuration;

            var newAprEndDate = newforecast.AprEndDate?? new DateTime(newforecast.Year.Value, 4, 1);
            var newAprStartDate = newforecast.AprStartDate?? new DateTime(newforecast.Year.Value, 4, 1);
            var newAprForecastPreciseDuration = newforecast.AprForecastPreciseDuration ??0;
            var newResourceRateApr = NewResourceRate(newAprForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.AprEndDate = newAprEndDate;
            newforecast.AprStartDate = newAprStartDate;
            newforecast.ResourceRateApr = newResourceRateApr;
            newforecast.AprForecastPreciseDuration = newAprForecastPreciseDuration;

            var newMayEndDate = newforecast.MayEndDate?? new DateTime(newforecast.Year.Value, 5, 1);
            var newMayStartDate = newforecast.MayStartDate?? new DateTime(newforecast.Year.Value, 5, 1);
            var newMayForecastPreciseDuration = newforecast.MayForecastPreciseDuration ??0;
            var newResourceRateMay = NewResourceRate(newMayForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.MayEndDate = newMayEndDate;
            newforecast.MayStartDate = newMayStartDate;
            newforecast.ResourceRateMay = newResourceRateMay;
            newforecast.MayForecastPreciseDuration = newMayForecastPreciseDuration;


            var newJunEndDate = newforecast.JunEndDate?? new DateTime(newforecast.Year.Value, 6, 1);
            var newJunStartDate = newforecast.JunStartDate?? new DateTime(newforecast.Year.Value, 6, 1);
            var newJunForecastPreciseDuration = newforecast.JunForecastPreciseDuration ??0;
            var newResourceRateJun = NewResourceRate(newJunForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.JunEndDate = newJunEndDate;
            newforecast.JunStartDate = newJunStartDate;
            newforecast.ResourceRateJun = newResourceRateJun;
            newforecast.JunForecastPreciseDuration = newJunForecastPreciseDuration;


            var newJulEndDate = newforecast.JulEndDate?? new DateTime(newforecast.Year.Value, 7, 1);
            var newJulStartDate = newforecast.JulStartDate?? new DateTime(newforecast.Year.Value, 7, 1);
            var newJulForecastPreciseDuration = newforecast.JulForecastPreciseDuration ??0;
            var newResourceRateJul = NewResourceRate(newJulForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.JulEndDate = newJulEndDate;
            newforecast.JulStartDate = newJulStartDate;
            newforecast.ResourceRateJul = newResourceRateJul;
            newforecast.JulForecastPreciseDuration = newJulForecastPreciseDuration;


            var newAugEndDate = newforecast.AugEndDate?? new DateTime(newforecast.Year.Value, 8, 1);
            var newAugStartDate = newforecast.AugStartDate?? new DateTime(newforecast.Year.Value, 8, 1);
            var newAugForecastPreciseDuration = newforecast.AugForecastPreciseDuration ??0;
            var newResourceRateAug = NewResourceRate(newAugForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.AugEndDate = newAugEndDate;
            newforecast.AugStartDate = newAugStartDate;
            newforecast.ResourceRateAug = newResourceRateAug;
            newforecast.AugForecastPreciseDuration = newAugForecastPreciseDuration;

            var newSepEndDate = newforecast.SepEndDate?? new DateTime(newforecast.Year.Value, 9, 1);
            var newSepStartDate = newforecast.SepStartDate?? new DateTime(newforecast.Year.Value, 9, 1);
            var newSepForecastPreciseDuration = newforecast.SepForecastPreciseDuration ??0;
            var newResourceRateSep = NewResourceRate(newSepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.SepEndDate = newSepEndDate;
            newforecast.SepStartDate = newSepStartDate;
            newforecast.ResourceRateSep = newResourceRateSep;
            newforecast.SepForecastPreciseDuration = newSepForecastPreciseDuration;

            var newOctEndDate = newforecast.OctEndDate?? new DateTime(newforecast.Year.Value, 10, 1);
            var newOctStartDate = newforecast.OctStartDate?? new DateTime(newforecast.Year.Value, 10, 1);
            var newOctForecastPreciseDuration = newforecast.OctForecastPreciseDuration ??0;
            var newResourceRateOct = NewResourceRate(newOctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.OctEndDate = newOctEndDate;
            newforecast.OctStartDate = newOctStartDate;
            newforecast.ResourceRateOct = newResourceRateOct;
            newforecast.OctForecastPreciseDuration = newOctForecastPreciseDuration;

            var newNovEndDate = newforecast.NovEndDate?? new DateTime(newforecast.Year.Value, 11, 1);
            var newNovStartDate = newforecast.NovStartDate?? new DateTime(newforecast.Year.Value, 11, 1);
            var newNovForecastPreciseDuration = newforecast.NovForecastPreciseDuration ??0;
            var newResourceRateNov = NewResourceRate(newNovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.NovEndDate = newNovEndDate;
            newforecast.NovStartDate = newNovStartDate;
            newforecast.ResourceRateNov = newResourceRateNov;
            newforecast.NovForecastPreciseDuration = newNovForecastPreciseDuration;

            var newDecEndDate = newforecast.DecEndDate?? new DateTime(newforecast.Year.Value, 12, 1);
            var newDecStartDate = newforecast.DecStartDate?? new DateTime(newforecast.Year.Value, 12, 1);
            var newDecForecastPreciseDuration = newforecast.DecForecastPreciseDuration ??0;
            var newResourceRateDec = NewResourceRate(newDecForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.DecEndDate = newDecEndDate;
            newforecast.DecStartDate = newDecStartDate;
            newforecast.ResourceRateDec = newResourceRateDec;
            newforecast.DecForecastPreciseDuration = newDecForecastPreciseDuration;


            if (newforecast.CostType == Constants.Strings.CostTypes.LabourCost)
            {
                newforecast.JanForecastAmount = CalculateAmount(newJanForecastPreciseDuration, newResourceRateJan);
                newforecast.FebForecastAmount = CalculateAmount(newFebForecastPreciseDuration, newResourceRateFeb);
                newforecast.MarForecastAmount = CalculateAmount(newMarForecastPreciseDuration, newResourceRateMar);
                newforecast.AprForecastAmount = CalculateAmount(newAprForecastPreciseDuration, newResourceRateApr);
                newforecast.MayForecastAmount = CalculateAmount(newMayForecastPreciseDuration, newResourceRateMay);
                newforecast.JunForecastAmount = CalculateAmount(newJunForecastPreciseDuration, newResourceRateJun);
                newforecast.JulForecastAmount = CalculateAmount(newJulForecastPreciseDuration, newResourceRateJul);
                newforecast.AugForecastAmount = CalculateAmount(newAugForecastPreciseDuration, newResourceRateAug);
                newforecast.SepForecastAmount = CalculateAmount(newSepForecastPreciseDuration, newResourceRateSep);
                newforecast.OctForecastAmount = CalculateAmount(newOctForecastPreciseDuration, newResourceRateOct);
                newforecast.NovForecastAmount = CalculateAmount(newNovForecastPreciseDuration, newResourceRateNov);
                newforecast.DecForecastAmount = CalculateAmount(newDecForecastPreciseDuration, newResourceRateDec);
            }
            if (newforecast.CostType != Constants.Strings.CostTypes.LabourCost)
            {
                newforecast.JanForecastAmount = CalculateAmount(newforecast.MaterialUnitCostJan ??0, newforecast.MaterialQuantityJan ??0);
                newforecast.FebForecastAmount = CalculateAmount(newforecast.MaterialUnitCostFeb ??0, newforecast.MaterialQuantityFeb ??0);
                newforecast.MarForecastAmount = CalculateAmount(newforecast.MaterialUnitCostMar ??0, newforecast.MaterialQuantityMar ??0);
                newforecast.AprForecastAmount = CalculateAmount(newforecast.MaterialUnitCostApr ??0, newforecast.MaterialQuantityApr ??0);
                newforecast.MayForecastAmount = CalculateAmount(newforecast.MaterialUnitCostMay ??0, newforecast.MaterialQuantityMay ??0);
                newforecast.JulForecastAmount = CalculateAmount(newforecast.MaterialUnitCostJul ??0, newforecast.MaterialQuantityJul ??0);
                newforecast.JunForecastAmount = CalculateAmount(newforecast.MaterialUnitCostJun ??0, newforecast.MaterialQuantityJun ??0);
                newforecast.AugForecastAmount = CalculateAmount(newforecast.MaterialUnitCostAug ??0, newforecast.MaterialQuantityAug ??0);
                newforecast.SepForecastAmount = CalculateAmount(newforecast.MaterialUnitCostSep ??0, newforecast.MaterialQuantitySep ??0);
                newforecast.OctForecastAmount = CalculateAmount(newforecast.MaterialUnitCostOct ??0, newforecast.MaterialQuantityOct ??0);
                newforecast.NovForecastAmount = CalculateAmount(newforecast.MaterialUnitCostNov ??0, newforecast.MaterialQuantityNov ??0);
                newforecast.DecForecastAmount = CalculateAmount(newforecast.MaterialUnitCostDec ??0, newforecast.MaterialQuantityDec ??0);

            }

            AppUser user = this.GetSecureUser();

            newforecast.DateCreated = DateTime.UtcNow;
            newforecast.DateModified = DateTime.UtcNow;
            newforecast.UserCreatedEmail = user.Email;
            newforecast.UserModifiedEmail = user.Email;
            newforecast.UserCreatedResourceId = user.ResourceId;
            newforecast.UserModifiedResourceId = user.ResourceId;
            newforecast.UserCreatedId = user.Id;
            newforecast.UserModifiedId = user.Id;

            var newtasktotal = (newforecast.JanForecastAmount +
                    newforecast.FebForecastAmount +
                    newforecast.MarForecastAmount+
                    newforecast.AprForecastAmount +
                    newforecast.MayForecastAmount +
                    newforecast.JulForecastAmount +
                    newforecast.JunForecastAmount +
                    newforecast.AugForecastAmount +
                    newforecast.SepForecastAmount +
                    newforecast.OctForecastAmount +
                    newforecast.NovForecastAmount +
                    newforecast.DecForecastAmount);


            newforecast.TotalForecastAmount = newtasktotal;

            MinMaxDates dates =  FindEarliestActivityDay(
            newforecast.JanForecastAmount,newforecast.FebForecastAmount,newforecast.MarForecastAmount,newforecast.AprForecastAmount,newforecast.MayForecastAmount,newforecast.JunForecastAmount,newforecast.JulForecastAmount,
            newforecast.AugForecastAmount,newforecast.SepForecastAmount,newforecast.OctForecastAmount,newforecast.NovForecastAmount,newforecast.DecForecastAmount,newforecast.JanEndDate,newforecast.JanStartDate,
            newforecast.FebEndDate,newforecast.FebStartDate,newforecast.MarEndDate,newforecast.MarStartDate,newforecast.AprEndDate,newforecast.AprStartDate,newforecast.MayEndDate,newforecast.MayStartDate,
            newforecast.JunEndDate,newforecast.JunStartDate,newforecast.JulEndDate,newforecast.JulStartDate,newforecast.AugEndDate,newforecast.AugStartDate,newforecast.SepEndDate,newforecast.SepStartDate,
            newforecast.OctEndDate,newforecast.OctStartDate,newforecast.NovEndDate,newforecast.NovStartDate,newforecast.DecEndDate,newforecast.DecStartDate
            );

            newforecast.TaskEarliestStartDate = dates.MinStartDate;
            newforecast.TaskLatestndEDate= dates.MaxEndDate;


            resource.JanResourceUtilizationInDays = CalculateUtilizationNewForecast(resource.JanResourceUtilizationInDays??0,  forecasttaskData.JanForecastPreciseDuration);
            resource.FebResourceUtilizationInDays = CalculateUtilizationNewForecast(resource.FebResourceUtilizationInDays??0,  forecasttaskData.FebForecastPreciseDuration);
            resource.MarResourceUtilizationInDays = CalculateUtilizationNewForecast(resource.MarResourceUtilizationInDays??0,  forecasttaskData.MarForecastPreciseDuration);
            resource.AprResourceUtilizationInDays = CalculateUtilizationNewForecast(resource.AprResourceUtilizationInDays??0,  forecasttaskData.AprForecastPreciseDuration);
            resource.MayResourceUtilizationInDays = CalculateUtilizationNewForecast(resource.MayResourceUtilizationInDays??0,  forecasttaskData.MayForecastPreciseDuration);
            resource.JunResourceUtilizationInDays = CalculateUtilizationNewForecast(resource.JunResourceUtilizationInDays??0,  forecasttaskData.JunForecastPreciseDuration);
            resource.JulResourceUtilizationInDays = CalculateUtilizationNewForecast(resource.JulResourceUtilizationInDays??0,  forecasttaskData.JulForecastPreciseDuration);
            resource.AugResourceUtilizationInDays = CalculateUtilizationNewForecast(resource.AugResourceUtilizationInDays??0,  forecasttaskData.AugForecastPreciseDuration);
            resource.SepResourceUtilizationInDays = CalculateUtilizationNewForecast(resource.SepResourceUtilizationInDays??0,  forecasttaskData.SepForecastPreciseDuration);
            resource.OctResourceUtilizationInDays = CalculateUtilizationNewForecast(resource.OctResourceUtilizationInDays??0,  forecasttaskData.OctForecastPreciseDuration);
            resource.NovResourceUtilizationInDays = CalculateUtilizationNewForecast(resource.NovResourceUtilizationInDays??0,  forecasttaskData.NovForecastPreciseDuration);
            resource.DecResourceUtilizationInDays = CalculateUtilizationNewForecast(resource.DecResourceUtilizationInDays??0,  forecasttaskData.DecForecastPreciseDuration);

            resource.TotalUtilizationInDays = resource.JanResourceUtilizationInDays + resource.FebResourceUtilizationInDays + resource.MarResourceUtilizationInDays + resource.AprResourceUtilizationInDays
                     + resource.MayResourceUtilizationInDays + resource.JunResourceUtilizationInDays +  resource.JulResourceUtilizationInDays + resource.AugResourceUtilizationInDays
                     + resource.SepResourceUtilizationInDays + resource.OctResourceUtilizationInDays +  resource.NovResourceUtilizationInDays + resource.DecResourceUtilizationInDays;

           _appDbContext.ForecastTasks.Add(newforecast);
           _summaries =_projectService.GetForecastAndActual(project.ProjectId, _userService.GetSecureUserCompany(), p);
           _summaries.Lifetimeforecast.Add(newforecast);

           project = UpdateProjectSummaries(project, _summaries);
           _appDbContext.Projects.Update(project);

           await _appDbContext.SaveChangesAsync();

            newforecast = GetforecastTask(comp, id);

            var result = _mapper.Map<ForecastTask, ForecastTaskEAC>(newforecast);
            return Ok(result);
        }

        // AppUser GetSecureUser()
        // {
        //     //var id = HttpContext.User.Claims.First().Value;
        //     var id = HttpContext.User.Claims.Single(c => c.Type == "id").Value;
        //     return _appDbContext.Users.SingleOrDefault(u => u.Id == id);
        // }

        public MinMaxDates FindEarliestActivityDay(
            decimal? JanAmount,decimal? FebAmount,decimal? MarAmount,decimal? AprAmount,decimal? MayAmount,decimal? JunAmount,decimal? JulAmount,
            decimal? AugAmount,decimal? SepAmount,decimal? OctAmount,decimal? NovAmount,decimal? DecAmount,DateTime? JanEndDate,DateTime? JanStartDate,
            DateTime? FebEndDate,DateTime? FebStartDate,DateTime? MarEndDate,DateTime? MarStartDate,DateTime? AprEndDate,DateTime? AprStartDate,DateTime? MayEndDate,DateTime? MayStartDate,
            DateTime? JunEndDate,DateTime? JunStartDate,DateTime? JulEndDate,DateTime? JulStartDate,DateTime? AugEndDate,DateTime? AugStartDate,DateTime? SepEndDate,DateTime? SepStartDate,
            DateTime? OctEndDate,DateTime? OctStartDate,DateTime? NovEndDate,DateTime? NovStartDate,DateTime? DecEndDate,DateTime? DecStartDate
            )
        {
            DateTime? startdate = new DateTime();
            DateTime? enddate = new DateTime();
            if ((JanAmount!=0))
            {
               startdate = JanStartDate;
            }
            if ((DecAmount!=0))
            {
               enddate = DecEndDate;
            }
            if ((DecAmount==0))
            {
                if ((NovAmount!=0))
                {
                  enddate = NovEndDate;
                }
                if ((NovAmount==0)&&(OctAmount!=0))
                {
                  enddate = OctEndDate;
                }
                if ((NovAmount==0)&&(OctAmount==0)&&(SepAmount!=0))
                {
                  enddate = SepEndDate;
                }
                if ((NovAmount==0)&&(OctAmount==0)&&(SepAmount==0)&&(AugAmount!=0))
                {
                  enddate = AugEndDate;
                }
                if ((NovAmount==0)&&(OctAmount==0)&&(SepAmount==0)&&(AugAmount==0)&&(JulAmount!=0))
                {
                  enddate = JulEndDate;
                }
                if ((NovAmount==0)&&(OctAmount==0)&&(SepAmount==0)&&(AugAmount==0)&&(JulAmount==0)&&(JunAmount!=0))
                {
                  enddate = JunEndDate;
                }
                if ((NovAmount==0)&&(OctAmount==0)&&(SepAmount==0)&&(AugAmount==0)&&(JulAmount==0)&&(JunAmount==0)&&(MayAmount!=0))
                {
                  enddate = MayEndDate;
                }
                if ((NovAmount==0)&&(OctAmount==0)&&(SepAmount==0)&&(AugAmount==0)&&(JulAmount==0)&&(JunAmount==0)&&(MayAmount==0)&&(AprAmount!=0))
                {
                  enddate = AprEndDate;
                }
                if ((NovAmount==0)&&(OctAmount==0)&&(SepAmount==0)&&(AugAmount==0)&&(JulAmount==0)&&(JunAmount==0)&&(MayAmount==0)&&(AprAmount==0)&&(MarAmount!=0))
                {
                  enddate = MarEndDate;
                }
                if ((NovAmount==0)&&(OctAmount==0)&&(SepAmount==0)&&(AugAmount==0)&&(JulAmount==0)&&(JunAmount==0)&&(MayAmount==0)&&(AprAmount==0)&&(MarAmount!=0)&&(FebAmount!=0))
                {
                  enddate = FebEndDate;
                }
                if ((NovAmount==0)&&(OctAmount==0)&&(SepAmount==0)&&(AugAmount==0)&&(JulAmount==0)&&(JunAmount==0)&&(MayAmount==0)&&(AprAmount==0)&&(MarAmount!=0)&&(FebAmount==0)&&(JanAmount!=0))
                {
                  enddate = JanEndDate;
                  startdate = JanStartDate;
                }

            }

            if ((JanAmount==0))
            {
                if ((FebAmount!=0))
                {
                  startdate = FebStartDate;
                }
                if ((FebAmount==0)&&(MarAmount!=0))
                {
                  startdate = MarStartDate;
                }
                if ((FebAmount==0)&&(MarAmount==0)&&(AprAmount!=0))
                {
                  startdate = AprStartDate;
                }
                if ((FebAmount==0)&&(MarAmount==0)&&(AprAmount==0)&&(MayAmount!=0))
                {
                  startdate = MayStartDate;
                }
                if ((FebAmount==0)&&(MarAmount==0)&&(AprAmount==0)&&(MayAmount==0)&&(JunAmount!=0))
                {
                  startdate = JunStartDate;
                }
                if ((FebAmount==0)&&(MarAmount==0)&&(AprAmount==0)&&(MayAmount==0)&&(JunAmount==0)&&(JulAmount!=0))
                {
                  startdate = JulStartDate;
                }
                if ((FebAmount==0)&&(MarAmount==0)&&(AprAmount==0)&&(MayAmount==0)&&(JunAmount==0)&&(JulAmount==0)&&(AugAmount!=0))
                {
                  startdate = AugStartDate;
                }
                if ((FebAmount==0)&&(MarAmount==0)&&(AprAmount==0)&&(MayAmount==0)&&(JunAmount==0)&&(JulAmount==0)&&(AugAmount==0)&&(SepAmount!=0))
                {
                  startdate = SepStartDate;
                }
                if ((FebAmount==0)&&(MarAmount==0)&&(AprAmount==0)&&(MayAmount==0)&&(JunAmount==0)&&(JulAmount==0)&&(AugAmount==0)&&(SepAmount==0)&&(OctAmount!=0))
                {
                  startdate = OctStartDate;
                }
                if ((FebAmount==0)&&(MarAmount==0)&&(AprAmount==0)&&(MayAmount==0)&&(JunAmount==0)&&(JulAmount==0)&&(AugAmount==0)&&(SepAmount==0)&&(OctAmount==0)&&(NovAmount!=0))
                {
                  startdate = NovStartDate;
                }
                if ((FebAmount==0)&&(MarAmount==0)&&(AprAmount==0)&&(MayAmount==0)&&(JunAmount==0)&&(JulAmount==0)&&(AugAmount==0)&&(SepAmount==0)&&(OctAmount==0)&&(NovAmount==0)&&(DecAmount!=0))
                {
                  startdate = DecStartDate;
                  enddate = DecEndDate;
                }
            }
            return new MinMaxDates(){
                MinStartDate = startdate,
                MaxEndDate = enddate,
            };
        }



    }
}