using PTApi.Models;
using PTApi.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace PTApi.ViewModels
{


    public class ResourceAdminViewModel: BaseEntity
   {
        
        public string ResourceId { get; set; }
        public string ResourceNumber { get; set; }
        
        public string ResourceEmailAddress { get; set; }
        public string EmployeeRef { get; set; }
        public DateTime? ResourceStartDate { get; set; }
        public DateTime? ResourceEndDate { get; set; }

        public string PlatformId { get; set; }
        
        public string Agency { get; set; }
        public string Vendor { get; set; }
        public string LocationName { get; set; }
        public string Location { get; set; }
        public bool Billable { get; set; }
        public bool IsDisabled { get; set; }

        public string EmployeeJobTitle { get; set; }
        public string ResourceRateCardId { get; set; }
        
        public CompanyRateCard CompanyRateCard { get; set; }

        public decimal? ContractedHours { get; set; }
        public decimal? ResourceContractEffortInPercentage { get; set; }

        public string ResourceType { get; set; }
        public string EmployeeType { get; set; }

    
        public string CompanyId { get; set; }

      
        public Company Company { get; set; }
        public string ResourceManagerId { get; set; }
        
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageCaption { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
        public string ImageId { get; set; }
        public byte[] AvatarImage { get; set; }
      
        public string DisplayName { get; set; }

        public string Gender { get; set; }
        
        //public decimal? TotalForecastHours { get; }
        
        //public decimal? TotalForecastReconciledHours { get; }

    
        //public int? TotalProjectsForecastCount { get; }
       
        //public int? TotalCountProjects { get; }
       
        //public int? TotalCountProjectsPermitted { get; }
       
        //public int? TotalCountProgrammes { get; }
       
        //public int? TotalCountProgrammesPermitted { get; }
       
        //public int? TotalCountDomains { get; }
       
        //public int? TotalCountDomainsPermitted { get; }
       
        //public int? TotalCountPortfolios { get; }
       
        //public int? TotalCountPortfoliosPermitted { get; }
       
        //public int? TotalCountBusinessUnits { get; }
       
        //public int? TotalCountBusinessUnitsPermitted { get; }


        

        public bool IsAppUser { get; set; }


        //public ICollection<ResourceWorkTimesheet> ResourceWorkTimesheets { get; set; }
        //public ICollection<ResourceEffortSummary> ResourceEffortSummaries { get; set; }
        //public ICollection<ResourceHolidayBooked> ResourceHolidaysBooked { get; set; }
        //public ICollection<ForecastTask> ForecastTasks { get; set; }


        //public ResourceAdminViewModel()
        //{

        //    ResourceWorkTimesheets = new Collection<ResourceWorkTimesheet>();
        //    ResourceEffortSummaries = new Collection<ResourceEffortSummary>();
        //    ResourceHolidaysBooked = new Collection<ResourceHolidayBooked>();
        //    ForecastTasks = new Collection<ForecastTask>();
        //}
        
    }
}