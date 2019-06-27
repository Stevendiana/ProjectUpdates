
using PTApi.Data;
using PTApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Services
{
    public class ResourceService : Repository<Resource>, IResourceService
    {
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly ApplicationDbContext _appDbContext;

        public ResourceService (IUserService userService, ApplicationDbContext appDbContext, IProjectService projectService)
            : base(appDbContext)
        {
            _userService = userService;
            _projectService = projectService;
            _appDbContext = appDbContext;
        }

        //public ResourceService()
        //{
        //}

        public class ForecastTotals
        {
            public decimal? ForecastDays { get; set; }
            public decimal? ReconciledForecastDays { get; set; }
            public int? TotalProjectsForecastCount { get; set;}

        }

        public class GetResourceAvailabilityAndUtility
        {

            public decimal? SumJanResourceTotalAvailability { get; set; }
            public decimal? SumFebResourceTotalAvailability { get; set; }
            public decimal? SumMarResourceTotalAvailability { get; set; }
            public decimal? SumAprResourceTotalAvailability { get; set; }
            public decimal? SumMayResourceTotalAvailability { get; set; }
            public decimal? SumJunResourceTotalAvailability { get; set; }
            public decimal? SumJulResourceTotalAvailability { get; set; }
            public decimal? SumAugResourceTotalAvailability { get; set; }
            public decimal? SumSepResourceTotalAvailability { get; set; }
            public decimal? SumOctResourceTotalAvailability { get; set; }
            public decimal? SumNovResourceTotalAvailability { get; set; }
            public decimal? SumDecResourceTotalAvailability { get; set; }


        }

        public class GetAllResourceUtilizationByMonth
        {
            public decimal? GetJanResourceUtilizationByMonth { get; set; }
            public decimal? GetFebResourceUtilizationByMonth { get; set; }
            public decimal? GetMarResourceUtilizationByMonth { get; set; }
            public decimal? GetAprResourceUtilizationByMonth { get; set; }
            public decimal? GetMayResourceUtilizationByMonth { get; set; }
            public decimal? GetJunResourceUtilizationByMonth { get; set; }
            public decimal? GetJulResourceUtilizationByMonth { get; set; }
            public decimal? GetAugResourceUtilizationByMonth { get; set; }
            public decimal? GetSepResourceUtilizationByMonth { get; set; }
            public decimal? GetOctResourceUtilizationByMonth { get; set; }
            public decimal? GetNovResourceUtilizationByMonth { get; set; }
            public decimal? GetDecResourceUtilizationByMonth { get; set; }


        }


        public Resource GetLoggedInUserResource()
        {
            var comp = _userService.GetSecureUserCompany();
            var userId = _userService.GetSecureUserId();

            var resource = _appDbContext.Resources.SingleOrDefault(r => (r.CompanyId == comp)&& (r.IdentityId == userId));
            return resource;
        }

        public ForecastTotals GetPerResourceForecastTotals (IEnumerable<ForecastTask> forecastList)
        {
            var totalForecastDays = forecastList?.Select(f=> f.TotalForecastDaysUnits).Sum();
            var totalActualRecenciled = forecastList?.Select(f=> f.TotalActualsReconciled).Sum();
            var totalProjectsForecastCount = forecastList?.Select(f=> f.ProjectId).Distinct().Count();

            return new ForecastTotals(){
                ForecastDays = totalForecastDays,
                ReconciledForecastDays = totalActualRecenciled,
                TotalProjectsForecastCount = totalProjectsForecastCount,
            };
        }

        public Resource GetResourceById(string userId, string resourceId)
        {
            if (!string.IsNullOrEmpty(userId) || !string.IsNullOrEmpty(resourceId))
            {
                var comp = _userService.GetSecureUserCompany();
                if (!string.IsNullOrEmpty(userId))
                {
                    var resource = _appDbContext.Resources.SingleOrDefault(r => (r.CompanyId == comp)&& (r.IdentityId == userId));
                    return resource;
                }
                if (!string.IsNullOrEmpty(resourceId))
                {
                    var resource = _appDbContext.Resources.SingleOrDefault(r => (r.CompanyId == comp)&& (r.ResourceId == resourceId));
                    return resource;
                }

            }

            return null;
        }

        public decimal? GetAllResourceHolidaysTotalsByMonth(string companyId, string resourceId, int? year, int? month){

           return GetResourceHolidaysTotals(companyId,resourceId, year, month).SumResourceTotalHolidayHours;
        }
        public decimal? GetNumberOfWorkingDaysInMonth(int year, byte month){

           return _projectService.GetDaysPerMonth(year, month).WorkingdaysInMonth;
        }

        // public decimal? GetResourceCompanyStandardDailyHours(string resourceId){

        //    //GetIdsWithPartIds.ResourceUtilization getIdsWithPartIds = new GetIdsWithPartIds.ResourceUtilization();
        //    GetIdsWithPartIds getIdsWithPartIds = new GetIdsWithPartIds();
        //    return getIdsWithPartIds.GetCompanyStandardDailyHours(resourceId).ResourceCompanyStandardHours;
        // }

        // public decimal? GetResourceContractedEffortHours(string resourceId){

        //    //GetIdsWithPartIds.ResourceUtilization getIdsWithPartIds = new GetIdsWithPartIds.ResourceUtilization();
        //    GetIdsWithPartIds getIdsWithPartIds = new GetIdsWithPartIds();
        //    return getIdsWithPartIds.GetCompanyStandardDailyHours(resourceId).ResourceContractedEffortHours;
        // }


        public GetAllResourceUtilizationByMonth GetAllResourceUtilization (string resourceId, int? year) {

            var getAllResourceUtilizationForecast =  _appDbContext.ForecastTasks
             .Where(ruf => (ruf.ResourceId == resourceId)
              &&(ruf.Year == year)).ToList();

            decimal? getJanResourceUtilizationByMonth =  getAllResourceUtilizationForecast.Select(g => g.JanForecastDaysUnits).Sum();
            decimal? getFebResourceUtilizationByMonth =  getAllResourceUtilizationForecast.Select(g => g.FebForecastDaysUnits).Sum();
            decimal? getMarResourceUtilizationByMonth =  getAllResourceUtilizationForecast.Select(g => g.MarForecastDaysUnits).Sum();
            decimal? getAprResourceUtilizationByMonth =  getAllResourceUtilizationForecast.Select(g => g.AprForecastDaysUnits).Sum();
            decimal? getMayResourceUtilizationByMonth =  getAllResourceUtilizationForecast.Select(g => g.MayForecastDaysUnits).Sum();
            decimal? getJunResourceUtilizationByMonth =  getAllResourceUtilizationForecast.Select(g => g.JunForecastDaysUnits).Sum();
            decimal? getJulResourceUtilizationByMonth =  getAllResourceUtilizationForecast.Select(g => g.JulForecastDaysUnits).Sum();
            decimal? getAugResourceUtilizationByMonth =  getAllResourceUtilizationForecast.Select(g => g.AugForecastDaysUnits).Sum();
            decimal? getSepResourceUtilizationByMonth =  getAllResourceUtilizationForecast.Select(g => g.SepForecastDaysUnits).Sum();
            decimal? getOctResourceUtilizationByMonth =  getAllResourceUtilizationForecast.Select(g => g.OctForecastDaysUnits).Sum();
            decimal? getNovResourceUtilizationByMonth =  getAllResourceUtilizationForecast.Select(g => g.NovForecastDaysUnits).Sum();
            decimal? getDecResourceUtilizationByMonth =  getAllResourceUtilizationForecast.Select(g => g.DecForecastDaysUnits).Sum();



            var resourceUtilizationObj = new GetAllResourceUtilizationByMonth() {
            GetJanResourceUtilizationByMonth=getJanResourceUtilizationByMonth,
            GetFebResourceUtilizationByMonth=getFebResourceUtilizationByMonth,
            GetMarResourceUtilizationByMonth=getMarResourceUtilizationByMonth,
            GetAprResourceUtilizationByMonth=getAprResourceUtilizationByMonth,
            GetMayResourceUtilizationByMonth=getMayResourceUtilizationByMonth,
            GetJunResourceUtilizationByMonth=getJunResourceUtilizationByMonth,
            GetJulResourceUtilizationByMonth=getJulResourceUtilizationByMonth,
            GetAugResourceUtilizationByMonth=getAugResourceUtilizationByMonth,
            GetSepResourceUtilizationByMonth=getSepResourceUtilizationByMonth,
            GetOctResourceUtilizationByMonth=getOctResourceUtilizationByMonth,
            GetNovResourceUtilizationByMonth=getNovResourceUtilizationByMonth,
            GetDecResourceUtilizationByMonth=getDecResourceUtilizationByMonth,


            };

           return resourceUtilizationObj;

        }

        public GetResourceAvailabilityAndUtility GetAllResourceAvailabilityAndUtility(string companyId, string resourceId, int? year){

           var getResourceAvailabilityAndUtility =  _appDbContext.ResourceEffortSummaries.Where(re => (re.CompanyId == companyId)).ToList();

           var getResourceAvailabilityAndUtilityTotals =  getResourceAvailabilityAndUtility
             .Where(re => (re.ResourceId == resourceId)
              &&((re.Year == year)  || (re.Year == year)
              //&&((rwt.TimesheetCalendar.SaturdayPeriod == month)  || (rwt.TimesheetCalendar.SundayPeriod == month))
             )).ToList();


            decimal? sumJanResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.JanAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumFebResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.FebAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumMarResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.MarAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumAprResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.AprAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumMayResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.MayAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumJunResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.JunAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumJulResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.JulAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumAugResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.AugAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumSepResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.SepAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumOctResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.OctAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumNovResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.NovAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumDecResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.DecAvailabilityAfterHolidaysInDays).Sum();


            var availabilityObj = new GetResourceAvailabilityAndUtility() {

                SumJanResourceTotalAvailability = sumJanResourceTotalAvailability,
                SumFebResourceTotalAvailability = sumFebResourceTotalAvailability,
                SumMarResourceTotalAvailability = sumMarResourceTotalAvailability,
                SumAprResourceTotalAvailability = sumAprResourceTotalAvailability,
                SumMayResourceTotalAvailability = sumMayResourceTotalAvailability,
                SumJunResourceTotalAvailability = sumJunResourceTotalAvailability,
                SumJulResourceTotalAvailability = sumJulResourceTotalAvailability,
                SumAugResourceTotalAvailability = sumAugResourceTotalAvailability,
                SumSepResourceTotalAvailability = sumSepResourceTotalAvailability,
                SumOctResourceTotalAvailability = sumOctResourceTotalAvailability,
                SumNovResourceTotalAvailability = sumNovResourceTotalAvailability,
                SumDecResourceTotalAvailability = sumDecResourceTotalAvailability,

            };


          return availabilityObj;

        }

        public class GetResourceTimesheetsTotalsByForecast
        {
            public decimal? SumResourceStandardTimeByForecast { get; set; }
            public decimal? SumResourceOverTimeByForecast { get; set; }
            public decimal? SumResourceStandardTimeNonBillableByForecast { get; set; }
            public decimal? SumResourceOverTimeNonBillableByForecast { get; set; }
            public decimal? GetForecastActualReconcileActual { get; set; }
            public decimal? GetTotalAllocatedAmountFromReconcileActual { get; set; }

        }

        public class GetResourceHolidaysTotalsByResource
        {
            public decimal? SumResourceTotalHolidayHours { get; set; }


        }

        

        public GetResourceTimesheetsTotalsByForecast GetResourceTimesheetsTotals(string companyId, string resourceId, string projectId, string forecastTaskId, int? year, int? month)
        {

            var getAllCompanyResourceTimesheets = _appDbContext.ResourceWorkTimesheets.Where(rwt => (rwt.CompanyId == companyId)).ToList();
            var getAllResourceTimesheetsTotals = getAllCompanyResourceTimesheets
              .Where(rwt => (rwt.ResourceId == resourceId)
               && (rwt.ProjectId == projectId)
               && (rwt.ForecastTaskId == forecastTaskId)
               && ((rwt.TimesheetCalendar.SaturdayYear == year) || (rwt.TimesheetCalendar.SundayYear == year)
              //&&((rwt.TimesheetCalendar.SaturdayPeriod == month)  || (rwt.TimesheetCalendar.SundayPeriod == month))
              )).ToList();


            decimal? sumResourceStandardTimeByForecast = getAllResourceTimesheetsTotals
                                                 .Where(g => (g.TimesheetStatus == "Approved")
                                                 && (g.TimesheetCalendar.SaturdayPeriod == month) || (g.TimesheetCalendar.SundayPeriod == month))
                                                 .Select(rwt => rwt.TotalStandardDayBillableHours).Sum();

            decimal? sumResourceOverTimeByForecast = getAllResourceTimesheetsTotals
                                             .Where(g => (g.TimesheetStatus == "Approved")
                                             && (g.TimesheetCalendar.SaturdayPeriod == month) || (g.TimesheetCalendar.SundayPeriod == month))
                                             .Select(rwt => rwt.TotalOvertimeBillableHours).Sum();

            decimal? sumResourceStandardTimeNonBillableByForecast = getAllResourceTimesheetsTotals
                                                            .Where(g => (g.TimesheetStatus == "Approved")
                                                            && (g.TimesheetCalendar.SaturdayPeriod == month) || (g.TimesheetCalendar.SundayPeriod == month))
                                                            .Select(rwt => rwt.TotalStandardDayNonBillableHours).Sum();

            decimal? sumResourceOverTimeNonBillableByForecast = getAllResourceTimesheetsTotals
                                                        .Where(g => (g.TimesheetStatus == "Approved")
                                                        && (g.TimesheetCalendar.SaturdayPeriod == month) || (g.TimesheetCalendar.SundayPeriod == month))
                                                        .Select(rwt => rwt.TotalOvertimeNonBillableHours).Sum();

            var forecastObj = new GetResourceTimesheetsTotalsByForecast()
            {
                SumResourceStandardTimeByForecast = sumResourceStandardTimeByForecast,
                SumResourceOverTimeByForecast = sumResourceOverTimeByForecast,
                SumResourceStandardTimeNonBillableByForecast = sumResourceStandardTimeNonBillableByForecast,
                SumResourceOverTimeNonBillableByForecast = sumResourceOverTimeNonBillableByForecast

            };


            return forecastObj;

        }

        public GetResourceHolidaysTotalsByResource GetResourceHolidaysTotals(string companyId, string resourceId, int? year, int? month)
        {

            var getAllCompanyResourceHolidays = _appDbContext.ResourceHolidays.Where(rh => (rh.CompanyId == companyId)).ToList();

            var getAllResourceHolidaysTotals = getAllCompanyResourceHolidays
              .Where(rh => (rh.ResourceId == resourceId)
               && ((rh.TimesheetCalendar.SaturdayYear == year) || (rh.TimesheetCalendar.SundayYear == year)
              //&&((rwt.TimesheetCalendar.SaturdayPeriod == month)  || (rwt.TimesheetCalendar.SundayPeriod == month))
              )).ToList();


            decimal? sumResourceTotalHolidayHours = getAllResourceHolidaysTotals
                                                 .Where(g => (g.HolidayStatus == "Approved")
                                                 && (g.TimesheetCalendar.SaturdayPeriod == month) || (g.TimesheetCalendar.SundayPeriod == month))
                                                 .Select(rh => rh.TotalHolidayHours).Sum();



            var holidayObj = new GetResourceHolidaysTotalsByResource()
            {
                SumResourceTotalHolidayHours = sumResourceTotalHolidayHours,

            };


            return holidayObj;

        }

        public GetResourceAvailabilityAndUtility GetAllResourceAvailabilityAndUtility(string companyId, string resourceId, int? year, int? month)
        {

            var getResourceAvailabilityAndUtility = _appDbContext.ResourceEffortSummaries.Where(re => (re.CompanyId == companyId)).ToList();

            var getResourceAvailabilityAndUtilityTotals = getResourceAvailabilityAndUtility
              .Where(re => (re.ResourceId == resourceId)
               && ((re.Year == year) || (re.Year == year)
              //&&((rwt.TimesheetCalendar.SaturdayPeriod == month)  || (rwt.TimesheetCalendar.SundayPeriod == month))
              )).ToList();


            decimal? sumJanResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.JanAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumFebResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.FebAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumMarResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.MarAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumAprResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.AprAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumMayResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.MayAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumJunResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.JunAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumJulResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.JulAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumAugResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.AugAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumSepResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.SepAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumOctResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.OctAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumNovResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.NovAvailabilityAfterHolidaysInDays).Sum();
            decimal? sumDecResourceTotalAvailability = getResourceAvailabilityAndUtilityTotals.Select(re => re.DecAvailabilityAfterHolidaysInDays).Sum();


            var availabilityObj = new GetResourceAvailabilityAndUtility()
            {

                SumJanResourceTotalAvailability = sumJanResourceTotalAvailability,
                SumFebResourceTotalAvailability = sumFebResourceTotalAvailability,
                SumMarResourceTotalAvailability = sumMarResourceTotalAvailability,
                SumAprResourceTotalAvailability = sumAprResourceTotalAvailability,
                SumMayResourceTotalAvailability = sumMayResourceTotalAvailability,
                SumJunResourceTotalAvailability = sumJunResourceTotalAvailability,
                SumJulResourceTotalAvailability = sumJulResourceTotalAvailability,
                SumAugResourceTotalAvailability = sumAugResourceTotalAvailability,
                SumSepResourceTotalAvailability = sumSepResourceTotalAvailability,
                SumOctResourceTotalAvailability = sumOctResourceTotalAvailability,
                SumNovResourceTotalAvailability = sumNovResourceTotalAvailability,
                SumDecResourceTotalAvailability = sumDecResourceTotalAvailability,

            };


            return availabilityObj;

        }

        public GetResourceTimesheetsTotalsByForecast GetTotalAllocatedAmountFromReconcileActual(string companyId, string projectId, string forecastTaskId, int? year, int? month)
        {

            var getAllReconciledTotals = _appDbContext.ReconciledActuals.Where(ra => (ra.CompanyId == companyId) && (ra.ProjectId == projectId)).ToList();

            decimal? getForecastActualReconcileActual = getAllReconciledTotals
              .Where(ra => (ra.ForecastTaskId == forecastTaskId)
              && (ra.Actual.ActualYear == year)
              && (ra.Actual.ActualMonth == month))
              .Select(ra => ra.AllocatedAmount).Sum();


            var forecastReconciledObj = new GetResourceTimesheetsTotalsByForecast()
            {
                GetForecastActualReconcileActual = getForecastActualReconcileActual,
                //GetTotalAllocatedAmountFromReconcileActual=getTotalAllocatedAmountFromReconcileActual

            };

            return forecastReconciledObj;
        }


    }
}