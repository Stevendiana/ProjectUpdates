using System.ComponentModel.DataAnnotations;

namespace PTApi.Models
{
    public class ProjectsPermitted : BaseEntity
    {
        [Key]
        [Required]
        public string UserId { get; set; }
        [Key]
        [Required]
        public string ResourceId { get; set; }
        [Key]
        [Required]
        public string CompanyId { get; set; }
        [Key]
        [Required]
        public string ProjectId { get; set; }
        public bool CanEdit { get; set; }
        public Project Project { get; set; }
    }
}
