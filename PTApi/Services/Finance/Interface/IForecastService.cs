using PTApi.Models;
using System.Collections.Generic;


namespace PTApi.Services
{
    public interface IForecastService
    {
        void SaveForecast(ForecastTask forecasttask, ForecastTaskEAC forecasttaskData, ForecastTask oldforecasttask, Resource resource, string reportingperiod);
        void CreateForecast(ForecastTask newforecast, ForecastTaskEAC forecasttaskData, Resource resource);
    }
}
