using PTApi.Models;
using System.Collections.Generic;
using static PTApi.Services.ResourceService;

namespace PTApi.Services
{
    public interface IResourceService
    {
        Resource GetLoggedInUserResource();
        Resource GetResourceById(string userId, string resourceId);
        ForecastTotals GetPerResourceForecastTotals(IEnumerable<ForecastTask> forecastList);
        decimal? GetAllResourceHolidaysTotalsByMonth(string companyId, string resourceId, int? year, int? month);
        decimal? GetNumberOfWorkingDaysInMonth(int year, byte month);

        GetResourceHolidaysTotalsByResource GetResourceHolidaysTotals(string companyId, string resourceId, int? year, int? month);
        GetAllResourceUtilizationByMonth GetAllResourceUtilization(string resourceId, int? year);
        GetResourceAvailabilityAndUtility GetAllResourceAvailabilityAndUtility(string companyId, string resourceId, int? year);
        GetResourceTimesheetsTotalsByForecast GetResourceTimesheetsTotals(string companyId, string resourceId, string projectId, string forecastTaskId, int? year, int? month);
        GetResourceAvailabilityAndUtility GetAllResourceAvailabilityAndUtility(string companyId, string resourceId, int? year, int? month);
        GetResourceTimesheetsTotalsByForecast GetTotalAllocatedAmountFromReconcileActual(string companyId, string projectId, string forecastTaskId, int? year, int? month);
        ResourceUtilizationSummary CalculateResourceUtilAvail(ResourceUtilizationSummary Utility, string resid, string comp, int year, decimal resourceStandardHrs, int CompanyStandardHrs);

    }
}