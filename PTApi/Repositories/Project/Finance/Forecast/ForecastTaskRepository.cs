using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;

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
