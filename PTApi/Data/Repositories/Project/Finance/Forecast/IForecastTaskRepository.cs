using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IForecastTaskRepository : IRepository<ForecastTask>
    {
        IEnumerable<ForecastTaskEAC> GetLifeTimeForecast(string companyId, string projectId, string reportingperiod, string reportingyear);
        


    }
}






