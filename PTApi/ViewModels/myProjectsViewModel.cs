using System;

namespace PTApi.ViewModels
{
    public class myProjectsViewModel
    {


        public string ProjectId { get; set; }
        public string ResourceId { get; set; }
        public string CompanyId { get; set; }
        public bool CanEdit { get; set; }
        public bool Following { get; set; }

        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectRef { get; set; }
        public string ParentId { get; set; }
        public string NodeId { get; set; }
        public string ProjectStrategy { get; set; }
        public string BusinessStrategy { get; set; }
        public string ProjectManagerDisplayName { get; set; }

        public string ProjectReportedToDisplayname { get; set; }
        public string ProjectPrimaryContactDisplayName { get; set; }
        public string ProjectFinanceContactDisplayName { get; set; }
        public string ProjectOwnerDisplayName { get; set; }

        public string ProgrammeId { get; set; }
        public string PortfolioId { get; set; }
        public string BusinessUnitId { get; set; }
        public string DomainId { get; set; }
        public string BusinessCustomerId { get; set; }
       
        public string AccountingCode { get; set; }
        public string CurrentStageGateStatus { get; set; }
        public string ProjectLifecycleStage { get; set; }
        public string ProjectLifecycleStageId { get; set; }
        
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
        

        public string Projectlignment { get; set; }
        public string RevexCostCode { get; set; }
        public string CapexCostCode { get; set; }
        public string OpexCostCode { get; set; }
        public decimal? TotalLifeTimeForecast { get; set; }
        public decimal? TotalActual { get; set; }
        public string ProjectCurrentBudgetTrackerId { get; set; }
        public int LastBudgetBatchVersion { get; set; }
        public double? ProjectPlannedCompletion { get; set; }
        public decimal? ProjectActualCompletion { get; set; }
        public decimal? TotalPlannedValue { get; set; }
        public decimal? ProjectEarnedValue { get; set; }
        public decimal? ProjectEstimateAtCompletion { get; set; }
        public decimal? ProjectEstimateToComplete { get; set; }
        public decimal? ProjectVarianceAtComplete { get; set; }
        public decimal? ProjectSPI { get; set; }
        public decimal? ProjectCPI { get; set; }
        public decimal? ProjectEAC { get; set; }
        public bool IsCanceled { get; private set; }
        public string ProjectManagementRankId { get; set; }
     


    }
}