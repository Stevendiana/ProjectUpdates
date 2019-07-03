using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class ForecastTaskRepository : Repository<ForecastTask>, IForecastTaskRepository
    {
        private readonly IForecastService _forecastService;

        public ForecastTaskRepository(ApplicationDbContext context, IForecastService forecastService)
            : base(context)
        {
            _forecastService = forecastService;
        }

        public IEnumerable<string> GetAllResourcesInProject(string projectsId, string companyId)
        {
            var allforecast = GetJustForecast(companyId).Where(f=>f.ProjectId==projectsId).Select(f=>f.ResourceId).ToList();
            return allforecast;
        }

        public IEnumerable<ForecastTask> GetJustForecast(string companyId)
        {
            var allforecast = ApplicationDbContext.ForecastTasks.ToList().Where(r => r.CompanyId == companyId);
            return allforecast;
        }

        public bool CheckForecastExistForResource(string resourceId, string companyId)
        {
            bool anyforecast = GetJustForecast(companyId).Any(r=>r.ResourceId == resourceId);
            return anyforecast;
        }

        public IEnumerable<ForecastTaskEAC> GetLifeTimeForecast(string companyId, string projectId, string reportingperiod, string reportingyear)
        {
            var lifetimeforecast = _forecastService.GetLifeTimeForecast(companyId, projectId, reportingperiod, reportingyear);
            return lifetimeforecast;
        }

        

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
