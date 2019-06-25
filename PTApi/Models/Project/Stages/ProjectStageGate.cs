using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTApi.Models
{
    [Table("ProjectStageGate")]
    public class ProjectStageGate : BaseEntity
    {
        public string ProjectId { get; set; }
        public string CompanyId { get; set; }
        public string CompanyMethodologyStageId { get; set; }
        public string BriefNote { get; set; }
        public DateTime? PlannedStartDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? PlannedEndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public Project Project { get; set; }
        public Company Company { get; set; }
        public decimal? ProjectStageGateDurationDays { get; set; }
        public decimal? ProjectStageGateApprovedBudgetCapex { get; set; }
        public decimal? ProjectStageGateApprovedBudgetRevex { get; set; }
        public decimal? ProjectStageGateApprovedBudgetOpex { get; set; }
        public decimal? TotalProjectStageGateApprovedBudget { get; set; }
        public CompanyMethodologyStage CompanyMethodologyStage { get; set; }
    }
}