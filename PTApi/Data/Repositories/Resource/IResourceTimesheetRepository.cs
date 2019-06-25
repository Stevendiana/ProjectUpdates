using PTApi.Models;
using System.Collections.Generic;
using static PTApi.Repositories.ResourceTimesheetRepository;

namespace PTApi.Data.Repositories
{
    public interface IResourceTimesheetRepository : IRepository<ResourceWorkTimesheet>
    {
        IEnumerable<TimesheetCalendar> GetAllTimesheetDatesToDate();
        IEnumerable<ResourceWorkTimesheet> GetAllResourceWorkTimesheets(string companyId);
        IEnumerable<TimesheetTotals> GetAllResourceTimesheetsToDate(string resourceId, string companyId);
        IEnumerable<ForecastTask> GetOneResourceTimeForecast(string resourceId, string companyId);


    }
}







