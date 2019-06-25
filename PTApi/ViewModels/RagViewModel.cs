using System.ComponentModel.DataAnnotations;
using PTApi.Models;

namespace PTApi.ViewModels
{
    public class RagViewModel
    {
        public string ProjectRagStatusId { get; set; }
        [Required]
        public string ProjectId { get; set; }
        [Required]
        public string CompanyId { get; set; }
        public int Year { get; set; }
        public byte ReportingPeriodNumbers { get; set; }
        public string ReportingPeriodWords { get; set; }

        public string PortfolioMiReportingPeriod { get; set; }

        [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
        public string HighlightsThisPeriod { get; set; }
        [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
        public string ActivitiesPlannedNextPeriod { get; set; }
        public string RagStatusSummary { get; set; }
        [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
        public string RagNarrativeSummary { get; set; }
        public string RagStatusGovernanceBusinessChange { get; set; }
         [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
        public string RagNarrativeGovernanceBusinessChange { get; set; }
        public string RagStatusScope { get; set; }
         [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
        public string RagNarrativeScope { get; set; }
        public string RagStatusQuality { get; set; }
         [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
        public string RagNarrativeQuality { get; set; }
        public string RagStatusSchedule { get; set; }
         [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
        public string RagNarrativeSchedule { get; set; }
        public string RagStatusFinances { get; set; }
         [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
        public string RagNarrativeFinances { get; set; }
        public string RagStatusResourcing { get; set; }
        [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
        public string RagNarrativeResourcing { get; set; }
        public string RagStatusCustomerSatisfaction { get; set; }
         [StringLength(2500, ErrorMessage = "Update cannot be longer than 2,500 characters.")]
        public string RagNarrativeCustomerSatisfaction { get; set; }
        public Project Project { get; set; }
        public Company Company { get; set; }
    }
}