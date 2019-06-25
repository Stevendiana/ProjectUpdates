using PTApi.Services;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTApi.Models
{
    [Table("ReconciledActuals")]
    public class ReconciledActual
    {
        private readonly IUserService _userService;

        public ReconciledActual(IUserService userService)
        {
            _userService = userService;
        }
        public ReconciledActual()
        {
        }


        public static decimal GetBusinessDays(DateTime startD, DateTime endD)
        {
                decimal calcBusinessDays =Convert.ToDecimal( 1 + ((endD - startD).TotalDays * 5 -
                (startD.DayOfWeek - endD.DayOfWeek) * 2) / 7)
               ;

           if (endD.DayOfWeek == DayOfWeek.Saturday) calcBusinessDays--;
           if (startD.DayOfWeek == DayOfWeek.Sunday) calcBusinessDays--;

           return calcBusinessDays;
        }


        // public static decimal? GetCompanyStandardHours(string resourceId){

        //    GetIdsWithPartIds getIdsWithPartIds = new GetIdsWithPartIds();
        //    return getIdsWithPartIds.GetCompanyStandardDailyHours(resourceId).ResourceCompanyStandardHours;
        // }


         // Automatically calculates all ForecastTaskActual with similar Actualid from the ForecastTask table and returns total.

        [Key]
        [Required]
        public string ActualId { get; set; }
        [Key]
        [Required]
        public string ForecastTaskId { get; set; }
        [Required]
        public string ProjectId { get; set; }
        [Required]
        public string CompanyId { get; set; }
      
        public Project Project { get; set; }
        public Company Company { get; set; }
        public decimal? AllocatedAmount { get; set; }
        public ForecastTask ForecastTask { get; set; }
        public Actual Actual { get; set; }

        public DateTime ActualDateFrom { get; set; }
        public DateTime ActualDateTo { get; set; }


        public decimal? ActualDurationInDays { get{return Convert.ToDecimal((ActualDateTo.Date - ActualDateFrom.Date).TotalDays);} }
        public decimal? ActualDurationInHours { get{return (Convert.ToDecimal((ActualDateTo.Date - ActualDateFrom.Date).TotalDays))*Convert.ToInt32(_userService.GetSecureUserCompanyStandardHrs());} }
        // public decimal? ActualDurationInHours { get{return (Convert.ToDecimal((ActualDateTo.Date - ActualDateFrom.Date).TotalDays))* GetCompanyStandardHours(ForecastTask.ResourceId);} }
        public decimal? ActualDurationInDaysWorkingDays { get{return GetBusinessDays(ActualDateFrom, ActualDateTo);} }
        public decimal? ActualDurationInDaysWorkingDaysHours { get{return GetBusinessDays(ActualDateFrom, ActualDateTo)* Convert.ToInt32(_userService.GetSecureUserCompanyStandardHrs());} }
        // public decimal? ActualDurationInDaysWorkingDaysHours { get{return GetBusinessDays(ActualDateFrom, ActualDateTo)* GetCompanyStandardHours(ForecastTask.ResourceId);} }


    }
}