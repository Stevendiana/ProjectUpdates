using System;

namespace PTApi.Controllers.Resources
{
    public class ResourceTimesheetResource
    {
        public int Id { get; set; }
        public string TimesheetCalendarTsId { get; set; }
        public int ResourceId { get; set; }
        public int ProjectId { get; set; }
        public int ForecastTaskId { get; set; }
        public string TimesheetStatus { get; set; }
        public string TimesheetResourceUsername { get; set; }
        public Guid CompanyId { get; set; }
        public decimal? StandardDaySundayBillableHours { get; set; }
        public decimal? StandardDayMondayBillableHours { get; set; }
        public decimal? StandardDayTuesdayBillableHours { get; set; }
        public decimal? StandardDayWednesdayBillableHours { get; set; }
        public decimal? StandardDayThursdayBillableHours { get; set; }
        public decimal? StandardDayFridayBillableHours { get; set; }
        public decimal? StandardDaySaturdayBillableHours { get; set; }
        public decimal? TotalStandardDayBillableHours { get; set; }
        public decimal? OvertimeSundayBillableHours { get; set; }
        public decimal? OvertimeMondayBillableHours { get; set; }
        public decimal? OvertimeTuesdayBillableHours { get; set; }
        public decimal? OvertimeWednesdayBillableHours { get; set; }
        public decimal? OvertimeThursdayBillableHours { get; set; }
        public decimal? OvertimeFridayBillableHours { get; set; }
        public decimal? OvertimeSaturdayBillableHours { get; set; }
        public decimal? TotalOvertimeBillableHours { get; set; }
        public decimal? TotalBillableHours { get; set; }
        public decimal? StandardDaySundayNonBillableHours { get; set; }
        public decimal? StandardDayMondayNonBillableHours { get; set; }
        public decimal? StandardDayTuesdayNonBillableHours { get; set; }
        public decimal? StandardDayWednesdayNonBillableHours { get; set; }
        public decimal? StandardDayThursdayNonBillableHours { get; set; }
        public decimal? StandardDayFridayNonBillableHours { get; set; }
        public decimal? StandardDaySaturdayNonBillableHours { get; set; }
        public decimal? TotalStandardDayNonBillableHours { get; set; }
        public decimal? OvertimeSundayNonBillableHours { get; set; }
        public decimal? OvertimeMondayNonBillableHours { get; set; }
        public decimal? OvertimeTuesdayNonBillableHours { get; set; }
        public decimal? OvertimeWednesdayNonBillableHours { get; set; }
        public decimal? OvertimeThursdayNonBillableHours { get; set; }
        public decimal? OvertimeFridayNonBillableHours { get; set; }
        public decimal? OvertimeSaturdayNonBillableHours { get; set; }
        public decimal? TotalOvertimeNonBillableHours { get; set; }
        public decimal? TotalNonBillableHours { get; set; }
        public decimal? TotalHours { get; set; }
        public string ResourceFeedBackNote { get; set; }
        public string ApproverFeedBackNote { get; set; }

    }
}