using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTApi.Models
{
    [Table("ResourceHolidaysBooked")]
    public class ResourceHolidayBooked
    {

        [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ResourceHolidayBookedId { get; set; }
        public string HolidayBookingCode { get; set; }
        public string HolidayStatus { get; set; }
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
        public string CompanyId { get; set; }
        public Company Company { get; set; }
        public string ResourceId { get; set; }
        public Resource Resource { get; set; }
        public int TimesheetCalendarTsId { get; set; }
        public TimesheetCalendar TimesheetCalendar { get; set; }
    }
}