using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Helpers;
using PTApi.Methods;
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
        private readonly IResourceService _resourceService;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _appDbContext;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;

        public ForecastService(IUserService userService, IGeneratePublicIdMethod getpublicId, IGetIdsWithPartIdsMethod getIdsWithPartIds, 
            IResourceService resourceService, IMapper mapper, ApplicationDbContext appDbContext, IProjectService projectService)
            : base(appDbContext)
        {
            _userService = userService;
            _mapper = mapper;
            _projectService = projectService;
            _getpublicId = getpublicId;
            _getIdsWithPartIds = getIdsWithPartIds;
            _resourceService = resourceService;
            _appDbContext = appDbContext;
        }

        private string CreateNewId(string id)
        {
            return _getpublicId.PartId(id, 8);
        }

        public decimal NewResourceRate(decimal duration, decimal rate)
        {
            if (duration == 0 || rate == 0)
            {
                return 0;
            }
            return rate;
        }


        public class MinMaxDates
        {
            public DateTime? MinStartDate { get; set; }
            public DateTime? MaxEndDate { get; set; }
        }

        public class ActualSumAndDuration
        {
            public decimal? AmountSum { get; set; }
            public decimal? TimeDuration { get; set; }
        }

        

        public string GetResourcePerCost(ForecastTask forecast)
        {

            if (forecast.CostType == Constants.Strings.CostTypes.LabourCost && forecast.ResourceId != null)
            {
                return forecast.ResourceId; 
            }
            return forecast.VendorId;
        }

        

        //public ActualSumAndDuration GetActualsReconciled(ForecastTask forecast, string forecastId, int month)
        //{

        //    var forecastactuals = forecast.ReconciledActuals.Where(a => (a.ActualDateTo.Month == month) &&
        //                                  (a.ActualDateFrom.Month == month) &&
        //                                  (a.ForecastTaskId == forecastId)).ToList();


        //    decimal? amountSum = forecastactuals.Select(a => a.AllocatedAmount).Sum();
        //    decimal? timeDuration = forecastactuals.Select(a => a.ActualDurationInDaysWorkingDays).Sum();

        //    var forecastObj = new ActualSumAndDuration()
        //    {
        //        AmountSum = amountSum,
        //        TimeDuration = timeDuration
        //    };

        //    return forecastObj;
        //}

        public void CreateForecast(ForecastTask newforecast, ForecastTaskEAC forecasttaskData, Resource resource)
        {


            var newJanEndDate = newforecast.JanEndDate ?? new DateTime(newforecast.Year, 1, 1);
            var newJanStartDate = newforecast.JanStartDate ?? new DateTime(newforecast.Year, 1, 1);
            var newJanForecastPreciseDuration = newforecast.JanForecastPreciseDuration ?? 0;
            var newResourceRateJan = NewResourceRate(newJanForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.JanEndDate = newJanEndDate;
            newforecast.JanStartDate = newJanStartDate;
            newforecast.ResourceRateJan = newResourceRateJan;
            newforecast.JanForecastPreciseDuration = newJanForecastPreciseDuration;

            var newFebEndDate = newforecast.FebEndDate ?? new DateTime(newforecast.Year, 2, 1);
            var newFebStartDate = newforecast.FebStartDate ?? new DateTime(newforecast.Year, 2, 1);
            var newFebForecastPreciseDuration = newforecast.FebForecastPreciseDuration ?? 0;
            var newResourceRateFeb = NewResourceRate(newFebForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.FebEndDate = newFebEndDate;
            newforecast.FebStartDate = newFebStartDate;
            newforecast.ResourceRateFeb = newResourceRateFeb;
            newforecast.FebForecastPreciseDuration = newFebForecastPreciseDuration;

            var newMarEndDate = newforecast.MarEndDate ?? new DateTime(newforecast.Year, 3, 1);
            var newMarStartDate = newforecast.MarStartDate ?? new DateTime(newforecast.Year, 3, 1);
            var newMarForecastPreciseDuration = newforecast.MarForecastPreciseDuration ?? 0;
            var newResourceRateMar = NewResourceRate(newMarForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.MarEndDate = newMarEndDate;
            newforecast.MarStartDate = newMarStartDate;
            newforecast.ResourceRateMar = newResourceRateMar;
            newforecast.MarForecastPreciseDuration = newMarForecastPreciseDuration;

            var newAprEndDate = newforecast.AprEndDate ?? new DateTime(newforecast.Year, 4, 1);
            var newAprStartDate = newforecast.AprStartDate ?? new DateTime(newforecast.Year, 4, 1);
            var newAprForecastPreciseDuration = newforecast.AprForecastPreciseDuration ?? 0;
            var newResourceRateApr = NewResourceRate(newAprForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.AprEndDate = newAprEndDate;
            newforecast.AprStartDate = newAprStartDate;
            newforecast.ResourceRateApr = newResourceRateApr;
            newforecast.AprForecastPreciseDuration = newAprForecastPreciseDuration;

            var newMayEndDate = newforecast.MayEndDate ?? new DateTime(newforecast.Year, 5, 1);
            var newMayStartDate = newforecast.MayStartDate ?? new DateTime(newforecast.Year, 5, 1);
            var newMayForecastPreciseDuration = newforecast.MayForecastPreciseDuration ?? 0;
            var newResourceRateMay = NewResourceRate(newMayForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.MayEndDate = newMayEndDate;
            newforecast.MayStartDate = newMayStartDate;
            newforecast.ResourceRateMay = newResourceRateMay;
            newforecast.MayForecastPreciseDuration = newMayForecastPreciseDuration;


            var newJunEndDate = newforecast.JunEndDate ?? new DateTime(newforecast.Year, 6, 1);
            var newJunStartDate = newforecast.JunStartDate ?? new DateTime(newforecast.Year, 6, 1);
            var newJunForecastPreciseDuration = newforecast.JunForecastPreciseDuration ?? 0;
            var newResourceRateJun = NewResourceRate(newJunForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.JunEndDate = newJunEndDate;
            newforecast.JunStartDate = newJunStartDate;
            newforecast.ResourceRateJun = newResourceRateJun;
            newforecast.JunForecastPreciseDuration = newJunForecastPreciseDuration;


            var newJulEndDate = newforecast.JulEndDate ?? new DateTime(newforecast.Year, 7, 1);
            var newJulStartDate = newforecast.JulStartDate ?? new DateTime(newforecast.Year, 7, 1);
            var newJulForecastPreciseDuration = newforecast.JulForecastPreciseDuration ?? 0;
            var newResourceRateJul = NewResourceRate(newJulForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.JulEndDate = newJulEndDate;
            newforecast.JulStartDate = newJulStartDate;
            newforecast.ResourceRateJul = newResourceRateJul;
            newforecast.JulForecastPreciseDuration = newJulForecastPreciseDuration;


            var newAugEndDate = newforecast.AugEndDate ?? new DateTime(newforecast.Year, 8, 1);
            var newAugStartDate = newforecast.AugStartDate ?? new DateTime(newforecast.Year, 8, 1);
            var newAugForecastPreciseDuration = newforecast.AugForecastPreciseDuration ?? 0;
            var newResourceRateAug = NewResourceRate(newAugForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.AugEndDate = newAugEndDate;
            newforecast.AugStartDate = newAugStartDate;
            newforecast.ResourceRateAug = newResourceRateAug;
            newforecast.AugForecastPreciseDuration = newAugForecastPreciseDuration;

            var newSepEndDate = newforecast.SepEndDate ?? new DateTime(newforecast.Year, 9, 1);
            var newSepStartDate = newforecast.SepStartDate ?? new DateTime(newforecast.Year, 9, 1);
            var newSepForecastPreciseDuration = newforecast.SepForecastPreciseDuration ?? 0;
            var newResourceRateSep = NewResourceRate(newSepForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.SepEndDate = newSepEndDate;
            newforecast.SepStartDate = newSepStartDate;
            newforecast.ResourceRateSep = newResourceRateSep;
            newforecast.SepForecastPreciseDuration = newSepForecastPreciseDuration;

            var newOctEndDate = newforecast.OctEndDate ?? new DateTime(newforecast.Year, 10, 1);
            var newOctStartDate = newforecast.OctStartDate ?? new DateTime(newforecast.Year, 10, 1);
            var newOctForecastPreciseDuration = newforecast.OctForecastPreciseDuration ?? 0;
            var newResourceRateOct = NewResourceRate(newOctForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.OctEndDate = newOctEndDate;
            newforecast.OctStartDate = newOctStartDate;
            newforecast.ResourceRateOct = newResourceRateOct;
            newforecast.OctForecastPreciseDuration = newOctForecastPreciseDuration;

            var newNovEndDate = newforecast.NovEndDate ?? new DateTime(newforecast.Year, 11, 1);
            var newNovStartDate = newforecast.NovStartDate ?? new DateTime(newforecast.Year, 11, 1);
            var newNovForecastPreciseDuration = newforecast.NovForecastPreciseDuration ?? 0;
            var newResourceRateNov = NewResourceRate(newNovForecastPreciseDuration, resource.CompanyRateCard.DailyRate);

            newforecast.NovEndDate = newNovEndDate;
            newforecast.NovStartDate = newNovStartDate;
            newforecast.ResourceRateNov = newResourceRateNov;
            newforecast.NovForecastPreciseDuration = newNovForecastPreciseDuration;

            var newDecEndDate = newforecast.DecEndDate ?? new DateTime(newforecast.Year, 12, 1);
            var newDecStartDate = newforecast.DecStartDate ?? new DateTime(newforecast.Year, 12, 1);
            var newDecForecastPreciseDuration = newforecast.DecForecastPreciseDuration ?? 0;
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
                newforecast.JanForecastAmount = CalculateAmount(newforecast.MaterialUnitCostJan ?? 0, newforecast.MaterialQuantityJan ?? 0);
                newforecast.FebForecastAmount = CalculateAmount(newforecast.MaterialUnitCostFeb ?? 0, newforecast.MaterialQuantityFeb ?? 0);
                newforecast.MarForecastAmount = CalculateAmount(newforecast.MaterialUnitCostMar ?? 0, newforecast.MaterialQuantityMar ?? 0);
                newforecast.AprForecastAmount = CalculateAmount(newforecast.MaterialUnitCostApr ?? 0, newforecast.MaterialQuantityApr ?? 0);
                newforecast.MayForecastAmount = CalculateAmount(newforecast.MaterialUnitCostMay ?? 0, newforecast.MaterialQuantityMay ?? 0);
                newforecast.JulForecastAmount = CalculateAmount(newforecast.MaterialUnitCostJul ?? 0, newforecast.MaterialQuantityJul ?? 0);
                newforecast.JunForecastAmount = CalculateAmount(newforecast.MaterialUnitCostJun ?? 0, newforecast.MaterialQuantityJun ?? 0);
                newforecast.AugForecastAmount = CalculateAmount(newforecast.MaterialUnitCostAug ?? 0, newforecast.MaterialQuantityAug ?? 0);
                newforecast.SepForecastAmount = CalculateAmount(newforecast.MaterialUnitCostSep ?? 0, newforecast.MaterialQuantitySep ?? 0);
                newforecast.OctForecastAmount = CalculateAmount(newforecast.MaterialUnitCostOct ?? 0, newforecast.MaterialQuantityOct ?? 0);
                newforecast.NovForecastAmount = CalculateAmount(newforecast.MaterialUnitCostNov ?? 0, newforecast.MaterialQuantityNov ?? 0);
                newforecast.DecForecastAmount = CalculateAmount(newforecast.MaterialUnitCostDec ?? 0, newforecast.MaterialQuantityDec ?? 0);

            }

            //AppUser user = this.GetSecureUser();

            newforecast.DateCreated = DateTime.UtcNow;
            newforecast.DateModified = DateTime.UtcNow;
            newforecast.UserCreatedEmail = _userService.GetSecureUserEmail();
            newforecast.UserModifiedEmail = _userService.GetSecureUserEmail();
            newforecast.UserCreatedResourceId = _userService.GetSecureResource();
            newforecast.UserModifiedResourceId = _userService.GetSecureResource();
            newforecast.UserCreatedId = _userService.GetSecureUserId();
            newforecast.UserModifiedId = _userService.GetSecureUserId();

            var newtasktotal = (newforecast.JanForecastAmount +
                    newforecast.FebForecastAmount +
                    newforecast.MarForecastAmount +
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

            MinMaxDates dates = FindEarliestActivityDay(
            newforecast.JanForecastAmount, newforecast.FebForecastAmount, newforecast.MarForecastAmount, newforecast.AprForecastAmount, newforecast.MayForecastAmount, newforecast.JunForecastAmount, newforecast.JulForecastAmount,
            newforecast.AugForecastAmount, newforecast.SepForecastAmount, newforecast.OctForecastAmount, newforecast.NovForecastAmount, newforecast.DecForecastAmount, newforecast.JanEndDate, newforecast.JanStartDate,
            newforecast.FebEndDate, newforecast.FebStartDate, newforecast.MarEndDate, newforecast.MarStartDate, newforecast.AprEndDate, newforecast.AprStartDate, newforecast.MayEndDate, newforecast.MayStartDate,
            newforecast.JunEndDate, newforecast.JunStartDate, newforecast.JulEndDate, newforecast.JulStartDate, newforecast.AugEndDate, newforecast.AugStartDate, newforecast.SepEndDate, newforecast.SepStartDate,
            newforecast.OctEndDate, newforecast.OctStartDate, newforecast.NovEndDate, newforecast.NovStartDate, newforecast.DecEndDate, newforecast.DecStartDate
            );

            newforecast.TaskEarliestStartDate = dates.MinStartDate;
            newforecast.TaskLatestndEDate = dates.MaxEndDate;

        }

        public void SaveForecast(ForecastTask forecasttask, ForecastTaskEAC forecasttaskData, ForecastTask oldforecasttask, Resource resource, string reportingperiod)
        {
            if (reportingperiod == Constants.Strings.ReportingPeriods.January)
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
            if (reportingperiod == Constants.Strings.ReportingPeriods.February)
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
            if (reportingperiod == Constants.Strings.ReportingPeriods.March)
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
            if (reportingperiod == Constants.Strings.ReportingPeriods.April)
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
            if (reportingperiod == Constants.Strings.ReportingPeriods.May)
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
            if (reportingperiod == Constants.Strings.ReportingPeriods.June)
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
            if (reportingperiod == Constants.Strings.ReportingPeriods.July)
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
            if (reportingperiod == Constants.Strings.ReportingPeriods.August)
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
            if (reportingperiod == Constants.Strings.ReportingPeriods.September)
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
            if (reportingperiod == Constants.Strings.ReportingPeriods.October)
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
            if (reportingperiod == Constants.Strings.ReportingPeriods.November)
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
            if (reportingperiod == Constants.Strings.ReportingPeriods.December)
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
                    forecasttask.MarForecastAmount +
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

            
            forecasttask.VendorId = forecasttaskData.VendorId ?? forecasttask.VendorId;
            forecasttask.Year = forecasttaskData.Year ?? forecasttask.Year;


            //forecasttask.Month = forecasttaskData.Month ?? forecasttask.Month;
            //forecasttask.ForecastPeriodType = forecasttaskData.ForecastPeriodType ?? forecasttask.ForecastPeriodType;
            //forecasttask.TextTaskCostDescription = forecasttaskData.TextTaskCostDescription ?? forecasttask.TextTaskCostDescription;

            //forecasttask.BaselinePeriod = forecasttaskData.BaselinePeriod ?? forecasttask.BaselinePeriod;
            //forecasttask.Open = forecasttaskData.Open;
            //forecasttask.Order = forecasttaskData.Order ?? forecasttask.Order;
            //forecasttask.Parent = forecasttaskData.Parent ?? forecasttask.Parent;
            //forecasttask.Progress = forecasttaskData.Progress;
            //forecasttask.ProjectStage = forecasttaskData.ProjectStage ?? forecasttask.ProjectStage;
            //forecasttask.ProjectStageRefid = forecasttaskData.ProjectStageRefid ?? forecasttask.ProjectStageRefid;


            forecasttask.CostCat = forecasttaskData.CostCat ?? forecasttask.CostCat;
            forecasttask.CostSubCategory = forecasttaskData.CostSubCategory ?? forecasttask.CostSubCategory;

            
            forecasttask.OrderNumber = forecasttaskData.OrderNumber ?? forecasttask.OrderNumber;
            
            forecasttask.ResourceId = forecasttaskData.ResourceId ?? forecasttask.ResourceId;
            forecasttask.ResourceName = forecasttaskData.ResourceName ?? forecasttask.ResourceName;

            MinMaxDates dates = FindEarliestActivityDay(
            forecasttask.JanForecastAmount, forecasttask.FebForecastAmount, forecasttask.MarForecastAmount, forecasttask.AprForecastAmount, forecasttask.MayForecastAmount, forecasttask.JunForecastAmount, forecasttask.JulForecastAmount,
            forecasttask.AugForecastAmount, forecasttask.SepForecastAmount, forecasttask.OctForecastAmount, forecasttask.NovForecastAmount, forecasttask.DecForecastAmount, forecasttask.JanEndDate, forecasttask.JanStartDate,
            forecasttask.FebEndDate, forecasttask.FebStartDate, forecasttask.MarEndDate, forecasttask.MarStartDate, forecasttask.AprEndDate, forecasttask.AprStartDate, forecasttask.MayEndDate, forecasttask.MayStartDate,
            forecasttask.JunEndDate, forecasttask.JunStartDate, forecasttask.JulEndDate, forecasttask.JulStartDate, forecasttask.AugEndDate, forecasttask.AugStartDate, forecasttask.SepEndDate, forecasttask.SepStartDate,
            forecasttask.OctEndDate, forecasttask.OctStartDate, forecasttask.NovEndDate, forecasttask.NovStartDate, forecasttask.DecEndDate, forecasttask.DecStartDate
            );

            forecasttask.TaskEarliestStartDate = dates.MinStartDate;
            forecasttask.TaskLatestndEDate = dates.MaxEndDate;
            forecasttask.JanActualsReconciled = SumReconciledActualsByForecast(forecasttask.CompanyId, forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 1);
            forecasttask.FebActualsReconciled = SumReconciledActualsByForecast(forecasttask.CompanyId, forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 2); ;
            forecasttask.MarActualsReconciled = SumReconciledActualsByForecast(forecasttask.CompanyId, forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 3);
            forecasttask.AprActualsReconciled = SumReconciledActualsByForecast(forecasttask.CompanyId, forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 4);
            forecasttask.MayActualsReconciled = SumReconciledActualsByForecast(forecasttask.CompanyId, forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 5);
            forecasttask.JunActualsReconciled = SumReconciledActualsByForecast(forecasttask.CompanyId, forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 6);
            forecasttask.JulActualsReconciled = SumReconciledActualsByForecast(forecasttask.CompanyId, forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 7);
            forecasttask.AugActualsReconciled = SumReconciledActualsByForecast(forecasttask.CompanyId, forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 8);
            forecasttask.SepActualsReconciled = SumReconciledActualsByForecast(forecasttask.CompanyId, forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 9);
            forecasttask.OctActualsReconciled = SumReconciledActualsByForecast(forecasttask.CompanyId, forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 10);
            forecasttask.NovActualsReconciled = SumReconciledActualsByForecast(forecasttask.CompanyId, forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 11);
            forecasttask.DecActualsReconciled = SumReconciledActualsByForecast(forecasttask.CompanyId, forecasttask.ProjectId, forecasttask.ForecastTaskId, forecasttask.Year, 12);


            forecasttask.ForecastTaskId = oldforecasttask.ForecastTaskId;

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

        public decimal? CalculateUtilization(decimal? oldutility, decimal? oldforecast, decimal? newforecast)
        {
            if (oldforecast == newforecast)
            {
                return oldutility;
            }
            var difference = newforecast - oldforecast;
            var newutility = difference + oldutility;

            return newutility;
        }

        public decimal? CalculateUtilizationNewForecast(decimal? oldutility, decimal? newforecast)
        {

            var newutility = oldutility + newforecast;

            return newutility;
        }


        public decimal? SumReconciledActualsByForecast(string CompanyId, string ProjectId, string ForecastTaskId, int? Year, int? Month)
        {
            return _resourceService.GetTotalAllocatedAmountFromReconcileActual(CompanyId, ProjectId, ForecastTaskId, Year, Month).GetForecastActualReconcileActual;
        }

        public MinMaxDates FindEarliestActivityDay(
           decimal? JanAmount, decimal? FebAmount, decimal? MarAmount, decimal? AprAmount, decimal? MayAmount, decimal? JunAmount, decimal? JulAmount,
           decimal? AugAmount, decimal? SepAmount, decimal? OctAmount, decimal? NovAmount, decimal? DecAmount, DateTime? JanEndDate, DateTime? JanStartDate,
           DateTime? FebEndDate, DateTime? FebStartDate, DateTime? MarEndDate, DateTime? MarStartDate, DateTime? AprEndDate, DateTime? AprStartDate, DateTime? MayEndDate, DateTime? MayStartDate,
           DateTime? JunEndDate, DateTime? JunStartDate, DateTime? JulEndDate, DateTime? JulStartDate, DateTime? AugEndDate, DateTime? AugStartDate, DateTime? SepEndDate, DateTime? SepStartDate,
           DateTime? OctEndDate, DateTime? OctStartDate, DateTime? NovEndDate, DateTime? NovStartDate, DateTime? DecEndDate, DateTime? DecStartDate
        )
        {
            DateTime? startdate = new DateTime();
            DateTime? enddate = new DateTime();
            if ((JanAmount != 0))
            {
                startdate = JanStartDate;
            }
            if ((DecAmount != 0))
            {
                enddate = DecEndDate;
            }
            if ((DecAmount == 0))
            {
                if ((NovAmount != 0))
                {
                    enddate = NovEndDate;
                }
                if ((NovAmount == 0) && (OctAmount != 0))
                {
                    enddate = OctEndDate;
                }
                if ((NovAmount == 0) && (OctAmount == 0) && (SepAmount != 0))
                {
                    enddate = SepEndDate;
                }
                if ((NovAmount == 0) && (OctAmount == 0) && (SepAmount == 0) && (AugAmount != 0))
                {
                    enddate = AugEndDate;
                }
                if ((NovAmount == 0) && (OctAmount == 0) && (SepAmount == 0) && (AugAmount == 0) && (JulAmount != 0))
                {
                    enddate = JulEndDate;
                }
                if ((NovAmount == 0) && (OctAmount == 0) && (SepAmount == 0) && (AugAmount == 0) && (JulAmount == 0) && (JunAmount != 0))
                {
                    enddate = JunEndDate;
                }
                if ((NovAmount == 0) && (OctAmount == 0) && (SepAmount == 0) && (AugAmount == 0) && (JulAmount == 0) && (JunAmount == 0) && (MayAmount != 0))
                {
                    enddate = MayEndDate;
                }
                if ((NovAmount == 0) && (OctAmount == 0) && (SepAmount == 0) && (AugAmount == 0) && (JulAmount == 0) && (JunAmount == 0) && (MayAmount == 0) && (AprAmount != 0))
                {
                    enddate = AprEndDate;
                }
                if ((NovAmount == 0) && (OctAmount == 0) && (SepAmount == 0) && (AugAmount == 0) && (JulAmount == 0) && (JunAmount == 0) && (MayAmount == 0) && (AprAmount == 0) && (MarAmount != 0))
                {
                    enddate = MarEndDate;
                }
                if ((NovAmount == 0) && (OctAmount == 0) && (SepAmount == 0) && (AugAmount == 0) && (JulAmount == 0) && (JunAmount == 0) && (MayAmount == 0) && (AprAmount == 0) && (MarAmount != 0) && (FebAmount != 0))
                {
                    enddate = FebEndDate;
                }
                if ((NovAmount == 0) && (OctAmount == 0) && (SepAmount == 0) && (AugAmount == 0) && (JulAmount == 0) && (JunAmount == 0) && (MayAmount == 0) && (AprAmount == 0) && (MarAmount != 0) && (FebAmount == 0) && (JanAmount != 0))
                {
                    enddate = JanEndDate;
                    startdate = JanStartDate;
                }

            }

            if ((JanAmount == 0))
            {
                if ((FebAmount != 0))
                {
                    startdate = FebStartDate;
                }
                if ((FebAmount == 0) && (MarAmount != 0))
                {
                    startdate = MarStartDate;
                }
                if ((FebAmount == 0) && (MarAmount == 0) && (AprAmount != 0))
                {
                    startdate = AprStartDate;
                }
                if ((FebAmount == 0) && (MarAmount == 0) && (AprAmount == 0) && (MayAmount != 0))
                {
                    startdate = MayStartDate;
                }
                if ((FebAmount == 0) && (MarAmount == 0) && (AprAmount == 0) && (MayAmount == 0) && (JunAmount != 0))
                {
                    startdate = JunStartDate;
                }
                if ((FebAmount == 0) && (MarAmount == 0) && (AprAmount == 0) && (MayAmount == 0) && (JunAmount == 0) && (JulAmount != 0))
                {
                    startdate = JulStartDate;
                }
                if ((FebAmount == 0) && (MarAmount == 0) && (AprAmount == 0) && (MayAmount == 0) && (JunAmount == 0) && (JulAmount == 0) && (AugAmount != 0))
                {
                    startdate = AugStartDate;
                }
                if ((FebAmount == 0) && (MarAmount == 0) && (AprAmount == 0) && (MayAmount == 0) && (JunAmount == 0) && (JulAmount == 0) && (AugAmount == 0) && (SepAmount != 0))
                {
                    startdate = SepStartDate;
                }
                if ((FebAmount == 0) && (MarAmount == 0) && (AprAmount == 0) && (MayAmount == 0) && (JunAmount == 0) && (JulAmount == 0) && (AugAmount == 0) && (SepAmount == 0) && (OctAmount != 0))
                {
                    startdate = OctStartDate;
                }
                if ((FebAmount == 0) && (MarAmount == 0) && (AprAmount == 0) && (MayAmount == 0) && (JunAmount == 0) && (JulAmount == 0) && (AugAmount == 0) && (SepAmount == 0) && (OctAmount == 0) && (NovAmount != 0))
                {
                    startdate = NovStartDate;
                }
                if ((FebAmount == 0) && (MarAmount == 0) && (AprAmount == 0) && (MayAmount == 0) && (JunAmount == 0) && (JulAmount == 0) && (AugAmount == 0) && (SepAmount == 0) && (OctAmount == 0) && (NovAmount == 0) && (DecAmount != 0))
                {
                    startdate = DecStartDate;
                    enddate = DecEndDate;
                }
            }
            return new MinMaxDates()
            {
                MinStartDate = startdate,
                MaxEndDate = enddate,
            };
        }

    }
}
