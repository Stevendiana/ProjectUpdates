using System.ComponentModel.DataAnnotations.Schema;

namespace PTApi.Models
{
    [Table("ProjectPlanBudgetBenefits")]
    public class ProjectPlanBudgetBenefit : BaseEntity
    {
        public int Year { get; set; }
        public string CostCategory { get; set; }
        public string CompanyId { get; set; }
        public string ProjectId { get; set; }
        public Project Project { get; set; }
        public Company Company { get; set; }
        public decimal? PlanJan { get; set; }
        public decimal? PlanFeb { get; set; }
        public decimal? PlanMar { get; set; }
        public decimal? PlanApr { get; set; }
        public decimal? PlanMay { get; set; }
        public decimal? PlanJun { get; set; }
        public decimal? PlanJul { get; set; }
        public decimal? PlanAug { get; set; }
        public decimal? PlanSep { get; set; }
        public decimal? PlanOct { get; set; }
        public decimal? PlanNov { get; set; }
        public decimal? PlanDec { get; set; }
        public decimal? PlanPerCategoryQ1 { get; set; }
        public decimal? PlanPerCategoryQ2 { get; set; }
        public decimal? PlanPerCategoryQ3 { get; set; }
        public decimal? PlanPerCategoryQ4 { get; set; }
        public decimal? PlanCategoryTotal { get; set; }


        public decimal? JanBudgetDemand { get; set; }
        public decimal? FebBudgetDemand { get; set; }
        public decimal? MarBudgetDemand { get; set; }
        public decimal? AprBudgetDemand { get; set; }
        public decimal? MayBudgetDemand { get; set; }
        public decimal? JunBudgetDemand { get; set; }
        public decimal? JulBudgetDemand { get; set; }
        public decimal? AugBudgetDemand { get; set; }
        public decimal? SepBudgetDemand { get; set; }
        public decimal? OctBudgetDemand { get; set; }
        public decimal? NovBudgetDemand { get; set; }
        public decimal? DecBudgetDemand { get; set; }

        public decimal? Q1BudgetDemandPerCategory { get; set; }
        public decimal? Q2BudgetDemandPerCategory { get; set; }
        public decimal? Q3BudgetDemandPerCategory { get; set; }
        public decimal? Q4BudgetDemandPerCategory { get; set; }

        public decimal? TotalCategoryBudgetDemand { get; set; }

        public decimal? JanBudgetApproved { get; set; }
        public decimal? FebBudgetApproved { get; set; }
        public decimal? MarBudgetApproved { get; set; }
        public decimal? AprBudgetApproved { get; set; }
        public decimal? MayBudgetApproved { get; set; }
        public decimal? JunBudgetApproved { get; set; }
        public decimal? JulBudgetApproved { get; set; }
        public decimal? AugBudgetApproved { get; set; }
        public decimal? SepBudgetApproved { get; set; }
        public decimal? OctBudgetApproved { get; set; }
        public decimal? NovBudgetApproved { get; set; }
        public decimal? DecBudgetApproved { get; set; }

        public decimal? Q1BudgetApprovedPerCategory { get; set; }
        public decimal? Q2BudgetApprovedPerCategory { get; set; }
        public decimal? Q3BudgetApprovedPerCategory { get; set; }
        public decimal? Q4BudgetApprovedPerCategory { get; set; }

        public decimal? TotalBudgetApprovedPerCategory { get; set; }

        public decimal? JanBenefitExpected { get; set; }
        public decimal? FebBenefitExpected { get; set; }
        public decimal? MarBenefitExpected { get; set; }
        public decimal? AprBenefitExpected { get; set; }
        public decimal? MayBenefitExpected { get; set; }
        public decimal? JunBenefitExpected { get; set; }
        public decimal? JulBenefitExpected { get; set; }
        public decimal? AugBenefitExpected { get; set; }
        public decimal? SepBenefitExpected { get; set; }
        public decimal? OctBenefitExpected { get; set; }
        public decimal? NovBenefitExpected { get; set; }
        public decimal? DecBenefitExpected { get; set; }

        public decimal? Q1BenefitExpectedPerCategory { get; set; }
        public decimal? Q2BenefitExpectedPerCategory { get; set; }
        public decimal? Q3BenefitExpectedPerCategory { get; set; }
        public decimal? Q4BenefitExpectedPerCategory { get; set; }

        public decimal? TotalBenefitExpected { get; set; }

        public decimal? JanBenefitAchieved { get; set; }
        public decimal? FebBenefitAchieved { get; set; }
        public decimal? MarBenefitAchieved { get; set; }
        public decimal? AprBenefitAchieved { get; set; }
        public decimal? MayBenefitAchieved { get; set; }
        public decimal? JunBenefitAchieved { get; set; }
        public decimal? JulBenefitAchieved { get; set; }
        public decimal? AugBenefitAchieved { get; set; }
        public decimal? SepBenefitAchieved { get; set; }
        public decimal? OctBenefitAchieved { get; set; }
        public decimal? NovBenefitAchieved { get; set; }
        public decimal? DecBenefitAchieved { get; set; }

        public decimal? Q1BenefitAchievedPerCategory { get; set; }
        public decimal? Q2BenefitAchievedPerCategory { get; set; }
        public decimal? Q3BenefitAchievedPerCategory { get; set; }
        public decimal? Q4BenefitAchievedPerCategory { get; set; }

        public decimal? TotalBenefitAchievedPerCategory { get; set; }

        public decimal? JanBenefitForecast { get; set; }
        public decimal? FebBenefitForecast { get; set; }
        public decimal? MarBenefitForecast { get; set; }
        public decimal? AprBenefitForecast { get; set; }
        public decimal? MayBenefitForecast { get; set; }
        public decimal? JunBenefitForecast { get; set; }
        public decimal? JulBenefitForecast { get; set; }
        public decimal? AugBenefitForecast { get; set; }
        public decimal? SepBenefitForecast { get; set; }
        public decimal? OctBenefitForecast { get; set; }
        public decimal? NovBenefitForecast { get; set; }
        public decimal? DecBenefitForecast { get; set; }

        public decimal? Q1BenefitForecastPerCategory { get; set; }
        public decimal? Q2BenefitForecastPerCategory { get; set; }
        public decimal? Q3BenefitForecastPerCategory { get; set; }
        public decimal? Q4BenefitForecastPerCategory { get; set; }

        public decimal? TotalBenefitForecastPerCategory { get; set; }

        public decimal? JanOpexImpact { get; set; }
        public decimal? FebOpexImpact { get; set; }
        public decimal? MarOpexImpact { get; set; }
        public decimal? AprOpexImpact { get; set; }
        public decimal? MayOpexImpact { get; set; }
        public decimal? JunOpexImpact { get; set; }
        public decimal? JulOpexImpact { get; set; }
        public decimal? AugOpexImpact { get; set; }
        public decimal? SepOpexImpact { get; set; }
        public decimal? OctOpexImpact { get; set; }
        public decimal? NovOpexImpact { get; set; }
        public decimal? DecOpexImpact { get; set; }

        public decimal? Q1OpexImpactPerCategory { get; set; }
        public decimal? Q2OpexImpactPerCategory { get; set; }
        public decimal? Q3OpexImpactPerCategory { get; set; }
        public decimal? Q4OpexImpactPerCategory { get; set; }

        public decimal? TotalOpexImpactPerCategory { get; set; }

    }
}