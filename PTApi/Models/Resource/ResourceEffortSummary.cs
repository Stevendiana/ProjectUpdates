using PTApi.Data.Repositories;
using PTApi.Services;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTApi.Models
{
    [Table("ResourceEffortSummaries")]
  public class ResourceEffortSummary
  {

        private readonly IResourceService _resourceService;
        private readonly IProjectService _projectService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserService _userService;

        public ResourceEffortSummary (IResourceService resourceService, IProjectService projectService, IUnitOfWork unitOfWork, IUserService userService)
        {
            _resourceService = resourceService;
            _projectService = projectService;
            _unitOfWork = unitOfWork;
            _userService = userService;
        }

        public ResourceEffortSummary()
        {
 
        }


        public decimal? GetAllResourceHolidaysTotalsByMonth(string companyId, string resourceId, int? year, int? month)
        {
            return _resourceService.GetResourceHolidaysTotals(companyId, resourceId, year, month).SumResourceTotalHolidayHours;
        }

        public  decimal? GetNumberOfWorkingDaysInMonth(int year, byte month)
        {
            return _projectService.GetDaysPerMonth(year, month).WorkingdaysInMonth;
        }

       

        public decimal? GetResourceCompanyStandardDailyHours()
        {
            return Convert.ToInt32(_userService.GetSecureUserCompanyStandardHrs());
        }

        public decimal? GetResourceContractedEffortHours(string resourceId, string companyId)
        {
            return _unitOfWork.Resources.GetResourceContractedEffortHours(resourceId, companyId );
        }


        public decimal? sumJanUtilizationByMonth(string resourceId, int? year)
        {
            return _resourceService.GetAllResourceUtilization(resourceId, year).GetJanResourceUtilizationByMonth;
        }
        public decimal? sumFebUtilizationByMonth(string resourceId, int? year)
        {
            return _resourceService.GetAllResourceUtilization(resourceId, year).GetFebResourceUtilizationByMonth;
        }
        public decimal? sumMarUtilizationByMonth(string resourceId, int? year)
        {
            return _resourceService.GetAllResourceUtilization(resourceId, year).GetMarResourceUtilizationByMonth;
        }
        public decimal? sumAprUtilizationByMonth(string resourceId, int? year)
        {
            return _resourceService.GetAllResourceUtilization(resourceId, year).GetAprResourceUtilizationByMonth;
        }
        public  decimal? sumMayUtilizationByMonth(string resourceId, int? year)
        { 
            return _resourceService.GetAllResourceUtilization(resourceId, year).GetMayResourceUtilizationByMonth;
        }

        public  decimal? sumJunUtilizationByMonth(string resourceId, int? year)
        {
            return _resourceService.GetAllResourceUtilization(resourceId, year).GetJunResourceUtilizationByMonth;
        }

        public decimal? sumJulUtilizationByMonth(string resourceId, int? year)
        {
            return _resourceService.GetAllResourceUtilization(resourceId, year).GetJulResourceUtilizationByMonth;
        }

        public  decimal? sumAugUtilizationByMonth(string resourceId, int? year)
        {
            return _resourceService.GetAllResourceUtilization(resourceId, year).GetAugResourceUtilizationByMonth;
        }

        public  decimal? sumSepUtilizationByMonth(string resourceId, int? year)
        {
            return _resourceService.GetAllResourceUtilization(resourceId, year).GetSepResourceUtilizationByMonth;
        }

        public  decimal? sumOctUtilizationByMonth(string resourceId, int? year)
        {
            return _resourceService.GetAllResourceUtilization(resourceId, year).GetOctResourceUtilizationByMonth;
        }

        public  decimal? sumNovUtilizationByMonth(string resourceId, int? year)
        {
            return _resourceService.GetAllResourceUtilization(resourceId, year).GetNovResourceUtilizationByMonth;
        }

        public  decimal? sumDecUtilizationByMonth(string resourceId, int? year)
        {
            return _resourceService.GetAllResourceUtilization(resourceId, year).GetDecResourceUtilizationByMonth;
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ResourceEffortSummaryId { get; set; }
        public int Year { get; set; }

        public decimal? JanResourceUtilizationInDays { get { return sumJanUtilizationByMonth(ResourceId, Year); } }
        public decimal? FebResourceUtilizationInDays { get { return sumFebUtilizationByMonth(ResourceId, Year); } }
        public decimal? MarResourceUtilizationInDays { get { return sumMarUtilizationByMonth(ResourceId, Year); } }
        public decimal? AprResourceUtilizationInDays { get { return sumAprUtilizationByMonth(ResourceId, Year); } }
        public decimal? MayResourceUtilizationInDays { get { return sumMayUtilizationByMonth(ResourceId, Year); } }
        public decimal? JunResourceUtilizationInDays { get { return sumJunUtilizationByMonth(ResourceId, Year); } }
        public decimal? JulResourceUtilizationInDays { get { return sumJulUtilizationByMonth(ResourceId, Year); } }
        public decimal? AugResourceUtilizationInDays { get { return sumAugUtilizationByMonth(ResourceId, Year); } }
        public decimal? SepResourceUtilizationInDays { get { return sumSepUtilizationByMonth(ResourceId, Year); } }
        public decimal? OctResourceUtilizationInDays { get { return sumOctUtilizationByMonth(ResourceId, Year); } }
        public decimal? NovResourceUtilizationInDays { get { return sumNovUtilizationByMonth(ResourceId, Year); } }
        public decimal? DecResourceUtilizationInDays { get { return sumDecUtilizationByMonth(ResourceId, Year); } }

        // Schedule - Actual Days taken From ForecastTaskTimesheet
        public decimal? TotalUtilizationInDays
        {
            get
            {
                return JanResourceUtilizationInDays + FebResourceUtilizationInDays + MarResourceUtilizationInDays + AprResourceUtilizationInDays
                      + MayResourceUtilizationInDays + JunResourceUtilizationInDays + JulResourceUtilizationInDays + AugResourceUtilizationInDays
                      + SepResourceUtilizationInDays + OctResourceUtilizationInDays + NovResourceUtilizationInDays + DecResourceUtilizationInDays;
            }
        }

        //standard daily hours = 8hrs.

        public decimal? JanAvailabilityBeforeHolidaysInDays { get { return (GetNumberOfWorkingDaysInMonth(Year, 1) * (GetResourceContractedEffortHours(ResourceId, CompanyId) / GetResourceCompanyStandardDailyHours())); } }
        public decimal? FebAvailabilityBeforeHolidaysInDays { get { return (GetNumberOfWorkingDaysInMonth(Year, 2) * (GetResourceContractedEffortHours(ResourceId, CompanyId) / GetResourceCompanyStandardDailyHours())); } }
        public decimal? MarAvailabilityBeforeHolidaysInDays { get { return (GetNumberOfWorkingDaysInMonth(Year, 3) * (GetResourceContractedEffortHours(ResourceId, CompanyId) / GetResourceCompanyStandardDailyHours())); } }
        public decimal? AprAvailabilityBeforeHolidaysInDays { get { return (GetNumberOfWorkingDaysInMonth(Year, 4) * (GetResourceContractedEffortHours(ResourceId, CompanyId) / GetResourceCompanyStandardDailyHours())); } }
        public decimal? MayAvailabilityBeforeHolidaysInDays { get { return (GetNumberOfWorkingDaysInMonth(Year, 5) * (GetResourceContractedEffortHours(ResourceId, CompanyId) / GetResourceCompanyStandardDailyHours())); } }
        public decimal? JunAvailabilityBeforeHolidaysInDays { get { return (GetNumberOfWorkingDaysInMonth(Year, 6) * (GetResourceContractedEffortHours(ResourceId, CompanyId) / GetResourceCompanyStandardDailyHours())); } }
        public decimal? JulAvailabilityBeforeHolidaysInDays { get { return (GetNumberOfWorkingDaysInMonth(Year, 7) * (GetResourceContractedEffortHours(ResourceId, CompanyId) / GetResourceCompanyStandardDailyHours())); } }
        public decimal? AugAvailabilityBeforeHolidaysInDays { get { return (GetNumberOfWorkingDaysInMonth(Year, 8) * (GetResourceContractedEffortHours(ResourceId, CompanyId) / GetResourceCompanyStandardDailyHours())); } }
        public decimal? SepAvailabilityBeforeHolidaysInDays { get { return (GetNumberOfWorkingDaysInMonth(Year, 9) * (GetResourceContractedEffortHours(ResourceId, CompanyId) / GetResourceCompanyStandardDailyHours())); } }
        public decimal? OctAvailabilityBeforeHolidaysInDays { get { return (GetNumberOfWorkingDaysInMonth(Year, 10) * (GetResourceContractedEffortHours(ResourceId, CompanyId) / GetResourceCompanyStandardDailyHours())); } }
        public decimal? NovAvailabilityBeforeHolidaysInDays { get { return (GetNumberOfWorkingDaysInMonth(Year, 11) * (GetResourceContractedEffortHours(ResourceId, CompanyId) / GetResourceCompanyStandardDailyHours())); } }
        public decimal? DecAvailabilityBeforeHolidaysInDays { get { return (GetNumberOfWorkingDaysInMonth(Year, 12) * (GetResourceContractedEffortHours(ResourceId, CompanyId) / GetResourceCompanyStandardDailyHours())); } }

        public decimal? TotalAvailabilityBeforeHolidaysInDays
        {
            get
            {
                return JanAvailabilityBeforeHolidaysInDays + FebAvailabilityBeforeHolidaysInDays + MarAvailabilityBeforeHolidaysInDays + AprAvailabilityBeforeHolidaysInDays
                      + MayAvailabilityBeforeHolidaysInDays + JunAvailabilityBeforeHolidaysInDays + JulAvailabilityBeforeHolidaysInDays + AugAvailabilityBeforeHolidaysInDays
                      + SepAvailabilityBeforeHolidaysInDays + OctAvailabilityBeforeHolidaysInDays + NovAvailabilityBeforeHolidaysInDays + DecAvailabilityBeforeHolidaysInDays;
            }
        }

        public decimal? JanTotalHolidays { get { return GetAllResourceHolidaysTotalsByMonth(CompanyId, ResourceId, Year, 1); } }
        public decimal? FebTotalHolidays { get { return GetAllResourceHolidaysTotalsByMonth(CompanyId, ResourceId, Year, 2); } }
        public decimal? MarTotalHolidays { get { return GetAllResourceHolidaysTotalsByMonth(CompanyId, ResourceId, Year, 3); } }
        public decimal? AprTotalHolidays { get { return GetAllResourceHolidaysTotalsByMonth(CompanyId, ResourceId, Year, 4); } }
        public decimal? MayTotalHolidays { get { return GetAllResourceHolidaysTotalsByMonth(CompanyId, ResourceId, Year, 5); } }
        public decimal? JunTotalHolidays { get { return GetAllResourceHolidaysTotalsByMonth(CompanyId, ResourceId, Year, 6); } }
        public decimal? JulTotalHolidays { get { return GetAllResourceHolidaysTotalsByMonth(CompanyId, ResourceId, Year, 7); } }
        public decimal? AugTotalHolidays { get { return GetAllResourceHolidaysTotalsByMonth(CompanyId, ResourceId, Year, 8); } }
        public decimal? SepTotalHolidays { get { return GetAllResourceHolidaysTotalsByMonth(CompanyId, ResourceId, Year, 9); } }
        public decimal? OctTotalHolidays { get { return GetAllResourceHolidaysTotalsByMonth(CompanyId, ResourceId, Year, 10); } }
        public decimal? NovTotalHolidays { get { return GetAllResourceHolidaysTotalsByMonth(CompanyId, ResourceId, Year, 11); } }
        public decimal? DecTotalHolidays { get { return GetAllResourceHolidaysTotalsByMonth(CompanyId, ResourceId, Year, 12); } }


        public decimal? JanAvailabilityAfterHolidaysInDays { get { return JanAvailabilityBeforeHolidaysInDays - JanTotalHolidays; } }
        public decimal? FebAvailabilityAfterHolidaysInDays { get { return FebAvailabilityBeforeHolidaysInDays - FebTotalHolidays; } }
        public decimal? MarAvailabilityAfterHolidaysInDays { get { return MarAvailabilityBeforeHolidaysInDays - MarTotalHolidays; } }
        public decimal? AprAvailabilityAfterHolidaysInDays { get { return AprAvailabilityBeforeHolidaysInDays - AprTotalHolidays; } }
        public decimal? MayAvailabilityAfterHolidaysInDays { get { return MayAvailabilityBeforeHolidaysInDays - MayTotalHolidays; } }
        public decimal? JunAvailabilityAfterHolidaysInDays { get { return JunAvailabilityBeforeHolidaysInDays - JunTotalHolidays; } }
        public decimal? JulAvailabilityAfterHolidaysInDays { get { return JulAvailabilityBeforeHolidaysInDays - JulTotalHolidays; } }
        public decimal? AugAvailabilityAfterHolidaysInDays { get { return AugAvailabilityBeforeHolidaysInDays - AugTotalHolidays; } }
        public decimal? SepAvailabilityAfterHolidaysInDays { get { return SepAvailabilityBeforeHolidaysInDays - SepTotalHolidays; } }
        public decimal? OctAvailabilityAfterHolidaysInDays { get { return OctAvailabilityBeforeHolidaysInDays - OctTotalHolidays; } }
        public decimal? NovAvailabilityAfterHolidaysInDays { get { return NovAvailabilityBeforeHolidaysInDays - NovTotalHolidays; } }
        public decimal? DecAvailabilityAfterHolidaysInDays { get { return DecAvailabilityBeforeHolidaysInDays - DecTotalHolidays; } }


        // Schedule - Actual Days taken From ResourceWorkTimesheet
        public decimal? TotalAvailabilityAfterHolidaysInDays
        {
            get
            {
                return JanAvailabilityAfterHolidaysInDays + FebAvailabilityAfterHolidaysInDays + MarAvailabilityAfterHolidaysInDays + AprAvailabilityAfterHolidaysInDays
                      + MayAvailabilityAfterHolidaysInDays + JunAvailabilityAfterHolidaysInDays + JulAvailabilityAfterHolidaysInDays + AugAvailabilityAfterHolidaysInDays
                      + SepAvailabilityAfterHolidaysInDays + OctAvailabilityAfterHolidaysInDays + NovAvailabilityAfterHolidaysInDays + DecAvailabilityAfterHolidaysInDays;
            }
        }

        public decimal? JanUtilizationPercentage { get { return (JanResourceUtilizationInDays / JanAvailabilityAfterHolidaysInDays); } }
        public decimal? FebUtilizationPercentage { get { return (FebResourceUtilizationInDays / FebAvailabilityAfterHolidaysInDays); } }
        public decimal? MarUtilizationPercentage { get { return (MarResourceUtilizationInDays / MarAvailabilityAfterHolidaysInDays); } }
        public decimal? AprUtilizationPercentage { get { return (AprResourceUtilizationInDays / AprAvailabilityAfterHolidaysInDays); } }
        public decimal? MayUtilizationPercentage { get { return (MayResourceUtilizationInDays / MayAvailabilityAfterHolidaysInDays); } }
        public decimal? JunUtilizationPercentage { get { return (JunResourceUtilizationInDays / JunAvailabilityAfterHolidaysInDays); } }
        public decimal? JulUtilizationPercentage { get { return (JulResourceUtilizationInDays / JulAvailabilityAfterHolidaysInDays); } }
        public decimal? AugUtilizationPercentage { get { return (AugResourceUtilizationInDays / AugAvailabilityAfterHolidaysInDays); } }
        public decimal? SepUtilizationPercentage { get { return (SepResourceUtilizationInDays / SepAvailabilityAfterHolidaysInDays); } }
        public decimal? OctUtilizationPercentage { get { return (OctResourceUtilizationInDays / OctAvailabilityAfterHolidaysInDays); } }
        public decimal? NovUtilizationPercentage { get { return (NovResourceUtilizationInDays / NovAvailabilityAfterHolidaysInDays); } }
        public decimal? DecUtilizationPercentage { get { return (DecResourceUtilizationInDays / DecAvailabilityAfterHolidaysInDays); } }


       
    public string CompanyId { get; set; }
    public Company Company { get; set; }
    public string ResourceId { get; set; }
    public Resource Resource { get; set; }
  }
}