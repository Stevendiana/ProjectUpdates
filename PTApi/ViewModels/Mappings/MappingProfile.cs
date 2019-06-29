using AutoMapper;
using PTApi.Controllers.Resources;
using PTApi.Models;
using PTApi.Services;
using System.Linq;
using static PTApi.Controllers.AssumptionsController;
using static PTApi.Controllers.BusinessUnitsController;
using static PTApi.Controllers.CompanyRateCardsController;
using static PTApi.Controllers.DependenciesController;
using static PTApi.Controllers.DomainsController;
using static PTApi.Controllers.IssuesController;
using static PTApi.Controllers.NotificationsController;
using static PTApi.Controllers.PlatformsController;
using static PTApi.Controllers.PortfoliosController;
using static PTApi.Controllers.ProgrammesController;
using static PTApi.Controllers.ProjectsController;
using static PTApi.Controllers.RagsController;
using static PTApi.Controllers.ResourcesController;
using static PTApi.Controllers.RisksController;
using static PTApi.Controllers.UploadActualsController;
using static PTApi.Services.ProjectForecastService;
using ForecastTaskEAC = PTApi.Models.ForecastTaskEAC;
using ProjectData = PTApi.Controllers.NotificationsController.ProjectData;

namespace PTApi.ViewModels.Mappings
{
    public class MappingProfile : Profile
    {
        private readonly IProjectService _projectService;
        private readonly IUserService _userService;
        private readonly IResourceService _resourceService;

        public MappingProfile(IProjectService projectService, IUserService userService, IResourceService resourceService)
        {
            _projectService = projectService;
            _userService = userService;
            _resourceService = resourceService;
        }
        public MappingProfile()
        {
            // Domain to API Resource

            CreateMap<Resource, ResourceViewModel>()
            .ForMember(dto => dto.ResourceId, map => map.MapFrom(src => src.ResourceId))
            .ForMember(dto => dto.Identity, opt => opt.MapFrom(src => src.Identity))
            .ForMember(dto => dto.Company, opt => opt.MapFrom(src => src.Company))
            .ForMember(dto => dto.CompanyRateCard, opt => opt.MapFrom(src => src.CompanyRateCard));

            CreateMap<ProjectBudget, ProjectBudgetViewModel>()
            .ForMember(dto => dto.ProjectBudgetId, map => map.MapFrom(src => src.ProjectBudgetId))
            .ForMember(vr => vr.Resource, opt => opt.MapFrom(v => v.Resource))
            .ForMember(vr => vr.Supplier, opt => opt.MapFrom(v => v.Supplier))
            .ForMember(vr => vr.ForecastTask, opt => opt.MapFrom(v => v.ForecastTask))
            .ForMember(dto => dto.ReconciledActuals, opt => opt.MapFrom(src => src.ReconciledActuals));

            CreateMap<ForecastTaskEAC, ProjectBudget>()
            .ForMember(p => p.ProjectBudgetId, opt => opt.Ignore())
            .ForMember(dto => dto.ForecastTaskId, map => map.MapFrom(src => src.ForecastTaskId))
            .ForMember(vr => vr.Resource, opt => opt.MapFrom(v => v.Resource))
            .ForMember(vr => vr.Supplier, opt => opt.MapFrom(v => v.Supplier))
            //.ForMember(vr => vr.ForecastTask, opt => opt.MapFrom(v => v.ForecastTask))
            .ForMember(dto => dto.ReconciledActuals, opt => opt.MapFrom(src => src.ReconciledActuals));

            CreateMap<ProjectRagStatus, RagViewModel>()
            .ForMember(dto => dto.ProjectRagStatusId, map => map.MapFrom(src => src.ProjectRagStatusId))
            .ForMember(vr => vr.Company, opt => opt.MapFrom(v => v.Company))
            .ForMember(vr => vr.Project, opt => opt.MapFrom(v => v.Project));

            CreateMap<ProjectRagStatus, EditRagData>()
             .ForMember(b => b.ProjectRagStatusId, map => map.MapFrom(vm => vm.ProjectRagStatusId));

            CreateMap<Risk, RiskViewModel>()
            .ForMember(dto => dto.RiskId, map => map.MapFrom(src => src.RiskId));
            CreateMap<Risk, EditRiskData>()
            .ForMember(dto => dto.RiskId, map => map.MapFrom(src => src.RiskId));

            CreateMap<Assumption, AssumptionViewModel>()
            .ForMember(dto => dto.AssumptionId, map => map.MapFrom(src => src.AssumptionId));
            CreateMap<Assumption, EditAssumptionData>()
            .ForMember(dto => dto.AssumptionId, map => map.MapFrom(src => src.AssumptionId));

            CreateMap<Issue, IssueViewModel>()
            .ForMember(dto => dto.IssueId, map => map.MapFrom(src => src.IssueId));
            CreateMap<Issue, EditIssueData>()
           .ForMember(dto => dto.IssueId, map => map.MapFrom(src => src.IssueId));

            CreateMap<Dependency, DependencyViewModel>()
            .ForMember(dto => dto.DependencyId, map => map.MapFrom(src => src.DependencyId));
            CreateMap<Dependency, EditDependencyData>()
            .ForMember(dto => dto.DependencyId, map => map.MapFrom(src => src.DependencyId));

            CreateMap<CompanyMethodology, CompanyMethodologyViewModel>()
            .ForMember(vm => vm.CompanyMethodologyId, map => map.MapFrom(b => b.CompanyMethodologyId))
            .ForMember(vm => vm.CompanyMethodologyStages, opt => opt.MapFrom(b => b.CompanyMethodologyStages));

            CreateMap<ChangeLog, ChangelogViewModel>()
            .ForMember(vm => vm.Id, map => map.MapFrom(c => c.Id));

            CreateMap<ForecastTask, ForecastTaskEAC>()
            .ForMember(vr => vr.Resource, opt => opt.MapFrom(v => v.Resource))
            .ForMember(vr => vr.Supplier, opt => opt.MapFrom(v => v.Supplier))
            .ForMember(dto => dto.ForecastTaskId, map => map.MapFrom(src => src.ForecastTaskId))
            .ForMember(dto => dto.ReconciledActuals, opt => opt.MapFrom(src => src.ReconciledActuals));

            CreateMap<ForecastTask, ForecastTaskViewModel>()
            .ForMember(vr => vr.Resource, opt => opt.MapFrom(v => v.Resource))
            .ForMember(vr => vr.Supplier, opt => opt.MapFrom(v => v.Supplier))
            .ForMember(dto => dto.ForecastTaskId, map => map.MapFrom(src => src.ForecastTaskId))
            .ForMember(dto => dto.ReconciledActuals, opt => opt.MapFrom(src => src.ReconciledActuals));

            CreateMap<ProjectBudgetTracker, ProjectBudgetTrackerViewModel>()
            .ForMember(dto => dto.ProjectBudgetTrackerId, map => map.MapFrom(src => src.ProjectBudgetTrackerId))
            .ForMember(dto => dto.ProjectBudgets, opt => opt.MapFrom(src => src.ProjectBudgets));


            CreateMap<Forecast, Actual>()
            .ForMember(vm => vm.ActualId, map => map.MapFrom(b => b.ActualId));
            CreateMap<Forecast, ForecastTask>()
            .ForMember(vm => vm.ForecastTaskId, map => map.MapFrom(b => b.ForecastTaskId));
            //.ForMember(d => d.ForecastTaskId, opt => opt.MapFrom(s => s));


            CreateMap<Notification, SummarisedNotification>()
              .ForMember(vm => vm.Id, map => map.MapFrom(b => b.Id));

            CreateMap<Notification, SummarisedNotification>()
              .ForMember(vm => vm.ProjectId, map => map.MapFrom(b => b.ProjectId))
              .ForMember(vm => vm.OriginalResourceCreatedId, map => map.MapFrom(b => b.OriginalResourceCreatedId))
              .ForMember(vm => vm.LastResourceModifiedId, map => map.MapFrom(b => b.LastResourceModifiedId))
              .ForMember(vm => vm.UpdatedByResourceId, map => map.MapFrom(b => b.UpdatedByResourceId))
              .ForMember(vm => vm.Project, opt => opt.MapFrom(r => r.Project));

            CreateMap<Project, ProjectData>()
              .ForMember(vm => vm.Id, map => map.MapFrom(b => b.ProjectId));
            CreateMap<CompanyRateCard, EditCompanyRateCard>()
              .ForMember(vm => vm.CompanyRateCardId, map => map.MapFrom(b => b.CompanyRateCardId));

            CreateMap<Resource, ResourceData>()
              .ForMember(vm => vm.Id, map => map.MapFrom(b => b.ResourceId));

            CreateMap<BusinessUnit, EditBusinessUnitData>()
              .ForMember(vm => vm.BusinessUnitId, map => map.MapFrom(b => b.Id));
            CreateMap<BusinessUnit, BusinessUnitViewModel>()
              .ForMember(vm => vm.BusinessUnitId, map => map.MapFrom(b => b.Id))
              .ForMember(vm => vm.Domains, opt => opt.MapFrom(b => b.Domains));

            CreateMap<Platform, EditPlatformData>()
              .ForMember(vm => vm.PlatformId, map => map.MapFrom(b => b.PlatformId));
            CreateMap<Platform, PlatformViewModel>()
              .ForMember(vm => vm.PlatformId, map => map.MapFrom(b => b.PlatformId));


            CreateMap<Domain, EditDomainData>()
              .ForMember(vm => vm.DomainId, map => map.MapFrom(b => b.Id));
            CreateMap<Domain, DomainViewModel>()
              .ForMember(vm => vm.DomainId, map => map.MapFrom(b => b.Id))
              .ForMember(vm => vm.BusinessUnitId, map => map.MapFrom(b => b.BusinessUnitId))
              .ForMember(vm => vm.Portfolios, opt => opt.MapFrom(b => b.Portfolios));

            CreateMap<Portfolio, EditPortfolioData>()
              .ForMember(vm => vm.PortfolioId, map => map.MapFrom(b => b.Id));
            CreateMap<Portfolio, PortfolioViewModel>()
              .ForMember(vm => vm.PortfolioId, map => map.MapFrom(b => b.Id))
              .ForMember(vm => vm.DomainId, map => map.MapFrom(b => b.DomainId))
              .ForMember(vm => vm.Programmes, opt => opt.MapFrom(b => b.Programmes));

            CreateMap<Programme, EditProgrammeData>()
              .ForMember(vm => vm.ProgrammeId, map => map.MapFrom(b => b.Id));
            CreateMap<Programme, ProgrammeViewModel>()
              .ForMember(vm => vm.ProgrammeId, map => map.MapFrom(b => b.Id))
              .ForMember(vm => vm.PortfolioId, map => map.MapFrom(b => b.PortfolioId))
              .ForMember(vm => vm.Projects, opt => opt.MapFrom(b => b.Projects));

            CreateMap<Project, EditProjectData>()
              .ForMember(vm => vm.ProjectId, map => map.MapFrom(b => b.ProjectId));
            CreateMap<Project, ProjectViewModel>()
              .ForMember(vm => vm.ProjectId, map => map.MapFrom(b => b.ProjectId))
              .ForMember(vm => vm.ProgrammeId, map => map.MapFrom(b => b.ProgrammeId));

            CreateMap<Resource, EditResourceData>()
              .ForMember(vm => vm.ResourceId, map => map.MapFrom(b => b.ResourceId));
            CreateMap<Resource, EditResourceData>()
              .ForMember(vm => vm.ResourceId, map => map.MapFrom(b => b.ResourceId))
              .ForMember(vm => vm.ResourceRateCardId, map => map.MapFrom(b => b.CompanyRateCard.CompanyRateCardId));


            CreateMap<BusinessCustomer, BusinessCustomerViewModel>().ForMember(vm => vm.BusinessCustomerId, map => map.MapFrom(b => b.BusinessCustomerId));

            CreateMap<Actual, ActualViewModel>()
           .ForMember(vm => vm.ActualId, map => map.MapFrom(b => b.ActualId))
           .ForMember(vr => vr.Project, opt => opt.MapFrom(v => v.Project))
           .ForMember(dto => dto.ReconciledActuals, opt => opt.MapFrom(src => src.ReconciledActuals));

            CreateMap<Actual, SaveActualResource>().ForMember(vm => vm.ActualId, map => map.MapFrom(b => b.ActualId));
            CreateMap<ForecastTask, ForecastTaskViewModel>().ForMember(vm => vm.ForecastTaskId, map => map.MapFrom(b => b.ForecastTaskId));


            CreateMap<BusinessUnit, BusinessUnitViewModel>().ForMember(vm => vm.BusinessUnitId, map => map.MapFrom(b => b.Id));
            CreateMap<Domain, DomainViewModel>().ForMember(vm => vm.DomainId, map => map.MapFrom(b => b.Id));
            CreateMap<Portfolio, PortfolioViewModel>().ForMember(vm => vm.PortfolioId, map => map.MapFrom(b => b.Id));
            CreateMap<Programme, ProgrammeViewModel>().ForMember(vm => vm.ProgrammeId, map => map.MapFrom(b => b.Id));

            //.ForMember(vm => vm.Id, opt => opt.MapFrom(r => r.Id));
            CreateMap<Project, ProjectsPermittedViewModel>()
              .ForMember(vm => vm.ProjectId, map => map.MapFrom(p => p.ProjectId))
              .ForMember(vr => vr.CompanyId, map => map.MapFrom(p => p.CompanyId))
            // .ForMember(vm => vm.ProjectId, opt => opt.MapFrom(r => r.Id))
            .ForMember(vm => vm.Project, opt => opt.MapFrom(p => new Project(_projectService, _userService, _resourceService) { ProjectName = p.ProjectName, ProjectRef = p.ProjectRef, Company = p.Company }));



            CreateMap<ProjectsPermitted, ProjectsPermittedViewModel>()
              .ForMember(vm => vm.ProjectId, map => map.MapFrom(r => r.ProjectId))
              .ForMember(vm => vm.ProjectId, opt => opt.MapFrom(r => r.Project.ProjectId))
              .ForMember(vr => vr.CompanyId, map => map.MapFrom(p => p.CompanyId));

            CreateMap<myProjects, myProjectsViewModel>()
              .ForMember(vm => vm.ProjectId, map => map.MapFrom(r => r.ProjectId))
              .ForMember(vm => vm.ProjectId, opt => opt.MapFrom(r => r.Project.ProjectId));


            CreateMap<Project, ProjectViewModel>()
            .ForMember(vm => vm.ProjectId, map => map.MapFrom(b => b.ProjectId))
            .ForMember(vr => vr.ProjectCurrentBudgetTrackerId, map => map.MapFrom(p => p.ProjectCurrentBudgetTrackerId))
            .ForMember(vr => vr.ProjectCurrentBudgetTrackerId, opt => opt.MapFrom(p => p.ProjectBudgetTracker.ProjectBudgetTrackerId));
            ;
            CreateMap<CompanyRateCard, CompanyRateCardViewModel>()
            .ForMember(vm => vm.CompanyRateCardId, map => map.MapFrom(b => b.CompanyRateCardId));

            CreateMap<Resource, ResourceViewModel>().ForMember(vm => vm.ResourceId, map => map.MapFrom(b => b.ResourceId));
            //.ForAllMembers(opt=>opt.Condition((src, dest, srcMember )=>srcMember!=null))


            CreateMap<Resource, ResourceProfileViewModel>()
            .ForMember(vm => vm.ResourceId, map => map.MapFrom(r => r.ResourceId));
           
            CreateMap<Resource, ResourceAdminViewModel>()
            .ForMember(dto => dto.ResourceId, map => map.MapFrom(src => src.ResourceId))
            // .ForMember(dto => dto.Identity, opt => opt.MapFrom(src => src.Identity))
            .ForMember(dto => dto.Company, opt => opt.MapFrom(src => src.Company))
            .ForMember(dto => dto.CompanyRateCard, opt => opt.MapFrom(src => src.CompanyRateCard));

            CreateMap<Actual, ActualViewModel>()
            .ForMember(vr => vr.ReconciledActuals, opt => opt.MapFrom(v => v.ReconciledActuals
            .Select(vf => new ForecastTask { })));

           

            // API Resource to Domain
            CreateMap<EditBusinessUnitData, BusinessUnit>()
              .ForMember(b => b.Id, map => map.MapFrom(vm => vm.BusinessUnitId));

            CreateMap<EditRagData, ProjectRagStatus>()
              .ForMember(b => b.ProjectRagStatusId, map => map.MapFrom(vm => vm.ProjectRagStatusId));

            CreateMap<EditRiskData, Risk>()
              .ForMember(b => b.RiskId, map => map.MapFrom(vm => vm.RiskId));

            CreateMap<EditIssueData, Issue>()
              .ForMember(b => b.IssueId, map => map.MapFrom(vm => vm.IssueId));

            CreateMap<EditAssumptionData, Assumption>()
              .ForMember(b => b.AssumptionId, map => map.MapFrom(vm => vm.AssumptionId));

            CreateMap<EditDependencyData, Dependency>()
              .ForMember(b => b.DependencyId, map => map.MapFrom(vm => vm.DependencyId));

            CreateMap<EditResourceData, Resource>()
              .ForMember(b => b.ResourceId, map => map.MapFrom(vm => vm.ResourceId));

            CreateMap<EditDomainData, Domain>()
              .ForMember(b => b.Id, map => map.MapFrom(vm => vm.DomainId));

            CreateMap<EditPortfolioData, Portfolio>()
              .ForMember(b => b.Id, map => map.MapFrom(vm => vm.PortfolioId));

            CreateMap<EditProgrammeData, Programme>()
              .ForMember(b => b.Id, map => map.MapFrom(vm => vm.ProgrammeId));

            CreateMap<EditProjectData, Project>()
              .ForMember(b => b.ProjectId, map => map.MapFrom(vm => vm.ProjectId));

            CreateMap<EditCompanyRateCard, CompanyRateCard>()
              .ForMember(b => b.CompanyRateCardId, map => map.MapFrom(vm => vm.CompanyRateCardId));

            CreateMap<ForecastTaskEAC, ForecastTask>()
             .ForMember(b => b.ForecastTaskId, map => map.MapFrom(vm => vm.ForecastTaskId));



            CreateMap<RegistrationViewModel, ApplicationUser>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
            CreateMap<AddResourceViewModel, Resource>().ForMember(r => r.ResourceEmailAddress, map => map.MapFrom(vm => vm.ResourceEmail));
            CreateMap<SaveActualResource, Actual>().ForMember(vm => vm.ActualId, map => map.MapFrom(a => a.ActualId));

            CreateMap<EditResourceDataViewModel, Resource>().ForMember(r => r.ResourceId, opt => opt.Ignore());
            // .ForMember(r => r.BusinessUnits, opt => opt.Ignore())
            // .ForMember(r => r.Domains, opt => opt.Ignore())
            // .ForMember(r => r.Portfolios, opt => opt.Ignore())
            // .ForMember(r => r.Programmes, opt => opt.Ignore())
            // .ForMember(r => r.Projects, opt => opt.Ignore())

            // .ForMember(r => r.BusinessUnitsPermitted, opt => opt.Ignore())
            // .ForMember(r => r.DomainsPermitted, opt => opt.Ignore())
            // .ForMember(r => r.PortfoliosPermitted, opt => opt.Ignore())
            // .ForMember(r => r.ProgrammesPermitted, opt => opt.Ignore())
            // .ForMember(r => r.ProjectsPermitted, opt => opt.Ignore());

            CreateMap<ActualToUpload, Actual>()
            .ForMember(vm => vm.ActualId, map => map.MapFrom(r => r.ActualId));
            // .ForMember(vm => vm.Amount, map => map.MapFrom(r => r.TransactionAmount));



            CreateMap<ProjectsPermittedViewModel, ProjectsPermitted>()
                .ForMember(p => p.UserId, opt => opt.Ignore())
                // .ForMember(v => v.Id, opt => opt.Ignore())
                .ForMember(vm => vm.ProjectId, map => map.MapFrom(p => p.ProjectId))
                .ForMember(vm => vm.ResourceId, map => map.MapFrom(p => p.ResourceId))
                .ForMember(vm => vm.CompanyId, map => map.MapFrom(p => p.CompanyId));
                //.ForMember(p => p.ResourcesPermitted, opt => opt.Ignore())
                //.AfterMap((pp, p) =>
                //{
                //        // Remove unselected resourcesPermitted
                //        var removedResourcesPermitted = p.ResourcesPermitted.Where(f => !pp.ResourcesPermitted.Contains(f.Id)).ToList();
                //    foreach (var f in removedResourcesPermitted)
                //        p.ResourcesPermitted.Remove(f);

                //        // Add new features
                //        var addedResourcesPermitted = pp.ResourcesPermitted.Where(id => !p.ResourcesPermitted.Any(f => f.Id == id)).Select(id => new ProjectPermitted { Id = id }).ToList();
                //    foreach (var f in addedResourcesPermitted)
                //        p.ResourcesPermitted.Add(f);
                //});


           
        }
    }
}


