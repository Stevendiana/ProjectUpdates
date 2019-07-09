using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IForecastTaskRepository : IRepository<ForecastTask>
    {
        IEnumerable<ForecastTask> GetJustForecast(string companyId);

        bool CheckForecastExistForResource(string resourceId, string companyId);
        IEnumerable<string> GetAllResourcesInProject(string projectsId, string companyId);
        IEnumerable<ForecastTaskEAC> GetLifeTimeForecast(string companyId, string projectId, string reportingperiod, string reportingyear);

        IEnumerable<ForecastTaskEAC> GetCombinedLifeTimeForecast(string companyId, string projectId, string reportingperiod, string reportingyear);
        List<ForecastTaskEAC> GetCurrentYearForecast(IEnumerable<ForecastTask> allprojectforecastLifetime, string reportingperiod, int reportingyear);
        List<ForecastTaskEAC> GetPastYearsForecast(IEnumerable<ForecastTask> allprojectforecastLifetime, string reportingperiod, int reportingyear);
        List<ForecastTaskEAC> GetFutureYearsForecast(IEnumerable<ForecastTask> allprojectforecastLifetime, string reportingperiod, int reportingyear);
        string GetResourcePerCost(ForecastTask forecast);
        decimal? GetTotalActualReconciled(IEnumerable<ForecastTask> forecast, string forecastId, int month);

    }
}






