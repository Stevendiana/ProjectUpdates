using PTApi.Methods;
using PTApi.Models;


namespace PTApi.ViewModels
{
    public class ResourceHolidayViewModel
    {
        private static string CreateNewId(string supplierId, int length)
        {
            GeneratePublicIdMethod generatePublicId = new GeneratePublicIdMethod();
            return generatePublicId.PartId(supplierId, 8);
        }

        public string HolidayBookingCode
        {
            get { return "HOLS" + "-" + CreateNewId(ResourceHolidayBookedId, 8).ToUpper(); }
        }

        public string ResourceHolidayBookedId { get; set; }
        public string HolidayStatus { get; set; }
        public decimal? SundayHolidayHours { get; set; }
        public decimal? MondayHolidayHours { get; set; }
        public decimal? TuesdayHolidayHours { get; set; }
        public decimal? WednesdayHolidayHours { get; set; }
        public decimal? ThursdayHolidayHours { get; set; }
        public decimal? FridayHolidayHours { get; set; }
        public decimal? SaturdayHolidayHours { get; set; }

        public decimal? TotalHolidayHours
        {
            get{return SundayHolidayHours + MondayHolidayHours + TuesdayHolidayHours
                      + WednesdayHolidayHours + ThursdayHolidayHours + FridayHolidayHours +  SaturdayHolidayHours; }
        }

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