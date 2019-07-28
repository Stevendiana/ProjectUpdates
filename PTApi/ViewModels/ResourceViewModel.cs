using PTApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace PTApi.ViewModels
{
    public class ResourceViewModel: BaseEntity
    {
        [Key]
        public string ResourceId { get; set; }
        public string ResourceNumber { get; set; }

        [Required]
        public string ResourceEmailAddress { get; set; }
        [Required]
        public string CompanyId { get; set; }
        [Required]
        public DateTime? ResourceStartDate { get; set; }
        [Required]
        public DateTime? ResourceEndDate { get; set; }
        [Required]
        public string FirstName { get; set; }

        public Platform Platform { get; set; }
        public Supplier Supplier { get; set; }
        public CompanyRateCard CompanyRateCard { get; set; }
        public Company Company { get; set; }
        public Resource ResourceManager { get; set; }


        public string EmployeeRef { get; set; }
        public string PlatformId { get; set; }
        public string Agency { get; set; }
        public string SupplierId { get; set; }

        public string LocationName { get; set; }
        public string Location { get; set; }
        public bool Billable { get; set; }
        public bool IsDisabled { get; set; }

        public string EmployeeJobTitle { get; set; }
        public string ResourceRateCardId { get; set; }

        public decimal? ContractedHours { get; set; }
        public decimal? ResourceContractEffortInPercentage { get; set; }

        public string ResourceType { get; set; }
        public string EmployeeType { get; set; }
        public string ResourceManagerId { get; set; }

        public string Note { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string IdentityId { get; set; }

        public string LastName { get; set; }
        public string ImageCaption { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
        public string ImageId { get; set; }
        public byte[] AvatarImage { get; set; }


        public string DisplayName { get { return LastName + ", " + FirstName; } }



        public bool IsAppUser { get; set; }


        public ICollection<ResourceWorkTimesheet> ResourceWorkTimesheets { get; set; }
        public ICollection<ResourceUtilizationSummary> ResourceUtilizationSummaries { get; set; }
        public ICollection<ResourceHolidayBooked> ResourceHolidaysBooked { get; set; }
        public ICollection<ForecastTask> ForecastTasks { get; set; }


        public ResourceViewModel()
        {

            ResourceWorkTimesheets = new Collection<ResourceWorkTimesheet>();
            ResourceUtilizationSummaries = new Collection<ResourceUtilizationSummary>();
            ResourceHolidaysBooked = new Collection<ResourceHolidayBooked>();
            ForecastTasks = new Collection<ForecastTask>();
        }
    }
}
