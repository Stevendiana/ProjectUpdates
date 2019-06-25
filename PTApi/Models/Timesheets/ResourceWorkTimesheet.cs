using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTApi.Models
{
    [Table("ResourceWorkTimesheets")]
    public class ResourceWorkTimesheet
    {

        //decimal sumBillableHours = SummaryList.Select(x => x.Marks).Sum();
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ResourceWorkTimesheetId { get; set; }
        public string TimesheetStatus { get; set; }

        public decimal StandardDaySundayBillableHours { get; set; }
        public decimal StandardDayMondayBillableHours { get; set; }
        public decimal StandardDayTuesdayBillableHours { get; set; }
        public decimal StandardDayWednesdayBillableHours { get; set; }
        public decimal StandardDayThursdayBillableHours { get; set; }
        public decimal StandardDayFridayBillableHours { get; set; }
        public decimal StandardDaySaturdayBillableHours { get; set; }

        [NotMapped]
        public decimal TotalStandardDayBillableHours
        {
             get{return StandardDaySundayBillableHours + StandardDayMondayBillableHours + StandardDayTuesdayBillableHours
                      + StandardDayWednesdayBillableHours + StandardDayThursdayBillableHours + StandardDayFridayBillableHours +  StandardDaySaturdayBillableHours; }
        }

        public decimal OvertimeSundayBillableHours { get; set; }
        public decimal OvertimeMondayBillableHours { get; set; }
        public decimal OvertimeTuesdayBillableHours { get; set; }
        public decimal OvertimeWednesdayBillableHours { get; set; }
        public decimal OvertimeThursdayBillableHours { get; set; }
        public decimal OvertimeFridayBillableHours { get; set; }
        public decimal OvertimeSaturdayBillableHours { get; set; }
        [NotMapped]
        public decimal TotalOvertimeBillableHours
        {
            get{return OvertimeSundayBillableHours + OvertimeMondayBillableHours + OvertimeTuesdayBillableHours
                     + OvertimeWednesdayBillableHours + OvertimeThursdayBillableHours + OvertimeFridayBillableHours +  OvertimeSaturdayBillableHours; }
        }
        [NotMapped]
        public decimal TotalBillableHours
        {
            get{return TotalStandardDayBillableHours + TotalOvertimeBillableHours; }
        }

        public decimal StandardDaySundayNonBillableHours { get; set; }
        public decimal StandardDayMondayNonBillableHours { get; set; }
        public decimal StandardDayTuesdayNonBillableHours { get; set; }
        public decimal StandardDayWednesdayNonBillableHours { get; set; }
        public decimal StandardDayThursdayNonBillableHours { get; set; }
        public decimal StandardDayFridayNonBillableHours { get; set; }
        public decimal StandardDaySaturdayNonBillableHours { get; set; }

        [NotMapped]
        public decimal TotalStandardDayNonBillableHours
        {
             get{return StandardDaySundayNonBillableHours + StandardDayMondayNonBillableHours + StandardDayTuesdayNonBillableHours
                      + StandardDayWednesdayNonBillableHours + StandardDayThursdayNonBillableHours + StandardDayFridayNonBillableHours +  StandardDaySaturdayNonBillableHours; }
        }

        public decimal OvertimeSundayNonBillableHours { get; set; }
        public decimal OvertimeMondayNonBillableHours { get; set; }
        public decimal OvertimeTuesdayNonBillableHours { get; set; }
        public decimal OvertimeWednesdayNonBillableHours { get; set; }
        public decimal OvertimeThursdayNonBillableHours { get; set; }
        public decimal OvertimeFridayNonBillableHours { get; set; }
        public decimal OvertimeSaturdayNonBillableHours { get; set; }

        [NotMapped]
        public decimal TotalOvertimeNonBillableHours
        {
            get{return OvertimeSundayNonBillableHours + OvertimeMondayNonBillableHours + OvertimeTuesdayNonBillableHours
                      + OvertimeWednesdayNonBillableHours + OvertimeThursdayNonBillableHours + OvertimeFridayNonBillableHours +  OvertimeSaturdayNonBillableHours; }
        }
        [NotMapped]
        public decimal TotalNonBillableHours
        {
            get{return TotalStandardDayNonBillableHours + TotalOvertimeNonBillableHours; }

        }

        [NotMapped]
        public decimal TotalHours
        {
            get{return TotalBillableHours + TotalNonBillableHours; }

        }


        public string ResourceFeedBackNote { get; set; }
        public string ApproverFeedBackNote { get; set; }

        public string ResourceId { get; set; }
        public Resource Resource { get; set; }
        public string CompanyId { get; set; }
        public Company Company { get; set; }
        public string ProjectId { get; set; }
        public Project Project { get; set; }
        public string ForecastTaskId { get; set; }
        public ForecastTask ForecastTask { get; set; }
        public int TimesheetCalendarTsId { get; set; }
        public TimesheetCalendar TimesheetCalendar { get; set; }
    }
}