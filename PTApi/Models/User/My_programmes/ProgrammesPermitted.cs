using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTApi.Models
{
    [Table("ProgrammesPermitted")]
    public class ProgrammesPermitted: BaseEntity
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
        public string ProgrammeId { get; set; }
        public Programme Programme { get; set; }

        public bool CanEdit { get; set; }

        public ICollection<Resource> ResourcesPermitted { get; set; }

        public ProgrammesPermitted()
        {
            ResourcesPermitted = new Collection<Resource>();
        }
    }
}