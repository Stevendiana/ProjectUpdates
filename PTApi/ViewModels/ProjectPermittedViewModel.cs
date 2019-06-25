using PTApi.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;


namespace PTApi.ViewModels
{
    public class ProjectPermittedViewModel
    {

        public string Id { get; set; }
        public string ProjectId { get; set; }
        public Project Project { get; set; }
        public string NodeId { get; set; } ="project";
        public bool ReadWritePermission { get; set; }
        [Required]
        public string ResourceId { get; set; }
        public Resource Resource { get; set; }
        [Required]
        public string CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<string> ResourcesPermitted { get; set; }
        // public ICollection<ForecastTask> ForecastTasks { get; set; }
        // public ICollection<Actual> Actuals { get; set; }
        // public ICollection<ProjectStageGate> ProjectStageGates { get; set; }
        // public ICollection<ProjectRagStatus> ProjectRagStatuses { get; set; }
        // public ICollection<ProjectPlanBudgetBenefit> ProjectPlanBudgetBenefits { get; set; }

        public ProjectPermittedViewModel()
        {
            ResourcesPermitted = new Collection<string>();
            // ForecastTasks = new Collection<ForecastTask>();
            // Actuals = new Collection<Actual>();
            // ProjectStageGates = new Collection<ProjectStageGate>();
            // ProjectRagStatuses = new Collection<ProjectRagStatus>();
            // ProjectPlanBudgetBenefits = new Collection<ProjectPlanBudgetBenefit>();
        }

        // public string ProjectId { get; set; }
        // public Project Project { get; set; }
        // public string ProjectName { get; set; }
        // public string NodeId { get; set; } ="project";
        // public bool ReadWritePermission { get; set; }
        // public string ResourceId { get; set; }
        // public string CompanyId { get; set; }


        //  public ProjectPermittedViewModel()
        // {
        //     ForecastTasks = new Collection<ForecastTask>();
        //     Actuals = new Collection<Actual>();
        //     ProjectStageGates = new Collection<ProjectStageGate>();
        //     ProjectRagStatuses = new Collection<ProjectRagStatus>();
        //     ProjectPlanBudgetBenefits = new Collection<ProjectPlanBudgetBenefit>();
        // }

        // // [Key]
        // // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // // public string Id { get; set; }
        // // public string CompanyId { get; set; }
        // // [ForeignKey("CompanyId")]
        // // public Company  Company { get; set; }
        // // [Required]
        // // public string ProjectName { get; set; }
        // public string ProjectRef { get; set; }
        // public string ParentId { get; set; }
        // // public string PortfolioId { get; set; }
        // // public Portfolio Portfolios { get; set; }
        // public Programme Programmes { get; set; }
        // public string BusinessCustomerId { get; set; }
        // public BusinessCustomer BusinessCustomers { get; set; }
        // public string AccountingCode { get; set; }
        // public string CurrentStageGateStatus { get; set; }
        // public string ProjectLifecycleStage { get; set; }
        // public string ProjectStatus { get; set; }
        // public string RfqNumber { get; set; }
        // public string ProjectBudget { get; set; }
        // public string ProjectObjective { get; set; }
        // public string FinancialStatus { get; set; }
        // public string ProjectPrioritisation { get; set; }
        // public string Sponsor { get; set; }
        // public string ProjectCustomer { get; set; }
        // public string ProjectManagerUserName { get; set; }
        // public string ProjectManagerUserId { get; set; }

        // // public string ResourceCostCentreId { get; set; }
        // // [ForeignKey("ResourceCostCentreId")]
        // // public ResourceCostCentre ResourceCostCentre { get; set; }


        // public string ProjectReportedToUserName { get; set; }

        // public string ProjectPrimaryContactUsername { get; set; }
        // public string ProjectFinanceContactUsername { get; set; }
        // public string ProjectOwnerUserName { get; set; }

        // [DataType(DataType.MultilineText)]
        // public string ProjectStrategy { get; set; }

        // [DataType(DataType.MultilineText)]
        // public string BusinessStrategy { get; set; }
        // public string ProjectAlignment { get; set; }
        // public string BusinessAlignment { get; set; }


        // public DateTime? ProjectStartDate { get; set; }
        // public DateTime? ProjectEndDate { get; set; }

        // public int? BenefitsStartYear { get; set; }
        // public int? BenefitsDurationInYears { get; set; }
        // public decimal? GrandTotalOpexImpact { get; set; }
        // public decimal? GrandTotalBenefitsForecast { get; set; }
        // public decimal? GrandTotalBenefitsAchieved { get; set; }
        // public decimal? GrandTotalBenefitsExpected { get; set; }
        // public decimal? PlanGrandTotalCapex { get; set; }
        // public decimal? PlanGrandTotalRevex { get; set; }
        // public decimal? PlanGrandTotalOpex { get; set; }
        // public decimal? GrandTotalBudgetSubmitted { get; set; }
        // public decimal? GrandTotalBudgetApproved { get; set; }

        // public string ProjectManagerDisplayName { get; set; }

        // //Get from Application Users that are from the Project's company only.
        // //public string ProjectManagerDisplayName { get ; set;}

        // public string ProjectReportedToDisplayname { get ; set;}
        // public string ProjectPrimaryContactDisplayName { get ; set;}
        // public string ProjectFinanceContactDisplayName { get ; set;}
        // public string ProjectOwnerDisplayName{ get ; set;}
        // public string Projectlignment { get; set; }
        // public string RevexCostCode { get ; set;}
        // public string CapexCostCode { get ; set;}
        // public string OpexCostCode { get ; set;}


        // public ICollection<ForecastTask> ForecastTasks { get; set; }
        // public ICollection<Actual> Actuals { get; set; }
        // public ICollection<ProjectStageGate> ProjectStageGates { get; set; }
        // public ICollection<ProjectRagStatus> ProjectRagStatuses { get; set; }
        // public ICollection<ProjectPlanBudgetBenefit> ProjectPlanBudgetBenefits { get; set; }


    }
}