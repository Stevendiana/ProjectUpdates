using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectCentreBackend.Models;
using ProjectCentreBackend.Models.Entities;
using ProjectCentreBackend.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProjectCentreBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/Timesheetcalendars")]
    public class TimesheetCalendarsController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly ProjectCentreDbContext _appDbContext;

        public TimesheetCalendarsController(UserManager<AppUser> userManager, ProjectCentreDbContext appDbContext)
        {
            _userManager = userManager;
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<TimesheetCalendar>> GetTimesheetCalendars()
        {
        var timesheetCalendars = await _appDbContext.TimesheetCalendars
                                               .Where(t => (t.Sunday <= DateTime.Today) &&
                                               ((t.SundayYear >= (DateTime.Today.Year) - 1) || (t.SaturdayYear >= (DateTime.Today.Year) - 1)))
                                               .OrderByDescending(t => t.TsId)
                                               .ToListAsync();

        return timesheetCalendars;
        //return mapper.Map<List<TimesheetCalendar>, List<TimesheetResource>>(timesheetCalendars);
       }

        // public IEnumerable<TimesheetCalendarResource> GetTimesheetCalendars(string query = null)
        // {
        //     IQueryable<TimesheetCalendar> timesheetCalendarsQuery = context.TimesheetCalendars
        //          .Where(t => (t.Sunday <= DateTime.Today) &&
        //           //((t.SundayYear == DateTime.Today.Year) || (t.SaturdayYear == DateTime.Today.Year)))  /**Returns the beginning of this year till date.**/
        //           ((t.SundayYear >= (DateTime.Today.Year) - 1) || (t.SaturdayYear >= (DateTime.Today.Year) - 1)))  /**Returns the beginning of last year till date.**/
        //          .OrderByDescending(t => t.TsId);

        //     if (!String.IsNullOrWhiteSpace(query))
        //         timesheetCalendarsQuery = timesheetCalendarsQuery.Where(t => t.TsId.Contains(query));

        //     return timesheetCalendarsQuery
        //         .ToList()
        //         .Select(Mapper.Map<TimesheetCalendar, TimesheetCalendarResource>);
        // }


    }
}