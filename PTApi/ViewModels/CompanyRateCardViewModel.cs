

namespace PTApi.ViewModels
{
    public class CompanyRateCardViewModel
    {
        public string CompanyRateCardId { get; set; }
        public string CompanyRateCardCode { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeJobTitleOrGradeOrBand { get; set; }
        public string LocationForGradeOnshoreOffShore { get; set; }
        public bool IsContractor { get; set; }
        public decimal DailyRate { get; set; }
    }
}