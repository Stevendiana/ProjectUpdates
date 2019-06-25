using System.Collections.Generic;
using System.Collections.ObjectModel;
using PTApi.Models;

namespace PTApi.ViewModels
{
    public class ProjectBudgetTrackerViewModel: BaseEntity
    {
        public string ProjectBudgetTrackerId { get; set; }
        public string BudgetBadgetStatus  { get; set; }
        public string BudgetBadgetVersion  { get; set; }
        public string CompanyId { get; set; }
        public string ProjectId { get; set; }
        public ProjectBudgetTrackerViewModel()
        {
            ProjectBudgets = new Collection<ProjectBudget>();
        }

        public ICollection<ProjectBudget> ProjectBudgets { get; set; }



    }
}