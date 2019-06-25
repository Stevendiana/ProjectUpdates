using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTApi.Models
{
    [Table("ProjectBudgetTracker")]
    public class ProjectBudgetTracker : BaseEntity
    {
        [Key]
        public string ProjectBudgetTrackerId { get; set; }
        public string ProjectBudgetTrackerCode { get; set; }
        public string BudgetBadgetStatus  { get; set; }
        public int? BudgetBadgetVersion  { get; set; }
        public string CompanyId { get; set; }
        public string ProjectId { get; set; }
        public DateTime? BudgetStartDate { get; set; }
        public DateTime? BudgetEndDate { get; set; }

        public decimal? TotalLifeTimeBudget  { get; set; }

        public ProjectBudgetTracker()
        {
            ProjectBudgets = new Collection<ProjectBudget>();
        }

        public ICollection<ProjectBudget> ProjectBudgets { get; set; }



    }
}