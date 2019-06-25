using PTApi.Methods;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTApi.Models
{
    [Table("TimesheetCalendars")]
    public class TimesheetCalendar
    {
        public TimesheetCalendar()
        {
            ForecastTasks = new Collection<ForecastTask>();
            ResourceHolidaysBooked = new Collection<ResourceHolidayBooked>();
            ResourceWorkTimesheets = new Collection<ResourceWorkTimesheet>();
        }

        public static string WriteMonthInWords(int period){

            GeneratePublicIdMethod convert = new GeneratePublicIdMethod();
           return convert.ConvertMonthNumbersToWords(period);
        }


        public int Id { get; set; }

        [Required]
        public string TsId { get; set;}
        //
        public string SaturdayMonthInWords { get{return WriteMonthInWords(SaturdayPeriod);} }
        public string SundayMonthInWords { get{return WriteMonthInWords(SundayPeriod);} }

        [Required]
        public int SundayYear { get; set; }
        public int SaturdayYear { get; set; }
        public int SundayPeriod { get; set; }
        public int SaturdayPeriod { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime? Sunday { get; set; }

        [Required]
        public DateTime? Monday { get; set; }

        [Required]
        public DateTime? Tuesday { get; set; }

        [Required]
        public DateTime? Wednesday { get; set; }

        [Required]
        public DateTime? Thursday { get; set; }

        [Required]
        public DateTime? Friday { get; set; }

        [Required]
        public DateTime? Saturday { get; set; }
        public ICollection<ForecastTask> ForecastTasks { get; set; }
        public ICollection<ResourceWorkTimesheet> ResourceWorkTimesheets { get; set; }
        public ICollection<ResourceHolidayBooked> ResourceHolidaysBooked { get; set; }

    }
}