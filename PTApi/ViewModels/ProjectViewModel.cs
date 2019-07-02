using PTApi.Methods;
using PTApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTApi.ViewModels
{
    public class ProjectViewModel : BaseEntity
    {
        public ProjectViewModel()
        {
           PermittedUsers = new Collection<ProjectsPermitted>();

        }


        private static string CreateNewId(string portfolioId, int length)
        {
            GeneratePublicIdMethod generatePublicId = new GeneratePublicIdMethod();
            return generatePublicId.PartId(portfolioId, 8);
        }


        public string ProjectId { get; set; }
        public string CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        [Required]
        public string ProjectName { get; set; }
        public string ProjectCode
        {
            get { return "PRJT" + "-" + CreateNewId(ProjectId, 8).ToUpper(); }
        }
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
        public string FinancialStatus { get; set; }
        public string RagStatus { get; set; }
        public string RagStatusSummary { get; set; }
        public string Activitythisperiod { get; set; }
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
        // Draft, Approved, Rejected, Revised
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
        public ICollection<ProjectsPermitted> PermittedUsers { get; private set; }
    }


}