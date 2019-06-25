using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTApi.Models
{
    [Table("ProjectsPermitted")]
    public class ProjectPermitted: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Key]
        public string ProjectId { get; set; }
        public Project Project { get; set; }
        public string NodeId { get; set; } ="project";
        public bool ReadWritePermission { get; set; }
        [Required]
        public string ResourceId { get; set; }
        [Required]
        [Key]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        [Required]
        public string CompanyId { get; set; }
        public Company Company { get; set; }

        public ICollection<ProjectPermitted> ResourcesPermitted { get; set; }
        // public ICollection<ForecastTask> ForecastTasks { get; set; }
        // public ICollection<Actual> Actuals { get; set; }
        // public ICollection<ProjectStageGate> ProjectStageGates { get; set; }
        // public ICollection<ProjectRagStatus> ProjectRagStatuses { get; set; }
        // public ICollection<ProjectPlanBudgetBenefit> ProjectPlanBudgetBenefits { get; set; }

        public ProjectPermitted()
        {
            ResourcesPermitted = new Collection<ProjectPermitted>();
            // ForecastTasks = new Collection<ForecastTask>();
            // Actuals = new Collection<Actual>();
            // ProjectStageGates = new Collection<ProjectStageGate>();
            // ProjectRagStatuses = new Collection<ProjectRagStatus>();
            // ProjectPlanBudgetBenefits = new Collection<ProjectPlanBudgetBenefit>();
        }
    }
}