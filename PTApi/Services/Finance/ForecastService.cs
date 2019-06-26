using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Helpers;
using PTApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Services
{
    public class ForecastService : Repository<ForecastTask>, IForecastService
    {
       
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
