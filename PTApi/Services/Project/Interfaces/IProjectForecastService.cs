using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static PTApi.Services.ProjectForecastService;


// using static ProjectCentreBackend.Core.Repositories.ProjectForecastRepository;

namespace PTApi.Services
{
    public interface IProjectForecastService
    {
         DaysPerMonth GetDaysPerMonth(int year, byte month);
         decimal GetLifetime(DateTime? projectStartDate, DateTime? projectEndDate);
         decimal GetMinActual(DateTime? minActualDate, DateTime? maxActualDate);
         decimal GetMinActualNoForecast(DateTime? minActualDateDecActualNoForecast, DateTime? maxActualDateDecActualNoForecast);
         decimal GetPercentageComplete(decimal? projectlifetime, decimal? projectdayscompleted);
         decimal GetPercentageCompleteDecActualNoForecast(decimal? projectlifetime, decimal? projectdayscompletedDecActualNoForecast);
         DateTime GetlastDayOfPreviousMonth(DateTime currentMonthForecastStartDate, int month);
         Task<IEnumerable<Forecast>> GetLifetimeforecastwithactuals(string projectId, string companyId);
         Task<IEnumerable<Forecast>> GetFutureyearfullyearforecastforallperiods(string projectId, string companyId);
         Task<IEnumerable<Forecast>> GetPastyearActuals(string projectId, string companyId, int month);
         Task<IEnumerable<Forecast>> GetCurrentyearfullActuals(string projectId, string companyId);
         Task<IEnumerable<Forecast>> GetCurrentyearfullyearforecastbyperiodsforjan(string projectId, string companyId);
         Task<IEnumerable<Forecast>> GetLifetimeforecast(string projectId, string companyId, int month);
         GetForecastAndActualMinAndMaxDates ForecastAndActual(string projectId, string companyId, int month);
         GetForecastAndActualMinAndMaxDates SumForecastAndActual(GetForecastAndActualMinAndMaxDates _summaries);

    }
}