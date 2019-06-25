
using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PTApi.Repositories
{
    public partial class ResourceTimesheetRepository : Repository<ResourceWorkTimesheet>, IResourceTimesheetRepository
    {
        private readonly ApplicationDbContext _appDbContext;


        public ResourceTimesheetRepository(ApplicationDbContext context)
            : base(context)
        {
            _appDbContext = context;
        }


        public IEnumerable<TimesheetCalendar> GetAllTimesheetDatesToDate()
        {
            return _appDbContext.TimesheetCalendars.Where(t => (t.Sunday <= DateTime.Today) &&
                                               ((t.SundayYear >= (DateTime.Today.Year) - 1) || (t.SaturdayYear >= (DateTime.Today.Year) - 1)))
                                               .OrderByDescending(t => t.TsId)
                                               .ToList();

        }

        public IEnumerable<ResourceWorkTimesheet> GetAllResourceWorkTimesheets(string companyId)
        {
            return _appDbContext.ResourceWorkTimesheets.Where(b => b.CompanyId == companyId).OrderByDescending(b => b.Resource).ToList();
        }


        public IEnumerable<ForecastTask> GetOneResourceTimeForecast(string resourceId, string companyId)
        {
            return _appDbContext.ForecastTasks.Include(f => f.ParentTask).Include(f => f.Project).Include(f => f.ResourceTimesheets).Where(f => f.ResourceId == resourceId)
                .Where(f => f.CompanyId == companyId).ToList().OrderByDescending(f => f.ProjectId).ThenByDescending(f => f.ParentTask);
        }


        public IEnumerable<TimesheetTotals> GetAllResourceTimesheetsToDate(string resourceId, string companyId)
        {

            return GetAllTimesheetDatesToDate().GroupJoin(GetAllResourceWorkTimesheets(companyId).Where(t => t.ResourceId == resourceId),
                t => t.Id,
                rt => rt.TimesheetCalendarTsId,
                (time, timesheets) => new Timesheets()
                {
                    CalendarTime = time,
                    ResourceTimesheets = timesheets

                }
               ).SelectMany(x => x.ResourceTimesheets.DefaultIfEmpty(),
               (a, b) => new TimesheetTotals() {

                   CalendarTimeId = a.CalendarTime.Id,
                   CalendarTime = a.CalendarTime,
                   ResourceTimesheets = a.ResourceTimesheets,
                   
                   TotalBillableHours = b == null ? 0 : b.TotalBillableHours,
                   TotalNonBillableHours = b == null ? 0 : b.TotalNonBillableHours,
                   TotalHours = b == null ? 0 : b.TotalHours,
                   TotalOvertimeBillableHours = b == null ? 0 : b.TotalOvertimeBillableHours,
                   TotalOvertimeNonBillableHours = b == null ? 0 : b.TotalOvertimeNonBillableHours,
                   TotalStandardDayBillableHours = b == null ? 0 : b.TotalStandardDayBillableHours,
                   TotalStandardDayNonBillableHours = b == null ? 0 :  b.TotalStandardDayNonBillableHours

               }).ToList();
        }




        //public ApplicationDbContext ApplicationDbContext
        //{
        //    get { return Context as ApplicationDbContext; }
        //}

        // TsId = a.CalendarTime.TsId,
        //SaturdayMonthInWords = a.CalendarTime.SaturdayMonthInWords,
        //SundayMonthInWords = a.CalendarTime.SundayMonthInWords,
        //SundayYear = a.CalendarTime.SundayYear,
        //SaturdayYear = a.CalendarTime.SaturdayYear,
        //SundayPeriod = a.CalendarTime.Id,
        //SaturdayPeriod = a.CalendarTime.Id,
        //Sunday = a.CalendarTime.Sunday,
        //Monday = a.CalendarTime.Monday,
        //Tuesday = a.CalendarTime.Tuesday,
        //Wednesday = a.CalendarTime.Wednesday,
        //Thursday = a.CalendarTime.Thursday,
        //Friday = a.CalendarTime.Friday,
        //Saturday = a.CalendarTime.Saturday,
    }


}
