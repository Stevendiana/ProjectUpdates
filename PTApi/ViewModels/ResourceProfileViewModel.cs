using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using PTApi.Models;

namespace PTApi.ViewModels
{
    public class ResourceProfileViewModel
    {
        public string ResourceId { get; set; }
        public string ResourceEmailAddress { get; set; }
        public string CompanyId { get; set; }
        public string AppUserRole {get;set;}
        public Company Company { get; set; }
        public Project Project { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName
        {
            get { return LastName + "," + " " + FirstName; }
        }

        public ICollection<BusinessUnit> BusinessUnits { get; set; }
        public ICollection<Domain> Domains { get; set; }
        public ICollection<Portfolio> Portfolios { get; set; }
        public ICollection<Programme> Programmes { get; set; }
        public ICollection<Project> Projects { get; set; }

        public ICollection<KeyValuePairViewModel> BusinessUnitsPermitted { get; set; }
        public ICollection<KeyValuePairViewModel> DomainsPermitted { get; set; }
        public ICollection<KeyValuePairViewModel> PortfoliosPermitted { get; set; }
        public ICollection<KeyValuePairViewModel> ProgrammesPermitted { get; set; }
        public ICollection<ProjectsPermitted> ProjectsPermitted { get; set; }
        public ICollection<ResourceWorkTimesheet> ResourceWorkTimesheets { get; set; }
        public ResourceProfileViewModel()
        {

            BusinessUnitsPermitted = new Collection<KeyValuePairViewModel>();
            DomainsPermitted = new Collection<KeyValuePairViewModel>();
            PortfoliosPermitted = new Collection<KeyValuePairViewModel>();
            ProgrammesPermitted = new Collection<KeyValuePairViewModel>();
            ProjectsPermitted = new Collection<ProjectsPermitted>();
            ResourceWorkTimesheets = new Collection<ResourceWorkTimesheet>();

            BusinessUnits = new Collection<BusinessUnit>();
            Domains = new Collection<Domain>();
            Portfolios = new Collection<Portfolio>();
            Programmes = new Collection<Programme>();
            Projects = new Collection<Project>();
        }  // navigation property
    }
}