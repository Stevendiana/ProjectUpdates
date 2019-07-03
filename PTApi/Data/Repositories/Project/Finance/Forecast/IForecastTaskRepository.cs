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
       

    }
}






