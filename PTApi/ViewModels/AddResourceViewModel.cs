using PTApi.Models;
using System;
using System.ComponentModel.DataAnnotations;


namespace PTApi.ViewModels
{
    //[Validator(typeof(AddResourceViewModelValidator))]
    public class AddResourceViewModel
    {
      [Display(Name = "Choose a new Username for the new user")]
      public string Username { get; set; }

      [Display(Name = "New User Email Address")]
      public string ResourceEmail { get; set; }

      [Display(Name = "New User Password")]
      public string Password { get; set; }

      [Display(Name = "New User First Name")]
      public string FirstName { get; set; }

      [Display(Name = "New User Last Name")]
      public string LastName { get; set; }

      [Display(Name = "New User Permission")]
      public string AppUserRole { get; set; }

      [Display(Name = "Employment Reference Number")]
      public string EmployeeRef { get; set; }

      [Display(Name = "Resource Job Title")]
      public string EmployeeJobTitle { get; set; }

      [Display(Name = "Employee Grand Band")]
      public string EmployeeGradeBand { get; set; }

        //[Required]
      [Display(Name = "Employement Start Date")]
      public DateTime? ResourceStartDate { get; set; }

        //[Required]
        [Display(Name = "Employement End Date")]
        public DateTime? ResourceEndDate { get; set; }

        [Display(Name = "Business Domain")]
        public string Domain { get; set; }

        [Display(Name = "Business Unit")]
        public string BusinessUnit { get; set; }

        [Display(Name = "Business Platform")]
        public string CurrentPlatform { get; set; }

        [Display(Name = "Platform Lead")]
        public string PlatformLead { get; set; }

        [Display(Name = "Resource Manager")]
        public string ManagerName { get; set; }


        public string ResourceManagerId { get; set; }

        [Display(Name = "Resource Supplier")]
        public string Agency { get; set; }

        [Display(Name = "Temporal Staff")]
        public string Vendor { get; set; }

        [Display(Name = "Where is the resource based?")]
        public string LocationName { get; set; }

        [Display(Name = "Is the Resource Time Billable?")]
        public bool Billable { get; set; }

        [Display(Name = "What is the billable Hours per day?")]
        public string ContractedHours { get; set; }

        [Display(Name = "Resource rate per day")]
        public decimal? ResourceRate { get; set; }

        [Display(Name = "Resource Utilization %")]
        public decimal? ResourceContractEffortInPercentage { get; set; }

        [Display(Name = "Resource Type")]
        public string ResourceType { get; set; }

        [Display(Name = "Employment Type")]
        public string EmployeeType { get; set; }

        public string Location {get;set;}
        public string CompanyId {get;set;}

        public string IdentityId { get; set; }
        public ApplicationUser Identity { get; set; }  // navigation property

        //public IEnumerable<TimesheetCalendar> TimesheetCalendars { get; set; }
    }

}