using System.Collections.Generic;
using static PTApi.Services.ForecastService;

namespace PTApi.Services
{
    public interface IForecastService
    {
        IEnumerable<ForecastTaskEAC> GetLifeTimeForecast(string companyId, string projectId, string reportingperiod, string reportingyear);
    }
}
