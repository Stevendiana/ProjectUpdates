using PTApi.Models;
using System.Collections.Generic;


namespace PTApi.Services
{
    public interface IForecastService
    {
        IEnumerable<ForecastTaskEAC> GetLifeTimeForecast(string companyId, string projectId, string reportingperiod, string reportingyear);
    }
}
