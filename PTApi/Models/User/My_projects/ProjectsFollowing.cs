using System.ComponentModel.DataAnnotations;

namespace PTApi.Models
{
    public class ProjectsFollowing : BaseEntity
    {
        [Key]
        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        [Key]
        [Required]
        public string ResourceId { get; set; }
        public Resource Resource { get; set; }
        [Key]
        [Required]
        public string CompanyId { get; set; }
        [Key]
        [Required]
        public string ProjectId { get; set; }
        public bool Following { get; set; }

    }
}
