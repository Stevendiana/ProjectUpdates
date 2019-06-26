using PTApi.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace PTApi.Models
{
    [Table("Projects")]
    public class Project : BaseEntity
    {
        private readonly IProjectService _projectService;
        private readonly IUserService _userService;
        private readonly IResourceService _resourceService;

        public Project()
        {

        }


        [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ProjectId { get; set; }
        public string CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        [Required]
        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectRef { get; set; }
        public string ParentId { get; set; }
        public string NodeId { get; set; }

        [DataType(DataType.MultilineText)]
        public string ProjectStrategy { get; set; }

        [DataType(DataType.MultilineText)]
        public string BusinessStrategy { get; set; }
        public string ProjectManagerDisplayName { get; set; }

        //Get from Application Users that are from the Project's company only.
        //public string ProjectManagerDisplayName { get ; set;}

        public string ProjectReportedToDisplayname { get; set; }
        public string ProjectPrimaryContactDisplayName { get; set; }
        public string ProjectFinanceContactDisplayName { get; set; }
        public string ProjectOwnerDisplayName { get; set; }
        public string ProgrammeId { get; set; }
        public Portfolio Portfolio { get; set; }
        public string PortfolioId { get; set; }
        public Programme Programme { get; set; }
        public Domain Domain { get; set; }
        public BusinessUnit BusinessUnit { get; set; }
        public string BusinessUnitId { get; set; }
        public string DomainId { get; set; }
        public string BusinessCustomerId { get; set; }
        public BusinessCustomer BusinessCustomers { get; set; }
        public string AccountingCode { get; set; }
        public string CurrentStageGateStatus { get; set; }
        public string ProjectLifecycleStage { get; set; }
        public string ProjectLifecycleStageId { get; set; }
        public ProjectStageGate ProjectStageGates { get; set; }
        // Not-Started, Active, On-Hold, Completed & Closed, Cancelled
        public string ProjectStatus { get; set; }
        public string RfqNumber { get; set; }
        // public string ProjectBudget { get; set; }
        public string ProjectObjective { get; set; }
        public string RagStatus { get; set; }
        public string RagStatusSummary { get; set; }
        public string Activitythisperiod { get; set; }
        public string FinancialStatus { get; set; }
        public string ProjectPrioritisation { get; set; }
        public string Sponsor { get; set; }
        public string ProjectCustomer { get; set; }
        public string ProjectManagerUserName { get; set; }

        public string ProjectAlignment { get; set; }
        public string BusinessAlignment { get; set; }
        public DateTime? ProjectStartDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }

        public int? BenefitsStartYear { get; set; }
        public int? BenefitsDurationInYears { get; set; }
        public decimal? GrandTotalOpexImpact { get; set; }
        public decimal? GrandTotalBenefitsForecast { get; set; }
        public decimal? GrandTotalBenefitsAchieved { get; set; }
        public decimal? GrandTotalBenefitsExpected { get; set; }
        public decimal? PlanGrandTotalCapex { get; set; }
        public decimal? PlanGrandTotalRevex { get; set; }
        public decimal? PlanGrandTotalOpex { get; set; }
        // public decimal? GrandTotalBudgetSubmitted { get; set; }
        // public decimal? GrandTotalBudgetApproved { get; set; }
        public string Projectlignment { get; set; }
        public string RevexCostCode { get; set; }
        public string CapexCostCode { get; set; }
        public string OpexCostCode { get; set; }
        // [NotMapped]
        public decimal? TotalLifeTimeForecast  { get; set; }

        public decimal? TotalActual  { get; set; }

        // [NotMapped]
        // public decimal? TotalPreviousYearsActuals  { get{return (TotalActualCurrentYearTotalminus5+TotalActualCurrentYearTotalminus4+TotalActualCurrentYearTotalminus3+
        // TotalActualCurrentYearTotalminus2+TotalActualCurrentYearTotalminus1);}}
        // Approved budget - updated during budget submission/approval
        // public decimal? ProjectBudgetAtComplete { get; set; }


        public string ProjectCurrentBudgetTrackerId  { get; set; }
        [ForeignKey("ProjectCurrentBudgetTrackerId")]
        public ProjectBudgetTracker ProjectBudgetTracker  { get; set; }

        public int LastBatchCount { get; set; }
        //public int? LastApprovedBatchtVersion { get; set; }
        //// Draft, Approved, Rejected, Revised
        //public string BudgetCurrentStatus  { get; set; }
        //public int? CurrentBudgetBadgeVersion  { get; set; }


        // [NotMapped]
        // Planned Completion - % Completed Planned = PV ⁄ BAC; The percentage of work which was planned to be completed by the Reporting Date.
        public double? ProjectPlannedCompletion { get; set; }
        // Actual Completion - % Completed Actual = AC ⁄ EAC; The percentage of work which was actually completed by the Reporting Date.
        public decimal? ProjectActualCompletion { get; set; }
        // [NotMapped]
        // Planned Completion (%) * BAC
        public decimal? TotalPlannedValue { get; set; }
        // [NotMapped]
        // Actual Completion (%) * BAC
        public decimal? ProjectEarnedValue { get; set; }
        // [NotMapped]
        // AC + (BAC − EV); AC + ETC (Estimate To Complete)
        public decimal? ProjectEstimateAtCompletion{ get; set; }
        // [NotMapped]
        public decimal? ProjectEstimateToComplete { get; set; }
        // [NotMapped]
        // VAC = BAC − EAC
        public decimal? ProjectVarianceAtComplete { get; set; }

        // [NotMapped]
        // EV / PV
        public decimal? ProjectSPI { get; set; }
        // [NotMapped]
        //  EV / AC
        public decimal? ProjectCPI { get; set; }
        // [NotMapped]
        public decimal? ProjectEAC { get; set; }


        public bool IsCanceled { get; private set; }

        public string ProjectManagementRankId { get; set; }
        [ForeignKey("ProjectManagementRankId")]
        public ProjectManagementRank ProjectManagementRank { get; set; }


        public ICollection<ProjectPermitted> PermittedUsers { get; private set; }
        public ICollection<Risk> Risks { get; private set; }
        public ICollection<Assumption> Assumptions { get; private set; }
        public ICollection<Issue> Issues { get; private set; }
        public ICollection<Dependency> Dependencies { get; private set; }


        public Project(IProjectService projectService, IUserService userService, IResourceService resourceService)
        {
            _projectService = projectService;
            _userService = userService;
            _resourceService = resourceService;
            PermittedUsers = new Collection<ProjectPermitted>();
            Risks = new Collection<Risk>();
            Assumptions = new Collection<Assumption>();
            Issues = new Collection<Issue>();
            Dependencies = new Collection<Dependency>();

            // ForecastTasks = new Collection<ForecastTask>();
            // Actuals = new Collection<Actual>();
            // ProjectStageGates = new Collection<ProjectStageGate>();
            // ProjectRagStatuses = new Collection<ProjectRagStatus>();
            // ProjectPlanBudgetBenefits = new Collection<ProjectPlanBudgetBenefit>();

        }


        public void Cancel()
        {
            IsCanceled = true;

            var loggedInResourceId = _resourceService.GetLoggedInUserResource().ResourceId;

            var notification = Notification.ProjectCanceled(this, _userService.GetSecureUserId(), loggedInResourceId);

            foreach (var permittedUser in PermittedUsers.Select(p => p.User))
            {
                permittedUser.Notify(notification);
            }
        }

        public void CreateProject(string currentuser, string loggedInResourceId)
        {
            // var currentuser = _userService.GetSecureUserId();
            // var loggedInResourceId = _resourceService.GetLoggedInUserResource().ResourceId;

            var notification = Notification.ProjectCreated(this, currentuser, loggedInResourceId);

            if ((ProjectManagementRank.ProjectManagerUserId !=null))
            {
                ProjectManagementRank.ProjectManager.Notify(notification);
            }
            if ((ProjectManagementRank.ProjectPrimaryContactUserId !=null))
            {
                ProjectManagementRank.ProjectPrmiaryContact.Notify(notification);
            }
            if ((ProjectManagementRank.ProjectFinanceContactUserId !=null))
            {
                ProjectManagementRank.ProjectFinanceContact.Notify(notification);
            }
            if ((ProjectManagementRank.ProjectSeniorManagerUserId !=null))
            {
                ProjectManagementRank.ProjectSeniorManager.Notify(notification);
            }
            if ((ProjectManagementRank.ProjectOwnerUserId !=null))
            {
                ProjectManagementRank.ProjectOwner.Notify(notification);
            }
            return;
        }

        public void UpdateProjectInfo()
        {
            var currentuser = _userService.GetSecureUserId();
            var loggedInResourceId = _resourceService.GetLoggedInUserResource().ResourceId;

            var notification = Notification.ProjectInfoUpdated(this, currentuser, loggedInResourceId);

            if ((ProjectManagementRank.ProjectManagerUserId != currentuser ))
            {
                ProjectManagementRank.ProjectManager.Notify(notification);
            }
            if ((ProjectManagementRank.ProjectPrimaryContactUserId != currentuser ))
            {
                ProjectManagementRank.ProjectPrmiaryContact.Notify(notification);
            }

            return;
        }

        public void UpdateProjectStatus(string newStatus)
        {

            var currentuser = _userService.GetSecureUserId();
            var loggedInResourceId = _resourceService.GetLoggedInUserResource().ResourceId;

            var notification = Notification.ProjectStatusUpdated(this, currentuser, newStatus, loggedInResourceId);

            if (newStatus != ProjectStatus)
            {
                if ((ProjectManagementRank.ProjectManagerUserId != currentuser && ProjectManagementRank.ProjectPrimaryContactUserId != currentuser ))
                {
                    ProjectManagementRank.ProjectManager.Notify(notification);
                    ProjectManagementRank.ProjectPrmiaryContact.Notify(notification);
                }
                if ((ProjectManagementRank.ProjectManagerUserId != currentuser ))
                {
                    ProjectManagementRank.ProjectManager.Notify(notification);
                }
                if ((ProjectManagementRank.ProjectPrimaryContactUserId != currentuser ))
                {
                    ProjectManagementRank.ProjectPrmiaryContact.Notify(notification);
                }
                if (newStatus == "Closed" || newStatus == "Completed")
                {
                    foreach (var permittedUser in PermittedUsers.Select(p => p.User))
                    {
                        permittedUser.Notify(notification);
                    }
                }
            }
           return;
        }



        // public void ModifyProjectManagement( DateTime dateCreated, DateTime dateModified, string usercreatedEmail, string usermodifiedEmail,
        // string projectManagerUserId, string projectSeniorManagerUserId, string projectPrimaryContactUserId,
        // string projectFinanceContactUserId, string projectOwnerUserId, string user)
        // {
        //     var notification = Notification.ProjectManagementUpdated(this, DateCreated, DateModified, UserCreatedEmail, UserModifiedEmail, ProjectManagerUserId, ProjectSeniorManagerUserId, ProjectPrimaryContactUserId,
        //     ProjectFinanceContactUserId, ProjectOwnerUserId, user);

        //     DateCreated = dateCreated;
        //     DateModified = dateModified;
        //     UserCreatedEmail = usercreatedEmail;
        //     UserModifiedEmail = usermodifiedEmail;

        //     ProjectManagerUserId = projectManagerUserId;
        //     ProjectSeniorManagerUserId  = projectSeniorManagerUserId;
        //     ProjectPrimaryContactUserId  = projectPrimaryContactUserId;
        //     ProjectFinanceContactUserId  = projectFinanceContactUserId;
        //     ProjectOwnerUserId  = projectOwnerUserId;



        //     ProjectManager.Notify(notification);
        //     ProjectSeniorManager.Notify(notification);
        //     ProjectPrmiaryContact.Notify(notification);
        //     ProjectFinanceContact.Notify(notification);
        //     ProjectOwner.Notify(notification);

        // }


        // [NotMapped]
        // public decimal? TotalActualCurrentYearTotalminus5  { get{return (TotalActualCurrentYearCapexminus5+TotalActualCurrentYearRevexminus5+TotalActualCurrentYearOpexminus5);}}
        // public decimal? TotalActualCurrentYearCapexminus5  { get; set; }
        // public decimal? TotalActualCurrentYearRevexminus5  { get; set; }
        // public decimal? TotalActualCurrentYearOpexminus5  { get; set; }
        // [NotMapped]
        // public decimal? TotalActualCurrentYearTotalminus4  { get{return (TotalActualCurrentYearCapexminus4+TotalActualCurrentYearRevexminus4+TotalActualCurrentYearOpexminus4);}}
        // public decimal? TotalActualCurrentYearCapexminus4  { get; set; }
        // public decimal? TotalActualCurrentYearRevexminus4  { get; set; }
        // public decimal? TotalActualCurrentYearOpexminus4  { get; set; }
        // [NotMapped]
        // public decimal? TotalActualCurrentYearTotalminus3  { get{return (TotalActualCurrentYearCapexminus3+TotalActualCurrentYearRevexminus3+TotalActualCurrentYearOpexminus3);}}
        // public decimal? TotalActualCurrentYearCapexminus3  { get; set; }
        // public decimal? TotalActualCurrentYearRevexminus3  { get; set; }
        // public decimal? TotalActualCurrentYearOpexminus3  { get; set; }
        // [NotMapped]
        // public decimal? TotalActualCurrentYearTotalminus2  { get{return (TotalActualCurrentYearCapexminus2+TotalActualCurrentYearRevexminus2+TotalActualCurrentYearOpexminus2);}}
        // public decimal? TotalActualCurrentYearCapexminus2  { get; set; }
        // public decimal? TotalActualCurrentYearRevexminus2  { get; set; }
        // public decimal? TotalActualCurrentYearOpexminus2  { get; set; }
        // [NotMapped]
        // public decimal? TotalActualCurrentYearTotalminus1  { get{return (TotalActualCurrentYearCapexminus1+TotalActualCurrentYearRevexminus1+TotalActualCurrentYearOpexminus1);}}
        // public decimal? TotalActualCurrentYearCapexminus1  { get; set; }
        // public decimal? TotalActualCurrentYearRevexminus1  { get; set; }
        // public decimal? TotalActualCurrentYearOpexminus1  { get; set; }
        // [NotMapped]
        //  // TotalForecastCurrentYear - updated during forecasting
        // public decimal? TotalForecastCurrentYearTotal  { get{return (TotalForecastCurrentYearCapex+TotalForecastCurrentYearRevex+TotalForecastCurrentYearOpex);}}
        // public decimal? TotalForecastCurrentYearCapex  { get; set; }
        // public decimal? TotalForecastCurrentYearRevex  { get; set; }
        // public decimal? TotalForecastCurrentYearOpex  { get; set; }
        // [NotMapped]
        // public decimal? TotalForecastYearTotalplus1  { get{return (TotalForecastYearCapexplus1+TotalForecastYearRevexplus1+TotalForecastYearOpexplus1);}}
        // public decimal? TotalForecastYearCapexplus1  { get; set; }
        // public decimal? TotalForecastYearRevexplus1  { get; set; }
        // public decimal? TotalForecastYearOpexplus1  { get; set; }
        // [NotMapped]
        // public decimal? TotalForecastYearTotalplus2  { get{return (TotalForecastYearCapexplus2+TotalForecastYearRevexplus2+TotalForecastYearOpexplus2);}}
        // public decimal? TotalForecastYearCapexplus2  { get; set; }
        // public decimal? TotalForecastYearRevexplus2  { get; set; }
        // public decimal? TotalForecastYearOpexplus2  { get; set; }
        // [NotMapped]
        // public decimal? TotalForecastYearTotalplus3  { get{return (TotalForecastYearCapexplus3+TotalForecastYearRevexplus3+TotalForecastYearOpexplus3);}}
        // public decimal? TotalForecastYearCapexplus3  { get; set; }
        // public decimal? TotalForecastYearRevexplus3  { get; set; }
        // public decimal? TotalForecastYearOpexplus3  { get; set; }
        // [NotMapped]
        // public decimal? TotalForecastYearTotalplus4  { get{return (TotalForecastYearCapexplus4+TotalForecastYearRevexplus4+TotalForecastYearOpexplus4);}}
        // public decimal? TotalForecastYearCapexplus4  { get; set; }
        // public decimal? TotalForecastYearRevexplus4  { get; set; }
        // public decimal? TotalForecastYearOpexplus4  { get; set; }
        // [NotMapped]
        // public decimal? TotalForecastYearTotalplus5  { get{return (TotalForecastYearCapexplus5+TotalForecastYearRevexplus5+TotalForecastYearOpexplus5);}}
        // public decimal? TotalForecastYearCapexplus5  { get; set; }
        // public decimal? TotalForecastYearRevexplus5  { get; set; }
        // public decimal? TotalForecastYearOpexplus5  { get; set; }
        // [NotMapped]
        // public decimal? TotalActual  { get{return (TotalActualCurrentYearTotal+TotalPreviousYearsActuals);}}
        // [NotMapped]
        // public decimal? TotalActualCurrentYearTotal  { get{return (TotalActualCurrentYearCapex+TotalActualCurrentYearRevex+TotalActualCurrentYearOpex);}}
        // public decimal? TotalActualCurrentYearCapex  { get; set; }
        // public decimal? TotalActualCurrentYearRevex  { get; set; }
        // public decimal? TotalActualCurrentYearOpex  { get; set; }




        // // Planned Value(PV) - All previous years spend(Actual) + current year forecast
        // //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        // [NotMapped]
        // public decimal? NoActualJanForecastTotal { get { return _projectService?.Test(CompanyId)??0.0m; } private set { } }
        // //public decimal? NoActualJanForecastTotal { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 1, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforjanrec??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? JanActualFebForecastTotal { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 2, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforfebrec??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? FebActualMarForecastTotal { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 3, ProjectStartDate, ProjectEndDate).Projectlifetimetotalformarrec??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? MarActualAprForecastTotal { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 4, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforaprrec??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? AprActualMayForecastTotal { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 5, ProjectStartDate, ProjectEndDate).Projectlifetimetotalformayrec??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? MayActualJunForecastTotal { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 6, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforjunrec??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? JunActualJulForecastTotal { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 7, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforjulrec??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? JulActualAugForecastTotal { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 8, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforaugrec??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? AugActualSepForecastTotal { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 9, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforseprec??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? SepActualOctForecastTotal { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 10, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforoctrec??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? OctActualNovForecastTotal { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 11, ProjectStartDate, ProjectEndDate).Projectlifetimetotalfornovrec??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? NovActualDecForecastTotal { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 12, ProjectStartDate, ProjectEndDate).Projectlifetimetotalfordecrec??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? DecActualNoForecastTotal { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 12, ProjectStartDate, ProjectEndDate).Projectlifetimetotalfordecactualsyearendrec??0.0m; } private set { } }

        // //Actual Cost to Date(AC)
        // [NotMapped]
        // public decimal? JanAllActualToDate { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 1, ProjectStartDate, ProjectEndDate).SumpastyearsActuals??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? FebAllActualToDate { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 2, ProjectStartDate, ProjectEndDate).SumpastyearsActuals??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? MarAllActualToDate { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 3, ProjectStartDate, ProjectEndDate).SumpastyearsActuals??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? AprAllActualToDate { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 4, ProjectStartDate, ProjectEndDate).SumpastyearsActuals??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? MayAllActualToDate { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 5, ProjectStartDate, ProjectEndDate).SumpastyearsActuals??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? JunAllActualToDate { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 6, ProjectStartDate, ProjectEndDate).SumpastyearsActuals??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? JulAllActualToDate { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 7, ProjectStartDate, ProjectEndDate).SumpastyearsActuals??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? AugAllActualToDate { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 8, ProjectStartDate, ProjectEndDate).SumpastyearsActuals??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? SepAllActualToDate { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 9, ProjectStartDate, ProjectEndDate).SumpastyearsActuals??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? OctAllActualToDate { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 10, ProjectStartDate, ProjectEndDate).SumpastyearsActuals??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? NovAllActualToDate { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 11, ProjectStartDate, ProjectEndDate).SumpastyearsActuals??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? DecAllActualToDate { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 12, ProjectStartDate, ProjectEndDate).SumpastyearsActuals??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? DecAllActualToDecEndDate { get { return _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 12, ProjectStartDate, ProjectEndDate).SumpastyearActualsToCurrentFullYearActual??0.0m; } private set { } }

        // //Earned Value (EV) = Total plan * %complete of the project.
        // [NotMapped]
        // public decimal? NoActualJanForecastTotalEarnedValue { get { return NoActualJanForecastTotal * _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 1, ProjectStartDate, ProjectEndDate).Percentagecomplete??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? JanActualFebForecastTotalEarnedValue { get { return JanActualFebForecastTotal * _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 2, ProjectStartDate, ProjectEndDate).Percentagecomplete??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? FebActualMarForecastTotalEarnedValue { get { return FebActualMarForecastTotal * _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 3, ProjectStartDate, ProjectEndDate).Percentagecomplete??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? MarActualAprForecastTotalEarnedValue { get { return MarActualAprForecastTotal * _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 4, ProjectStartDate, ProjectEndDate).Percentagecomplete??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? AprActualMayForecastTotalEarnedValue { get { return AprActualMayForecastTotal * _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 5, ProjectStartDate, ProjectEndDate).Percentagecomplete??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? MayActualJunForecastTotalEarnedValue { get { return MayActualJunForecastTotal * _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 6, ProjectStartDate, ProjectEndDate).Percentagecomplete??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? JunActualJulForecastTotalEarnedValue { get { return JunActualJulForecastTotal * _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 7, ProjectStartDate, ProjectEndDate).Percentagecomplete??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? JulActualAugForecastTotalEarnedValue { get { return JulActualAugForecastTotal * _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 8, ProjectStartDate, ProjectEndDate).Percentagecomplete??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? AugActualSepForecastTotalEarnedValue { get { return AugActualSepForecastTotal * _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 9, ProjectStartDate, ProjectEndDate).Percentagecomplete??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? SepActualOctForecastTotalEarnedValue { get { return SepActualOctForecastTotal * _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 10, ProjectStartDate, ProjectEndDate).Percentagecomplete??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? OctActualNovForecastTotalEarnedValue { get { return OctActualNovForecastTotal * _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 11, ProjectStartDate, ProjectEndDate).Percentagecomplete??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? NovActualDecForecastTotalEarnedValue { get { return NovActualDecForecastTotal * _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 12, ProjectStartDate, ProjectEndDate).Percentagecomplete??0.0m; } private set { } }
        // [NotMapped]
        // public decimal? DecActualNoForecastTotalEarnedValue { get { return DecActualNoForecastTotal * _projectService?.GetActualMinAndMaxDates(Id, CompanyId, 12, ProjectStartDate, ProjectEndDate).PercentagecompleteDecActualNoForecast??0.0m; } private set { } }


        // //Schedule Performance Index (SPI) calculation: SPI = EV/PV
        // //SPI measures progress achieved against progress planned. An SPI value < 1.0 indicates less work was completed than was planned. SPI > 1.0 indicates that more work was completed than was planned.
        // [NotMapped]
        // public decimal? NoActualJanForecastTotalSPI { get { if (NoActualJanForecastTotalEarnedValue!=0&&NoActualJanForecastTotal!=0) return (NoActualJanForecastTotalEarnedValue / NoActualJanForecastTotal);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? JanActualFebForecastTotalSPI { get { if (JanActualFebForecastTotalEarnedValue!=0&&JanActualFebForecastTotal!=0) return  (JanActualFebForecastTotalEarnedValue / JanActualFebForecastTotal);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? FebActualMarForecastTotalSPI { get { if (FebActualMarForecastTotalEarnedValue!=0&&FebActualMarForecastTotal!=0)return (FebActualMarForecastTotalEarnedValue / FebActualMarForecastTotal);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? MarActualAprForecastTotalSPI { get { if (MarActualAprForecastTotalEarnedValue!=0&&MarActualAprForecastTotal!=0)return (MarActualAprForecastTotalEarnedValue / MarActualAprForecastTotal);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? AprActualMayForecastTotalSPI { get { if (AprActualMayForecastTotalEarnedValue!=0&&AprActualMayForecastTotal!=0)return (AprActualMayForecastTotalEarnedValue / AprActualMayForecastTotal);return 0.0m;} private set { } }
        // [NotMapped]
        // public decimal? MayActualJunForecastTotalSPI { get { if (MayActualJunForecastTotalEarnedValue!=0&&MayActualJunForecastTotal!=0)return (MayActualJunForecastTotalEarnedValue / MayActualJunForecastTotal);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? JunActualJulForecastTotalSPI { get { if (JunActualJulForecastTotalEarnedValue!=0&&JunActualJulForecastTotal!=0)return (JunActualJulForecastTotalEarnedValue / JunActualJulForecastTotal);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? JulActualAugForecastTotalSPI { get { if (JulActualAugForecastTotalEarnedValue!=0&&JulActualAugForecastTotal!=0)return (JulActualAugForecastTotalEarnedValue / JulActualAugForecastTotal);return 0.0m;} private set { } }
        // [NotMapped]
        // public decimal? AugActualSepForecastTotalSPI { get { if (AugActualSepForecastTotalEarnedValue!=0&&AugActualSepForecastTotal!=0)return (AugActualSepForecastTotalEarnedValue / AugActualSepForecastTotal);return 0.0m;} private set { } }
        // [NotMapped]
        // public decimal? SepActualOctForecastTotalSPI { get { if (SepActualOctForecastTotalEarnedValue!=0&&SepActualOctForecastTotal!=0)return (SepActualOctForecastTotalEarnedValue / SepActualOctForecastTotal);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? OctActualNovForecastTotalSPI { get { if (OctActualNovForecastTotalEarnedValue!=0&&OctActualNovForecastTotal!=0)return (OctActualNovForecastTotalEarnedValue / OctActualNovForecastTotal);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? NovActualDecForecastTotalSPI { get { if (NovActualDecForecastTotalEarnedValue!=0&&NovActualDecForecastTotal!=0)return (NovActualDecForecastTotalEarnedValue / NovActualDecForecastTotal);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? DecActualNoForecastTotalSPI { get { if (DecActualNoForecastTotalEarnedValue!=0&&DecActualNoForecastTotal!=0)return (DecActualNoForecastTotalEarnedValue / DecActualNoForecastTotal);return 0.0m; } private set { } }


        // //Cost Performance Index (CPI) calculation: CPI = EV/AC
        // //CPI measures the value of work completed against the actual cost. A CPI value < 1.0 indicates that costs were higher than budgeted. CPI > 1.0 indicates that costs were less than budgeted.
        // [NotMapped]
        // public decimal? NoActualJanForecastTotalCPI { get { if (NoActualJanForecastTotalEarnedValue!=0&&JanAllActualToDate!=0)return (NoActualJanForecastTotalEarnedValue / JanAllActualToDate);return 0.0m;} private set { } }
        // [NotMapped]
        // public decimal? JanActualFebForecastTotalCPI { get { if (JanActualFebForecastTotalEarnedValue!=0&&FebAllActualToDate!=0)return (JanActualFebForecastTotalEarnedValue / FebAllActualToDate);return 0.0m;} private set { } }
        // [NotMapped]
        // public decimal? FebActualMarForecastTotalCPI { get { if (FebActualMarForecastTotalEarnedValue!=0&&MarAllActualToDate!=0)return (FebActualMarForecastTotalEarnedValue / MarAllActualToDate);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? MarActualAprForecastTotalCPI { get { if (MarActualAprForecastTotalEarnedValue!=0&&AprAllActualToDate!=0)return (MarActualAprForecastTotalEarnedValue / AprAllActualToDate);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? AprActualMayForecastTotalCPI { get { if (AprActualMayForecastTotalEarnedValue!=0&&MayAllActualToDate!=0)return (AprActualMayForecastTotalEarnedValue / MayAllActualToDate);return 0.0m;} private set { } }
        // [NotMapped]
        // public decimal? MayActualJunForecastTotalCPI { get { if (MayActualJunForecastTotalEarnedValue!=0&&JunAllActualToDate!=0)return (MayActualJunForecastTotalEarnedValue / JunAllActualToDate);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? JunActualJulForecastTotalCPI { get { if (JunActualJulForecastTotalEarnedValue!=0&&JulAllActualToDate!=0)return (JunActualJulForecastTotalEarnedValue / JulAllActualToDate);return 0.0m;} private set { } }
        // [NotMapped]
        // public decimal? JulActualAugForecastTotalCPI { get { if (JulActualAugForecastTotalEarnedValue!=0&&AugAllActualToDate!=0)return (JulActualAugForecastTotalEarnedValue / AugAllActualToDate);return 0.0m;} private set { } }
        // [NotMapped]
        // public decimal? AugActualSepForecastTotalCPI { get { if (AugActualSepForecastTotalEarnedValue!=0&&SepAllActualToDate!=0)return (AugActualSepForecastTotalEarnedValue / SepAllActualToDate);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? SepActualOctForecastTotalCPI { get { if (SepActualOctForecastTotalEarnedValue!=0&&OctAllActualToDate!=0)return (SepActualOctForecastTotalEarnedValue / OctAllActualToDate);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? OctActualNovForecastTotalCPI { get { if (OctActualNovForecastTotalEarnedValue!=0&&NovAllActualToDate!=0)return (OctActualNovForecastTotalEarnedValue / NovAllActualToDate);return 0.0m;} private set { } }
        // [NotMapped]
        // public decimal? NovActualDecForecastTotalCPI { get { if (NovActualDecForecastTotalEarnedValue!=0&&DecAllActualToDate!=0)return (NovActualDecForecastTotalEarnedValue / DecAllActualToDate);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? DecActualNoForecastTotalCPI { get { if (DecActualNoForecastTotalEarnedValue!=0&&DecAllActualToDecEndDate!=0)return (DecActualNoForecastTotalEarnedValue / DecAllActualToDecEndDate);return 0.0m; } private set { } }

        // //Estimated at Completion (EAC) calculation: EAC = (Total Project Budget) / CPI
        // //EAC is a forecast of how much the total project will cost.
        // [NotMapped]
        // public decimal? NoActualJanForecastTotalEAC { get { if (NoActualJanForecastTotal!=0&&NoActualJanForecastTotalCPI!=0)return (NoActualJanForecastTotal / NoActualJanForecastTotalCPI);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? JanActualFebForecastTotalEAC { get { if (JanActualFebForecastTotal!=0&&JanActualFebForecastTotalCPI!=0)return (JanActualFebForecastTotal / JanActualFebForecastTotalCPI);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? FebActualMarForecastTotalEAC { get { if (FebActualMarForecastTotal!=0&&FebActualMarForecastTotalCPI!=0)return (FebActualMarForecastTotal / FebActualMarForecastTotalCPI);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? MarActualAprForecastTotalEAC { get { if (MarActualAprForecastTotal!=0&&MarActualAprForecastTotalCPI!=0)return (MarActualAprForecastTotal / MarActualAprForecastTotalCPI);return 0.0m;} private set { } }
        // [NotMapped]
        // public decimal? AprActualMayForecastTotalEAC { get { if (AprActualMayForecastTotal!=0&&AprActualMayForecastTotalCPI!=0)return (AprActualMayForecastTotal / AprActualMayForecastTotalCPI);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? MayActualJunForecastTotalEAC { get { if (MayActualJunForecastTotal!=0&&MayActualJunForecastTotalCPI!=0)return (MayActualJunForecastTotal / MayActualJunForecastTotalCPI);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? JunActualJulForecastTotalEAC { get { if (JunActualJulForecastTotal!=0&&JunActualJulForecastTotalCPI!=0)return (JunActualJulForecastTotal / JunActualJulForecastTotalCPI);return 0.0m;} private set { } }
        // [NotMapped]
        // public decimal? JulActualAugForecastTotalEAC { get { if (JulActualAugForecastTotal!=0&&JulActualAugForecastTotalCPI!=0)return (JulActualAugForecastTotal / JulActualAugForecastTotalCPI);return 0.0m;} private set { } }
        // [NotMapped]
        // public decimal? AugActualSepForecastTotalEAC { get { if (AugActualSepForecastTotal!=0&&AugActualSepForecastTotalCPI!=0)return (AugActualSepForecastTotal / AugActualSepForecastTotalCPI);return 0.0m;} private set { } }
        // [NotMapped]
        // public decimal? SepActualOctForecastTotalEAC { get { if (SepActualOctForecastTotal!=0&&SepActualOctForecastTotalCPI!=0)return (SepActualOctForecastTotal / SepActualOctForecastTotalCPI);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? OctActualNovForecastTotalEAC { get { if (OctActualNovForecastTotal!=0&&OctActualNovForecastTotalCPI!=0)return (OctActualNovForecastTotal / OctActualNovForecastTotalCPI);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? NovActualDecForecastTotalEAC { get { if (NovActualDecForecastTotal!=0&&NovActualDecForecastTotalCPI!=0)return (NovActualDecForecastTotal / NovActualDecForecastTotalCPI);return 0.0m; } private set { } }
        // [NotMapped]
        // public decimal? DecActualNoForecastTotalEAC { get { if (DecActualNoForecastTotal!=0&&DecActualNoForecastTotalCPI!=0)return (DecActualNoForecastTotal / DecActualNoForecastTotalCPI);return 0.0m; } private set { } }



        // // Planned Value(PV) - All previous years spend(Actual) + current year forecast
        // [NotMapped]
        // public decimal? NoActualJanForecastTotal { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 1, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforjanrec; } private set { } }
        // [NotMapped]
        // public decimal? JanActualFebForecastTotal { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 2, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforfebrec; } private set { } }
        // [NotMapped]
        // public decimal? FebActualMarForecastTotal { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 3, ProjectStartDate, ProjectEndDate).Projectlifetimetotalformarrec; } private set { } }
        // [NotMapped]
        // public decimal? MarActualAprForecastTotal { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 4, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforaprrec; } private set { } }
        // [NotMapped]
        // public decimal? AprActualMayForecastTotal { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 5, ProjectStartDate, ProjectEndDate).Projectlifetimetotalformayrec; } private set { } }
        // [NotMapped]
        // public decimal? MayActualJunForecastTotal { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 6, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforjunrec; } private set { } }
        // [NotMapped]
        // public decimal? JunActualJulForecastTotal { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 7, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforjulrec; } private set { } }
        // [NotMapped]
        // public decimal? JulActualAugForecastTotal { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 8, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforaugrec; } private set { } }
        // [NotMapped]
        // public decimal? AugActualSepForecastTotal { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 9, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforseprec; } private set { } }
        // [NotMapped]
        // public decimal? SepActualOctForecastTotal { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 10, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforoctrec; } private set { } }
        // [NotMapped]
        // public decimal? OctActualNovForecastTotal { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 11, ProjectStartDate, ProjectEndDate).Projectlifetimetotalfornovrec; } private set { } }
        // [NotMapped]
        // public decimal? NovActualDecForecastTotal { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 12, ProjectStartDate, ProjectEndDate).Projectlifetimetotalfordecrec; } private set { } }
        // [NotMapped]
        // public decimal? DecActualNoForecastTotal { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 12, ProjectStartDate, ProjectEndDate).Projectlifetimetotalfordecactualsyearendrec; } private set { } }

        // //Actual Cost to Date(AC)
        // [NotMapped]
        // public decimal? JanAllActualToDate { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 1, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } private set { } }
        // [NotMapped]
        // public decimal? FebAllActualToDate { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 2, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } private set { } }
        // [NotMapped]
        // public decimal? MarAllActualToDate { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 3, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } private set { } }
        // [NotMapped]
        // public decimal? AprAllActualToDate { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 4, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } private set { } }
        // [NotMapped]
        // public decimal? MayAllActualToDate { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 5, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } private set { } }
        // [NotMapped]
        // public decimal? JunAllActualToDate { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 6, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } private set { } }
        // [NotMapped]
        // public decimal? JulAllActualToDate { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 7, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } private set { } }
        // [NotMapped]
        // public decimal? AugAllActualToDate { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 8, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } private set { } }
        // [NotMapped]
        // public decimal? SepAllActualToDate { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 9, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } private set { } }
        // [NotMapped]
        // public decimal? OctAllActualToDate { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 10, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } private set { } }
        // [NotMapped]
        // public decimal? NovAllActualToDate { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 11, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } private set { } }
        // [NotMapped]
        // public decimal? DecAllActualToDate { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 12, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } private set { } }
        // [NotMapped]
        // public decimal? DecAllActualToDecEndDate { get { return _projectService.GetActualMinAndMaxDates(Id, CompanyId, 12, ProjectStartDate, ProjectEndDate).SumpastyearActualsToCurrentFullYearActual; } private set { } }

        // //Earned Value (EV) = Total plan * %complete of the project.
        // [NotMapped]
        // public decimal? NoActualJanForecastTotalEarnedValue { get { return NoActualJanForecastTotal * _projectService.GetActualMinAndMaxDates(Id, CompanyId, 1, ProjectStartDate, ProjectEndDate).Percentagecomplete; } private set { } }
        // [NotMapped]
        // public decimal? JanActualFebForecastTotalEarnedValue { get { return JanActualFebForecastTotal * _projectService.GetActualMinAndMaxDates(Id, CompanyId, 2, ProjectStartDate, ProjectEndDate).Percentagecomplete; } private set { } }
        // [NotMapped]
        // public decimal? FebActualMarForecastTotalEarnedValue { get { return FebActualMarForecastTotal * _projectService.GetActualMinAndMaxDates(Id, CompanyId, 3, ProjectStartDate, ProjectEndDate).Percentagecomplete; } private set { } }
        // [NotMapped]
        // public decimal? MarActualAprForecastTotalEarnedValue { get { return MarActualAprForecastTotal * _projectService.GetActualMinAndMaxDates(Id, CompanyId, 4, ProjectStartDate, ProjectEndDate).Percentagecomplete; } private set { } }
        // [NotMapped]
        // public decimal? AprActualMayForecastTotalEarnedValue { get { return AprActualMayForecastTotal * _projectService.GetActualMinAndMaxDates(Id, CompanyId, 5, ProjectStartDate, ProjectEndDate).Percentagecomplete; } private set { } }
        // [NotMapped]
        // public decimal? MayActualJunForecastTotalEarnedValue { get { return MayActualJunForecastTotal * _projectService.GetActualMinAndMaxDates(Id, CompanyId, 6, ProjectStartDate, ProjectEndDate).Percentagecomplete; } private set { } }
        // [NotMapped]
        // public decimal? JunActualJulForecastTotalEarnedValue { get { return JunActualJulForecastTotal * _projectService.GetActualMinAndMaxDates(Id, CompanyId, 7, ProjectStartDate, ProjectEndDate).Percentagecomplete; } private set { } }
        // [NotMapped]
        // public decimal? JulActualAugForecastTotalEarnedValue { get { return JulActualAugForecastTotal * _projectService.GetActualMinAndMaxDates(Id, CompanyId, 8, ProjectStartDate, ProjectEndDate).Percentagecomplete; } private set { } }
        // [NotMapped]
        // public decimal? AugActualSepForecastTotalEarnedValue { get { return AugActualSepForecastTotal * _projectService.GetActualMinAndMaxDates(Id, CompanyId, 9, ProjectStartDate, ProjectEndDate).Percentagecomplete; } private set { } }
        // [NotMapped]
        // public decimal? SepActualOctForecastTotalEarnedValue { get { return SepActualOctForecastTotal * _projectService.GetActualMinAndMaxDates(Id, CompanyId, 10, ProjectStartDate, ProjectEndDate).Percentagecomplete; } private set { } }
        // [NotMapped]
        // public decimal? OctActualNovForecastTotalEarnedValue { get { return OctActualNovForecastTotal * _projectService.GetActualMinAndMaxDates(Id, CompanyId, 11, ProjectStartDate, ProjectEndDate).Percentagecomplete; } private set { } }
        // [NotMapped]
        // public decimal? NovActualDecForecastTotalEarnedValue { get { return NovActualDecForecastTotal * _projectService.GetActualMinAndMaxDates(Id, CompanyId, 12, ProjectStartDate, ProjectEndDate).Percentagecomplete; } private set { } }
        // [NotMapped]
        // public decimal? DecActualNoForecastTotalEarnedValue { get { return DecActualNoForecastTotal * _projectService.GetActualMinAndMaxDates(Id, CompanyId, 12, ProjectStartDate, ProjectEndDate).PercentagecompleteDecActualNoForecast; } private set { } }


        // //Schedule Performance Index (SPI) calculation: SPI = EV/PV
        // //SPI measures progress achieved against progress planned. An SPI value < 1.0 indicates less work was completed than was planned. SPI > 1.0 indicates that more work was completed than was planned.
        // [NotMapped]
        // public decimal? NoActualJanForecastTotalSPI { get { return NoActualJanForecastTotalEarnedValue / NoActualJanForecastTotal; } private set { } }
        // [NotMapped]
        // public decimal? JanActualFebForecastTotalSPI { get { return JanActualFebForecastTotalEarnedValue / JanActualFebForecastTotal; } private set { } }
        // [NotMapped]
        // public decimal? FebActualMarForecastTotalSPI { get { return FebActualMarForecastTotalEarnedValue / FebActualMarForecastTotal; } private set { } }
        // [NotMapped]
        // public decimal? MarActualAprForecastTotalSPI { get { return MarActualAprForecastTotalEarnedValue / MarActualAprForecastTotal; } private set { } }
        // [NotMapped]
        // public decimal? AprActualMayForecastTotalSPI { get { return AprActualMayForecastTotalEarnedValue / AprActualMayForecastTotal; } private set { } }
        // [NotMapped]
        // public decimal? MayActualJunForecastTotalSPI { get { return MayActualJunForecastTotalEarnedValue / MayActualJunForecastTotal; } private set { } }
        // [NotMapped]
        // public decimal? JunActualJulForecastTotalSPI { get { return JunActualJulForecastTotalEarnedValue / JunActualJulForecastTotal; } private set { } }
        // [NotMapped]
        // public decimal? JulActualAugForecastTotalSPI { get { return JulActualAugForecastTotalEarnedValue / JulActualAugForecastTotal; } private set { } }
        // [NotMapped]
        // public decimal? AugActualSepForecastTotalSPI { get { return AugActualSepForecastTotalEarnedValue / AugActualSepForecastTotal; } private set { } }
        // [NotMapped]
        // public decimal? SepActualOctForecastTotalSPI { get { return SepActualOctForecastTotalEarnedValue / SepActualOctForecastTotal; } private set { } }
        // [NotMapped]
        // public decimal? OctActualNovForecastTotalSPI { get { return OctActualNovForecastTotalEarnedValue / OctActualNovForecastTotal; } private set { } }
        // [NotMapped]
        // public decimal? NovActualDecForecastTotalSPI { get { return NoActualJanForecastTotalEarnedValue / NovActualDecForecastTotal; } private set { } }
        // [NotMapped]
        // public decimal? DecActualNoForecastTotalSPI { get { return DecActualNoForecastTotalEarnedValue / DecActualNoForecastTotal; } private set { } }


        // //Cost Performance Index (CPI) calculation: CPI = EV/AC
        // //CPI measures the value of work completed against the actual cost. A CPI value < 1.0 indicates that costs were higher than budgeted. CPI > 1.0 indicates that costs were less than budgeted.
        // [NotMapped]
        // public decimal? NoActualJanForecastTotalCPI { get { return NoActualJanForecastTotalEarnedValue / JanAllActualToDate; } private set { } }
        // [NotMapped]
        // public decimal? JanActualFebForecastTotalCPI { get { return JanActualFebForecastTotalEarnedValue / FebAllActualToDate; } private set { } }
        // [NotMapped]
        // public decimal? FebActualMarForecastTotalCPI { get { return FebActualMarForecastTotalEarnedValue / MarAllActualToDate; } private set { } }
        // [NotMapped]
        // public decimal? MarActualAprForecastTotalCPI { get { return MarActualAprForecastTotalEarnedValue / AprAllActualToDate; } private set { } }
        // [NotMapped]
        // public decimal? AprActualMayForecastTotalCPI { get { return MayActualJunForecastTotalEarnedValue / MayAllActualToDate; } private set { } }
        // [NotMapped]
        // public decimal? MayActualJunForecastTotalCPI { get { return MayActualJunForecastTotalEarnedValue / JunAllActualToDate; } private set { } }
        // [NotMapped]
        // public decimal? JunActualJulForecastTotalCPI { get { return JunActualJulForecastTotalEarnedValue / JulAllActualToDate; } private set { } }
        // [NotMapped]
        // public decimal? JulActualAugForecastTotalCPI { get { return JulActualAugForecastTotalEarnedValue / AugAllActualToDate; } private set { } }
        // [NotMapped]
        // public decimal? AugActualSepForecastTotalCPI { get { return AugActualSepForecastTotalEarnedValue / SepAllActualToDate; } private set { } }
        // [NotMapped]
        // public decimal? SepActualOctForecastTotalCPI { get { return SepActualOctForecastTotalEarnedValue / OctAllActualToDate; } private set { } }
        // [NotMapped]
        // public decimal? OctActualNovForecastTotalCPI { get { return OctActualNovForecastTotalEarnedValue / NovAllActualToDate; } private set { } }
        // [NotMapped]
        // public decimal? NovActualDecForecastTotalCPI { get { return NoActualJanForecastTotalEarnedValue / DecAllActualToDate; } private set { } }
        // [NotMapped]
        // public decimal? DecActualNoForecastTotalCPI { get { return DecActualNoForecastTotalEarnedValue / DecAllActualToDecEndDate; } private set { } }

        // //Estimated at Completion (EAC) calculation: EAC = (Total Project Budget) / CPI
        // //EAC is a forecast of how much the total project will cost.
        // [NotMapped]
        // public decimal? NoActualJanForecastTotalEAC { get { return NoActualJanForecastTotal / NoActualJanForecastTotalCPI; } private set { } }
        // [NotMapped]
        // public decimal? JanActualFebForecastTotalEAC { get { return JanActualFebForecastTotal / JanActualFebForecastTotalCPI; } private set { } }
        // [NotMapped]
        // public decimal? FebActualMarForecastTotalEAC { get { return FebActualMarForecastTotal / FebActualMarForecastTotalCPI; } private set { } }
        // [NotMapped]
        // public decimal? MarActualAprForecastTotalEAC { get { return MarActualAprForecastTotal / MarActualAprForecastTotalCPI; } private set { } }
        // [NotMapped]
        // public decimal? AprActualMayForecastTotalEAC { get { return AprActualMayForecastTotal / AprActualMayForecastTotalCPI; } private set { } }
        // [NotMapped]
        // public decimal? MayActualJunForecastTotalEAC { get { return MayActualJunForecastTotal / MayActualJunForecastTotalCPI; } private set { } }
        // [NotMapped]
        // public decimal? JunActualJulForecastTotalEAC { get { return JunActualJulForecastTotal / JunActualJulForecastTotalCPI; } private set { } }
        // [NotMapped]
        // public decimal? JulActualAugForecastTotalEAC { get { return JulActualAugForecastTotal / JulActualAugForecastTotalCPI; } private set { } }
        // [NotMapped]
        // public decimal? AugActualSepForecastTotalEAC { get { return AugActualSepForecastTotal / AugActualSepForecastTotalCPI; } private set { } }
        // [NotMapped]
        // public decimal? SepActualOctForecastTotalEAC { get { return SepActualOctForecastTotal / SepActualOctForecastTotalCPI; } private set { } }
        // [NotMapped]
        // public decimal? OctActualNovForecastTotalEAC { get { return OctActualNovForecastTotal / OctActualNovForecastTotalCPI; } private set { } }
        // [NotMapped]
        // public decimal? NovActualDecForecastTotalEAC { get { return NovActualDecForecastTotal / NovActualDecForecastTotalCPI; } private set { } }
        // [NotMapped]
        // public decimal? DecActualNoForecastTotalEAC { get { return DecActualNoForecastTotal / DecActualNoForecastTotalCPI; } private set { } }



        // public decimal? NoActualJanForecastTotal { get { return FirstName + "; " + LastName; } private set {} }
        // [NotMapped]
        // public decimal? JanActualFebForecastTotal { get; private set; }
        // [NotMapped]
        // public decimal? FebActualMarForecastTotal { get; private set; }
        // [NotMapped]
        // public decimal? MarActualAprForecastTotal { get; private set; }
        // [NotMapped]
        // public decimal? AprActualMayForecastTotal { get; private set; }
        // [NotMapped]
        // public decimal? MayActualJunForecastTotal { get; private set; }
        // [NotMapped]
        // public decimal? JunActualJulForecastTotal { get; private set; }
        // [NotMapped]
        // public decimal? JulActualAugForecastTotal { get; private set; }
        // [NotMapped]
        // public decimal? AugActualSepForecastTotal { get; private set; }
        // [NotMapped]
        // public decimal? SepActualOctForecastTotal { get; private set; }
        // [NotMapped]
        // public decimal? OctActualNovForecastTotal { get; private set; }
        // [NotMapped]
        // public decimal? NovActualDecForecastTotal { get; private set; }
        // [NotMapped]
        // public decimal? DecActualNoForecastTotal { get; private set; }


        // //Actual Cost to Date(AC)
        //  [NotMapped]
        // public decimal? JanAllActualToDate { get; private set; }
        //  [NotMapped]
        // public decimal? FebAllActualToDate { get; private set; }
        //  [NotMapped]
        // public decimal? MarAllActualToDate { get; private set; }
        //  [NotMapped]
        // public decimal? AprAllActualToDate { get; private set; }
        //  [NotMapped]
        // public decimal? MayAllActualToDate { get; private set; }
        //  [NotMapped]
        // public decimal? JunAllActualToDate { get; private set; }
        //  [NotMapped]
        // public decimal? JulAllActualToDate { get; private set; }
        //  [NotMapped]
        // public decimal? AugAllActualToDate { get; private set; }
        //  [NotMapped]
        // public decimal? SepAllActualToDate { get; private set; }
        //  [NotMapped]
        // public decimal? OctAllActualToDate { get; private set; }
        //  [NotMapped]
        // public decimal? NovAllActualToDate { get; private set; }
        //  [NotMapped]
        // public decimal? DecAllActualToDate { get; private set; }
        //  [NotMapped]
        // public decimal? DecAllActualToDecEndDate { get; private set; }

        // //Earned Value (EV) = Total plan * %complete of the project.
        //  [NotMapped]
        // public decimal? NoActualJanForecastTotalEarnedValue { get; private set; }
        //  [NotMapped]
        // public decimal? JanActualFebForecastTotalEarnedValue { get; private set; }
        //  [NotMapped]
        // public decimal? FebActualMarForecastTotalEarnedValue { get; private set; }
        //  [NotMapped]
        // public decimal? MarActualAprForecastTotalEarnedValue { get; private set; }
        //  [NotMapped]
        // public decimal? AprActualMayForecastTotalEarnedValue { get; private set; }
        //  [NotMapped]
        // public decimal? MayActualJunForecastTotalEarnedValue { get; private set; }
        //  [NotMapped]
        // public decimal? JunActualJulForecastTotalEarnedValue { get; private set; }
        //  [NotMapped]
        // public decimal? JulActualAugForecastTotalEarnedValue { get; private set; }
        //  [NotMapped]
        // public decimal? AugActualSepForecastTotalEarnedValue { get; private set; }
        //  [NotMapped]
        // public decimal? SepActualOctForecastTotalEarnedValue { get; private set; }
        //  [NotMapped]
        // public decimal? OctActualNovForecastTotalEarnedValue { get; private set; }
        //  [NotMapped]
        // public decimal? NovActualDecForecastTotalEarnedValue { get; private set; }
        //  [NotMapped]
        // public decimal? DecActualNoForecastTotalEarnedValue { get; private set; }


        // //Schedule Performance Index (SPI) calculation: SPI = EV/PV
        // //SPI measures progress achieved against progress planned. An SPI value < 1.0 indicates less work was completed than was planned. SPI > 1.0 indicates that more work was completed than was planned.
        //  [NotMapped]
        // public decimal? NoActualJanForecastTotalSPI { get; private set; }
        //  [NotMapped]
        // public decimal? JanActualFebForecastTotalSPI { get; private set; }
        // public decimal? FebActualMarForecastTotalSPI { get; private set; }
        //  [NotMapped]
        // public decimal? MarActualAprForecastTotalSPI { get; private set; }
        //  [NotMapped]
        // public decimal? AprActualMayForecastTotalSPI { get; private set; }
        //  [NotMapped]
        // public decimal? MayActualJunForecastTotalSPI { get; private set; }
        //  [NotMapped]
        // public decimal? JunActualJulForecastTotalSPI { get; private set; }
        //  [NotMapped]
        // public decimal? JulActualAugForecastTotalSPI { get; private set; }
        //  [NotMapped]
        // public decimal? AugActualSepForecastTotalSPI { get; private set; }
        //  [NotMapped]
        // public decimal? SepActualOctForecastTotalSPI { get; private set; }
        //  [NotMapped]
        // public decimal? OctActualNovForecastTotalSPI { get; private set; }
        //  [NotMapped]
        // public decimal? NovActualDecForecastTotalSPI { get; private set; }
        //  [NotMapped]
        // public decimal? DecActualNoForecastTotalSPI { get; private set; }


        // //Cost Performance Index (CPI) calculation: CPI = EV/AC
        // //CPI measures the value of work completed against the actual cost. A CPI value < 1.0 indicates that costs were higher than budgeted. CPI > 1.0 indicates that costs were less than budgeted.
        // [NotMapped]
        // public decimal? NoActualJanForecastTotalCPI { get; private set; }
        //  [NotMapped]
        // public decimal? JanActualFebForecastTotalCPI { get; private set; }
        //  [NotMapped]
        // public decimal? FebActualMarForecastTotalCPI { get; private set; }
        //  [NotMapped]
        // public decimal? MarActualAprForecastTotalCPI { get; private set; }
        //  [NotMapped]
        // public decimal? AprActualMayForecastTotalCPI { get; private set; }
        //  [NotMapped]
        // public decimal? MayActualJunForecastTotalCPI { get; private set; }
        //  [NotMapped]
        // public decimal? JunActualJulForecastTotalCPI { get; private set; }
        //  [NotMapped]
        // public decimal? JulActualAugForecastTotalCPI { get; private set; }
        //  [NotMapped]
        // public decimal? AugActualSepForecastTotalCPI { get; private set; }
        //  [NotMapped]
        // public decimal? SepActualOctForecastTotalCPI { get; private set; }
        //  [NotMapped]
        // public decimal? OctActualNovForecastTotalCPI { get; private set; }
        //  [NotMapped]
        // public decimal? NovActualDecForecastTotalCPI { get; private set; }
        //  [NotMapped]
        // public decimal? DecActualNoForecastTotalCPI { get; private set; }

        // //Estimated at Completion (EAC) calculation: EAC = (Total Project Budget) / CPI
        // //EAC is a forecast of how much the total project will cost.

        // [NotMapped]
        // public decimal? NoActualJanForecastTotalEAC { get; private set; }
        //  [NotMapped]
        // public decimal? JanActualFebForecastTotalEAC { get; private set; }
        //  [NotMapped]
        // public decimal? FebActualMarForecastTotalEAC { get; private set; }
        //  [NotMapped]
        // public decimal? MarActualAprForecastTotalEAC { get; private set; }
        //  [NotMapped]
        // public decimal? AprActualMayForecastTotalEAC { get; private set; }
        //  [NotMapped]
        // public decimal? MayActualJunForecastTotalEAC { get; private set; }
        //  [NotMapped]
        // public decimal? JunActualJulForecastTotalEAC { get; private set; }
        //  [NotMapped]
        // public decimal? JulActualAugForecastTotalEAC { get; private set; }
        //  [NotMapped]
        // public decimal? AugActualSepForecastTotalEAC { get; private set; }
        //  [NotMapped]
        // public decimal? SepActualOctForecastTotalEAC { get; private set; }
        //  [NotMapped]
        // public decimal? OctActualNovForecastTotalEAC { get; private set; }
        //  [NotMapped]
        // public decimal? NovActualDecForecastTotalEAC { get; private set; }
        //  [NotMapped]
        // public decimal? DecActualNoForecastTotalEAC { get; private set; }



        // public ICollection<ForecastTask> ForecastTasks { get; set; }
        // public ICollection<Actual> Actuals { get; set; }
        // public ICollection<ProjectStageGate> ProjectStageGates { get; set; }
        // public ICollection<ProjectRagStatus> ProjectRagStatuses { get; set; }
        // public ICollection<ProjectPlanBudgetBenefit> ProjectPlanBudgetBenefits { get; set; }

    }
}