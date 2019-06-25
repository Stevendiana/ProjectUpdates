using System;
using System.ComponentModel.DataAnnotations;
using PTApi.Models;

namespace PTApi.ViewModels
{
    public class EditResourceDataViewModel: BaseEntity
    {
        public string ResourceId { get; set; }
        public string FirstName { get; set; }
        public string ResourceNumber { get; set; }
        public string LastName { get; set; }
        [Required]
        public string ResourceEmailAddress { get; set; }
        public string EmployeeRef { get; set; }
        public string EmployeeJobTitle { get; set; }
        public string EmployeeGradeBand { get; set; }
        public DateTime? ResourceStartDate { get; set; }
        public DateTime? ResourceEndDate { get; set; }
        public string Domain { get; set; }
        public string BusinessUnit { get; set; }
        public string CurrentPlatform { get; set; }
        public string PlatformLead { get; set; }
        public string ManagerName { get; set; }
        public string ResourceManagerId { get; set; }
        public string Agency { get; set; }
        public string Vendor { get; set; }
        public string LocationName { get; set; }
        public bool Billable { get; set; }
        public string ContractedHours { get; set; }
        public decimal? ResourceRate { get; set; }
        public decimal? ResourceContractEffortInPercentage { get; set; }
        public string ResourceType { get; set; }
        public string EmployeeType { get; set; }
        public string Location {get;set;}
        public string CompanyId {get;set;}
        public string ProjectId {get;set;}
        public string AppUserRole {get;set;}
        public string IdentityId { get; set; }

    }
}