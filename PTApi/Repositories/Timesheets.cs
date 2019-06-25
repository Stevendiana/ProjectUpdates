using PTApi.Models;
using System.Collections.Generic;


namespace PTApi.Repositories
{
    public partial class ResourceTimesheetRepository
    {
        public class Timesheets
        {
            public Timesheets()
            {
            }

            public TimesheetCalendar CalendarTime { get; set; }
            public IEnumerable<ResourceWorkTimesheet> ResourceTimesheets { get; set; }
        }

        public class TimesheetTotals
        {
            public TimesheetTotals()
            {
            }

            public int CalendarTimeId { get; set; }
            public decimal TotalBillableHours { get; set; }
            public decimal TotalNonBillableHours { get; set; }
            public decimal TotalHours { get; set; }
            public decimal TotalOvertimeBillableHours { get; set; }
            public decimal TotalOvertimeNonBillableHours { get; set; }
            public decimal TotalStandardDayBillableHours { get; set; }
            public decimal TotalStandardDayNonBillableHours { get; set; }

            public TimesheetCalendar CalendarTime { get; set; }
            public IEnumerable<ResourceWorkTimesheet> ResourceTimesheets { get; set; }

        }
    }

   
}
