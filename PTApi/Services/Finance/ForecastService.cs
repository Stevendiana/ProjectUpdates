using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Helpers;
using PTApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PTApi.Services
{
    public class ForecastService : Repository<ForecastTask>, IForecastService
    {
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


        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _appDbContext;

        public ForecastService(IUserService userService, IMapper mapper, ApplicationDbContext appDbContext, IProjectService projectService)
            : base(appDbContext)
        {
            _userService = userService;
            _mapper = mapper;
            _projectService = projectService;
            _appDbContext = appDbContext;
        }

        public decimal? GetTotalActualReconciled(IEnumerable<ForecastTask> forecast, string forecastId, int month)
        {

            var forecastactuals = forecast.SelectMany(f => f.ReconciledActuals.Where(fr => (f.ForecastTaskId == forecastId)));
            return forecastactuals?.Where(a => (a.ActualDateTo.Month == month) && (a.ActualDateFrom.Month == month)).Select(a => a.AllocatedAmount).Sum();
        }

        public string GetResourcePerCost(ForecastTask forecast)
        {

            if (forecast.CostType == Constants.Strings.CostTypes.LabourCost && forecast.ResourceId != null)
            {
                return forecast.ResourceId;
            }
            return forecast.VendorId;
        }

    
        public IEnumerable<ForecastTaskEAC> GetLifeTimeForecast(string companyId, string projectId, string reportingperiod, string reportingyear)
        {

            var comp = _userService.GetSecureUserCompany();
            var userreportingperiod = _userService.GetSecureUserCompanyReportingPeriod();
            var userreportingyear = _userService.GetSecureUserCompanyReportingYear();

            int i = 0;
            string s = userreportingyear;
            i = int.Parse(s);
            i = Convert.ToInt32(s);

            if (companyId != comp || reportingyear != userreportingyear)
            {
                return null;
            }

            var projectDb = _appDbContext.Projects.SingleOrDefault(b => (b.CompanyId == companyId) && (b.ProjectId == projectId));
            if (projectDb == null)
            {
                return null;
            }


            var allprojectforecastLifetime =  _appDbContext.ForecastTasks
                                                  .Include(f => f.Resource)
                                                  .Include(f => f.Supplier)
                                                  .Include(f => f.ParentTask)
                                                  .Include(f => f.ReconciledActuals)
                                                  .Where(f => (f.ProjectId == projectId) && (f.CompanyId == companyId)).ToList();

            if (allprojectforecastLifetime == null)
            {
                return null;
            }

            var pastyearforecast = GetPastYearsForecast(allprojectforecastLifetime, reportingperiod, i);
            var currentyearforecast = GetCurrentYearForecast(allprojectforecastLifetime, reportingperiod, i);
            var futureyearforecast = GetCurrentYearForecast(allprojectforecastLifetime, reportingperiod, i);

            var lifetime = new List<ForecastTaskEAC>(pastyearforecast.Count + currentyearforecast.Count + futureyearforecast.Count);

            lifetime.AddRange(pastyearforecast);
            lifetime.AddRange(currentyearforecast);
            lifetime.AddRange(futureyearforecast);

            return lifetime;
        }


        private List<ForecastTaskEAC> GetCurrentYearForecast(IEnumerable<ForecastTask> allprojectforecastLifetime, string reportingperiod, int reportingyear)
        {
            var allprojectforecast = allprojectforecastLifetime.Where(f => f.Year == reportingyear).ToList();

            List<ForecastTaskEAC> forecastTask = new List<ForecastTaskEAC>();
            // var forecastEac =  Mapper.Map<List<ForecastTask>, List<ForecastTaskEAC>>(allprojectforecast);

            if (reportingperiod == Constants.Strings.ReportingPeriods.January)
            {
                foreach (var item in allprojectforecast)
                {
                    var forecast = _mapper.Map<ForecastTask, ForecastTaskEAC>(item);

                    forecast.JanAmount = item.JanForecastAmount ?? 0;
                    forecast.FebAmount = item.FebForecastAmount ?? 0;
                    forecast.MarAmount = item.MarForecastAmount ?? 0;
                    forecast.AprAmount = item.AprForecastAmount ?? 0;
                    forecast.MayAmount = item.MayForecastAmount ?? 0;
                    forecast.JunAmount = item.JunForecastAmount ?? 0;
                    forecast.JulAmount = item.JulForecastAmount ?? 0;
                    forecast.AugAmount = item.AugForecastAmount ?? 0;
                    forecast.SepAmount = item.SepForecastAmount ?? 0;
                    forecast.OctAmount = item.OctForecastAmount ?? 0;
                    forecast.NovAmount = item.NovForecastAmount ?? 0;
                    forecast.DecAmount = item.DecForecastAmount ?? 0;
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
                    forecast.FebAmount = item.FebForecastAmount ?? 0;
                    forecast.MarAmount = item.MarForecastAmount ?? 0;
                    forecast.AprAmount = item.AprForecastAmount ?? 0;
                    forecast.MayAmount = item.MayForecastAmount ?? 0;
                    forecast.JunAmount = item.JunForecastAmount ?? 0;
                    forecast.JulAmount = item.JulForecastAmount ?? 0;
                    forecast.AugAmount = item.AugForecastAmount ?? 0;
                    forecast.SepAmount = item.SepForecastAmount ?? 0;
                    forecast.OctAmount = item.OctForecastAmount ?? 0;
                    forecast.NovAmount = item.NovForecastAmount ?? 0;
                    forecast.DecAmount = item.DecForecastAmount ?? 0;
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
                    forecast.MarAmount = item.MarForecastAmount ?? 0;
                    forecast.AprAmount = item.AprForecastAmount ?? 0;
                    forecast.MayAmount = item.MayForecastAmount ?? 0;
                    forecast.JunAmount = item.JunForecastAmount ?? 0;
                    forecast.JulAmount = item.JulForecastAmount ?? 0;
                    forecast.AugAmount = item.AugForecastAmount ?? 0;
                    forecast.SepAmount = item.SepForecastAmount ?? 0;
                    forecast.OctAmount = item.OctForecastAmount ?? 0;
                    forecast.NovAmount = item.NovForecastAmount ?? 0;
                    forecast.DecAmount = item.DecForecastAmount ?? 0;
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

                    forecast.AprAmount = item.AprForecastAmount ?? 0;
                    forecast.MayAmount = item.MayForecastAmount ?? 0;
                    forecast.JunAmount = item.JunForecastAmount ?? 0;
                    forecast.JulAmount = item.JulForecastAmount ?? 0;
                    forecast.AugAmount = item.AugForecastAmount ?? 0;
                    forecast.SepAmount = item.SepForecastAmount ?? 0;
                    forecast.OctAmount = item.OctForecastAmount ?? 0;
                    forecast.NovAmount = item.NovForecastAmount ?? 0;
                    forecast.DecAmount = item.DecForecastAmount ?? 0;
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
                    forecast.MayAmount = item.MayForecastAmount ?? 0;
                    forecast.JunAmount = item.JunForecastAmount ?? 0;
                    forecast.JulAmount = item.JulForecastAmount ?? 0;
                    forecast.AugAmount = item.AugForecastAmount ?? 0;
                    forecast.SepAmount = item.SepForecastAmount ?? 0;
                    forecast.OctAmount = item.OctForecastAmount ?? 0;
                    forecast.NovAmount = item.NovForecastAmount ?? 0;
                    forecast.DecAmount = item.DecForecastAmount ?? 0;
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
                    forecast.JunAmount = item.JunForecastAmount ?? 0;
                    forecast.JulAmount = item.JulForecastAmount ?? 0;
                    forecast.AugAmount = item.AugForecastAmount ?? 0;
                    forecast.SepAmount = item.SepForecastAmount ?? 0;
                    forecast.OctAmount = item.OctForecastAmount ?? 0;
                    forecast.NovAmount = item.NovForecastAmount ?? 0;
                    forecast.DecAmount = item.DecForecastAmount ?? 0;
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
                    forecast.JulAmount = item.JulForecastAmount ?? 0;
                    forecast.AugAmount = item.AugForecastAmount ?? 0;
                    forecast.SepAmount = item.SepForecastAmount ?? 0;
                    forecast.OctAmount = item.OctForecastAmount ?? 0;
                    forecast.NovAmount = item.NovForecastAmount ?? 0;
                    forecast.DecAmount = item.DecForecastAmount ?? 0;
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
                    forecast.AugAmount = item.AugForecastAmount ?? 0;
                    forecast.SepAmount = item.SepForecastAmount ?? 0;
                    forecast.OctAmount = item.OctForecastAmount ?? 0;
                    forecast.NovAmount = item.NovForecastAmount ?? 0;
                    forecast.DecAmount = item.DecForecastAmount ?? 0;
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

                    forecast.SepAmount = item.SepForecastAmount ?? 0;
                    forecast.OctAmount = item.OctForecastAmount ?? 0;
                    forecast.NovAmount = item.NovForecastAmount ?? 0;
                    forecast.DecAmount = item.DecForecastAmount ?? 0;
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

                    forecast.OctAmount = item.OctForecastAmount ?? 0;
                    forecast.NovAmount = item.NovForecastAmount ?? 0;
                    forecast.DecAmount = item.DecForecastAmount ?? 0;
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

                    forecast.NovAmount = item.NovForecastAmount ?? 0;
                    forecast.DecAmount = item.DecForecastAmount ?? 0;
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
                    forecast.DecAmount = item.DecForecastAmount ?? 0;
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

        private List<ForecastTaskEAC> GetPastYearsForecast(IEnumerable<ForecastTask> allprojectforecastLifetime, string reportingperiod, int reportingyear)
        {

            var allprojectforecasts = allprojectforecastLifetime.Where(f => f.Year < reportingyear).ToList();

            if (allprojectforecasts == null)
            {
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

        private List<ForecastTaskEAC> GetFutureYearsForecast(IEnumerable<ForecastTask> allprojectforecastLifetime, string reportingperiod, int reportingyear)
        {

            var allprojectforecasts = allprojectforecastLifetime.Where(f => f.Year > reportingyear).ToList();

            if (allprojectforecasts == null)
            {
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



    }
}
