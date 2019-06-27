
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PTApi.Data.Repositories;
using PTApi.Helpers;
using PTApi.Methods;
using PTApi.Models;
using PTApi.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using static PTApi.Services.ProjectForecastService;

namespace PTApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ForecastTasksController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IForecastService _forecastService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;


        public ForecastTasksController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, IGetIdsWithPartIdsMethod getIdsWithPartIds, 
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

        private int Convertwordmonthtonum(string periodinword)
        {
            return _getpublicId.ConvertMonthWordsToNumbers(periodinword);
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

       


        // public class ForecastTaskEAC
        //{
        //    // public string ForecastCode { get{return "FOR" + "-" + CreateNewId(ForecastTaskId,8).ToUpper();}}

        //    public string ForecastTaskId { get; set; }
        //    public string TextTaskCostDescription { get; set; }
        //    public byte? ForecastPeriodType { get; set; }
        //    public int? Order { get; set; }
        //    public decimal Progress { get; set; }
        //    public bool Open { get; set; }
        //    public string Parent { get; set; }
        //    public int? Year { get; set; }
        //    public byte? Month { get; set; }
        //    public int? BaselinePeriod { get; set; }
        //    public string ForecastCode { get; set; }
        //    public string ProjectStageRefid { get; set; }
        //    public string ProjectStage { get; set; }
        //    public string CostType { get; set; }
        //    public string CostCat { get; set; }
        //    public string ResourceId { get; set; }
        //    public string ResourceName { get; set; }
        //    public string VendorId { get; set; }
        //    public Supplier Supplier { get; set; }
        //    public Resource Resource { get; set; }
        //    public string OrderNumber { get; set; }
        //    public string CompanyId { get; set; }
        //    public string ProjectId { get; set; }
        //    public DateTime? JanStartDate { get; set; }
        //    public DateTime? JanEndDate { get; set; }
        //    public decimal? ResourceRateJan { get; set; }
        //    public decimal? JanForecastPreciseDuration { get; set; }
        //    public decimal? JanAmount { get; set; }
        //    public DateTime? FebStartDate { get; set; }
        //    public DateTime? FebEndDate { get; set; }
        //    public decimal? ResourceRateFeb { get; set; }
        //    public decimal? FebForecastPreciseDuration { get; set; }
        //    public decimal? FebAmount { get; set; }
        //    public DateTime? MarStartDate { get; set; }
        //    public DateTime? MarEndDate { get; set; }
        //    public decimal? ResourceRateMar { get; set; }
        //    public decimal? MarForecastPreciseDuration { get; set; }
        //    public decimal? MarAmount { get; set; }
        //    public DateTime? AprStartDate { get; set; }
        //    public DateTime? AprEndDate { get; set; }
        //    public decimal? ResourceRateApr { get; set; }
        //    public decimal? AprForecastPreciseDuration { get; set; }
        //    public decimal? AprAmount { get; set; }
        //    public DateTime? MayStartDate { get; set; }
        //    public DateTime? MayEndDate { get; set; }
        //    public decimal? ResourceRateMay { get; set; }
        //    public decimal? MayForecastPreciseDuration { get; set; }
        //    public decimal? MayAmount { get; set; }
        //    public DateTime? JunStartDate { get; set; }
        //    public DateTime? JunEndDate { get; set; }
        //    public decimal? ResourceRateJun { get; set; }
        //    public decimal? JunForecastPreciseDuration { get; set; }
        //    public decimal? JunAmount { get; set; }
        //    public DateTime? JulStartDate { get; set; }
        //    public DateTime? JulEndDate { get; set; }
        //    public decimal? ResourceRateJul { get; set; }
        //    public decimal? JulForecastPreciseDuration { get; set; }
        //    public decimal? JulAmount { get; set; }
        //    public DateTime? AugStartDate { get; set; }
        //    public DateTime? AugEndDate { get; set; }
        //    public decimal? ResourceRateAug { get; set; }
        //    public decimal? AugForecastPreciseDuration { get; set; }
        //    public decimal? AugAmount { get; set; }
        //    public DateTime? SepStartDate { get; set; }
        //    public DateTime? SepEndDate { get; set; }
        //    public decimal? ResourceRateSep { get; set; }
        //    public decimal? SepForecastPreciseDuration { get; set; }
        //    public decimal? SepAmount { get; set; }
        //    public DateTime? OctEndDate { get; set; }
        //    public DateTime? OctStartDate { get; set; }
        //    public decimal? ResourceRateOct { get; set; }
        //    public decimal? OctForecastPreciseDuration { get; set; }
        //    public decimal? OctAmount { get; set; }
        //    public DateTime? NovStartDate { get; set; }
        //    public DateTime? NovEndDate { get; set; }
        //    public decimal? ResourceRateNov { get; set; }
        //    public decimal? NovForecastPreciseDuration { get; set; }
        //    public decimal? NovAmount { get; set; }
        //    public DateTime? DecStartDate { get; set; }
        //    public DateTime? DecEndDate { get; set; }
        //    public decimal? ResourceRateDec { get; set; }
        //    public decimal? DecForecastPreciseDuration { get; set; }
        //    public decimal? DecAmount { get; set; }

        //    public decimal? QoneForecastAmount { get; set; }
        //    public decimal? QtwoForecastAmount { get; set; }
        //    public decimal? QthreeForecastAmount { get; set; }
        //    public decimal? QfourForecastAmount { get; set; }

        //    public decimal? TotalForecastPreciseDuration { get; set; }
        //    public decimal? TotalAmount { get; set; }

        //    public string CostSubCategory { get; set; }
        //    public string ResourcePerCost { get; set; }
        //    public decimal? MaterialQuantityJan { get; set; }
        //    public decimal? MaterialUnitCostJan { get; set; }

        //    public decimal? MaterialQuantityFeb { get; set; }
        //    public decimal? MaterialUnitCostFeb { get; set; }
        //    public decimal? MaterialQuantityMar { get; set; }
        //    public decimal? MaterialUnitCostMar { get; set; }
        //    public decimal? MaterialQuantityApr { get; set; }
        //    public decimal? MaterialUnitCostApr { get; set; }
        //    public decimal? MaterialQuantityMay { get; set; }
        //    public decimal? MaterialUnitCostMay { get; set; }
        //    public decimal? MaterialQuantityJun { get; set; }
        //    public decimal? MaterialUnitCostJun { get; set; }
        //    public decimal? MaterialQuantityJul { get; set; }
        //    public decimal? MaterialUnitCostJul { get; set; }
        //    public decimal? MaterialQuantityAug { get; set; }
        //    public decimal? MaterialUnitCostAug { get; set; }
        //    public decimal? MaterialQuantitySep { get; set; }
        //    public decimal? MaterialUnitCostSep { get; set; }
        //    public decimal? MaterialQuantityOct { get; set; }
        //    public decimal? MaterialUnitCostOct { get; set; }
        //    public decimal? MaterialQuantityNov { get; set; }
        //    public decimal? MaterialUnitCostNov { get; set; }
        //    public decimal? MaterialQuantityDec { get; set; }
        //    public decimal? MaterialUnitCostDec { get; set; }

        //    public ICollection<ReconciledActual> ReconciledActuals { get; set; }

        //    public ForecastTaskEAC()
        //    {
        //        ReconciledActuals = new Collection<ReconciledActual>();
        //    }

        //}

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

        public decimal? GetActualsReconciledSum(ForecastTask  forecast, string forecastId, int month)
        {

          var forecastactuals = forecast.ReconciledActuals.Where(a=>(a.ActualDateTo.Month == month)&&
                                        (a.ActualDateFrom.Month == month)&&
                                        (a.ForecastTaskId == forecastId)).Select(a=> a.AllocatedAmount).Sum();
          return forecastactuals;
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

        public Project UpdateProjectSummaries(Project project, GetForecastAndActualMinAndMaxDates _summaries, int p)
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
        [HttpGet("{companyId}/{id}")]
        public ActionResult Get(string companyId, string id)
        {

            var forecastTaskDb = _unitOfWork.LifetimeForecast.SingleOrDefault(b => (b.CompanyId == companyId) && (b.ForecastTaskId == id));

            if (forecastTaskDb == null)
                return NotFound("Forecast not found");

            return Ok(forecastTaskDb);
        }


        [Authorize]
        [HttpGet("currentprojectforecast/{companyId}/{projectId}/{reportingperiod}/{reportingyear}")]
        public IActionResult GetCurrentLifeTimeForecast(string companyId, string projectId, string reportingperiod, string reportingyear) {

            var comp = _userService.GetSecureUserCompany();
            var userreportingperiod = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Financerepperiod).Value;
            var userreportingyear = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Financerepyear).Value;


            if(companyId != comp  || reportingperiod != userreportingperiod || reportingyear != userreportingyear){
                return BadRequest();
            }

            var allprojectforecast = _unitOfWork.LifetimeForecast.GetLifeTimeForecast(comp, projectId, userreportingperiod, userreportingyear);

            if (allprojectforecast == null){
                return null;
            }

            return Ok(allprojectforecast);
        }


        [HttpPost("editforecasttask/{companyId}/{reportingperiod}")]
        [Authorize]
        // [Authorize(Policy = "Admin_Group, Portfolio_Group, Finance_Group")]
        public ActionResult EditOneForecast([FromBody] ForecastTaskEAC forecasttaskData, string companyId, string reportingperiod)
        {

            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();
            var systemreportingperiod = HttpContext.User.Claims.Single(c => c.Type == "financerepperiod").Value;
            int period = Convertwordmonthtonum(systemreportingperiod);

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

            var oldforecasttask = _unitOfWork.LifetimeForecast.SingleOrDefault(b => (b.CompanyId == comp) && (b.ForecastTaskId == forecasttaskData.ForecastTaskId));
            
            var resource = _unitOfWork.Resources.SingleOrDefault(b => (b.CompanyId == comp) && (b.ProjectId == forecasttaskData.ProjectId));
            var project = _unitOfWork.Projects.SingleOrDefault(b => (b.CompanyId == comp) && (b.ProjectId == forecasttaskData.ProjectId));

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
            
            //saveforecast
            _forecastService.SaveForecast(forecasttask, forecasttaskData, oldforecasttask, resource, systemreportingperiod);
            _unitOfWork.LifetimeForecast.Update(forecasttask);

           var _summaries =_projectService.GetForecastAndActual(project.ProjectId, _userService.GetSecureUserCompany(), period);
           _summaries.Lifetimeforecast.Add(forecasttask);

            //update project summaries
            project = UpdateProjectSummaries(project, _summaries, period);
            _unitOfWork.Projects.Update(project);

            //Save everything
            _unitOfWork.Complete();
            
            forecasttask = _unitOfWork.LifetimeForecast.SingleOrDefault(f=>(f.CompanyId == comp) && (f.ForecastTaskId == oldforecasttask.ForecastTaskId));

            var result = _mapper.Map<ForecastTask, EditForecastTaskData>(forecasttask);
            return Ok(result);
        }


        [HttpPost("newforecasttask/{companyId}/{reportingperiod}")]
        [Authorize]
        // [Authorize(Policy = "Admin_Group, Portfolio_Group, Finance_Group")]
        public IActionResult CreateForecast([FromBody] ForecastTaskEAC forecasttaskData, string companyId, string reportingperiod)
        {

            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();
            var systemreportingperiod = HttpContext.User.Claims.Single(c => c.Type == "financerepperiod").Value;
            int period = Convertwordmonthtonum(systemreportingperiod);


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

            var resource = _unitOfWork.Resources.SingleOrDefault(b => (b.CompanyId == comp) && (b.ProjectId == forecasttaskData.ProjectId));
            var project = _unitOfWork.Projects.SingleOrDefault(b => (b.CompanyId == comp) && (b.ProjectId == forecasttaskData.ProjectId));

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

            var id = Guid.NewGuid().ToString();
            newforecast.ForecastTaskId = id;
            newforecast.CompanyId = _userService.GetSecureUserCompany();
            newforecast.ForecastCode = "FOR" + "-" + CreateNewId(id).ToUpper();


            _forecastService.CreateForecast(newforecast, forecasttaskData, resource);

            _unitOfWork.LifetimeForecast.Add(newforecast);

            var _summaries = _projectService.GetForecastAndActual(project.ProjectId, _userService.GetSecureUserCompany(), period);
            _summaries.Lifetimeforecast.Add(newforecast);

            project = UpdateProjectSummaries(project, _summaries, period);
            _unitOfWork.Projects.Update(project);

            //Save everything
            _unitOfWork.Complete();

            newforecast = _unitOfWork.LifetimeForecast.SingleOrDefault(f => (f.CompanyId == comp) && (f.ForecastTaskId == id));


            var result = _mapper.Map<ForecastTask, ForecastTaskEAC>(newforecast);
            return Ok(result);
        }

        
    }
}