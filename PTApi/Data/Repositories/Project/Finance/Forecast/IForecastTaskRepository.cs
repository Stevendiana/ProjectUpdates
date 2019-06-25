using PTApi.Models;
using System.Collections.Generic;
using static PTApi.Services.ForecastService;

namespace PTApi.Data.Repositories
{
    public interface IForecastTaskRepository : IRepository<ForecastTask>
    {
        IEnumerable<ForecastTaskEAC> GetLifeTimeForecast(string companyId, string projectId, string reportingperiod, string reportingyear);


    }
}






