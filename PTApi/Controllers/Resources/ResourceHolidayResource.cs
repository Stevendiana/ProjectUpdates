using System;

namespace PTApi.Controllers.Resources
{
    public class ResourceHolidayResource
    {
        public int Id { get; set; }
        public string TimesheetCalendarTsId { get; set; }
        public int ResourceId { get; set; }
        public Guid CompanyId { get; set; }
        public string HolidayStatus { get; set; }
        public string HolidayResourceUsername { get; set; }
        public string HolidayCompanyId { get; set; }
        public decimal? SundayHolidayHours { get; set; }
        public decimal? MondayHolidayHours { get; set; }
        public decimal? TuesdayHolidayHours { get; set; }
        public decimal? WednesdayHolidayHours { get; set; }
        public decimal? ThursdayHolidayHours { get; set; }
        public decimal? FridayHolidayHours { get; set; }
        public decimal? SaturdayHolidayHours { get; set; }
        public decimal? TotalHolidayHours { get; set; }
        public string ResourceFeedBackNote { get; set; }
        public string ApproverFeedBackNote { get; set; }
        
    }
}