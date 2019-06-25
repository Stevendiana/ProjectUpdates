using PTApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using static PTApi.Methods.GetIdsWithPartIdsMethod;
using static PTApi.Services.ProjectForecastService;

namespace PTApi.Services
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> ReadAllAsync();
        Task<Project> ReadOneAsync(string projectId);
        Task<bool> IsProjectExistsAsync(string projectId);

        Task<Project> CreateAsync(Project project);
        Task<Project> UpdateAsync(Project project);
        Task<Project> DeleteAsync(string projectId);

        DaysPerMonth GetDaysPerMonth(int year, byte month);
        decimal GetLifetime(DateTime? projectStartDate, DateTime? projectEndDate);
        int ConvertMonthWordsToNumbers(string period);
        decimal GetMinActual(DateTime? minActualDate, DateTime? maxActualDate);
        decimal GetMinActualNoForecast(DateTime? minActualDateDecActualNoForecast, DateTime? maxActualDateDecActualNoForecast);
        decimal GetPercentageComplete(decimal? projectlifetime, decimal? projectdayscompleted);
        decimal GetPercentageCompleteDecActualNoForecast(decimal? projectlifetime, decimal? projectdayscompletedDecActualNoForecast);
        GetForecastAndActualMinAndMaxDates GetForecastAndActual(string projectId, string companyId, int month);
        GetForecastAndActualMinAndMaxDates GetSumForecastAndActual(GetForecastAndActualMinAndMaxDates _summaries);
        DateTime GetlastDayOfPreviousMonth(DateTime currentMonthForecastStartDate, int month);
        string GetDisplayName( string thiscompanyId, string thisuserName);
        string GetActualCompanyId(string companyCode);
        string GetResourceDisplayName(string companyId, string userName);
        ResourceUtilization GetCompanyStandardDailyHours(string resourceId);
        string GetActualProjectId(string projectCode);
        decimal? GetTotalAllocatedAmountFromReconcileActual(string actualId, string projectId);
        ActualStartAndEndDate GetMinAndMaxActualDates(string companyId, string forecastTaskId, byte month);
        ProjectStartAndEndDate GetProjectStartAndEndDates(string companyId, string projectId);
        string CostCodeGeneration(string param, int length);
        string PartId(string param, int length);
        decimal Test(string companyId);

    }
}