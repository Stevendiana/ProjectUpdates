using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PTApi.Controllers.Resources
{
    public class TimesheetResource
    {
        public TimesheetResource()
        {
            ForecastTasks = new Collection<ForecastTaskResource>();
            // ResourceHolidaysBooked = new Collection<ResourceHolidayResource>();
            // ResourceWorkTimesheets = new Collection<ResourceTimesheetResource>();
        }

        public int Id { get; set; }
        public string TsId { get; set; }
        public int SundayYear { get; set; }
        public int SaturdayYear { get; set; }
        public int SundayPeriod { get; set; }
        public int SaturdayPeriod { get; set; }
        public DateTime? Sunday { get; set; }
        public DateTime? Monday { get; set; }
        public DateTime? Tuesday { get; set; }
        public DateTime? Wednesday { get; set; }
        public DateTime? Thursday { get; set; }
        public DateTime? Friday { get; set; }
        public DateTime? Saturday { get; set; }
        public ICollection<ForecastTaskResource> ForecastTasks { get; set; }
        // public ICollection<ResourceTimesheetResource> ResourceWorkTimesheets { get; set; }
        // public ICollection<ResourceHolidayResource> ResourceHolidaysBooked { get; set; }

    }
}